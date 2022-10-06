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
    }
}

