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
        HardDrive hd = new HardDrive();
        SystemInfo si = new SystemInfo();
        TaskManager tm = new TaskManager();

        public frmUtilitiesDisplay()
        {
            InitializeComponent();
            grpSystem.Focus();
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


    }
}
