using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Persistence.Classes.IO
{
    public class Helpers
    {
        #region Methods
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static string GetCurrentMethod()
        {
            var stackTrace = new StackTrace();

            var stackFrame = stackTrace.GetFrame(1);

            return stackFrame.GetMethod().Name;
        }
        #endregion
    }
}