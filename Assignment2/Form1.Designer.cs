namespace Assignment2
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
            this.AmountDue = new System.Windows.Forms.TextBox();
            this.BasePrice = new System.Windows.Forms.TextBox();
            this.TradeInAllowance = new System.Windows.Forms.TextBox();
            this.Total = new System.Windows.Forms.TextBox();
            this.AdditionalOption = new System.Windows.Forms.TextBox();
            this.SalesTax = new System.Windows.Forms.TextBox();
            this.Subtotal = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fontFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.关于AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.StereoSystem = new System.Windows.Forms.CheckBox();
            this.LeatherInterior = new System.Windows.Forms.CheckBox();
            this.ComputerNavigation = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CustomizedDetailing = new System.Windows.Forms.RadioButton();
            this.Pearlized = new System.Windows.Forms.RadioButton();
            this.Standard = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // AmountDue
            // 
            this.AmountDue.Location = new System.Drawing.Point(169, 267);
            this.AmountDue.Name = "AmountDue";
            this.AmountDue.ReadOnly = true;
            this.AmountDue.Size = new System.Drawing.Size(100, 21);
            this.AmountDue.TabIndex = 0;
            // 
            // BasePrice
            // 
            this.BasePrice.Location = new System.Drawing.Point(169, 3);
            this.BasePrice.Name = "BasePrice";
            this.BasePrice.Size = new System.Drawing.Size(100, 21);
            this.BasePrice.TabIndex = 3;
            this.BasePrice.Text = "0";
            this.BasePrice.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // TradeInAllowance
            // 
            this.TradeInAllowance.Location = new System.Drawing.Point(169, 223);
            this.TradeInAllowance.Name = "TradeInAllowance";
            this.TradeInAllowance.Size = new System.Drawing.Size(100, 21);
            this.TradeInAllowance.TabIndex = 4;
            this.TradeInAllowance.Text = "0";
            // 
            // Total
            // 
            this.Total.Location = new System.Drawing.Point(169, 179);
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Size = new System.Drawing.Size(100, 21);
            this.Total.TabIndex = 5;
            // 
            // AdditionalOption
            // 
            this.AdditionalOption.Location = new System.Drawing.Point(169, 47);
            this.AdditionalOption.Name = "AdditionalOption";
            this.AdditionalOption.ReadOnly = true;
            this.AdditionalOption.Size = new System.Drawing.Size(100, 21);
            this.AdditionalOption.TabIndex = 6;
            this.AdditionalOption.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // SalesTax
            // 
            this.SalesTax.Location = new System.Drawing.Point(169, 135);
            this.SalesTax.Name = "SalesTax";
            this.SalesTax.ReadOnly = true;
            this.SalesTax.Size = new System.Drawing.Size(100, 21);
            this.SalesTax.TabIndex = 7;
            // 
            // Subtotal
            // 
            this.Subtotal.Location = new System.Drawing.Point(169, 91);
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            this.Subtotal.Size = new System.Drawing.Size(100, 21);
            this.Subtotal.TabIndex = 8;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.BasePrice, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.Subtotal, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.AdditionalOption, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.AmountDue, 1, 6);
            this.tableLayoutPanel3.Controls.Add(this.SalesTax, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.Total, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.TradeInAllowance, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(29, 38);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 7;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(277, 311);
            this.tableLayoutPanel3.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Adobe Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(3, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 47);
            this.label7.TabIndex = 15;
            this.label7.Text = "Amount Due:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Adobe Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(3, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 44);
            this.label6.TabIndex = 14;
            this.label6.Text = "Trade in allowance:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Adobe Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(3, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 44);
            this.label5.TabIndex = 13;
            this.label5.Text = "Total:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Adobe Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(3, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 44);
            this.label4.TabIndex = 12;
            this.label4.Text = "Sales Tax(13%):";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Adobe Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(3, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 44);
            this.label3.TabIndex = 11;
            this.label3.Text = "Subtotal:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Adobe Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(3, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 44);
            this.label2.TabIndex = 10;
            this.label2.Text = "Additional Option:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Adobe Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 44);
            this.label1.TabIndex = 9;
            this.label1.Text = "Base price:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件FToolStripMenuItem,
            this.编辑EToolStripMenuItem,
            this.帮助HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(536, 25);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件FToolStripMenuItem
            // 
            this.文件FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.退出XToolStripMenuItem});
            this.文件FToolStripMenuItem.Name = "文件FToolStripMenuItem";
            this.文件FToolStripMenuItem.Size = new System.Drawing.Size(53, 21);
            this.文件FToolStripMenuItem.Text = "File(&F)";
            this.文件FToolStripMenuItem.Click += new System.EventHandler(this.文件FToolStripMenuItem_Click);
            // 
            // 退出XToolStripMenuItem
            // 
            this.退出XToolStripMenuItem.Name = "退出XToolStripMenuItem";
            this.退出XToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.退出XToolStripMenuItem.Text = "Eixt(&X)";
            this.退出XToolStripMenuItem.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // 编辑EToolStripMenuItem
            // 
            this.编辑EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.toolStripMenuItem1,
            this.fontFToolStripMenuItem,
            this.colorRToolStripMenuItem});
            this.编辑EToolStripMenuItem.Name = "编辑EToolStripMenuItem";
            this.编辑EToolStripMenuItem.Size = new System.Drawing.Size(57, 21);
            this.编辑EToolStripMenuItem.Text = "Edit(&E)";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.clearToolStripMenuItem.Text = "Clear(&L)";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem1.Text = "Calculate(&C)";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // fontFToolStripMenuItem
            // 
            this.fontFToolStripMenuItem.Name = "fontFToolStripMenuItem";
            this.fontFToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fontFToolStripMenuItem.Text = "Font(&F)";
            this.fontFToolStripMenuItem.Click += new System.EventHandler(this.fontFToolStripMenuItem_Click);
            // 
            // colorRToolStripMenuItem
            // 
            this.colorRToolStripMenuItem.Name = "colorRToolStripMenuItem";
            this.colorRToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.colorRToolStripMenuItem.Text = "Color(&R)";
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator5,
            this.关于AToolStripMenuItem});
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(64, 21);
            this.帮助HToolStripMenuItem.Text = "Help(&H)";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(122, 6);
            // 
            // 关于AToolStripMenuItem
            // 
            this.关于AToolStripMenuItem.Name = "关于AToolStripMenuItem";
            this.关于AToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.关于AToolStripMenuItem.Text = "About(&A)...";
            this.关于AToolStripMenuItem.Click += new System.EventHandler(this.关于AToolStripMenuItem_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(223, 372);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 35);
            this.button3.TabIndex = 13;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(407, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 35);
            this.button1.TabIndex = 14;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(29, 372);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 35);
            this.button2.TabIndex = 15;
            this.button2.Text = "Calculate";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // StereoSystem
            // 
            this.StereoSystem.AutoSize = true;
            this.StereoSystem.Font = new System.Drawing.Font("Adobe Hebrew", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StereoSystem.Location = new System.Drawing.Point(6, 29);
            this.StereoSystem.Name = "StereoSystem";
            this.StereoSystem.Size = new System.Drawing.Size(120, 24);
            this.StereoSystem.TabIndex = 1;
            this.StereoSystem.Text = "Stereo System";
            this.StereoSystem.UseVisualStyleBackColor = true;
            this.StereoSystem.CheckedChanged += new System.EventHandler(this.StereoSystem_CheckedChanged);
            // 
            // LeatherInterior
            // 
            this.LeatherInterior.AutoSize = true;
            this.LeatherInterior.Font = new System.Drawing.Font("Adobe Hebrew", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeatherInterior.Location = new System.Drawing.Point(6, 59);
            this.LeatherInterior.Name = "LeatherInterior";
            this.LeatherInterior.Size = new System.Drawing.Size(131, 24);
            this.LeatherInterior.TabIndex = 2;
            this.LeatherInterior.Text = "Leather interior";
            this.LeatherInterior.UseVisualStyleBackColor = true;
            // 
            // ComputerNavigation
            // 
            this.ComputerNavigation.AutoSize = true;
            this.ComputerNavigation.Font = new System.Drawing.Font("Adobe Hebrew", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComputerNavigation.Location = new System.Drawing.Point(6, 89);
            this.ComputerNavigation.Name = "ComputerNavigation";
            this.ComputerNavigation.Size = new System.Drawing.Size(172, 24);
            this.ComputerNavigation.TabIndex = 3;
            this.ComputerNavigation.Text = "Computer Navigation";
            this.ComputerNavigation.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LeatherInterior);
            this.groupBox1.Controls.Add(this.StereoSystem);
            this.groupBox1.Controls.Add(this.ComputerNavigation);
            this.groupBox1.Location = new System.Drawing.Point(327, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 132);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Additional Item:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CustomizedDetailing);
            this.groupBox2.Controls.Add(this.Pearlized);
            this.groupBox2.Controls.Add(this.Standard);
            this.groupBox2.Location = new System.Drawing.Point(327, 193);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(194, 133);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Exterior Finish:";
            // 
            // CustomizedDetailing
            // 
            this.CustomizedDetailing.AutoSize = true;
            this.CustomizedDetailing.Font = new System.Drawing.Font("Adobe Hebrew", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomizedDetailing.Location = new System.Drawing.Point(6, 85);
            this.CustomizedDetailing.Name = "CustomizedDetailing";
            this.CustomizedDetailing.Size = new System.Drawing.Size(156, 22);
            this.CustomizedDetailing.TabIndex = 19;
            this.CustomizedDetailing.Text = "Customized Detailing";
            this.CustomizedDetailing.UseVisualStyleBackColor = true;
            // 
            // Pearlized
            // 
            this.Pearlized.AutoSize = true;
            this.Pearlized.Font = new System.Drawing.Font("Adobe Hebrew", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pearlized.Location = new System.Drawing.Point(6, 55);
            this.Pearlized.Name = "Pearlized";
            this.Pearlized.Size = new System.Drawing.Size(80, 22);
            this.Pearlized.TabIndex = 18;
            this.Pearlized.Text = "Pearlized";
            this.Pearlized.UseVisualStyleBackColor = true;
            // 
            // Standard
            // 
            this.Standard.AutoSize = true;
            this.Standard.Checked = true;
            this.Standard.Font = new System.Drawing.Font("Adobe Hebrew", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Standard.Location = new System.Drawing.Point(6, 24);
            this.Standard.Name = "Standard";
            this.Standard.Size = new System.Drawing.Size(82, 22);
            this.Standard.TabIndex = 17;
            this.Standard.TabStop = true;
            this.Standard.Text = "Standard";
            this.Standard.UseVisualStyleBackColor = true;
            this.Standard.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 423);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Sharp Auto Form";
            this.Load += new System.EventHandler(this.SharpAutoForm_Load);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AmountDue;
        private System.Windows.Forms.TextBox BasePrice;
        private System.Windows.Forms.TextBox TradeInAllowance;
        private System.Windows.Forms.TextBox Total;
        private System.Windows.Forms.TextBox AdditionalOption;
        private System.Windows.Forms.TextBox SalesTax;
        private System.Windows.Forms.TextBox Subtotal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fontFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorRToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox StereoSystem;
        private System.Windows.Forms.CheckBox LeatherInterior;
        private System.Windows.Forms.CheckBox ComputerNavigation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton CustomizedDetailing;
        private System.Windows.Forms.RadioButton Pearlized;
        private System.Windows.Forms.RadioButton Standard;
    }
}

