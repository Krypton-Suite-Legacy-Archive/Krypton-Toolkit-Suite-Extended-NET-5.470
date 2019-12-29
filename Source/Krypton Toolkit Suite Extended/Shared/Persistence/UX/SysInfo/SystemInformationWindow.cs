#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using ComponentFactory.Krypton.Toolkit;
using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Persistence.UX.SysInfo
{
    public partial class SystemInformationWindow : KryptonForm
    {
        #region Variables
        private string[] stringWin32classes = {"Win32_1394Controller",
                                                "Win32_1394ControllerDevice",
                                                "Win32_AccountSID",
                                                "Win32_ActionCheck",
                                                "Win32_ActiveRoute",
                                                "Win32_AllocatedResource",
                                                "Win32_ApplicationCommandLine",
                                                "Win32_ApplicationService",
                                                "Win32_AssociatedBattery",
                                                "Win32_AssociatedProcessorMemory",
                                                "Win32_AutochkSetting",
                                                "Win32_BaseBoard",
                                                "Win32_Battery",
                                                "Win32_Binary",
                                                "Win32_BindImageAction",
                                                "Win32_BIOS",
                                                "Win32_BootConfiguration",
                                                "Win32_Bus"+
                                                "Win32_CacheMemory",
                                                "Win32_CDROMDrive",
                                                "Win32_CheckCheck",
                                                "Win32_CIMLogicalDeviceCIMDataFile",
                                                "Win32_ClassicCOMApplicationClasses",
                                                "Win32_ClassicCOMClass",
                                                "Win32_ClassicCOMClassSetting",
                                                "Win32_ClassicCOMClassSettings",
                                                "Win32_ClassInforAction",
                                                "Win32_ClientApplicationSetting",
                                                "Win32_CodecFile",
                                                "Win32_COMApplicationSettings",
                                                "Win32_COMClassAutoEmulator",
                                                "Win32_ComClassEmulator",
                                                "Win32_CommandLineAccess",
                                                "Win32_ComponentCategory",
                                                "Win32_ComputerSystem",
                                                "Win32_ComputerSystemProcessor",
                                                "Win32_ComputerSystemProduct",
                                                "Win32_ComputerSystemWindowsProductActivationSetting",
                                                "Win32_Condition",
                                                "Win32_ConnectionShare",
                                                "Win32_ControllerHastHub",
                                                "Win32_CreateFolderAction",
                                                "Win32_CurrentProbe",
                                                "Win32_DCOMApplication",
                                                "Win32_DCOMApplicationAccessAllowedSetting",
                                                "Win32_DCOMApplicationLaunchAllowedSetting",
                                                "Win32_DCOMApplicationSetting",
                                                "Win32_DependentService",
                                                "Win32_Desktop",
                                                "Win32_DesktopMonitor",
                                                "Win32_DeviceBus",
                                                "Win32_DeviceMemoryAddress",
                                                "Win32_Directory",
                                                "Win32_DirectorySpecification",
                                                "Win32_DiskDrive",
                                                "Win32_DiskDrivePhysicalMedia",
                                                "Win32_DiskDriveToDiskPartition",
                                                "Win32_DiskPartition",
                                                "Win32_DiskQuota",
                                                "Win32_DisplayConfiguration",
                                                "Win32_DisplayControllerConfiguration",
                                                "Win32_DMAChanner",
                                                "Win32_DriverForDevice",
                                                "Win32_DriverVXD",
                                                "Win32_DuplicateFileAction",
                                                "Win32_Environment",
                                                "Win32_EnvironmentSpecification",
                                                "Win32_ExtensionInfoAction",
                                                "Win32_Fan",
                                                "Win32_FileSpecification",
                                                "Win32_FloppyController",
                                                "Win32_FloppyDrive",
                                                "Win32_FontInfoAction",
                                                "Win32_Group",
                                                "Win32_GroupDomain",
                                                "Win32_GroupUser",
                                                "Win32_HeatPipe",
                                                "Win32_IDEController",
                                                "Win32_IDEControllerDevice",
                                                "Win32_ImplementedCategory",
                                                "Win32_InfraredDevice",
                                                "Win32_IniFileSpecification",
                                                "Win32_InstalledSoftwareElement",
                                                "Win32_IP4PersistedRouteTable",
                                                "Win32_IP4RouteTable",
                                                "Win32_IRQResource",
                                                "Win32_Keyboard",
                                                "Win32_LaunchCondition",
                                                "Win32_LoadOrderGroup",
                                                "Win32_LoadOrderGroupServiceDependencies",
                                                "Win32_LoadOrderGroupServiceMembers",
                                                "Win32_LocalTime",
                                                "Win32_LoggedOnUser",
                                                "Win32_LogicalDisk",
                                                "Win32_LogicalDiskRootDirectory",
                                                "Win32_LogicalDiskToPartition",
                                                "Win32_LogicalFileAccess",
                                                "Win32_LogicalFileAuditing",
                                                "Win32_LogicalFileGroup",
                                                "Win32_LogicalFileOwner",
                                                "Win32_LogicalFileSecuritySetting",
                                                "Win32_LogicalMemoryConfiguration",
                                                "Win32_LogicalProgramGroup",
                                                "Win32_LogicalProgramGroupDirectory",
                                                "Win32_LogicalProgramGroupItem",
                                                "Win32_LogicalProgramGroupItemDataFile",
                                                "Win32_LogicalShareAccess",
                                                "Win32_LogicalShareAuditing",
                                                "Win32_LogicalShareSecuritySetting",
                                                "Win32_LogonSession",
                                                "Win32_LogonSessionMappedDisk",
                                                "Win32_MappedLogicalDisk",
                                                "Win32_MemoryArray",
                                                "Win32_MemoryArrayLocation",
                                                "Win32_MemoryDevice",
                                                "Win32_MemoryDeviceArray",
                                                "Win32_MemoryDeviceLocation",
                                                "Win32_MIMEInfoAction",
                                                "Win32_MotherboardDevice",
                                                "Win32_MoveFileAction",
                                                "Win32_NamedJobObject",
                                                "Win32_NamedJobObjectActgInfo",
                                                "Win32_NamedJobObjectLimit",
                                                "Win32_NamedJobObjectLimitSetting",
                                                "Win32_NamedJobObjectProcess",
                                                "Win32_NamedJobObjectSecLimit",
                                                "Win32_NamedJobObjectSecLimitSetting",
                                                "Win32_NamedJobObjectStatistics",
                                                "Win32_NetworkAdapter",
                                                "Win32_NetworkAdapterConfiguration",
                                                "Win32_NetworkAdapterSetting",
                                                "Win32_NetworkClient",
                                                "Win32_NetworkConnection",
                                                "Win32_NetworkLoginProfile",
                                                "Win32_NetworkProtocol",
                                                "Win32_NTDomain",
                                                "Win32_NTEventlogFile",
                                                "Win32_NTLogEvent",
                                                "Win32_NTLogEventComputer",
                                                "Win32_NTLogEvnetLog",
                                                "Win32_NTLogEventUser",
                                                "Win32_ODBCAttribute",
                                                "Win32_ODBCDataSourceAttribute",
                                                "Win32_ODBCDataSourceSpecification",
                                                "Win32_ODBCDriverAttribute",
                                                "Win32_ODBCDriverSoftwareElement",
                                                "Win32_ODBCDriverSpecification",
                                                "Win32_ODBCSourceAttribute",
                                                "Win32_ODBCTranslatorSpecification",
                                                "Win32_OnBoardDevice",
                                                "Win32_OperatingSystem",
                                                "Win32_OperatingSystemAutochkSetting",
                                                "Win32_OperatingSystemQFE",
                                                "Win32_OSRecoveryConfiguration",
                                                "Win32_PageFile",
                                                "Win32_PageFileElementSetting",
                                                "Win32_PageFileSetting",
                                                "Win32_PageFileUsage",
                                                "Win32_ParallelPort",
                                                "Win32_Patch",
                                                "Win32_PatchFile",
                                                "Win32_PatchPackage",
                                                "Win32_PCMCIAControler",
                                                "Win32_PerfFormattedData_ASP_ActiveServerPages",
                                                "Win32_PerfFormattedData_ASPNET_114322_ASPNETAppsv114322",
                                                "Win32_PerfFormattedData_ASPNET_114322_ASPNETv114322",
                                                "Win32_PerfFormattedData_ASPNET_2040607_ASPNETAppsv2040607",
                                                "Win32_PerfFormattedData_ASPNET_2040607_ASPNETv2040607",
                                                "Win32_PerfFormattedData_ASPNET_ASPNET",
                                                "Win32_PerfFormattedData_ASPNET_ASPNETApplications",
                                                "Win32_PerfFormattedData_aspnet_state_ASPNETStateService",
                                                "Win32_PerfFormattedData_ContentFilter_IndexingServiceFilter",
                                                "Win32_PerfFormattedData_ContentIndex_IndexingService",
                                                "Win32_PerfFormattedData_DTSPipeline_SQLServerDTSPipeline",
                                                "Win32_PerfFormattedData_Fax_FaxServices",
                                                "Win32_PerfFormattedData_InetInfo_InternetInformationServicesGlobal",
                                                "Win32_PerfFormattedData_ISAPISearch_HttpIndexingService",
                                                "Win32_PerfFormattedData_MSDTC_DistributedTransactionCoordinator",
                                                "Win32_PerfFormattedData_NETCLRData_NETCLRData",
                                                "Win32_PerfFormattedData_NETCLRNetworking_NETCLRNetworking",
                                                "Win32_PerfFormattedData_NETDataProviderforOracle_NETCLRData",
                                                "Win32_PerfFormattedData_NETDataProviderforSqlServer_NETDataProviderforSqlServer",
                                                "Win32_PerfFormattedData_NETFramework_NETCLRExceptions",
                                                "Win32_PerfFormattedData_NETFramework_NETCLRInterop",
                                                "Win32_PerfFormattedData_NETFramework_NETCLRJit",
                                                "Win32_PerfFormattedData_NETFramework_NETCLRLoading",
                                                "Win32_PerfFormattedData_NETFramework_NETCLRLocksAndThreads",
                                                "Win32_PerfFormattedData_NETFramework_NETCLRMemory",
                                                "Win32_PerfFormattedData_NETFramework_NETCLRRemoting",
                                                "Win32_PerfFormattedData_NETFramework_NETCLRSecurity",
                                                "Win32_PerfFormattedData_NTFSDRV_ControladordealmacenamientoNTFSdeSMTP",
                                                "Win32_PerfFormattedData_Outlook_Outlook",
                                                "Win32_PerfFormattedData_PerfDisk_LogicalDisk",
                                                "Win32_PerfFormattedData_PerfDisk_PhysicalDisk",
                                                "Win32_PerfFormattedData_PerfNet_Browser",
                                                "Win32_PerfFormattedData_PerfNet_Redirector",
                                                "Win32_PerfFormattedData_PerfNet_Server",
                                                "Win32_PerfFormattedData_PerfNet_ServerWorkQueues",
                                                "Win32_PerfFormattedData_PerfOS_Cache",
                                                "Win32_PerfFormattedData_PerfOS_Memory",
                                                "Win32_PerfFormattedData_PerfOS_Objects",
                                                "Win32_PerfFormattedData_PerfOS_PagingFile",
                                                "Win32_PerfFormattedData_PerfOS_Processor",
                                                "Win32_PerfFormattedData_PerfOS_System",
                                                "Win32_PerfFormattedData_PerfProc_FullImage_Costly",
                                                "Win32_PerfFormattedData_PerfProc_Image_Costly",
                                                "Win32_PerfFormattedData_PerfProc_JobObject",
                                                "Win32_PerfFormattedData_PerfProc_JobObjectDetails",
                                                "Win32_PerfFormattedData_PerfProc_Process",
                                                "Win32_PerfFormattedData_PerfProc_ProcessAddressSpace_Costly",
                                                "Win32_PerfFormattedData_PerfProc_Thread",
                                                "Win32_PerfFormattedData_PerfProc_ThreadDetails_Costly",
                                                "Win32_PerfFormattedData_RemoteAccess_RASPort",
                                                "Win32_PerfFormattedData_RemoteAccess_RASTotal",
                                                "Win32_PerfFormattedData_RSVP_RSVPInterfaces",
                                                "Win32_PerfFormattedData_RSVP_RSVPService",
                                                "Win32_PerfFormattedData_Spooler_PrintQueue",
                                                "Win32_PerfFormattedData_TapiSrv_Telephony",
                                                "Win32_PerfFormattedData_Tcpip_ICMP",
                                                "Win32_PerfFormattedData_Tcpip_IP",
                                                "Win32_PerfFormattedData_Tcpip_NBTConnection",
                                                "Win32_PerfFormattedData_Tcpip_NetworkInterface",
                                                "Win32_PerfFormattedData_Tcpip_TCP",
                                                "Win32_PerfFormattedData_Tcpip_UDP",
                                                "Win32_PerfFormattedData_TermService_TerminalServices",
                                                "Win32_PerfFormattedData_TermService_TerminalServicesSession",
                                                "Win32_PerfFormattedData_W3SVC_WebService",
                                                "Win32_PerfRawData_ASP_ActiveServerPages",
                                                "Win32_PerfRawData_ASPNET_114322_ASPNETAppsv114322",
                                                "Win32_PerfRawData_ASPNET_114322_ASPNETv114322",
                                                "Win32_PerfRawData_ASPNET_2040607_ASPNETAppsv2040607",
                                                "Win32_PerfRawData_ASPNET_2040607_ASPNETv2040607",
                                                "Win32_PerfRawData_ASPNET_ASPNET",
                                                "Win32_PerfRawData_ASPNET_ASPNETApplications",
                                                "Win32_PerfRawData_aspnet_state_ASPNETStateService",
                                                "Win32_PerfRawData_ContentFilter_IndexingServiceFilter",
                                                "Win32_PerfRawData_ContentIndex_IndexingService",
                                                "Win32_PerfRawData_DTSPipeline_SQLServerDTSPipeline",
                                                "Win32_PerfRawData_Fax_FaxServices",
                                                "Win32_PerfRawData_InetInfo_InternetInformationServicesGlobal",
                                                "Win32_PerfRawData_ISAPISearch_HttpIndexingService",
                                                "Win32_PerfRawData_MSDTC_DistributedTransactionCoordinator",
                                                "Win32_PerfRawData_NETCLRData_NETCLRData",
                                                "Win32_PerfRawData_NETCLRNetworking_NETCLRNetworking",
                                                "Win32_PerfRawData_NETDataProviderforOracle_NETCLRData",
                                                "Win32_PerfRawData_NETDataProviderforSqlServer_NETDataProviderforSqlServer",
                                                "Win32_PerfRawData_NETFramework_NETCLRExceptions",
                                                "Win32_PerfRawData_NETFramework_NETCLRInterop",
                                                "Win32_PerfRawData_NETFramework_NETCLRJit",
                                                "Win32_PerfRawData_NETFramework_NETCLRLoading",
                                                "Win32_PerfRawData_NETFramework_NETCLRLocksAndThreads",
                                                "Win32_PerfRawData_NETFramework_NETCLRMemory",
                                                "Win32_PerfRawData_NETFramework_NETCLRRemoting",
                                                "Win32_PerfRawData_NETFramework_NETCLRSecurity",
                                                "Win32_PerfRawData_NTFSDRV_ControladordealmacenamientoNTFSdeSMTP",
                                                "Win32_PerfRawData_Outlook_Outlook",
                                                "Win32_PerfRawData_PerfDisk_LogicalDisk",
                                                "Win32_PerfRawData_PerfDisk_PhysicalDisk",
                                                "Win32_PerfRawData_PerfNet_Browser",
                                                "Win32_PerfRawData_PerfNet_Redirector",
                                                "Win32_PerfRawData_PerfNet_Server",
                                                "Win32_PerfRawData_PerfNet_ServerWorkQueues",
                                                "Win32_PerfRawData_PerfOS_Cache",
                                                "Win32_PerfRawData_PerfOS_Memory",
                                                "Win32_PerfRawData_PerfOS_Objects",
                                                "Win32_PerfRawData_PerfOS_PagingFile",
                                                "Win32_PerfRawData_PerfOS_Processor",
                                                "Win32_PerfRawData_PerfOS_System",
                                                "Win32_PerfRawData_PerfProc_FullImage_Costly",
                                                "Win32_PerfRawData_PerfProc_Image_Costly",
                                                "Win32_PerfRawData_PerfProc_JobObject",
                                                "Win32_PerfRawData_PerfProc_JobObjectDetails",
                                                "Win32_PerfRawData_PerfProc_Process",
                                                "Win32_PerfRawData_PerfProc_ProcessAddressSpace_Costly",
                                                "Win32_PerfRawData_PerfProc_Thread",
                                                "Win32_PerfRawData_PerfProc_ThreadDetails_Costly",
                                                "Win32_PerfRawData_RemoteAccess_RASPort",
                                                "Win32_PerfRawData_RemoteAccess_RASTotal",
                                                "Win32_PerfRawData_RSVP_RSVPInterfaces",
                                                "Win32_PerfRawData_RSVP_RSVPService",
                                                "Win32_PerfRawData_Spooler_PrintQueue",
                                                "Win32_PerfRawData_TapiSrv_Telephony",
                                                "Win32_PerfRawData_Tcpip_ICMP",
                                                "Win32_PerfRawData_Tcpip_IP",
                                                "Win32_PerfRawData_Tcpip_NBTConnection",
                                                "Win32_PerfRawData_Tcpip_NetworkInterface",
                                                "Win32_PerfRawData_Tcpip_TCP",
                                                "Win32_PerfRawData_Tcpip_UDP",
                                                "Win32_PerfRawData_TermService_TerminalServices",
                                                "Win32_PerfRawData_TermService_TerminalServicesSession",
                                                "Win32_PerfRawData_W3SVC_WebService",
                                                "Win32_PhysicalMedia",
                                                "Win32_PhysicalMemory",
                                                "Win32_PhysicalMemoryArray",
                                                "Win32_PhysicalMemoryLocation",
                                                "Win32_PingStatus",
                                                "Win32_PNPAllocatedResource",
                                                "Win32_PnPDevice",
                                                "Win32_PnPEntity",
                                                "Win32_PnPSignedDriver",
                                                "Win32_PnPSignedDriverCIMDataFile",
                                                "Win32_PointingDevice",
                                                "Win32_PortableBattery",
                                                "Win32_PortConnector",
                                                "Win32_PortResource",
                                                "Win32_POTSModem",
                                                "Win32_POTSModemToSerialPort",
                                                "Win32_Printer",
                                                "Win32_PrinterConfiguration",
                                                "Win32_PrinterController",
                                                "Win32_PrinterDriver",
                                                "Win32_PrinterDriverDll",
                                                "Win32_PrinterSetting",
                                                "Win32_PrinterShare",
                                                "Win32_PrintJob",
                                                "Win32_Process",
                                                "Win32_Processor",
                                                "Win32_Product",
                                                "Win32_ProductCheck",
                                                "Win32_ProductResource",
                                                "Win32_ProductSoftwareFeatures",
                                                "Win32_ProgIDSpecification",
                                                "Win32_ProgramGroup",
                                                "Win32_ProgramGroupContents",
                                                "Win32_Property",
                                                "Win32_ProtocolBinding",
                                                "Win32_Proxy",
                                                "Win32_PublishComponentAction",
                                                "Win32_QuickFixEngineering",
                                                "Win32_QuotaSetting",
                                                "Win32_Refrigeration",
                                                "Win32_Registry",
                                                "Win32_RegistryAction",
                                                "Win32_RemoveFileAction",
                                                "Win32_RemoveIniAction",
                                                "Win32_ReserveCost",
                                                "Win32_ScheduledJob",
                                                "Win32_SCSIController",
                                                "Win32_SCSIControllerDevice",
                                                "Win32_SecuritySettingOfLogicalFile",
                                                "Win32_SecuritySettingOfLogicalShare",
                                                "Win32_SelfRegModuleAction",
                                                "Win32_SerialPort",
                                                "Win32_SerialPortConfiguration",
                                                "Win32_SerialPortSetting",
                                                "Win32_ServerConnection",
                                                "Win32_ServerSession",
                                                "Win32_Service",
                                                "Win32_ServiceControl",
                                                "Win32_ServiceSpecification",
                                                "Win32_ServiceSpecificationService",
                                                "Win32_SessionConnection",
                                                "Win32_SessionProcess",
                                                "Win32_Share",
                                                "Win32_ShareToDirectory",
                                                "Win32_ShortcutAction",
                                                "Win32_ShortcutFile",
                                                "Win32_ShortcutSAP",
                                                "Win32_SID",
                                                "Win32_SoftwareElement",
                                                "Win32_SoftwareElementAction",
                                                "Win32_SoftwareElementCheck",
                                                "Win32_SoftwareElementCondition",
                                                "Win32_SoftwareElementResource",
                                                "Win32_SoftwareFeature",
                                                "Win32_SoftwareFeatureAction",
                                                "Win32_SoftwareFeatureCheck",
                                                "Win32_SoftwareFeatureParent",
                                                "Win32_SoftwareFeatureSoftwareElements",
                                                "Win32_SoundDevice",
                                                "Win32_StartupCommand",
                                                "Win32_SubDirectory",
                                                "Win32_SystemAccount",
                                                "Win32_SystemBIOS",
                                                "Win32_SystemBootConfiguration",
                                                "Win32_SystemDesktop",
                                                "Win32_SystemDevices",
                                                "Win32_SystemDriver",
                                                "Win32_SystemDriverPNPEntity",
                                                "Win32_SystemEnclosure",
                                                "Win32_SystemLoadOrderGroups",
                                                "Win32_SystemLogicalMemoryConfiguration",
                                                "Win32_SystemNetworkConnections",
                                                "Win32_SystemOperatingSystem",
                                                "Win32_SystemPartitions",
                                                "Win32_SystemProcesses",
                                                "Win32_SystemProgramGroups",
                                                "Win32_SystemResources",
                                                "Win32_SystemServices",
                                                "Win32_SystemSlot",
                                                "Win32_SystemSystemDriver",
                                                "Win32_SystemTimeZone",
                                                "Win32_SystemUsers",
                                                "Win32_TapeDrive",
                                                "Win32_TCPIPPrinterPort",
                                                "Win32_TemperatureProbe",
                                                "Win32_Terminal",
                                                "Win32_TerminalService",
                                                "Win32_TerminalServiceSetting",
                                                "Win32_TerminalServiceToSetting",
                                                "Win32_TerminalTerminalSetting",
                                                "Win32_Thread",
                                                "Win32_TimeZone",
                                                "Win32_TSAccount",
                                                "Win32_TSClientSetting",
                                                "Win32_TSEnvironmentSetting",
                                                "Win32_TSGeneralSetting",
                                                "Win32_TSLogonSetting",
                                                "Win32_TSNetworkAdapterListSetting",
                                                "Win32_TSNetworkAdapterSetting",
                                                "Win32_TSPermissionsSetting",
                                                "Win32_TSRemoteControlSetting",
                                                "Win32_TSSessionDirectory",
                                                "Win32_TSSessionDirectorySetting",
                                                "Win32_TSSessionSetting",
                                                "Win32_TypeLibraryAction",
                                                "Win32_UninterruptiblePowerSupply",
                                                "Win32_USBController",
                                                "Win32_USBControllerDevice",
                                                "Win32_USBHub",
                                                "Win32_UserAccount",
                                                "Win32_UserDesktop",
                                                "Win32_UserInDomain",
                                                "Win32_UTCTime",
                                                "Win32_VideoController",
                                                "Win32_VideoSettings",
                                                "Win32_VoltageProbe",
                                                "Win32_VolumeQuotaSetting",
                                                "Win32_WindowsProductActivation",
                                                "Win32_WMIElementSetting",
                                                "Win32_WMISetting"
                                                };

        private Control _targetControl = null;
        #endregion

        #region Properties
        public Control TargetControl { get { return _targetControl; } set { _targetControl = value; } }
        #endregion

        public SystemInformationWindow()
        {
            InitializeComponent();
        }

        private void kbtnClose_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void SystemInformationWindow_Load(object sender, EventArgs e)
        {
            foreach (string win32Class in stringWin32classes)
            {
                kcmbClass.Items.Add(win32Class);

                KryptonCheckBox classCheckBox = new KryptonCheckBox();

                classCheckBox.StateCommon.ShortText.Font = new Font("Segoe UI", 11.25f, FontStyle.Regular, GraphicsUnit.Point);

                classCheckBox.Text = win32Class;

                klstMoreInformation.Items.Add(classCheckBox);
            }

            GetSystemDetails();
        }

        private string GetSystemDetails()
        {
            StringBuilder sb = new StringBuilder();

            try
            {
                sb.AppendFormat($"Operating System: { Environment.OSVersion }\n");

                if (Environment.Is64BitOperatingSystem)
                {
                    sb.AppendFormat("\t\t x64 (64-bit) Operating System\n");
                }
                else
                {
                    sb.AppendFormat("\t\t x86 (32-bit) Operating System\n");
                }

                sb.AppendFormat($"System Directory: { Environment.SystemDirectory }\n");

                sb.AppendFormat($"Processor Count: { Environment.ProcessorCount }\n");

                sb.AppendFormat($"User Domain Name: { Environment.UserDomainName }\n");

                sb.AppendFormat($"User Name: { Environment.UserName }\n");

                sb.AppendFormat("Logical Drives:\n");

                foreach (DriveInfo driveInfo in DriveInfo.GetDrives())
                {
                    sb.AppendFormat($"\t Drive: { driveInfo.Name }\n\t\t Volume Label: { driveInfo.VolumeLabel }\n\t\t Drive Type: { driveInfo.DriveType }\n\t\t Drive Format: { driveInfo.DriveFormat }\n\t\t Total Size: { driveInfo.TotalSize }\n\t\t Available Free Space: { driveInfo.AvailableFreeSpace }\n");
                }

                sb.AppendFormat($"System Page Size: { Environment.SystemPageSize }\n");

                sb.AppendFormat($"Version: { Environment.Version }");
            }
            catch (Exception error)
            {
                KryptonMessageBox.Show($"An error has occurred: { error.Message }", "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return sb.ToString();
        }

        private string DeviceInformation(string stringIn)
        {
            StringBuilder StringBuilder1 = new StringBuilder(string.Empty);
            try
            {
                //ManagementClass ManagementClass1 = new ManagementClass(stringIn);
                ////Create a ManagementObjectCollection to loop through
                //ManagementObjectCollection ManagemenobjCol = ManagementClass1.GetInstances();
                ////Get the properties in the class
                //PropertyDataCollection properties = ManagementClass1.Properties;
                //foreach (ManagementObject obj in ManagemenobjCol)
                //{
                //    foreach (PropertyData property in properties)
                //    {
                //        try
                //        {
                //            StringBuilder1.AppendLine(property.Name + ":  " + obj.Properties[property.Name].Value.ToString());
                //        }
                //        catch
                //        {
                //            //Add codes to manage more informations
                //        }
                //    }
                //    StringBuilder1.AppendLine();
                //}
            }
            catch
            {
                //Win 32 Classes Which are not defined on client system
            }
            return StringBuilder1.ToString();
        }
    }
}