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

namespace Utilities
{
    public class HardDrive
    {
        string serialNo;
        public string GetSerial()
        {
            ManagementObjectSearcher moSearcher = new
                ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");

            foreach (ManagementObject wmi_HD in moSearcher.Get())
            {
                serialNo = wmi_HD["SerialNumber"].ToString();
            }

            return serialNo;
        }

        public int GetNumberOfDrives()
        {
            return DriveInfo.GetDrives().Length;
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

        public class TaskManager
        {
            Process[] proc;
            public void GetTasks(ListBox lst)
            {
                proc = Process.GetProcesses();
                lst.Items.Clear();
                foreach (Process p in proc)
                    lst.Items.Add(p.ProcessName);

            }

            public void NewTask()
            {

            }

            public void EndTask()
            {

            }
        }
    }
}

