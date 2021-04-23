
namespace Homework8
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageOrder = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceOrder = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageCustomer = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceCustomer = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageGoods = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceGoods = new System.Windows.Forms.BindingSource(this.components);
            this.menuStripOrderService = new System.Windows.Forms.MenuStrip();
            this.MenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripOrderService = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.button1 = new System.Windows.Forms.Button();
            this.popUpMenuOrder = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ModToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceOrder)).BeginInit();
            this.tabPageCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCustomer)).BeginInit();
            this.tabPageGoods.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGoods)).BeginInit();
            this.menuStripOrderService.SuspendLayout();
            this.toolStripOrderService.SuspendLayout();
            this.popUpMenuOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tabControl, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.menuStripOrderService, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.toolStripOrderService, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(896, 561);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageOrder);
            this.tabControl.Controls.Add(this.tabPageCustomer);
            this.tabControl.Controls.Add(this.tabPageGoods);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(3, 87);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(890, 471);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageOrder
            // 
            this.tabPageOrder.Controls.Add(this.dataGridView1);
            this.tabPageOrder.Location = new System.Drawing.Point(4, 25);
            this.tabPageOrder.Name = "tabPageOrder";
            this.tabPageOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOrder.Size = new System.Drawing.Size(882, 442);
            this.tabPageOrder.TabIndex = 0;
            this.tabPageOrder.Text = "订单";
            this.tabPageOrder.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.orderTimeDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSourceOrder;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(876, 436);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDown);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderTimeDataGridViewTextBoxColumn
            // 
            this.orderTimeDataGridViewTextBoxColumn.DataPropertyName = "OrderTime";
            this.orderTimeDataGridViewTextBoxColumn.HeaderText = "OrderTime";
            this.orderTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderTimeDataGridViewTextBoxColumn.Name = "orderTimeDataGridViewTextBoxColumn";
            this.orderTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.HeaderText = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            this.totalPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // bindingSourceOrder
            // 
            this.bindingSourceOrder.DataSource = typeof(Homework8.Order);
            // 
            // tabPageCustomer
            // 
            this.tabPageCustomer.Controls.Add(this.dataGridView2);
            this.tabPageCustomer.Location = new System.Drawing.Point(4, 25);
            this.tabPageCustomer.Name = "tabPageCustomer";
            this.tabPageCustomer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCustomer.Size = new System.Drawing.Size(882, 442);
            this.tabPageCustomer.TabIndex = 1;
            this.tabPageCustomer.Text = "用户";
            this.tabPageCustomer.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1,
            this.addrDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.bindingSourceCustomer;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(876, 436);
            this.dataGridView2.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn1.Width = 125;
            // 
            // addrDataGridViewTextBoxColumn
            // 
            this.addrDataGridViewTextBoxColumn.DataPropertyName = "Addr";
            this.addrDataGridViewTextBoxColumn.HeaderText = "Addr";
            this.addrDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addrDataGridViewTextBoxColumn.Name = "addrDataGridViewTextBoxColumn";
            this.addrDataGridViewTextBoxColumn.ReadOnly = true;
            this.addrDataGridViewTextBoxColumn.Width = 125;
            // 
            // bindingSourceCustomer
            // 
            this.bindingSourceCustomer.DataSource = typeof(Homework8.Customer);
            // 
            // tabPageGoods
            // 
            this.tabPageGoods.Controls.Add(this.dataGridView3);
            this.tabPageGoods.Location = new System.Drawing.Point(4, 25);
            this.tabPageGoods.Name = "tabPageGoods";
            this.tabPageGoods.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGoods.Size = new System.Drawing.Size(882, 442);
            this.tabPageGoods.TabIndex = 2;
            this.tabPageGoods.Text = "货物";
            this.tabPageGoods.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typeDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.bindingSourceGoods;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(3, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 27;
            this.dataGridView3.Size = new System.Drawing.Size(876, 436);
            this.dataGridView3.TabIndex = 0;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // bindingSourceGoods
            // 
            this.bindingSourceGoods.DataSource = typeof(Homework8.Goods);
            // 
            // menuStripOrderService
            // 
            this.menuStripOrderService.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripOrderService.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuToolStripMenuItem});
            this.menuStripOrderService.Location = new System.Drawing.Point(0, 0);
            this.menuStripOrderService.Name = "menuStripOrderService";
            this.menuStripOrderService.Size = new System.Drawing.Size(896, 28);
            this.menuStripOrderService.TabIndex = 2;
            this.menuStripOrderService.Text = "menuStrip1";
            // 
            // MenuToolStripMenuItem
            // 
            this.MenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ImportToolStripMenuItem,
            this.ExportToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem";
            this.MenuToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.MenuToolStripMenuItem.Text = "菜单";
            // 
            // ImportToolStripMenuItem
            // 
            this.ImportToolStripMenuItem.Name = "ImportToolStripMenuItem";
            this.ImportToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.ImportToolStripMenuItem.Text = "导入";
            this.ImportToolStripMenuItem.Click += new System.EventHandler(this.ImportToolStripMenuItem_Click);
            // 
            // ExportToolStripMenuItem
            // 
            this.ExportToolStripMenuItem.Name = "ExportToolStripMenuItem";
            this.ExportToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.ExportToolStripMenuItem.Text = "导出";
            this.ExportToolStripMenuItem.Click += new System.EventHandler(this.ExportToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.ExitToolStripMenuItem.Text = "退出";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // toolStripOrderService
            // 
            this.toolStripOrderService.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStripOrderService.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripOrderService.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripOrderService.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripComboBox1,
            this.toolStripTextBox1,
            this.toolStripButton1,
            this.toolStripSeparator1});
            this.toolStripOrderService.Location = new System.Drawing.Point(0, 28);
            this.toolStripOrderService.Name = "toolStripOrderService";
            this.toolStripOrderService.Padding = new System.Windows.Forms.Padding(3, 0, 1, 0);
            this.toolStripOrderService.Size = new System.Drawing.Size(896, 28);
            this.toolStripOrderService.TabIndex = 1;
            this.toolStripOrderService.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(39, 25);
            this.toolStripLabel1.Text = "查询";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "按ID查询",
            "按客户姓名查询"});
            this.toolStripComboBox1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(150, 28);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.toolStripTextBox1.Margin = new System.Windows.Forms.Padding(1, 0, 5, 0);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 28);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 25);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 22);
            this.button1.TabIndex = 3;
            this.button1.Text = "查看全部订单";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // popUpMenuOrder
            // 
            this.popUpMenuOrder.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.popUpMenuOrder.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddToolStripMenuItem,
            this.DelToolStripMenuItem,
            this.ModToolStripMenuItem,
            this.ViewToolStripMenuItem});
            this.popUpMenuOrder.Name = "MenuOperate";
            this.popUpMenuOrder.Size = new System.Drawing.Size(169, 100);
            // 
            // AddToolStripMenuItem
            // 
            this.AddToolStripMenuItem.Name = "AddToolStripMenuItem";
            this.AddToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.AddToolStripMenuItem.Text = "添加";
            this.AddToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
            // 
            // DelToolStripMenuItem
            // 
            this.DelToolStripMenuItem.Name = "DelToolStripMenuItem";
            this.DelToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.DelToolStripMenuItem.Text = "删除";
            this.DelToolStripMenuItem.Click += new System.EventHandler(this.DelToolStripMenuItem_Click);
            // 
            // ModToolStripMenuItem
            // 
            this.ModToolStripMenuItem.Name = "ModToolStripMenuItem";
            this.ModToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.ModToolStripMenuItem.Text = "修改";
            // 
            // ViewToolStripMenuItem
            // 
            this.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem";
            this.ViewToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.ViewToolStripMenuItem.Text = "查看详细信息";
            this.ViewToolStripMenuItem.Click += new System.EventHandler(this.ViewToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(896, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MainMenuStrip = this.menuStripOrderService;
            this.Name = "Form1";
            this.Text = "订单管理";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPageOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceOrder)).EndInit();
            this.tabPageCustomer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCustomer)).EndInit();
            this.tabPageGoods.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGoods)).EndInit();
            this.menuStripOrderService.ResumeLayout(false);
            this.menuStripOrderService.PerformLayout();
            this.toolStripOrderService.ResumeLayout(false);
            this.toolStripOrderService.PerformLayout();
            this.popUpMenuOrder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageOrder;
        private System.Windows.Forms.TabPage tabPageCustomer;
        private System.Windows.Forms.MenuStrip menuStripOrderService;
        private System.Windows.Forms.ToolStripMenuItem MenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ImportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStripOrderService;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.BindingSource bindingSourceOrder;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip popUpMenuOrder;
        private System.Windows.Forms.ToolStripMenuItem AddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ModToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPageGoods;
        private System.Windows.Forms.ToolStripMenuItem ViewToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn addrDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindingSourceCustomer;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindingSourceGoods;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button button1;
    }
}

