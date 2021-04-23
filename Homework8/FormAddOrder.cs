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
    public partial class FormAddOrder : Form
    {
        Form1 fm;
        OrderService os;
        public FormAddOrder()
        {
            InitializeComponent();
        }

        public FormAddOrder(Form1 fm)
        {
            InitializeComponent();
            this.fm = fm;
            this.os = fm.os;
        }

        private void FormAddOrder_Load(object sender, EventArgs e)
        {
            bindingSourceCustomer.DataSource = os.Customers;
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

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime time;
            if (checkBox1.Checked == true)
                time = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day,
                    dateTimePicker2.Value.Hour, dateTimePicker2.Value.Minute, dateTimePicker2.Value.Second);
            else
                time = DateTime.Now;

            if (radioButton1.Checked == true)
            {
                os.CreateOrder((Customer)dataGridView1.CurrentRow.DataBoundItem, time);
            }
            else if (radioButton2.Checked == true)
            {
                Customer cus = new Customer(textBox1.Text, textBox2.Text);
                os.CreateCustomer(cus.Name,cus.Addr);
                os.CreateOrder(cus, time);
            }
            fm.BindingOrderRefresh(false);
            fm.BindingCusRefresh(false);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
