using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Management.Instrumentation;
using System.Reflection.Emit;
using System.Collections;
using System.IO;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using WUApiLib;
using System.Diagnostics;
using Microsoft.Win32;

namespace Utilities
{
    public class Drives
    {
        string hSerialNo;
        string cSerialNo;

        public string GetSerial()
        {
            ManagementObjectSearcher moSearcher = new
                ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");

            foreach (ManagementObject wmi_HD in moSearcher.Get())
            {
                hSerialNo = wmi_HD["SerialNumber"].ToString();
            }

            return hSerialNo;
        }

        public int GetNumberOfDrives()
        {
            return DriveInfo.GetDrives().Length;
        }

        public string GetCDROM()
        {
            ManagementObjectSearcher moSearcher = new
                ManagementObjectSearcher("SELECT * FROM Win32_CDROMDrive");

            foreach (ManagementObject wmi_CD in moSearcher.Get())
            {
                cSerialNo = wmi_CD["SerialNumber"].ToString();
            }

            return cSerialNo;
        }
    }

    public class SystemInfo
    {
        int coreCount;
        public string GetMachineName()
        {
            return Environment.MachineName;
        }

        public UInt32 GetNumberOfPhyProcessors()
        {
            ManagementObjectSearcher moSearcher = new
            ManagementObjectSearcher("SELECT * FROM Win32_ComputerSystem");

            foreach (ManagementObject obj in moSearcher.Get())
            {
                return (UInt32)obj["NumberOfProcessors"];
            }

            return 0;

        }

        public int GetNumberOfLogProcessors()
        {
            return Environment.ProcessorCount;
        }

        public int GetNumberOfCores()
        {
            coreCount = 0;

            ManagementObjectSearcher moSearcher = new
            ManagementObjectSearcher("SELECT * FROM Win32_Processor");

            foreach (ManagementObject obj in moSearcher.Get())
            {
                coreCount += int.Parse(obj["NumberOfCores"].ToString());
            }

            return coreCount;
        }

        public int GetMemoryAmount()
        {
            ManagementObjectSearcher moSearcher = new
            ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");

            foreach (ManagementObject obj in moSearcher.Get())
            {
                return int.Parse(obj["TotalVisibleMemorySize"].ToString());
            }

            return 0;
        }

        public string GetNIC(RichTextBox rtb)
        {
            NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();

            foreach (NetworkInterface adapter in interfaces)
            {
                rtb.AppendText(Environment.NewLine + adapter.Name);
                rtb.AppendText(Environment.NewLine + "  Description .............................  " + adapter.Description);
                rtb.AppendText(Environment.NewLine + "  Interface type .......................... " + adapter.NetworkInterfaceType);
                rtb.AppendText(Environment.NewLine + "  Operational status ...................  " + adapter.OperationalStatus);
                rtb.AppendText(Environment.NewLine + "  MAC address ..........................  " + adapter.GetPhysicalAddress());
                rtb.AppendText(Environment.NewLine);
            }

            return null;
        }

        public string GetUpdates(RichTextBox rtb)
        {
            var updateSession = new UpdateSession();
            var updateSearcher = updateSession.CreateUpdateSearcher();
            var count = updateSearcher.GetTotalHistoryCount();
            var history = updateSearcher.QueryHistory(0, count);

            for (int i = 0; i < count; ++i)
            {
                rtb.AppendText(Environment.NewLine + history[i].Title);
            }

            return null;
        }
    }
    public class TaskManager
    {
        Process[] proc;
        public void GetTasks(ListBox lst)
        {
            lst.Sorted = true;
            proc = Process.GetProcesses();
            lst.Items.Clear();
            foreach (Process p in proc)
                lst.Items.Add(p.ProcessName);
        }

        public void NewTask(TextBox txt)
        {
            if (!string.IsNullOrEmpty(txt.Text))
            {
                try
                {
                    Process proc = new Process();
                    proc.StartInfo.FileName = txt.Text;
                    proc.Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void EndTask(ListBox lst)
        {
            try
            {
                proc[lst.SelectedIndex].Kill();
                lst.Items.Clear();
                GetTasks(lst);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    public class RegTools
    {
        RegistryKey creatingKey = Registry.CurrentUser.CreateSubKey(@"C_OwnKeys", true);
        RegistryKey openingKey = Registry.CurrentUser.OpenSubKey(@"C_OwnKeys", true);

        public void ReadKey(TextBox txtName, TextBox txtDescript)
        {
            if (openingKey.GetValue(txtName.Text) == null)
            {
                MessageBox.Show("The key does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtDescript.Text = openingKey.GetValue(txtName.Text).ToString();
            }
        }

        public bool WriteKey(TextBox txtName, TextBox txtDescript)
        {

            if (openingKey.GetValue(txtName.Text) != null)
            {
                DialogResult result = MessageBox.Show("This key already exists. Do you want to edit it?", "Edit key", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    creatingKey.SetValue(txtName.Text, txtDescript.Text);

                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                creatingKey.SetValue(txtName.Text, txtDescript.Text);
                return true;
            }

        }

        public bool DeleteKey(TextBox txtName)
        {
            if (openingKey.GetValue(txtName.Text) == null)
            {
                MessageBox.Show("The key does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                DialogResult result = MessageBox.Show("Do you want to delete this key?", "Delete key", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    openingKey.DeleteValue(txtName.Text, true);
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}

