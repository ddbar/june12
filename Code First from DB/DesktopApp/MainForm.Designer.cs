namespace DesktopApp
{
    partial class MainForm
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
      this.menuStrip2 = new System.Windows.Forms.MenuStrip();
      this.menuStrip3 = new System.Windows.Forms.MenuStrip();
      this.clickToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.clickHereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip2.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip2
      // 
      this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clickToolStripMenuItem});
      this.menuStrip2.Location = new System.Drawing.Point(0, 24);
      this.menuStrip2.Name = "menuStrip2";
      this.menuStrip2.Size = new System.Drawing.Size(619, 24);
      this.menuStrip2.TabIndex = 0;
      this.menuStrip2.Text = "menuStrip2";
      this.menuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
      // 
      // menuStrip3
      // 
      this.menuStrip3.Location = new System.Drawing.Point(0, 0);
      this.menuStrip3.Name = "menuStrip3";
      this.menuStrip3.Size = new System.Drawing.Size(619, 24);
      this.menuStrip3.TabIndex = 1;
      this.menuStrip3.Text = "menuStrip3";
      // 
      // clickToolStripMenuItem
      // 
      this.clickToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clickHereToolStripMenuItem});
      this.clickToolStripMenuItem.Name = "clickToolStripMenuItem";
      this.clickToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
      this.clickToolStripMenuItem.Text = "click";
      // 
      // clickHereToolStripMenuItem
      // 
      this.clickHereToolStripMenuItem.Name = "clickHereToolStripMenuItem";
      this.clickHereToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.clickHereToolStripMenuItem.Text = "click here";
      this.clickHereToolStripMenuItem.Click += new System.EventHandler(this.clickHereToolStripMenuItem_Click);
      // 
      // MainForm
      // 
      this.ClientSize = new System.Drawing.Size(619, 480);
      this.Controls.Add(this.menuStrip2);
      this.Controls.Add(this.menuStrip3);
      this.MainMenuStrip = this.menuStrip2;
      this.Name = "MainForm";
      this.Text = "main form";
      this.Load += new System.EventHandler(this.MainForm_Load_1);
      this.menuStrip2.ResumeLayout(false);
      this.menuStrip2.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shippersToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerOrdersToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem productSalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem errorLogsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutThisAppToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StartTime;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem clickToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clickHereToolStripMenuItem;

    }
}

