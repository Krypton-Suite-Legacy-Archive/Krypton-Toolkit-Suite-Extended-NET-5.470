using Microsoft.WindowsAPICodePack.Taskbar;

namespace APICodePackExtended
{
    public class WindowsAPICodePackModel
    {
        #region Constructors
        /// <summary>
        /// Ini
        /// </summary>
        public WindowsAPICodePackModel()
        {

        }
        #endregion

        #region Methods        
        /// <summary>
        /// Updates the taskbar progressbar value.
        /// </summary>
        /// <param name="state">The state.</param>
        /// <param name="currentValue">The current value.</param>
        /// <param name="maximumValue">The maximum value.</param>
        public static void UpdateTaskbarProgressbarValue(TaskbarProgressBarState state, int currentValue, int maximumValue = 100)
        {
            if (TaskbarManager.IsPlatformSupported)
            {
                TaskbarManager.Instance.SetProgressState(state);

                TaskbarManager.Instance.SetProgressValue(currentValue, maximumValue);
            }
        }
        #endregion
    }
}