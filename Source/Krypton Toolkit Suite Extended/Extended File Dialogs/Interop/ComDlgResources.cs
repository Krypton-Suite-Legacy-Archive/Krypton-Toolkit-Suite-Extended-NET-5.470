using ExtendedFileDialogs.Enumerations;

namespace ExtendedFileDialogs.Interop
{
    public static class ComDlgResources
    {
        #region Variables
        private static Win32Resources _resources = new Win32Resources("comdlg32.dll");
        #endregion

        #region Methods
        public static string LoadString(ComDlgResourceId id)
        {
            return _resources.LoadString((uint)id);
        }

        public static string FormatString(ComDlgResourceId id, params string[] args)
        {
            return _resources.FormatString((uint)id, args);
        }
        #endregion
    }
}