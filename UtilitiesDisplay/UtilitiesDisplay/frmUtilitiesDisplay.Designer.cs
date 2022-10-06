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
            this.grpHardDrive = new System.Windows.Forms.GroupBox();
            this.grpSystem = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rtbNIC = new System.Windows.Forms.RichTextBox();
            this.grpUpdates = new System.Windows.Forms.GroupBox();
            this.rtbUpdates = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpTasks = new System.Windows.Forms.GroupBox();
            this.lstTasks = new System.Windows.Forms.ListBox();
            this.grpHardDrive.SuspendLayout();
            this.grpSystem.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grpUpdates.SuspendLayout();
            this.grpTasks.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitleSerialnumber
            // 
            this.lblTitleSerialnumber.AutoSize = true;
            this.lblTitleSerialnumber.Location = new System.Drawing.Point(7, 38);
            this.lblTitleSerialnumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitleSerialnumber.Name = "lblTitleSerialnumber";
            this.lblTitleSerialnumber.Size = new System.Drawing.Size(109, 20);
            this.lblTitleSerialnumber.TabIndex = 0;
            this.lblTitleSerialnumber.Text = "Serial Number";
            // 
            // lblSerialNumber
            // 
            this.lblSerialNumber.AutoSize = true;
            this.lblSerialNumber.Location = new System.Drawing.Point(158, 38);
            this.lblSerialNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSerialNumber.Name = "lblSerialNumber";
            this.lblSerialNumber.Size = new System.Drawing.Size(18, 20);
            this.lblSerialNumber.TabIndex = 1;
            this.lblSerialNumber.Text = "0";
            // 
            // btnSysInfo
            // 
            this.btnSysInfo.Location = new System.Drawing.Point(23, 836);
            this.btnSysInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSysInfo.Name = "btnSysInfo";
            this.btnSysInfo.Size = new System.Drawing.Size(166, 35);
            this.btnSysInfo.TabIndex = 2;
            this.btnSysInfo.Text = "Get System Info";
            this.btnSysInfo.UseVisualStyleBackColor = true;
            this.btnSysInfo.Click += new System.EventHandler(this.btnSysInfo_Click);
            // 
            // lblTitleDrives
            // 
            this.lblTitleDrives.AutoSize = true;
            this.lblTitleDrives.Location = new System.Drawing.Point(7, 79);
            this.lblTitleDrives.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitleDrives.Name = "lblTitleDrives";
            this.lblTitleDrives.Size = new System.Drawing.Size(53, 20);
            this.lblTitleDrives.TabIndex = 3;
            this.lblTitleDrives.Text = "Drives";
            // 
            // lblDrives
            // 
            this.lblDrives.AutoSize = true;
            this.lblDrives.Location = new System.Drawing.Point(158, 79);
            this.lblDrives.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDrives.Name = "lblDrives";
            this.lblDrives.Size = new System.Drawing.Size(18, 20);
            this.lblDrives.TabIndex = 4;
            this.lblDrives.Text = "0";
            // 
            // lblTitlePhyProcessors
            // 
            this.lblTitlePhyProcessors.AutoSize = true;
            this.lblTitlePhyProcessors.Location = new System.Drawing.Point(7, 69);
            this.lblTitlePhyProcessors.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitlePhyProcessors.Name = "lblTitlePhyProcessors";
            this.lblTitlePhyProcessors.Size = new System.Drawing.Size(106, 20);
            this.lblTitlePhyProcessors.TabIndex = 5;
            this.lblTitlePhyProcessors.Text = "P. Processors";
            // 
            // lblPhyProcessors
            // 
            this.lblPhyProcessors.AutoSize = true;
            this.lblPhyProcessors.Location = new System.Drawing.Point(159, 69);
            this.lblPhyProcessors.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhyProcessors.Name = "lblPhyProcessors";
            this.lblPhyProcessors.Size = new System.Drawing.Size(18, 20);
            this.lblPhyProcessors.TabIndex = 6;
            this.lblPhyProcessors.Text = "0";
            // 
            // lblTitleLogProcessors
            // 
            this.lblTitleLogProcessors.AutoSize = true;
            this.lblTitleLogProcessors.Location = new System.Drawing.Point(7, 109);
            this.lblTitleLogProcessors.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitleLogProcessors.Name = "lblTitleLogProcessors";
            this.lblTitleLogProcessors.Size = new System.Drawing.Size(123, 20);
            this.lblTitleLogProcessors.TabIndex = 7;
            this.lblTitleLogProcessors.Text = "Log. Processors";
            // 
            // lblLogProcessors
            // 
            this.lblLogProcessors.AutoSize = true;
            this.lblLogProcessors.Location = new System.Drawing.Point(159, 109);
            this.lblLogProcessors.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogProcessors.Name = "lblLogProcessors";
            this.lblLogProcessors.Size = new System.Drawing.Size(18, 20);
            this.lblLogProcessors.TabIndex = 8;
            this.lblLogProcessors.Text = "0";
            // 
            // lblCores
            // 
            this.lblCores.AutoSize = true;
            this.lblCores.Location = new System.Drawing.Point(159, 149);
            this.lblCores.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCores.Name = "lblCores";
            this.lblCores.Size = new System.Drawing.Size(18, 20);
            this.lblCores.TabIndex = 10;
            this.lblCores.Text = "0";
            // 
            // lblTitleCores
            // 
            this.lblTitleCores.AutoSize = true;
            this.lblTitleCores.Location = new System.Drawing.Point(7, 149);
            this.lblTitleCores.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitleCores.Name = "lblTitleCores";
            this.lblTitleCores.Size = new System.Drawing.Size(51, 20);
            this.lblTitleCores.TabIndex = 9;
            this.lblTitleCores.Text = "Cores";
            // 
            // lblMachineName
            // 
            this.lblMachineName.AutoSize = true;
            this.lblMachineName.Location = new System.Drawing.Point(159, 29);
            this.lblMachineName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMachineName.Name = "lblMachineName";
            this.lblMachineName.Size = new System.Drawing.Size(18, 20);
            this.lblMachineName.TabIndex = 12;
            this.lblMachineName.Text = "0";
            // 
            // lblTitleMachineName
            // 
            this.lblTitleMachineName.AutoSize = true;
            this.lblTitleMachineName.Location = new System.Drawing.Point(7, 29);
            this.lblTitleMachineName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitleMachineName.Name = "lblTitleMachineName";
            this.lblTitleMachineName.Size = new System.Drawing.Size(115, 20);
            this.lblTitleMachineName.TabIndex = 11;
            this.lblTitleMachineName.Text = "Machine Name";
            // 
            // lblMemoryAmount
            // 
            this.lblMemoryAmount.AutoSize = true;
            this.lblMemoryAmount.Location = new System.Drawing.Point(159, 189);
            this.lblMemoryAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMemoryAmount.Name = "lblMemoryAmount";
            this.lblMemoryAmount.Size = new System.Drawing.Size(18, 20);
            this.lblMemoryAmount.TabIndex = 14;
            this.lblMemoryAmount.Text = "0";
            // 
            // lblTitleMemoryAmount
            // 
            this.lblTitleMemoryAmount.AutoSize = true;
            this.lblTitleMemoryAmount.Location = new System.Drawing.Point(7, 189);
            this.lblTitleMemoryAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitleMemoryAmount.Name = "lblTitleMemoryAmount";
            this.lblTitleMemoryAmount.Size = new System.Drawing.Size(125, 20);
            this.lblTitleMemoryAmount.TabIndex = 13;
            this.lblTitleMemoryAmount.Text = "Memory Amount";
            // 
            // grpHardDrive
            // 
            this.grpHardDrive.Controls.Add(this.lblTitleSerialnumber);
            this.grpHardDrive.Controls.Add(this.lblSerialNumber);
            this.grpHardDrive.Controls.Add(this.lblTitleDrives);
            this.grpHardDrive.Controls.Add(this.lblDrives);
            this.grpHardDrive.Location = new System.Drawing.Point(385, 16);
            this.grpHardDrive.Name = "grpHardDrive";
            this.grpHardDrive.Size = new System.Drawing.Size(684, 136);
            this.grpHardDrive.TabIndex = 17;
            this.grpHardDrive.TabStop = false;
            this.grpHardDrive.Text = "Hard Drive";
            // 
            // grpSystem
            // 
            this.grpSystem.Controls.Add(this.lblTitlePhyProcessors);
            this.grpSystem.Controls.Add(this.lblPhyProcessors);
            this.grpSystem.Controls.Add(this.lblTitleLogProcessors);
            this.grpSystem.Controls.Add(this.lblLogProcessors);
            this.grpSystem.Controls.Add(this.lblMemoryAmount);
            this.grpSystem.Controls.Add(this.lblTitleCores);
            this.grpSystem.Controls.Add(this.lblTitleMemoryAmount);
            this.grpSystem.Controls.Add(this.lblCores);
            this.grpSystem.Controls.Add(this.lblMachineName);
            this.grpSystem.Controls.Add(this.lblTitleMachineName);
            this.grpSystem.Location = new System.Drawing.Point(12, 12);
            this.grpSystem.Name = "grpSystem";
            this.grpSystem.Size = new System.Drawing.Size(349, 238);
            this.grpSystem.TabIndex = 18;
            this.grpSystem.TabStop = false;
            this.grpSystem.Text = "System";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rtbNIC);
            this.groupBox3.Location = new System.Drawing.Point(385, 172);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(684, 214);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Network Interface Card";
            // 
            // rtbNIC
            // 
            this.rtbNIC.BackColor = System.Drawing.SystemColors.Control;
            this.rtbNIC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbNIC.Location = new System.Drawing.Point(9, 25);
            this.rtbNIC.Name = "rtbNIC";
            this.rtbNIC.Size = new System.Drawing.Size(667, 174);
            this.rtbNIC.TabIndex = 17;
            this.rtbNIC.Text = "";
            // 
            // grpUpdates
            // 
            this.grpUpdates.Controls.Add(this.rtbUpdates);
            this.grpUpdates.Location = new System.Drawing.Point(385, 414);
            this.grpUpdates.Name = "grpUpdates";
            this.grpUpdates.Size = new System.Drawing.Size(684, 214);
            this.grpUpdates.TabIndex = 20;
            this.grpUpdates.TabStop = false;
            this.grpUpdates.Text = "Updates";
            // 
            // rtbUpdates
            // 
            this.rtbUpdates.BackColor = System.Drawing.SystemColors.Control;
            this.rtbUpdates.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbUpdates.Location = new System.Drawing.Point(9, 25);
            this.rtbUpdates.Name = "rtbUpdates";
            this.rtbUpdates.Size = new System.Drawing.Size(667, 174);
            this.rtbUpdates.TabIndex = 17;
            this.rtbUpdates.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 271);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 357);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // grpTasks
            // 
            this.grpTasks.Controls.Add(this.lstTasks);
            this.grpTasks.Location = new System.Drawing.Point(385, 653);
            this.grpTasks.Name = "grpTasks";
            this.grpTasks.Size = new System.Drawing.Size(684, 214);
            this.grpTasks.TabIndex = 21;
            this.grpTasks.TabStop = false;
            this.grpTasks.Text = "Tasks";
            // 
            // lstTasks
            // 
            this.lstTasks.BackColor = System.Drawing.SystemColors.Control;
            this.lstTasks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstTasks.FormattingEnabled = true;
            this.lstTasks.ItemHeight = 20;
            this.lstTasks.Location = new System.Drawing.Point(11, 25);
            this.lstTasks.Name = "lstTasks";
            this.lstTasks.Size = new System.Drawing.Size(665, 160);
            this.lstTasks.TabIndex = 0;
            // 
            // frmUtilitiesDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 885);
            this.Controls.Add(this.grpTasks);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpUpdates);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grpSystem);
            this.Controls.Add(this.grpHardDrive);
            this.Controls.Add(this.btnSysInfo);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmUtilitiesDisplay";
            this.Text = "Utilities Display";
            this.grpHardDrive.ResumeLayout(false);
            this.grpHardDrive.PerformLayout();
            this.grpSystem.ResumeLayout(false);
            this.grpSystem.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.grpUpdates.ResumeLayout(false);
            this.grpTasks.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.GroupBox grpHardDrive;
        private System.Windows.Forms.GroupBox grpSystem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox rtbNIC;
        private System.Windows.Forms.GroupBox grpUpdates;
        private System.Windows.Forms.RichTextBox rtbUpdates;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpTasks;
        private System.Windows.Forms.ListBox lstTasks;
    }
}

