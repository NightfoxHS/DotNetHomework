using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework8
{
    public partial class FormAddOrderDetail : Form
    {
        Order ord;
        OrderService os;
        FormOrderDetail fm;
        public FormAddOrderDetail()
        {
            InitializeComponent();
        }

        public FormAddOrderDetail(Order ord,OrderService os, FormOrderDetail fm)
        {
            InitializeComponent();
            this.ord = ord;
            this.os = os;
            this.fm = fm;
        }
        private void FormAddOrderDetail_Load(object sender, EventArgs e)
        {
            bindingSourceGoods.DataSource = os.Goodses;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
                panel1.Visible = true;
            else if (radioButton1.Checked == false)
                panel1.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
                panel2.Visible = true;
            else if (radioButton2.Checked == false)
                panel2.Visible = false;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                ord.Add((Goods)dataGridView1.CurrentRow.DataBoundItem, (int)numericUpDown1.Value);
            }
            else if (radioButton2.Checked == true)
            {
                Goods gds = new Goods(textBox1.Text, (float)numericUpDown2.Value);
                os.CreateGoods(textBox1.Text, (float)numericUpDown2.Value);
                ord.Add(gds, (int)numericUpDown1.Value);
            }
            fm.BindingOrdDetailRefresh(false);
            this.Close();
        }
    }
}
