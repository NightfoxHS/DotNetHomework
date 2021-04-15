using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Graphics Graph;
        int N { get { return int.Parse(nValue.Text); } }
        double Length { get { return double.Parse(lengthValue.Text); } }
        double Per1 { get { return double.Parse(per1Value.Text); } }
        double Per2 { get { return double.Parse(per2Value.Text); } }
        double Th1 { get { return int.Parse(th1Value.Text); } }
        double Th2 { get { return int.Parse(th2Value.Text); } }
       

        void DrawCarleyTree(int n, double x0, double y0, double leng, double th)
        {
            if (n == 0) return;
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            DrawLine(x0, y0, x1, y1);
            DrawCarleyTree(n - 1, x1, y1, Per1 * leng, th + Th1 * Math.PI / 180);
            DrawCarleyTree(n - 1, x1, y1, Per2 * leng, th - Th2 * Math.PI / 180);
        }

        void DrawLine(double x0, double y0, double x1, double y1)
        {
            Graph.DrawLine(new Pen(colorDialog1.Color), (int)x0, (int)y0, (int)x1, (int)y1);
        }


        private void colorSelect_Button_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                color_Label.ForeColor = colorDialog1.Color;
                color_Label.Text = Convert.ToString(colorDialog1.Color.ToArgb(),16);
            }
        }

        private void draw_Button_Click(object sender, EventArgs e)
        {
            if (Graph != null) 
                Graph.Clear(draw_Panel.BackColor);
            Graph = draw_Panel.CreateGraphics();
            DrawCarleyTree(N, draw_Panel.Width/2, draw_Panel.Height, Length, -Math.PI / 2);
        }
    }
}
