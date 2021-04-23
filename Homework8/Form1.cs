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
    public partial class Form1 : Form
    {
        public OrderService os = new OrderService();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripComboBox1.SelectedIndex = 0;
            bindingSourceOrder.DataSource = os.Orders;
            bindingSourceCustomer.DataSource = os.Customers;
            bindingSourceGoods.DataSource = os.Goodses;
            Customer cus = new Customer("Mew", "Rd");
            os.CreateOrder(cus, DateTime.Now);
            BindingOrderRefresh(false);
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0)
                {
                    if (dataGridView1.Rows[e.RowIndex].Selected == false)
                    {
                        dataGridView1.ClearSelection();
                        dataGridView1.Rows[e.RowIndex].Selected = true;
                    }
                    popUpMenuOrder.Show(MousePosition.X, MousePosition.Y);
                }
            }
        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddOrder fmAdd = new FormAddOrder(this);
            fmAdd.Show();
        }

        public void BindingOrderRefresh(bool f)
        {
            bindingSourceOrder.ResetBindings(f);
        }

        public void BindingCusRefresh(bool f)
        {
            bindingSourceCustomer.ResetBindings(f);
        }

        public void BindingGoodsRefresh(bool f)
        {
            bindingSourceGoods.ResetBindings(f);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                switch (toolStripComboBox1.SelectedIndex)
                {
                    case 0:
                        if (Double.TryParse(toolStripTextBox1.Text, out double id))
                            bindingSourceOrder.DataSource = os.QueryByID(id);
                        else
                            throw new ApplicationException("输入ID格式错误");
                        BindingOrderRefresh(false);
                        break;
                    case 1:
                        bindingSourceOrder.DataSource = os.QueryByName(toolStripTextBox1.Text);
                        BindingOrderRefresh(false);
                        break;
                    default:
                        break;
                }
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void ImportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.DefaultExt = ".xml";
                openFileDialog1.Filter = "*.xml";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    os.ImportOrders(openFileDialog1.FileName);
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void ExportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.DefaultExt = ".xml";
                saveFileDialog1.Filter = "*.xml";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    os.ExportOrders(saveFileDialog1.FileName);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count >= 1)
                {
                    if (MessageBox.Show($"确定要删除这{dataGridView1.SelectedRows.Count}项订单吗？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        bindingSourceOrder.Remove(dataGridView1.SelectedRows);
                    BindingOrderRefresh(false);
                }
                else
                    throw new ApplicationException("请至少选择一行"); 
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void ViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count == 1)
                {
                    Order ord = dataGridView1.SelectedRows[0].DataBoundItem as Order;
                    FormOrderDetail fmOD = new FormOrderDetail(os, this, ord.ID);
                    fmOD.Show();
                }
                else
                    throw new ApplicationException("尚未选择项目或选择了多行");
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
