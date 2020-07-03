namespace CTDL_Bai2
{
    partial class frmBalance
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBalance));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lbValue = new System.Windows.Forms.Label();
            this.cbSelect = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtResult);
            this.panel1.Controls.Add(this.txtInput);
            this.panel1.Location = new System.Drawing.Point(12, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 124);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(4, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 45);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kết quả";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "Biểu thức";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtResult
            // 
            this.txtResult.Enabled = false;
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(160, 75);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(331, 46);
            this.txtResult.TabIndex = 1;
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(160, 3);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(331, 46);
            this.txtInput.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.btnMenu);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.btnConvert);
            this.panel2.Controls.Add(this.lbValue);
            this.panel2.Controls.Add(this.cbSelect);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(12, 181);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(491, 188);
            this.panel2.TabIndex = 1;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Location = new System.Drawing.Point(51, 127);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(103, 44);
            this.btnMenu.TabIndex = 10;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(314, 127);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(103, 44);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.Location = new System.Drawing.Point(186, 127);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(103, 44);
            this.btnConvert.TabIndex = 8;
            this.btnConvert.Text = "Chuyển";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.btnChuyenDoi_Click);
            // 
            // lbValue
            // 
            this.lbValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbValue.Location = new System.Drawing.Point(281, 22);
            this.lbValue.Name = "lbValue";
            this.lbValue.Size = new System.Drawing.Size(207, 35);
            this.lbValue.TabIndex = 7;
            this.lbValue.Text = "0\r\n";
            this.lbValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbSelect
            // 
            this.cbSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSelect.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.cbSelect.FormattingEnabled = true;
            this.cbSelect.Items.AddRange(new object[] {
            "Trung tố sang hậu tố",
            "Hậu tố sang trung tố"});
            this.cbSelect.Location = new System.Drawing.Point(186, 90);
            this.cbSelect.Name = "cbSelect";
            this.cbSelect.Size = new System.Drawing.Size(231, 28);
            this.cbSelect.TabIndex = 6;
            this.cbSelect.Text = "Phương thức";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(4, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 45);
            this.label4.TabIndex = 5;
            this.label4.Text = "Lựa chọn";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(4, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 45);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kết quả của biểu thức";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lime;
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Location = new System.Drawing.Point(13, 376);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 198);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Instruction";
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(8, 20);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(473, 172);
            this.textBox3.TabIndex = 0;
            this.textBox3.Text = resources.GetString("textBox3.Text");
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(518, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // frmBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CTDL_Bai2.Properties.Resources.backg;
            this.ClientSize = new System.Drawing.Size(518, 586);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBalance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Balance";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lbValue;
        private System.Windows.Forms.ComboBox cbSelect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}