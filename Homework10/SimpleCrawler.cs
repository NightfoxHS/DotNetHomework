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
using System.Collections.Concurrent;

namespace Homework10
{
    public class SimpleCrawler
    {
        public event Action<string> AddLog;
        // 已遍历及待遍历url，其中，true为已遍历，false为未遍历
        private ConcurrentDictionary<string, bool> urls = new ConcurrentDictionary<string,bool>();
        // 待下载网页队列
        private ConcurrentQueue<string> downloads = new ConcurrentQueue<string>();

        private int cnt = 0; // 已完成任务数
        private string urlPattern = @"(href|HREF)[]*=[]*[""'][^""'#>]+[""']";
        public int Max { get; set; } = 20; // 最大爬取页面数量
        public string Range { get; set; } // 爬虫所爬取网页的Host
        public Uri BeginUrl { get; set; } // 起始网页网址
        public List<string> Log { get; } // 日志

        public SimpleCrawler(string beginUrl,int max,List<string> log,Form1 fm)
        {
            BeginUrl = new Uri(beginUrl);
            urls.TryAdd(beginUrl, false);
            Range = new Uri(beginUrl).Host;
            Max = max;
            Log = log;
        }

        public void Crawl()
        {
            Log.Add("爬虫开始运行……");
            AddLog(Log.Last());
            urls.Clear();
            downloads.Enqueue(BeginUrl.ToString());
            List<Task> tasks = new List<Task>(); // 并行任务列表

            while(tasks.Count < Max)
            {
                if(!downloads.TryDequeue(out string url))
                {
                    if (cnt < tasks.Count)
                        continue;
                    else
                        break;
                }
                Task task = Task.Run(() => DownloadAndParse(url));
                tasks.Add(task);
            }

            Task.WaitAll(tasks.ToArray());
        }

        public void DownloadAndParse(string url)
        {
            try
            {
                Log.Add("抓取" + url + "页面");
                AddLog(Log.Last());
                string html = DownLoad(url);
                Parse(html, url);
                cnt++;
            }
            catch(Exception ex)
            {
                Log.Add(ex.Message);
                AddLog(Log.Last());
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
            MatchCollection matches = new Regex(urlPattern).Matches(html);
            //并行处理matches中获取的元素
            Parallel.ForEach(matches.OfType<Match>(), match =>
            {
                string strRef = match.Value.Substring(match.Value.IndexOf('=') + 1)
                          .Trim('"', '\"', '#', '>');
                if (strRef.Length == 0 || !Regex.IsMatch(strRef, "(.html?|.jsp|.aspx|.php)"))
                    return;
                strRef = UrlToAbsolute(strRef, current);
                Uri uriRef = new Uri(strRef);
                if (!urls.ContainsKey(strRef) && uriRef.Host == Range)
                {
                    urls.TryAdd(strRef, false);
                    downloads.Enqueue(strRef);
                }
            });
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
