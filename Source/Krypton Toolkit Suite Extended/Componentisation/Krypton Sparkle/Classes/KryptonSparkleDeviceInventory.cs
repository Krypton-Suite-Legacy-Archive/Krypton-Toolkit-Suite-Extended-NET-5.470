using System;
using System.Management;
using System.Runtime.InteropServices;
using System.Threading;

namespace KryptonSparkle.Classes
{
    internal class KryptonSparkleDeviceInventory
    {
        public Boolean x64System { get; set; }
        public uint ProcessorSpeed { get; set; }
        public Int64 MemorySize { get; set; }
        public string OsVersion { get; set; }
        public int CPUCount { get; set; }

        private readonly KryptonSparkleConfiguration _config;

        public KryptonSparkleDeviceInventory(KryptonSparkleConfiguration config)
        {
            _config = config;
        }

        public void CollectInventory()
        {
            // x64
            CollectProcessorBitnes();

            // cpu speed
            CollectCPUSpeed();

            // cpu count
            CollectCPUCount();

            // ram size
            CollectRamSize();

            // windows
            CollectWindowsVersion();
        }

        public String BuildRequestUrl(String baseRequestUrl)
        {
            String retValue = baseRequestUrl;

            // x64 
            retValue += "cpu64bit=" + (x64System ? "1" : "0") + "&";

            // cpu speed
            retValue += "cpuFreqMHz=" + ProcessorSpeed + "&";

            // ram size
            retValue += "ramMB=" + MemorySize + "&";

            // Application name (as indicated by CFBundleName)
            retValue += "appName=" + _config.ApplicationName + "&";

            // Application version (as indicated by CFBundleVersion)
            retValue += "appVersion=" + _config.InstalledVersion + "&";

            // User’s preferred language
            retValue += "lang=" + Thread.CurrentThread.CurrentUICulture.ToString() + "&";

            // Windows version
            retValue += "osVersion=" + OsVersion + "&";

            // CPU type/subtype (see mach/machine.h for decoder information on this data)
            // ### TODO: cputype, cpusubtype ###

            // Mac model
            // ### TODO: model ###

            // Number of CPUs (or CPU cores, in the case of something like a Core Duo)
            // ### TODO: ncpu ###
            retValue += "ncpu=" + CPUCount + "&";

            // sanitize url
            retValue = retValue.TrimEnd('&');

            // go ahead
            return retValue;
        }

        private void CollectWindowsVersion()
        {
            OperatingSystem osInfo = Environment.OSVersion;
            OsVersion = string.Format("{0}.{1}.{2}.{3}", osInfo.Version.Major, osInfo.Version.Minor, osInfo.Version.Build, osInfo.Version.Revision);
        }

        private void CollectProcessorBitnes()
        {
            x64System = Marshal.SizeOf(typeof(IntPtr)) == 8;
        }

        private void CollectCPUCount()
        {
            CPUCount = Environment.ProcessorCount;
        }

        private void CollectCPUSpeed()
        {
            ManagementObject Mo = new ManagementObject("Win32_Processor.DeviceID='CPU0'");
            ProcessorSpeed = (uint)(Mo["CurrentClockSpeed"]);
            Mo.Dispose();
        }

        private void CollectRamSize()
        {
            MemorySize = 0;

            // RAM size
            ManagementScope oMs = new ManagementScope();
            ObjectQuery oQuery = new ObjectQuery("SELECT Capacity FROM Win32_PhysicalMemory");
            ManagementObjectSearcher oSearcher = new ManagementObjectSearcher(oMs, oQuery);
            ManagementObjectCollection oCollection = oSearcher.Get();

            // In case more than one Memory sticks are installed
            foreach (ManagementObject mobj in oCollection)
            {
                Int64 mCap = Convert.ToInt64(mobj["Capacity"]);
                MemorySize += mCap;
            }

            MemorySize = (MemorySize / 1024) / 1024;
        }
    }
}