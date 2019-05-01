#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

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