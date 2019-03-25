namespace ExtendedControls.Base.Enumerations
{
    public enum BlinkState
    {
        NormalBlink = 0,
        SoftBlink = 1
    }

    public enum ColourComponent
    {
        HUE,
        SATURATION,
        BRIGHTESS,
        RED,
        GREEN,
        BLUE
    }

    public enum SupportedExplorerTypes
    {
        FILE,
        FOLDER
    }

    public enum DevelopmentState
    {
        PREALPHA,
        ALPHA,
        BETA,
        RTM,
        CURRENT,
        EOL
    }

    public enum PaletteFileEditorStatusIndicator
    {
        CREATENEWFILE,
        CHANGEZOOMLEVEL,
        READY,
        OPENFILE,
        SAVEFILE
    }
}