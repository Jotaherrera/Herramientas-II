namespace PDF_Reader
{
    partial class frmPDF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPDF));
            this.apdf1 = new AxAcroPDFLib.AxAcroPDF();
            this.mnsPrincipal = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsrOpen = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.apdf1)).BeginInit();
            this.mnsPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // apdf1
            // 
            this.apdf1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.apdf1.Enabled = true;
            this.apdf1.Location = new System.Drawing.Point(0, 24);
            this.apdf1.Name = "apdf1";
            this.apdf1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("apdf1.OcxState")));
            this.apdf1.Size = new System.Drawing.Size(800, 587);
            this.apdf1.TabIndex = 0;
            // 
            // mnsPrincipal
            // 
            this.mnsPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mnsPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnsPrincipal.Name = "mnsPrincipal";
            this.mnsPrincipal.Size = new System.Drawing.Size(800, 24);
            this.mnsPrincipal.TabIndex = 1;
            this.mnsPrincipal.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsrOpen});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // tsrOpen
            // 
            this.tsrOpen.Name = "tsrOpen";
            this.tsrOpen.Size = new System.Drawing.Size(180, 22);
            this.tsrOpen.Text = "Open";
            this.tsrOpen.Click += new System.EventHandler(this.tsrOpen_Click);
            // 
            // frmPDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 611);
            this.Controls.Add(this.apdf1);
            this.Controls.Add(this.mnsPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnsPrincipal;
            this.Name = "frmPDF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDF Reader";
            ((System.ComponentModel.ISupportInitialize)(this.apdf1)).EndInit();
            this.mnsPrincipal.ResumeLayout(false);
            this.mnsPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxAcroPDFLib.AxAcroPDF apdf1;
        private System.Windows.Forms.MenuStrip mnsPrincipal;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsrOpen;
    }
}

