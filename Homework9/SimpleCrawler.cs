using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Homework9
{
    public class SimpleCrawler
    {
        public event Action<string> AddLog;
        private Hashtable urls = new Hashtable();
        private int cnt = 0;
        public int Max { get; set; } = 20; //最大爬取页面数量
        public string Range { get; set; } //爬虫所爬取网页的Host
        public Uri BeginUrl { get; set; } //起始网页网址
        public List<string> Log { get; } //日志

        public SimpleCrawler(string beginUrl,int max,List<string> log,Form1 fm)
        {
            BeginUrl = new Uri(beginUrl);
            urls.Add(beginUrl, false);
            Range = new Uri(beginUrl).Host;
            Max = max;
            Log = log;
        }

        public void Crawl()
        {
            Log.Add("爬虫开始运行……");
            AddLog(Log.Last());
            while (true)
            {
                string current = null;
                foreach (string url in urls.Keys)
                {
                    if ((bool)urls[url]) continue;
                    current = url;
                }

                if (current == null || cnt > Max) break;
                Log.Add("抓取" + current + "页面");
                AddLog(Log.Last());
                string html = DownLoad(current); //下载
                urls[current] = true;
                cnt++;
                Parse(html,current); //解析,并加入新的链接
            }
        }

        public string DownLoad(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);
                string fileName = cnt.ToString();
                File.WriteAllText(fileName, html, Encoding.UTF8);
                return html;
            }
            catch (Exception ex)
            {
                Log.Add(ex.Message);
                AddLog(Log.Last());
                return "";
            }
        }

        private void Parse(string html,string current)
        {
            string strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+[""']";
            MatchCollection matches = new Regex(strRef).Matches(html);
            foreach (Match match in matches)
            {
                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1)
                          .Trim('"', '\"', '#', '>');
                if (strRef.Length == 0 || !Regex.IsMatch(strRef, "(.html|.htm|.jsp|.aspx)"))
                    continue;
                strRef = UrlToAbsolute(strRef, current);
                Uri uriRef = new Uri(strRef);
                if (urls[strRef] == null && uriRef.Host == Range)
                    urls[strRef] = false;
            }
        }

        static public string UrlToAbsolute(string url,string baseUrl)
        {
            Uri bUrl = new Uri(baseUrl);

            if (url.Contains("://"))
            {
                return url;
            }

            if (url.StartsWith("//"))
            {
                return bUrl.Scheme + ":" +url;
            }

            if (url.StartsWith("/"))
            {
                return bUrl.Scheme + "://" + bUrl.Host + url;
            }

            if (url.StartsWith("./"))
            {
                return UrlToAbsolute(url.Substring(2), baseUrl);
            }

            if (url.StartsWith("../"))
            {
                url = url.Substring(3);
                int idx = baseUrl.LastIndexOf('/');
                return UrlToAbsolute(url, baseUrl.Substring(0, idx));
            }
            //default
            int end = baseUrl.LastIndexOf("/");
            return baseUrl.Substring(0, end) + "/" + url;
        }
    }
}
