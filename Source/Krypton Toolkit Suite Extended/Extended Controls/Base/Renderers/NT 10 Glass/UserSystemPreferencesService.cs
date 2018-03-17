using Microsoft.Win32;

namespace ExtendedControls.Base.Renderers.NT10Glass
{
    /// <summary>
    /// 
    /// </summary>
    public static class UserSystemPreferencesService
    {
        /// <summary>
        /// 
        /// </summary>
        public static bool IsTransparencyEnabled
        {
            get
            {
                using (RegistryKey baseKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
                {
                    return (int)baseKey.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Themes\Personalize").GetValue("EnableTransparency", 0) > 0;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool UseAccentColor
        {
            get
            {
                using (RegistryKey baseKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
                {
                    return (int)baseKey.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Themes\Personalize").GetValue("ColorPrevalence", 0) > 0;
                }
            }
        }
    }
}