using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Windows.Threading;
using System.Management;

namespace _7DaysServerManager
{
    public partial class Server_Panel_Form : Form
    {
        // Create A New Dispatcher Timer To Keep The UI From Freezing And Update The CPU/RAM Meters
        DispatcherTimer Server_Monitoring_Timer = new DispatcherTimer();

        public void Server_Monitoring()
        {

            Server_Monitoring_Timer.Tick += Server_Monitoring_Timer_Tick; // Don't Freeze The UI
            Server_Monitoring_Timer.Interval = new TimeSpan(0, 0, 0, 0, 1024);
            Server_Monitoring_Timer.IsEnabled = true;
        }

        // Start Performance Counters
        public PerformanceCounter cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
        public PerformanceCounter diskCounter = new PerformanceCounter("PhysicalDisk", "% Disk Time", "_Total");

        public Int32 CPU_Usage_Percent = 0;
        public Int32 DISK_Usage_Percent = 0;

        public void Server_Monitoring_Timer_Tick(System.Object sender, System.EventArgs e)
        {           
            //Update CPU Meter From Perf Counter
            CPU_Usage_Percent = Convert.ToInt32(cpuCounter.NextValue());
            CPU_Gauge.Value = CPU_Usage_Percent;
            //Echo_debug("CPU Percentage: " + CPU_Usage_Percent);

            //Update RAM Meter From WMI
            var wmiObject = new ManagementObjectSearcher("select * from Win32_OperatingSystem");

            var memoryValues = wmiObject.Get().Cast<ManagementObject>().Select(mo => new {
                FreePhysicalMemory = Double.Parse(mo["FreePhysicalMemory"].ToString()),
                TotalVisibleMemorySize = Double.Parse(mo["TotalVisibleMemorySize"].ToString())
            }).FirstOrDefault();

            if (memoryValues != null)
            {
                var ramPercent = ((memoryValues.TotalVisibleMemorySize - memoryValues.FreePhysicalMemory) / memoryValues.TotalVisibleMemorySize) * 100;
                RAM_Gauge.Value = Convert.ToInt32(ramPercent);
                //Echo_debug("RAM Percentage: " + ramPercent);
            }

            // Update DISK Meter From Somewhere?????
            DISK_Usage_Percent = Convert.ToInt32(diskCounter.NextValue());
            DISK_Gauge.Value = DISK_Usage_Percent;
            //Echo_debug("DISK Percentage: " + DISK_Usage_Percent);
        }

    }
}
