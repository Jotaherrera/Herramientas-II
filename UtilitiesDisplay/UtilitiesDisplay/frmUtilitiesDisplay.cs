using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities;

namespace UtilitiesDisplay
{
    public partial class frmUtilitiesDisplay : Form
    {
        Drives hd = new Drives();
        SystemInfo si = new SystemInfo();
        TaskManager tm = new TaskManager();
        RegTools rt = new RegTools();

        public frmUtilitiesDisplay()
        {
            InitializeComponent();
            lblDrives.Text = "";
            lblSerialNumber.Text = "";
            lblLogProcessors.Text = "";
            lblPhyProcessors.Text = "";
            lblCores.Text = "";
            lblMachineName.Text = "";
            lblMemoryAmount.Text = "";
        }

        private void LoadSystem()
        {
            lblSerialNumber.Text = hd.GetSerial().ToString();
            lblDrives.Text = hd.GetNumberOfDrives().ToString();
            lblPhyProcessors.Text = si.GetNumberOfPhyProcessors().ToString();
            lblLogProcessors.Text = si.GetNumberOfLogProcessors().ToString();
            lblCores.Text = si.GetNumberOfCores().ToString();
            lblMachineName.Text = si.GetMachineName();
            lblMemoryAmount.Text = $"{si.GetMemoryAmount() / 1000000} GB";
            lblCDROM.Text = hd.GetCDROM();
            si.GetNIC(rtbNIC);
            si.GetUpdates(rtbUpdates);
            tm.GetTasks(lstTasks);
        }
        private void frmUtilitiesDisplay_Load(object sender, EventArgs e)
        {
            LoadSystem();
        }

        private void btnKillTask_Click(object sender, EventArgs e)
        {
            tm.EndTask(lstTasks);
        }

        private void btnNewTask_Click(object sender, EventArgs e)
        {
            frmNewTask frmNewTask = new frmNewTask();
            frmNewTask.Show();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtValueName.Text) || string.IsNullOrWhiteSpace(txtValueName.Text))
            {
                MessageBox.Show("Please enter a key name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                rt.ReadKey(txtValueName, txtValueData);
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtValueName.Text) || string.IsNullOrWhiteSpace(txtValueName.Text))
            {
                MessageBox.Show("Please enter a correct key name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (rt.WriteKey(txtValueName, txtValueData))
                {
                    txtValueData.Clear();
                    txtValueName.Clear();

                    MessageBox.Show("The key was written successfully.", "Key written", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("The key was not successfully written.", "Key written", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtValueName.Text) || string.IsNullOrWhiteSpace(txtValueName.Text))
            {
                MessageBox.Show("Please enter a correct key name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (rt.DeleteKey(txtValueName))
                {
                    txtValueData.Clear();
                    txtValueName.Clear();

                    MessageBox.Show("The key was successfully deleted.", "Key written", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("The key was not successfully deleted.", "Key written", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
