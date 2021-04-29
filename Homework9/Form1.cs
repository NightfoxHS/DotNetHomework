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

namespace Homework9
{
    public partial class Form1 : Form
    {
        SimpleCrawler crawler;
        List<string> Log = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Log.Clear();
            crawler = new SimpleCrawler(textBox1.Text,(int)numericUpDown1.Value, Log, this);
            crawler.Crawl();
        }

        public void AddLog(string str)
        {
            textBox2.AppendText(str + "\r\n");
        }
    }
}
