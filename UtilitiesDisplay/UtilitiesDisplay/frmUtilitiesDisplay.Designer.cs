namespace UtilitiesDisplay
{
    partial class frmUtilitiesDisplay
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
            this.lblTitleSerialnumber = new System.Windows.Forms.Label();
            this.lblSerialNumber = new System.Windows.Forms.Label();
            this.btnSysInfo = new System.Windows.Forms.Button();
            this.lblTitleDrives = new System.Windows.Forms.Label();
            this.lblDrives = new System.Windows.Forms.Label();
            this.lblTitlePhyProcessors = new System.Windows.Forms.Label();
            this.lblPhyProcessors = new System.Windows.Forms.Label();
            this.lblTitleLogProcessors = new System.Windows.Forms.Label();
            this.lblLogProcessors = new System.Windows.Forms.Label();
            this.lblCores = new System.Windows.Forms.Label();
            this.lblTitleCores = new System.Windows.Forms.Label();
            this.lblMachineName = new System.Windows.Forms.Label();
            this.lblTitleMachineName = new System.Windows.Forms.Label();
            this.lblMemoryAmount = new System.Windows.Forms.Label();
            this.lblTitleMemoryAmount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitleSerialnumber
            // 
            this.lblTitleSerialnumber.AutoSize = true;
            this.lblTitleSerialnumber.Location = new System.Drawing.Point(33, 64);
            this.lblTitleSerialnumber.Name = "lblTitleSerialnumber";
            this.lblTitleSerialnumber.Size = new System.Drawing.Size(73, 13);
            this.lblTitleSerialnumber.TabIndex = 0;
            this.lblTitleSerialnumber.Text = "Serial Number";
            // 
            // lblSerialNumber
            // 
            this.lblSerialNumber.AutoSize = true;
            this.lblSerialNumber.Location = new System.Drawing.Point(134, 64);
            this.lblSerialNumber.Name = "lblSerialNumber";
            this.lblSerialNumber.Size = new System.Drawing.Size(13, 13);
            this.lblSerialNumber.TabIndex = 1;
            this.lblSerialNumber.Text = "0";
            // 
            // btnSysInfo
            // 
            this.btnSysInfo.Location = new System.Drawing.Point(36, 265);
            this.btnSysInfo.Name = "btnSysInfo";
            this.btnSysInfo.Size = new System.Drawing.Size(111, 23);
            this.btnSysInfo.TabIndex = 2;
            this.btnSysInfo.Text = "Get System Info";
            this.btnSysInfo.UseVisualStyleBackColor = true;
            this.btnSysInfo.Click += new System.EventHandler(this.btnSysInfo_Click);
            // 
            // lblTitleDrives
            // 
            this.lblTitleDrives.AutoSize = true;
            this.lblTitleDrives.Location = new System.Drawing.Point(33, 90);
            this.lblTitleDrives.Name = "lblTitleDrives";
            this.lblTitleDrives.Size = new System.Drawing.Size(37, 13);
            this.lblTitleDrives.TabIndex = 3;
            this.lblTitleDrives.Text = "Drives";
            // 
            // lblDrives
            // 
            this.lblDrives.AutoSize = true;
            this.lblDrives.Location = new System.Drawing.Point(134, 90);
            this.lblDrives.Name = "lblDrives";
            this.lblDrives.Size = new System.Drawing.Size(13, 13);
            this.lblDrives.TabIndex = 4;
            this.lblDrives.Text = "0";
            // 
            // lblTitlePhyProcessors
            // 
            this.lblTitlePhyProcessors.AutoSize = true;
            this.lblTitlePhyProcessors.Location = new System.Drawing.Point(33, 116);
            this.lblTitlePhyProcessors.Name = "lblTitlePhyProcessors";
            this.lblTitlePhyProcessors.Size = new System.Drawing.Size(72, 13);
            this.lblTitlePhyProcessors.TabIndex = 5;
            this.lblTitlePhyProcessors.Text = "P. Processors";
            // 
            // lblPhyProcessors
            // 
            this.lblPhyProcessors.AutoSize = true;
            this.lblPhyProcessors.Location = new System.Drawing.Point(134, 116);
            this.lblPhyProcessors.Name = "lblPhyProcessors";
            this.lblPhyProcessors.Size = new System.Drawing.Size(13, 13);
            this.lblPhyProcessors.TabIndex = 6;
            this.lblPhyProcessors.Text = "0";
            // 
            // lblTitleLogProcessors
            // 
            this.lblTitleLogProcessors.AutoSize = true;
            this.lblTitleLogProcessors.Location = new System.Drawing.Point(33, 142);
            this.lblTitleLogProcessors.Name = "lblTitleLogProcessors";
            this.lblTitleLogProcessors.Size = new System.Drawing.Size(83, 13);
            this.lblTitleLogProcessors.TabIndex = 7;
            this.lblTitleLogProcessors.Text = "Log. Processors";
            // 
            // lblLogProcessors
            // 
            this.lblLogProcessors.AutoSize = true;
            this.lblLogProcessors.Location = new System.Drawing.Point(134, 142);
            this.lblLogProcessors.Name = "lblLogProcessors";
            this.lblLogProcessors.Size = new System.Drawing.Size(13, 13);
            this.lblLogProcessors.TabIndex = 8;
            this.lblLogProcessors.Text = "0";
            // 
            // lblCores
            // 
            this.lblCores.AutoSize = true;
            this.lblCores.Location = new System.Drawing.Point(134, 170);
            this.lblCores.Name = "lblCores";
            this.lblCores.Size = new System.Drawing.Size(13, 13);
            this.lblCores.TabIndex = 10;
            this.lblCores.Text = "0";
            // 
            // lblTitleCores
            // 
            this.lblTitleCores.AutoSize = true;
            this.lblTitleCores.Location = new System.Drawing.Point(33, 170);
            this.lblTitleCores.Name = "lblTitleCores";
            this.lblTitleCores.Size = new System.Drawing.Size(34, 13);
            this.lblTitleCores.TabIndex = 9;
            this.lblTitleCores.Text = "Cores";
            // 
            // lblMachineName
            // 
            this.lblMachineName.AutoSize = true;
            this.lblMachineName.Location = new System.Drawing.Point(134, 198);
            this.lblMachineName.Name = "lblMachineName";
            this.lblMachineName.Size = new System.Drawing.Size(13, 13);
            this.lblMachineName.TabIndex = 12;
            this.lblMachineName.Text = "0";
            // 
            // lblTitleMachineName
            // 
            this.lblTitleMachineName.AutoSize = true;
            this.lblTitleMachineName.Location = new System.Drawing.Point(33, 198);
            this.lblTitleMachineName.Name = "lblTitleMachineName";
            this.lblTitleMachineName.Size = new System.Drawing.Size(79, 13);
            this.lblTitleMachineName.TabIndex = 11;
            this.lblTitleMachineName.Text = "Machine Name";
            // 
            // lblMemoryAmount
            // 
            this.lblMemoryAmount.AutoSize = true;
            this.lblMemoryAmount.Location = new System.Drawing.Point(134, 228);
            this.lblMemoryAmount.Name = "lblMemoryAmount";
            this.lblMemoryAmount.Size = new System.Drawing.Size(13, 13);
            this.lblMemoryAmount.TabIndex = 14;
            this.lblMemoryAmount.Text = "0";
            // 
            // lblTitleMemoryAmount
            // 
            this.lblTitleMemoryAmount.AutoSize = true;
            this.lblTitleMemoryAmount.Location = new System.Drawing.Point(33, 228);
            this.lblTitleMemoryAmount.Name = "lblTitleMemoryAmount";
            this.lblTitleMemoryAmount.Size = new System.Drawing.Size(83, 13);
            this.lblTitleMemoryAmount.TabIndex = 13;
            this.lblTitleMemoryAmount.Text = "Memory Amount";
            // 
            // frmUtilitiesDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMemoryAmount);
            this.Controls.Add(this.lblTitleMemoryAmount);
            this.Controls.Add(this.lblMachineName);
            this.Controls.Add(this.lblTitleMachineName);
            this.Controls.Add(this.lblCores);
            this.Controls.Add(this.lblTitleCores);
            this.Controls.Add(this.lblLogProcessors);
            this.Controls.Add(this.lblTitleLogProcessors);
            this.Controls.Add(this.lblPhyProcessors);
            this.Controls.Add(this.lblTitlePhyProcessors);
            this.Controls.Add(this.lblDrives);
            this.Controls.Add(this.lblTitleDrives);
            this.Controls.Add(this.btnSysInfo);
            this.Controls.Add(this.lblSerialNumber);
            this.Controls.Add(this.lblTitleSerialnumber);
            this.Name = "frmUtilitiesDisplay";
            this.Text = "Utilities Display";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitleSerialnumber;
        private System.Windows.Forms.Label lblSerialNumber;
        private System.Windows.Forms.Button btnSysInfo;
        private System.Windows.Forms.Label lblTitleDrives;
        private System.Windows.Forms.Label lblDrives;
        private System.Windows.Forms.Label lblTitlePhyProcessors;
        private System.Windows.Forms.Label lblPhyProcessors;
        private System.Windows.Forms.Label lblTitleLogProcessors;
        private System.Windows.Forms.Label lblLogProcessors;
        private System.Windows.Forms.Label lblCores;
        private System.Windows.Forms.Label lblTitleCores;
        private System.Windows.Forms.Label lblMachineName;
        private System.Windows.Forms.Label lblTitleMachineName;
        private System.Windows.Forms.Label lblMemoryAmount;
        private System.Windows.Forms.Label lblTitleMemoryAmount;
    }
}

