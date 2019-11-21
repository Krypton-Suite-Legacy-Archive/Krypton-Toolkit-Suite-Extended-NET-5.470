using KryptonSparkle.Interfaces;

namespace KryptonSparkle.Classes
{
    /// <summary>
    /// An assembly accessor
    /// </summary>
    public class KryptonSparkleAssemblyAccessor : IKryptonSparkleAssemblyAccessor
    {
        readonly IKryptonSparkleAssemblyAccessor _internalAccessor;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="assemblyName">the assembly name</param>
        /// <param name="isReflectionAccesorUsed"><c>true</c> if reflection is used to access the attributes.</param>
        public KryptonSparkleAssemblyAccessor(string assemblyName, bool isReflectionAccesorUsed)
        {
            if (isReflectionAccesorUsed)
                _internalAccessor = new KryptonSparkleAssemblyReflectionAccessor(assemblyName);
            else
                _internalAccessor = new KryptonSparkleAssemblyDiagnosticsAccessor(assemblyName);
        }

        #region INetSparkleAssemblyAccessor Members

        /// <summary>
        /// Gets the company
        /// </summary>
        public string AssemblyCompany
        {
            get { return _internalAccessor.AssemblyCompany; }
        }

        /// <summary>
        /// Gets the copyright
        /// </summary>
        public string AssemblyCopyright
        {
            get { return _internalAccessor.AssemblyCopyright; }
        }

        /// <summary>
        /// Gets the description
        /// </summary>
        public string AssemblyDescription
        {
            get { return _internalAccessor.AssemblyDescription; }
        }

        /// <summary>
        /// Gets the product
        /// </summary>
        public string AssemblyProduct
        {
            get { return _internalAccessor.AssemblyProduct; }
        }

        /// <summary>
        /// Gets the title
        /// </summary>
        public string AssemblyTitle
        {
            get { return _internalAccessor.AssemblyTitle; }
        }

        /// <summary>
        /// Gets the version
        /// </summary>
        public string AssemblyVersion
        {
            get { return _internalAccessor.AssemblyVersion; }
        }

        public string AssemblyBuild { get => _internalAccessor.AssemblyBuild; }
        #endregion
    }
}