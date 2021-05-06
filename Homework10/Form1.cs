using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework10
{
    public partial class Form1 : Form
    {
        private SimpleCrawler crawler;
        public List<string> Log = new List<string>();
        private Thread crawlerTh;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Log.Clear();
            crawler = new SimpleCrawler(textBox1.Text,(int)numericUpDown1.Value, Log, this);
            crawler.AddLog += Crawler_AddLog;
            crawlerTh = new Thread(crawler.Crawl);
            crawlerTh.Start();
        }

        public void Crawler_AddLog(string str)
        {
            if (textBox2.InvokeRequired)
            {
                Action<string> action = AddLog;
                Invoke(action, str);
            }
            else
                AddLog(str);
        }

        public void AddLog(string str)
        {
            textBox2.AppendText(str + "\r\n");
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            try
            {
                crawlerTh.Abort();
            }
            catch(Exception err)
            {
                AddLog(err.Message);
            }
            finally
            {
                AddLog("爬虫已终止");
            }
        }
    }
}
