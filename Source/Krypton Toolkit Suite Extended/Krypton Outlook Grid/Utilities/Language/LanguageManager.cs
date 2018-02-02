using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Threading;

namespace KryptonOutlookGrid.Utilities.Language
{
    /// <summary>
    /// This class handles the current localisation
    /// </summary>
    public class LanguageManager
    {
        // Local variable to store a reference to the instance of LanguageManager
        public static LanguageManager languageManager = null;

        public static readonly object myLock = new object();

        public ResourceManager resourceManager;

        private CultureInfo cultureInfo;

        //Used for blocking critical sections on updates
        private object locker = new object();

        private LanguageManager()
        {
            resourceManager = new ResourceManager("KryptonOutlookGrid.Utilities.Language.EnglishStringsUS", Assembly.GetExecutingAssembly());

            cultureInfo = Thread.CurrentThread.CurrentCulture;
        }

        /// <summary>
        /// Gets or sets the P locker.
        /// </summary>
        /// <value>The P locker.</value>
        public object PLocker
        {
            get
            {
                return this.locker;
            }

            set
            {
                this.locker = value;
            }
        }

        /// <summary>
        /// Gets the instance of the singleton.
        /// </summary>
        public static LanguageManager Instance
        {
            get
            {
                if (languageManager == null)
                {
                    lock (myLock)
                    {
                        if (languageManager == null)
                        {
                            languageManager = new LanguageManager();
                        }
                    }
                }

                return languageManager;
            }
        }

        /// <summary>
        /// Get localised string
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        public string GetString(string name)
        {
            return resourceManager.GetString(name, cultureInfo);
        }
    }
}