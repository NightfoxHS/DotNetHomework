﻿using System;
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
    public partial class FormOrderDetail : Form
    {
        Form1 fm;
        double ID;
        Order ord;
        OrderContext db;
        public FormOrderDetail()
        {
            InitializeComponent();
        }

        public FormOrderDetail(Form1 fm,double i)
        {
            InitializeComponent();
            this.fm = fm;
            ID = i;
            ord = OrderService.GetOrder(ID);
        }

        private void FormOrderDetail_Load(object sender, EventArgs e)
        {
            db = new OrderContext();
            bindingSourceOrderDetail.DataSource = db.OrderDetails.Where(d => d.OrderId == ord.Id).ToList();
            bindingSourceOrderDetail.ResetBindings(false);
            textBoxName.Text = ord.Name;
            labelIDValue.DataBindings.Add("Text", ord, "ID");
            labelTimeValue.DataBindings.Add("Text", ord, "OrderTime");
            labelPriceValue.DataBindings.Add("Text", ord, "TotalPrice");
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            OrderService.GetOrder(ID).Name = textBoxName.Text;
            fm.BindingOrderRefresh(false);
            this.Close();
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            FormAddOrderDetail fmAdd = new FormAddOrderDetail(ord,this);
            fmAdd.Show();
        }

        private void toolStripButtonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count >= 1)
                {
                    if (MessageBox.Show($"确定要删除这{dataGridView1.SelectedRows.Count}项订单吗？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        bindingSourceOrderDetail.Remove(dataGridView1.SelectedRows);
                    BindingOrdDetailRefresh(false);
                }
                else
                    throw new ApplicationException("请至少选择一行");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        public void BindingOrdDetailRefresh(bool f)
        {
            bindingSourceOrderDetail.ResetBindings(f);
        }

        private void FormOrderDetail_FormClosing(object sender, FormClosingEventArgs e)
        {
            db.Dispose();
        }
    }
}
