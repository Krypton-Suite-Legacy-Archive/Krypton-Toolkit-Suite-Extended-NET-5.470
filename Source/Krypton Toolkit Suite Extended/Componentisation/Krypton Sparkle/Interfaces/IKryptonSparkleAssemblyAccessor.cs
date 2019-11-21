namespace KryptonSparkle.Interfaces
{
    internal interface IKryptonSparkleAssemblyAccessor
    {
        string AssemblyCompany { get; }

        string AssemblyCopyright { get; }

        string AssemblyDescription { get; }

        string AssemblyProduct { get; }

        string AssemblyTitle { get; }

        string AssemblyVersion { get; }

        string AssemblyBuild { get; }
    }
}