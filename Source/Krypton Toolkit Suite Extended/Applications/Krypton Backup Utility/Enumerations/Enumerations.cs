namespace KryptonBackupUtility.Enumerations
{
    public enum DirectoryParsing
    {
        INCLUDESUBDIRECTORIES,
        TOPLEVELONLY
    }

    public enum OperationType
    {
        IDLE,
        ENUMERATINGDIRECTORIES,
        ENUMERATINGFILES,
        COPYING
    }
}