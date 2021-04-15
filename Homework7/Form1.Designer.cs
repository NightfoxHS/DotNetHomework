
namespace Homework7
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.nValue = new System.Windows.Forms.NumericUpDown();
            this.lengthValue = new System.Windows.Forms.NumericUpDown();
            this.per1Value = new System.Windows.Forms.NumericUpDown();
            this.per2Value = new System.Windows.Forms.NumericUpDown();
            this.th1Value = new System.Windows.Forms.NumericUpDown();
            this.th2Value = new System.Windows.Forms.NumericUpDown();
            this.colorSelect_Button = new System.Windows.Forms.Button();
            this.color_Label = new System.Windows.Forms.Label();
            this.draw_Button = new System.Windows.Forms.Button();
            this.draw_Panel = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lengthValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.per1Value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.per2Value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.th1Value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.th2Value)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(407, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "递归深度";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(407, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "主干长度";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(407, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "右分支长度比";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(407, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "左分支长度比";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(407, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "右分支角度";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(407, 452);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "左分支角度";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Controls.Add(this.label7, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.nValue, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lengthValue, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.per1Value, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.per2Value, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.th1Value, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.th2Value, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.colorSelect_Button, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.draw_Button, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.draw_Panel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.color_Label, 1, 8);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(622, 673);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(407, 536);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "画笔颜色";
            // 
            // nValue
            // 
            this.nValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nValue.Location = new System.Drawing.Point(531, 29);
            this.nValue.Name = "nValue";
            this.nValue.Size = new System.Drawing.Size(88, 25);
            this.nValue.TabIndex = 7;
            // 
            // lengthValue
            // 
            this.lengthValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lengthValue.Location = new System.Drawing.Point(531, 113);
            this.lengthValue.Name = "lengthValue";
            this.lengthValue.Size = new System.Drawing.Size(88, 25);
            this.lengthValue.TabIndex = 8;
            // 
            // per1Value
            // 
            this.per1Value.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.per1Value.DecimalPlaces = 1;
            this.per1Value.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.per1Value.Location = new System.Drawing.Point(531, 197);
            this.per1Value.Name = "per1Value";
            this.per1Value.Size = new System.Drawing.Size(88, 25);
            this.per1Value.TabIndex = 9;
            // 
            // per2Value
            // 
            this.per2Value.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.per2Value.DecimalPlaces = 1;
            this.per2Value.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.per2Value.Location = new System.Drawing.Point(531, 281);
            this.per2Value.Name = "per2Value";
            this.per2Value.Size = new System.Drawing.Size(88, 25);
            this.per2Value.TabIndex = 10;
            // 
            // th1Value
            // 
            this.th1Value.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.th1Value.Location = new System.Drawing.Point(531, 365);
            this.th1Value.Name = "th1Value";
            this.th1Value.Size = new System.Drawing.Size(88, 25);
            this.th1Value.TabIndex = 11;
            // 
            // th2Value
            // 
            this.th2Value.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.th2Value.Location = new System.Drawing.Point(531, 449);
            this.th2Value.Name = "th2Value";
            this.th2Value.Size = new System.Drawing.Size(88, 25);
            this.th2Value.TabIndex = 12;
            // 
            // colorSelect_Button
            // 
            this.colorSelect_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.colorSelect_Button.Location = new System.Drawing.Point(531, 531);
            this.colorSelect_Button.Name = "colorSelect_Button";
            this.colorSelect_Button.Size = new System.Drawing.Size(88, 29);
            this.colorSelect_Button.TabIndex = 16;
            this.colorSelect_Button.Text = "选择颜色";
            this.colorSelect_Button.UseVisualStyleBackColor = true;
            this.colorSelect_Button.Click += new System.EventHandler(this.colorSelect_Button_Click);
            // 
            // color_Label
            // 
            this.color_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.color_Label.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.color_Label, 2);
            this.color_Label.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.color_Label.Location = new System.Drawing.Point(506, 645);
            this.color_Label.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.color_Label.Name = "color_Label";
            this.color_Label.Size = new System.Drawing.Size(113, 23);
            this.color_Label.TabIndex = 17;
            this.color_Label.Text = "DefaultColor";
            // 
            // draw_Button
            // 
            this.draw_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.draw_Button, 2);
            this.draw_Button.Location = new System.Drawing.Point(463, 598);
            this.draw_Button.Name = "draw_Button";
            this.draw_Button.Size = new System.Drawing.Size(100, 30);
            this.draw_Button.TabIndex = 13;
            this.draw_Button.Text = "Draw";
            this.draw_Button.UseVisualStyleBackColor = true;
            this.draw_Button.Click += new System.EventHandler(this.draw_Button_Click);
            // 
            // draw_Panel
            // 
            this.draw_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.draw_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.draw_Panel.Location = new System.Drawing.Point(3, 3);
            this.draw_Panel.Name = "draw_Panel";
            this.tableLayoutPanel1.SetRowSpan(this.draw_Panel, 9);
            this.draw_Panel.Size = new System.Drawing.Size(398, 667);
            this.draw_Panel.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 673);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "CarleyTree";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lengthValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.per1Value)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.per2Value)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.th1Value)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.th2Value)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.NumericUpDown nValue;
        private System.Windows.Forms.NumericUpDown lengthValue;
        private System.Windows.Forms.NumericUpDown per1Value;
        private System.Windows.Forms.NumericUpDown per2Value;
        private System.Windows.Forms.NumericUpDown th1Value;
        private System.Windows.Forms.NumericUpDown th2Value;
        private System.Windows.Forms.Button draw_Button;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button colorSelect_Button;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label color_Label;
        private System.Windows.Forms.Panel draw_Panel;
    }
}

