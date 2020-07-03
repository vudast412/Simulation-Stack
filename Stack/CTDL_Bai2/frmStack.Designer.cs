namespace CTDL_Bai2
{
    partial class frmStack
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStack));
            this.numPush = new System.Windows.Forms.NumericUpDown();
            this.btnPush = new System.Windows.Forms.Button();
            this.txtStack = new System.Windows.Forms.TextBox();
            this.btnPop = new System.Windows.Forms.Button();
            this.btnPeak = new System.Windows.Forms.Button();
            this.txtPop = new System.Windows.Forms.TextBox();
            this.txtPeak = new System.Windows.Forms.TextBox();
            this.pnlCanvas = new System.Windows.Forms.Panel();
            this.txtHead = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbSpeed = new System.Windows.Forms.TrackBar();
            this.lbSpeed = new System.Windows.Forms.Label();
            this.balanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.numPush)).BeginInit();
            this.pnlCanvas.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // numPush
            // 
            this.numPush.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPush.Location = new System.Drawing.Point(397, 77);
            this.numPush.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numPush.Name = "numPush";
            this.numPush.Size = new System.Drawing.Size(100, 26);
            this.numPush.TabIndex = 0;
            // 
            // btnPush
            // 
            this.btnPush.AutoSize = true;
            this.btnPush.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnPush.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPush.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPush.Location = new System.Drawing.Point(397, 145);
            this.btnPush.Name = "btnPush";
            this.btnPush.Size = new System.Drawing.Size(100, 40);
            this.btnPush.TabIndex = 1;
            this.btnPush.Text = "Push";
            this.btnPush.UseVisualStyleBackColor = false;
            this.btnPush.Click += new System.EventHandler(this.btnPush_Click);
            // 
            // txtStack
            // 
            this.txtStack.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtStack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtStack.Location = new System.Drawing.Point(12, 27);
            this.txtStack.Multiline = true;
            this.txtStack.Name = "txtStack";
            this.txtStack.ReadOnly = true;
            this.txtStack.Size = new System.Drawing.Size(499, 44);
            this.txtStack.TabIndex = 2;
            // 
            // btnPop
            // 
            this.btnPop.AutoSize = true;
            this.btnPop.BackColor = System.Drawing.Color.Yellow;
            this.btnPop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPop.Location = new System.Drawing.Point(397, 332);
            this.btnPop.Name = "btnPop";
            this.btnPop.Size = new System.Drawing.Size(100, 40);
            this.btnPop.TabIndex = 1;
            this.btnPop.Text = "Pop";
            this.btnPop.UseVisualStyleBackColor = false;
            this.btnPop.Click += new System.EventHandler(this.btnPop_Click);
            // 
            // btnPeak
            // 
            this.btnPeak.AutoSize = true;
            this.btnPeak.BackColor = System.Drawing.Color.Salmon;
            this.btnPeak.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeak.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPeak.Location = new System.Drawing.Point(397, 459);
            this.btnPeak.Name = "btnPeak";
            this.btnPeak.Size = new System.Drawing.Size(100, 40);
            this.btnPeak.TabIndex = 1;
            this.btnPeak.Text = "Peak";
            this.btnPeak.UseVisualStyleBackColor = false;
            this.btnPeak.Click += new System.EventHandler(this.btnPeak_Click);
            // 
            // txtPop
            // 
            this.txtPop.Enabled = false;
            this.txtPop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPop.Location = new System.Drawing.Point(397, 300);
            this.txtPop.Name = "txtPop";
            this.txtPop.Size = new System.Drawing.Size(100, 26);
            this.txtPop.TabIndex = 3;
            // 
            // txtPeak
            // 
            this.txtPeak.Enabled = false;
            this.txtPeak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeak.Location = new System.Drawing.Point(397, 427);
            this.txtPeak.Name = "txtPeak";
            this.txtPeak.Size = new System.Drawing.Size(100, 26);
            this.txtPeak.TabIndex = 3;
            // 
            // pnlCanvas
            // 
            this.pnlCanvas.BackColor = System.Drawing.Color.White;
            this.pnlCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCanvas.Controls.Add(this.txtHead);
            this.pnlCanvas.Location = new System.Drawing.Point(12, 77);
            this.pnlCanvas.Name = "pnlCanvas";
            this.pnlCanvas.Size = new System.Drawing.Size(362, 500);
            this.pnlCanvas.TabIndex = 4;
            // 
            // txtHead
            // 
            this.txtHead.AutoSize = true;
            this.txtHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHead.ForeColor = System.Drawing.Color.Navy;
            this.txtHead.Location = new System.Drawing.Point(125, 464);
            this.txtHead.Name = "txtHead";
            this.txtHead.Size = new System.Drawing.Size(0, 20);
            this.txtHead.TabIndex = 0;
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnQuit.Location = new System.Drawing.Point(397, 537);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(100, 40);
            this.btnQuit.TabIndex = 5;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(397, 109);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 34);
            this.button2.TabIndex = 6;
            this.button2.Text = "Random";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem,
            this.balanceToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(518, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.quitToolStripMenuItem.Text = "Menu";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tbSpeed
            // 
            this.tbSpeed.Location = new System.Drawing.Point(397, 239);
            this.tbSpeed.Maximum = 6;
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.Size = new System.Drawing.Size(104, 45);
            this.tbSpeed.TabIndex = 8;
            this.tbSpeed.Value = 3;
            this.tbSpeed.ValueChanged += new System.EventHandler(this.tbSpeed_ValueChanged);
            // 
            // lbSpeed
            // 
            this.lbSpeed.Location = new System.Drawing.Point(397, 223);
            this.lbSpeed.Name = "lbSpeed";
            this.lbSpeed.Size = new System.Drawing.Size(97, 23);
            this.lbSpeed.TabIndex = 9;
            this.lbSpeed.Text = "Simulation speed";
            this.lbSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // balanceToolStripMenuItem
            // 
            this.balanceToolStripMenuItem.Name = "balanceToolStripMenuItem";
            this.balanceToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.balanceToolStripMenuItem.Text = "Balance";
            this.balanceToolStripMenuItem.Click += new System.EventHandler(this.balanceToolStripMenuItem_Click);
            // 
            // frmStack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(518, 586);
            this.Controls.Add(this.lbSpeed);
            this.Controls.Add(this.tbSpeed);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pnlCanvas);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.txtPop);
            this.Controls.Add(this.btnPop);
            this.Controls.Add(this.txtPeak);
            this.Controls.Add(this.btnPeak);
            this.Controls.Add(this.txtStack);
            this.Controls.Add(this.btnPush);
            this.Controls.Add(this.numPush);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStack";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STACK APP";
            ((System.ComponentModel.ISupportInitialize)(this.numPush)).EndInit();
            this.pnlCanvas.ResumeLayout(false);
            this.pnlCanvas.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numPush;
        private System.Windows.Forms.Button btnPush;
        private System.Windows.Forms.TextBox txtStack;
        private System.Windows.Forms.Button btnPop;
        private System.Windows.Forms.Button btnPeak;
        private System.Windows.Forms.TextBox txtPop;
        private System.Windows.Forms.TextBox txtPeak;
        private System.Windows.Forms.Panel pnlCanvas;
        private System.Windows.Forms.Label txtHead;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.TrackBar tbSpeed;
        private System.Windows.Forms.Label lbSpeed;
        private System.Windows.Forms.ToolStripMenuItem balanceToolStripMenuItem;
    }
}

