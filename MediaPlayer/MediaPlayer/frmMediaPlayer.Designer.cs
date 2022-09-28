namespace MediaPlayer
{
    partial class frmMediaPlayer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMediaPlayer));
            this.mns1 = new System.Windows.Forms.MenuStrip();
            this.tscFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsrOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.grpPrincipal = new System.Windows.Forms.GroupBox();
            this.lblVolume = new System.Windows.Forms.Label();
            this.trbVolume = new System.Windows.Forms.TrackBar();
            this.lstList = new System.Windows.Forms.ListBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.wmpPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.tmr1 = new System.Windows.Forms.Timer(this.components);
            this.lblTrackStart = new System.Windows.Forms.Label();
            this.prgbr1 = new System.Windows.Forms.ProgressBar();
            this.lblTrackEnd = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mns1.SuspendLayout();
            this.grpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbVolume)).BeginInit();
            this.pnl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmpPlayer)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mns1
            // 
            this.mns1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mns1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tscFile});
            this.mns1.Location = new System.Drawing.Point(0, 0);
            this.mns1.Name = "mns1";
            this.mns1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.mns1.Size = new System.Drawing.Size(654, 24);
            this.mns1.TabIndex = 3;
            this.mns1.Text = "menuStrip1";
            // 
            // tscFile
            // 
            this.tscFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsrOpen});
            this.tscFile.Name = "tscFile";
            this.tscFile.Size = new System.Drawing.Size(37, 22);
            this.tscFile.Text = "File";
            // 
            // tsrOpen
            // 
            this.tsrOpen.Name = "tsrOpen";
            this.tsrOpen.Size = new System.Drawing.Size(180, 22);
            this.tsrOpen.Text = "Open";
            this.tsrOpen.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // grpPrincipal
            // 
            this.grpPrincipal.Controls.Add(this.lblVolume);
            this.grpPrincipal.Controls.Add(this.trbVolume);
            this.grpPrincipal.Controls.Add(this.lstList);
            this.grpPrincipal.Controls.Add(this.btnNext);
            this.grpPrincipal.Controls.Add(this.btnPause);
            this.grpPrincipal.Controls.Add(this.btnStop);
            this.grpPrincipal.Controls.Add(this.btnPlay);
            this.grpPrincipal.Controls.Add(this.btnPrevious);
            this.grpPrincipal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpPrincipal.Location = new System.Drawing.Point(0, 414);
            this.grpPrincipal.Name = "grpPrincipal";
            this.grpPrincipal.Size = new System.Drawing.Size(654, 177);
            this.grpPrincipal.TabIndex = 4;
            this.grpPrincipal.TabStop = false;
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(439, 33);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(13, 13);
            this.lblVolume.TabIndex = 8;
            this.lblVolume.Text = "0";
            // 
            // trbVolume
            // 
            this.trbVolume.Location = new System.Drawing.Point(329, 31);
            this.trbVolume.Maximum = 100;
            this.trbVolume.Name = "trbVolume";
            this.trbVolume.Size = new System.Drawing.Size(104, 45);
            this.trbVolume.TabIndex = 7;
            this.trbVolume.Scroll += new System.EventHandler(this.trbVolume_Scroll);
            // 
            // lstList
            // 
            this.lstList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstList.FormattingEnabled = true;
            this.lstList.Location = new System.Drawing.Point(3, 79);
            this.lstList.Name = "lstList";
            this.lstList.Size = new System.Drawing.Size(648, 95);
            this.lstList.TabIndex = 6;
            this.lstList.SelectedIndexChanged += new System.EventHandler(this.lstList_SelectedIndexChanged);
            // 
            // btnNext
            // 
            this.btnNext.AutoSize = true;
            this.btnNext.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnNext.Location = new System.Drawing.Point(264, 24);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(59, 43);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "⏭️";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPause
            // 
            this.btnPause.AutoSize = true;
            this.btnPause.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnPause.Location = new System.Drawing.Point(134, 24);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(59, 43);
            this.btnPause.TabIndex = 4;
            this.btnPause.Text = "⏸️";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStop
            // 
            this.btnStop.AutoSize = true;
            this.btnStop.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnStop.Location = new System.Drawing.Point(199, 24);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(59, 43);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "⏹️";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.AutoSize = true;
            this.btnPlay.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnPlay.Location = new System.Drawing.Point(71, 24);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(57, 43);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.Text = " ►";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.AutoSize = true;
            this.btnPrevious.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnPrevious.Location = new System.Drawing.Point(6, 24);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(59, 43);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.Text = "⏮️";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // pnl1
            // 
            this.pnl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl1.Controls.Add(this.wmpPlayer);
            this.pnl1.Location = new System.Drawing.Point(0, 27);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(654, 373);
            this.pnl1.TabIndex = 0;
            // 
            // wmpPlayer
            // 
            this.wmpPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wmpPlayer.Enabled = true;
            this.wmpPlayer.Location = new System.Drawing.Point(0, 0);
            this.wmpPlayer.Name = "wmpPlayer";
            this.wmpPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpPlayer.OcxState")));
            this.wmpPlayer.Size = new System.Drawing.Size(654, 373);
            this.wmpPlayer.TabIndex = 0;
            // 
            // tmr1
            // 
            this.tmr1.Tick += new System.EventHandler(this.tmr1_Tick);
            // 
            // lblTrackStart
            // 
            this.lblTrackStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTrackStart.AutoSize = true;
            this.lblTrackStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrackStart.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTrackStart.Location = new System.Drawing.Point(9, 6);
            this.lblTrackStart.Name = "lblTrackStart";
            this.lblTrackStart.Size = new System.Drawing.Size(38, 16);
            this.lblTrackStart.TabIndex = 10;
            this.lblTrackStart.Text = "00:00";
            // 
            // prgbr1
            // 
            this.prgbr1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prgbr1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.prgbr1.Location = new System.Drawing.Point(65, 7);
            this.prgbr1.Name = "prgbr1";
            this.prgbr1.Size = new System.Drawing.Size(513, 15);
            this.prgbr1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prgbr1.TabIndex = 9;
            // 
            // lblTrackEnd
            // 
            this.lblTrackEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTrackEnd.AutoSize = true;
            this.lblTrackEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrackEnd.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTrackEnd.Location = new System.Drawing.Point(602, 7);
            this.lblTrackEnd.Name = "lblTrackEnd";
            this.lblTrackEnd.Size = new System.Drawing.Size(38, 16);
            this.lblTrackEnd.TabIndex = 10;
            this.lblTrackEnd.Text = "00:00";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.lblTrackEnd);
            this.panel1.Controls.Add(this.prgbr1);
            this.panel1.Controls.Add(this.lblTrackStart);
            this.panel1.Location = new System.Drawing.Point(0, 399);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(654, 28);
            this.panel1.TabIndex = 5;
            // 
            // frmMediaPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 591);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl1);
            this.Controls.Add(this.mns1);
            this.Controls.Add(this.grpPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mns1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMediaPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Media Player";
            this.mns1.ResumeLayout(false);
            this.mns1.PerformLayout();
            this.grpPrincipal.ResumeLayout(false);
            this.grpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbVolume)).EndInit();
            this.pnl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wmpPlayer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mns1;
        private System.Windows.Forms.ToolStripMenuItem tscFile;
        private System.Windows.Forms.ToolStripMenuItem tsrOpen;
        private System.Windows.Forms.GroupBox grpPrincipal;
        private System.Windows.Forms.Panel pnl1;
        private AxWMPLib.AxWindowsMediaPlayer wmpPlayer;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.TrackBar trbVolume;
        private System.Windows.Forms.ListBox lstList;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Timer tmr1;
        private System.Windows.Forms.Label lblTrackStart;
        private System.Windows.Forms.ProgressBar prgbr1;
        private System.Windows.Forms.Label lblTrackEnd;
        private System.Windows.Forms.Panel panel1;
    }
}

