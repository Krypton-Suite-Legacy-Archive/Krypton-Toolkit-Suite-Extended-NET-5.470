namespace PaletteExplorer.Enumerations
{
    public enum ColourDetailsType
    {
        ARGB = 0,
        RGB = 1,
        REALNAME = 2
    }

    public enum ColourSettingsType
    {
        ALLCOLOURSETTINGS = 0,
        BASICCOLOURSETTINGS = 1,
        CUSTOMCOLOURSETTINGS = 2,
        CUSTOMTEXTCOLOURSETTINGS = 3,
        LINKTEXTCOLOURSETTINGS = 4,
        MISCELLANEOUSCOLOURSETTINGS = 5,
        STANDARDCONTROLTEXTCOLOURSETTINGS = 6,
        TEXTCOLOURSETTINGS = 7
    }

    public enum ColourChannelType
    {
        ALPHACHANNEL = 0,
        REDCHANNEL = 1,
        GREENCHANNEL = 2,
        BLUECHANNEL = 3
    }

    public enum ViewLayoutType
    {
        CUSTOMCOLOURVIEW = 0,
        CUSTOMTEXTCOLOURVIEW = 1,
        NORMALVIEW = 2,
        NOCUSTOMCOLOURS = 3
    }
}