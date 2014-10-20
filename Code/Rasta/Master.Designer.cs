namespace Rasta
{
    partial class Master
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Master));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.treasuryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bankReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treasuryReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wEETREToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iTReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.treasuryToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(972, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(55, 20);
            this.toolStripMenuItem1.Text = "Admin";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(123, 20);
            this.toolStripMenuItem2.Text = "Account Receivable";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(111, 20);
            this.toolStripMenuItem3.Text = "Account Payable ";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bankReportToolStripMenuItem,
            this.treasuryReportToolStripMenuItem,
            this.wEETREToolStripMenuItem,
            this.iTReportToolStripMenuItem});
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(59, 20);
            this.toolStripMenuItem4.Text = "Reports";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // treasuryToolStripMenuItem
            // 
            this.treasuryToolStripMenuItem.Name = "treasuryToolStripMenuItem";
            this.treasuryToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.treasuryToolStripMenuItem.Text = "Treasury";
            this.treasuryToolStripMenuItem.Click += new System.EventHandler(this.treasuryToolStripMenuItem_Click);
            // 
            // bankReportToolStripMenuItem
            // 
            this.bankReportToolStripMenuItem.Name = "bankReportToolStripMenuItem";
            this.bankReportToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.bankReportToolStripMenuItem.Text = "Bank Report";
            this.bankReportToolStripMenuItem.Click += new System.EventHandler(this.bankReportToolStripMenuItem_Click);
            // 
            // treasuryReportToolStripMenuItem
            // 
            this.treasuryReportToolStripMenuItem.Name = "treasuryReportToolStripMenuItem";
            this.treasuryReportToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.treasuryReportToolStripMenuItem.Text = "Treasury Report";
            // 
            // wEETREToolStripMenuItem
            // 
            this.wEETREToolStripMenuItem.Name = "wEETREToolStripMenuItem";
            this.wEETREToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.wEETREToolStripMenuItem.Text = "WEETRE";
            // 
            // iTReportToolStripMenuItem
            // 
            this.iTReportToolStripMenuItem.Name = "iTReportToolStripMenuItem";
            this.iTReportToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.iTReportToolStripMenuItem.Text = "IT Report";
            // 
            // Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 488);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Master";
            this.Text = "Rasta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem treasuryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bankReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem treasuryReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wEETREToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iTReportToolStripMenuItem;

       
    }
}