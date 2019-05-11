#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using ComponentFactory.Krypton.Toolkit;
using ExtendedControls.Base.Code.Security;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.Controls
{
    public class PasswordStrengthControl : UserControl
    {
        #region Variables
        private PasswordStrength _passwordStrength = null;
        private LinearGradientBrush _linearGradientBrush = null;
        private Label lbText;
        private IContainer components = null;
        private KryptonPalette _palette = new KryptonPalette();
        #endregion

        #region Colour Array
        private Color[] _colourSpectrum = {
                                Color.FromArgb(255,255,0,0),
                                Color.FromArgb(255,255,1,0),
                                Color.FromArgb(255,255,2,0),
                                Color.FromArgb(255,255,4,0),
                                Color.FromArgb(255,255,5,0),
                                Color.FromArgb(255,255,6,0),
                                Color.FromArgb(255,255,7,0),
                                Color.FromArgb(255,255,8,0),
                                Color.FromArgb(255,255,10,0),
                                Color.FromArgb(255,255,11,0),
                                Color.FromArgb(255,255,12,0),
                                Color.FromArgb(255,255,13,0),
                                Color.FromArgb(255,255,15,0),
                                Color.FromArgb(255,255,16,0),
                                Color.FromArgb(255,255,17,0),
                                Color.FromArgb(255,255,19,0),
                                Color.FromArgb(255,255,20,0),
                                Color.FromArgb(255,255,21,0),
                                Color.FromArgb(255,255,22,0),
                                Color.FromArgb(255,255,23,0),
                                Color.FromArgb(255,255,25,0),
                                Color.FromArgb(255,255,26,0),
                                Color.FromArgb(255,255,27,0),
                                Color.FromArgb(255,255,28,0),
                                Color.FromArgb(255,255,30,0),
                                Color.FromArgb(255,255,31,0),
                                Color.FromArgb(255,255,32,0),
                                Color.FromArgb(255,255,34,0),
                                Color.FromArgb(255,255,35,0),
                                Color.FromArgb(255,255,36,0),
                                Color.FromArgb(255,255,37,0),
                                Color.FromArgb(255,255,38,0),
                                Color.FromArgb(255,255,40,0),
                                Color.FromArgb(255,255,41,0),
                                Color.FromArgb(255,255,42,0),
                                Color.FromArgb(255,255,43,0),
                                Color.FromArgb(255,255,44,0),
                                Color.FromArgb(255,255,46,0),
                                Color.FromArgb(255,255,47,0),
                                Color.FromArgb(255,255,48,0),
                                Color.FromArgb(255,255,49,0),
                                Color.FromArgb(255,255,51,0),
                                Color.FromArgb(255,255,52,0),
                                Color.FromArgb(255,255,53,0),
                                Color.FromArgb(255,255,55,0),
                                Color.FromArgb(255,255,56,0),
                                Color.FromArgb(255,255,57,0),
                                Color.FromArgb(255,255,58,0),
                                Color.FromArgb(255,255,59,0),
                                Color.FromArgb(255,255,61,0),
                                Color.FromArgb(255,255,62,0),
                                Color.FromArgb(255,255,63,0),
                                Color.FromArgb(255,255,64,0),
                                Color.FromArgb(255,255,66,0),
                                Color.FromArgb(255,255,67,0),
                                Color.FromArgb(255,255,68,0),
                                Color.FromArgb(255,255,70,0),
                                Color.FromArgb(255,255,71,0),
                                Color.FromArgb(255,255,72,0),
                                Color.FromArgb(255,255,73,0),
                                Color.FromArgb(255,255,74,0),
                                Color.FromArgb(255,255,76,0),
                                Color.FromArgb(255,255,77,0),
                                Color.FromArgb(255,255,78,0),
                                Color.FromArgb(255,255,80,0),
                                Color.FromArgb(255,255,81,0),
                                Color.FromArgb(255,255,82,0),
                                Color.FromArgb(255,255,83,0),
                                Color.FromArgb(255,255,85,0),
                                Color.FromArgb(255,255,86,0),
                                Color.FromArgb(255,255,87,0),
                                Color.FromArgb(255,255,88,0),
                                Color.FromArgb(255,255,89,0),
                                Color.FromArgb(255,255,91,0),
                                Color.FromArgb(255,255,92,0),
                                Color.FromArgb(255,255,93,0),
                                Color.FromArgb(255,255,95,0),
                                Color.FromArgb(255,255,96,0),
                                Color.FromArgb(255,255,97,0),
                                Color.FromArgb(255,255,98,0),
                                Color.FromArgb(255,255,100,0),
                                Color.FromArgb(255,255,101,0),
                                Color.FromArgb(255,255,102,0),
                                Color.FromArgb(255,255,103,0),
                                Color.FromArgb(255,255,104,0),
                                Color.FromArgb(255,255,106,0),
                                Color.FromArgb(255,255,107,0),
                                Color.FromArgb(255,255,108,0),
                                Color.FromArgb(255,255,110,0),
                                Color.FromArgb(255,255,111,0),
                                Color.FromArgb(255,255,112,0),
                                Color.FromArgb(255,255,113,0),
                                Color.FromArgb(255,255,115,0),
                                Color.FromArgb(255,255,116,0),
                                Color.FromArgb(255,255,117,0),
                                Color.FromArgb(255,255,118,0),
                                Color.FromArgb(255,255,119,0),
                                Color.FromArgb(255,255,121,0),
                                Color.FromArgb(255,255,122,0),
                                Color.FromArgb(255,255,123,0),
                                Color.FromArgb(255,255,124,0),
                                Color.FromArgb(255,255,125,0),
                                Color.FromArgb(255,255,127,0),
                                Color.FromArgb(255,255,128,0),
                                Color.FromArgb(255,255,129,0),
                                Color.FromArgb(255,255,131,0),
                                Color.FromArgb(255,255,132,0),
                                Color.FromArgb(255,255,133,0),
                                Color.FromArgb(255,255,134,0),
                                Color.FromArgb(255,255,136,0),
                                Color.FromArgb(255,255,137,0),
                                Color.FromArgb(255,255,138,0),
                                Color.FromArgb(255,255,139,0),
                                Color.FromArgb(255,255,140,0),
                                Color.FromArgb(255,255,142,0),
                                Color.FromArgb(255,255,143,0),
                                Color.FromArgb(255,255,144,0),
                                Color.FromArgb(255,255,146,0),
                                Color.FromArgb(255,255,147,0),
                                Color.FromArgb(255,255,148,0),
                                Color.FromArgb(255,255,149,0),
                                Color.FromArgb(255,255,151,0),
                                Color.FromArgb(255,255,152,0),
                                Color.FromArgb(255,255,153,0),
                                Color.FromArgb(255,255,154,0),
                                Color.FromArgb(255,255,155,0),
                                Color.FromArgb(255,255,155,0),
                                Color.FromArgb(255,255,156,0),
                                Color.FromArgb(255,255,157,0),
                                Color.FromArgb(255,255,158,0),
                                Color.FromArgb(255,255,159,0),
                                Color.FromArgb(255,255,159,0),
                                Color.FromArgb(255,255,160,0),
                                Color.FromArgb(255,255,161,0),
                                Color.FromArgb(255,255,162,0),
                                Color.FromArgb(255,255,163,0),
                                Color.FromArgb(255,255,163,0),
                                Color.FromArgb(255,255,164,0),
                                Color.FromArgb(255,255,165,0),
                                Color.FromArgb(255,255,166,0),
                                Color.FromArgb(255,255,167,0),
                                Color.FromArgb(255,255,167,0),
                                Color.FromArgb(255,255,168,0),
                                Color.FromArgb(255,255,169,0),
                                Color.FromArgb(255,255,170,0),
                                Color.FromArgb(255,255,171,0),
                                Color.FromArgb(255,255,171,0),
                                Color.FromArgb(255,255,172,0),
                                Color.FromArgb(255,255,173,0),
                                Color.FromArgb(255,255,174,0),
                                Color.FromArgb(255,255,175,0),
                                Color.FromArgb(255,255,175,0),
                                Color.FromArgb(255,255,176,0),
                                Color.FromArgb(255,255,177,0),
                                Color.FromArgb(255,255,178,0),
                                Color.FromArgb(255,255,179,0),
                                Color.FromArgb(255,255,179,0),
                                Color.FromArgb(255,255,180,0),
                                Color.FromArgb(255,255,181,0),
                                Color.FromArgb(255,255,181,0),
                                Color.FromArgb(255,255,182,0),
                                Color.FromArgb(255,255,183,0),
                                Color.FromArgb(255,255,184,0),
                                Color.FromArgb(255,255,185,0),
                                Color.FromArgb(255,255,185,0),
                                Color.FromArgb(255,255,186,0),
                                Color.FromArgb(255,255,187,0),
                                Color.FromArgb(255,255,188,0),
                                Color.FromArgb(255,255,189,0),
                                Color.FromArgb(255,255,189,0),
                                Color.FromArgb(255,255,190,0),
                                Color.FromArgb(255,255,191,0),
                                Color.FromArgb(255,255,192,0),
                                Color.FromArgb(255,255,193,0),
                                Color.FromArgb(255,255,193,0),
                                Color.FromArgb(255,255,194,0),
                                Color.FromArgb(255,255,195,0),
                                Color.FromArgb(255,255,196,0),
                                Color.FromArgb(255,255,197,0),
                                Color.FromArgb(255,255,197,0),
                                Color.FromArgb(255,255,198,0),
                                Color.FromArgb(255,255,199,0),
                                Color.FromArgb(255,255,200,0),
                                Color.FromArgb(255,255,201,0),
                                Color.FromArgb(255,255,201,0),
                                Color.FromArgb(255,255,202,0),
                                Color.FromArgb(255,255,203,0),
                                Color.FromArgb(255,255,204,0),
                                Color.FromArgb(255,255,205,0),
                                Color.FromArgb(255,255,205,0),
                                Color.FromArgb(255,255,206,0),
                                Color.FromArgb(255,255,207,0),
                                Color.FromArgb(255,255,208,0),
                                Color.FromArgb(255,255,209,0),
                                Color.FromArgb(255,255,209,0),
                                Color.FromArgb(255,255,210,0),
                                Color.FromArgb(255,255,211,0),
                                Color.FromArgb(255,255,212,0),
                                Color.FromArgb(255,255,213,0),
                                Color.FromArgb(255,255,213,0),
                                Color.FromArgb(255,255,214,0),
                                Color.FromArgb(255,255,215,0),
                                Color.FromArgb(255,255,216,0),
                                Color.FromArgb(255,255,217,0),
                                Color.FromArgb(255,255,217,0),
                                Color.FromArgb(255,255,218,0),
                                Color.FromArgb(255,255,219,0),
                                Color.FromArgb(255,255,220,0),
                                Color.FromArgb(255,255,221,0),
                                Color.FromArgb(255,255,221,0),
                                Color.FromArgb(255,255,222,0),
                                Color.FromArgb(255,255,223,0),
                                Color.FromArgb(255,255,224,0),
                                Color.FromArgb(255,255,225,0),
                                Color.FromArgb(255,255,225,0),
                                Color.FromArgb(255,255,226,0),
                                Color.FromArgb(255,255,227,0),
                                Color.FromArgb(255,255,228,0),
                                Color.FromArgb(255,255,229,0),
                                Color.FromArgb(255,255,229,0),
                                Color.FromArgb(255,255,230,0),
                                Color.FromArgb(255,255,231,0),
                                Color.FromArgb(255,255,232,0),
                                Color.FromArgb(255,255,233,0),
                                Color.FromArgb(255,255,233,0),
                                Color.FromArgb(255,255,234,0),
                                Color.FromArgb(255,255,235,0),
                                Color.FromArgb(255,255,236,0),
                                Color.FromArgb(255,255,237,0),
                                Color.FromArgb(255,255,237,0),
                                Color.FromArgb(255,255,238,0),
                                Color.FromArgb(255,255,239,0),
                                Color.FromArgb(255,255,240,0),
                                Color.FromArgb(255,255,241,0),
                                Color.FromArgb(255,255,241,0),
                                Color.FromArgb(255,255,242,0),
                                Color.FromArgb(255,255,243,0),
                                Color.FromArgb(255,255,244,0),
                                Color.FromArgb(255,255,245,0),
                                Color.FromArgb(255,255,245,0),
                                Color.FromArgb(255,255,246,0),
                                Color.FromArgb(255,255,247,0),
                                Color.FromArgb(255,255,248,0),
                                Color.FromArgb(255,255,249,0),
                                Color.FromArgb(255,255,249,0),
                                Color.FromArgb(255,255,250,0),
                                Color.FromArgb(255,255,251,0),
                                Color.FromArgb(255,255,252,0),
                                Color.FromArgb(255,255,253,0),
                                Color.FromArgb(255,255,253,0),
                                Color.FromArgb(255,255,254,0),
                                Color.FromArgb(255,255,255,0),
                                Color.FromArgb(255,255,255,0),
                                Color.FromArgb(255,254,254,1),
                                Color.FromArgb(255,253,254,1),
                                Color.FromArgb(255,252,254,1),
                                Color.FromArgb(255,251,253,2),
                                Color.FromArgb(255,251,253,2),
                                Color.FromArgb(255,250,252,3),
                                Color.FromArgb(255,249,252,3),
                                Color.FromArgb(255,248,252,3),
                                Color.FromArgb(255,247,251,4),
                                Color.FromArgb(255,247,251,4),
                                Color.FromArgb(255,246,250,5),
                                Color.FromArgb(255,245,250,5),
                                Color.FromArgb(255,244,250,5),
                                Color.FromArgb(255,243,249,6),
                                Color.FromArgb(255,243,249,6),
                                Color.FromArgb(255,242,248,7),
                                Color.FromArgb(255,241,248,7),
                                Color.FromArgb(255,240,248,7),
                                Color.FromArgb(255,239,247,8),
                                Color.FromArgb(255,239,247,8),
                                Color.FromArgb(255,238,247,8),
                                Color.FromArgb(255,237,246,9),
                                Color.FromArgb(255,237,246,9),
                                Color.FromArgb(255,236,245,10),
                                Color.FromArgb(255,235,245,10),
                                Color.FromArgb(255,234,245,10),
                                Color.FromArgb(255,233,244,11),
                                Color.FromArgb(255,233,244,11),
                                Color.FromArgb(255,232,243,12),
                                Color.FromArgb(255,231,243,12),
                                Color.FromArgb(255,230,243,12),
                                Color.FromArgb(255,230,242,13),
                                Color.FromArgb(255,229,242,13),
                                Color.FromArgb(255,228,242,13),
                                Color.FromArgb(255,227,241,14),
                                Color.FromArgb(255,227,241,14),
                                Color.FromArgb(255,226,240,15),
                                Color.FromArgb(255,225,240,15),
                                Color.FromArgb(255,224,240,15),
                                Color.FromArgb(255,223,239,16),
                                Color.FromArgb(255,223,239,16),
                                Color.FromArgb(255,222,238,17),
                                Color.FromArgb(255,221,238,17),
                                Color.FromArgb(255,220,238,17),
                                Color.FromArgb(255,219,237,18),
                                Color.FromArgb(255,219,237,18),
                                Color.FromArgb(255,218,236,19),
                                Color.FromArgb(255,217,236,19),
                                Color.FromArgb(255,216,236,19),
                                Color.FromArgb(255,215,235,20),
                                Color.FromArgb(255,215,235,20),
                                Color.FromArgb(255,214,234,21),
                                Color.FromArgb(255,213,234,21),
                                Color.FromArgb(255,213,234,21),
                                Color.FromArgb(255,212,233,22),
                                Color.FromArgb(255,211,233,22),
                                Color.FromArgb(255,210,233,22),
                                Color.FromArgb(255,209,232,23),
                                Color.FromArgb(255,209,232,23),
                                Color.FromArgb(255,208,231,24),
                                Color.FromArgb(255,207,231,24),
                                Color.FromArgb(255,206,231,24),
                                Color.FromArgb(255,205,230,25),
                                Color.FromArgb(255,205,230,25),
                                Color.FromArgb(255,204,229,26),
                                Color.FromArgb(255,203,229,26),
                                Color.FromArgb(255,202,229,26),
                                Color.FromArgb(255,201,228,27),
                                Color.FromArgb(255,201,228,27),
                                Color.FromArgb(255,200,227,28),
                                Color.FromArgb(255,199,227,28),
                                Color.FromArgb(255,198,227,28),
                                Color.FromArgb(255,197,226,29),
                                Color.FromArgb(255,197,226,29),
                                Color.FromArgb(255,196,226,29),
                                Color.FromArgb(255,195,225,30),
                                Color.FromArgb(255,195,225,30),
                                Color.FromArgb(255,194,224,31),
                                Color.FromArgb(255,193,224,31),
                                Color.FromArgb(255,192,224,31),
                                Color.FromArgb(255,191,223,32),
                                Color.FromArgb(255,191,223,32),
                                Color.FromArgb(255,190,222,33),
                                Color.FromArgb(255,189,222,33),
                                Color.FromArgb(255,188,222,33),
                                Color.FromArgb(255,187,221,34),
                                Color.FromArgb(255,187,221,34),
                                Color.FromArgb(255,186,220,35),
                                Color.FromArgb(255,185,220,35),
                                Color.FromArgb(255,184,220,35),
                                Color.FromArgb(255,183,219,36),
                                Color.FromArgb(255,183,219,36),
                                Color.FromArgb(255,182,219,36),
                                Color.FromArgb(255,181,218,37),
                                Color.FromArgb(255,181,218,37),
                                Color.FromArgb(255,180,217,38),
                                Color.FromArgb(255,179,217,38),
                                Color.FromArgb(255,178,217,38),
                                Color.FromArgb(255,177,216,39),
                                Color.FromArgb(255,177,216,39),
                                Color.FromArgb(255,176,215,40),
                                Color.FromArgb(255,175,215,40),
                                Color.FromArgb(255,174,215,40),
                                Color.FromArgb(255,173,214,41),
                                Color.FromArgb(255,173,214,41),
                                Color.FromArgb(255,172,213,42),
                                Color.FromArgb(255,171,213,42),
                                Color.FromArgb(255,171,213,42),
                                Color.FromArgb(255,170,212,43),
                                Color.FromArgb(255,169,212,43),
                                Color.FromArgb(255,168,212,43),
                                Color.FromArgb(255,167,211,44),
                                Color.FromArgb(255,167,211,44),
                                Color.FromArgb(255,166,210,45),
                                Color.FromArgb(255,165,210,45),
                                Color.FromArgb(255,164,210,45),
                                Color.FromArgb(255,163,209,46),
                                Color.FromArgb(255,163,209,46),
                                Color.FromArgb(255,162,208,47),
                                Color.FromArgb(255,161,208,47),
                                Color.FromArgb(255,160,208,47),
                                Color.FromArgb(255,159,207,48),
                                Color.FromArgb(255,159,207,48),
                                Color.FromArgb(255,158,206,49),
                                Color.FromArgb(255,157,206,49),
                                Color.FromArgb(255,156,206,49),
                                Color.FromArgb(255,155,205,50),
                                Color.FromArgb(255,155,205,50),
                                Color.FromArgb(255,154,205,50),
                                Color.FromArgb(255,153,204,51),
                                Color.FromArgb(255,152,203,51),
                                Color.FromArgb(255,151,202,50),
                                Color.FromArgb(255,149,202,50),
                                Color.FromArgb(255,148,201,49),
                                Color.FromArgb(255,146,200,49),
                                Color.FromArgb(255,145,199,48),
                                Color.FromArgb(255,144,198,48),
                                Color.FromArgb(255,143,197,48),
                                Color.FromArgb(255,141,196,47),
                                Color.FromArgb(255,140,195,47),
                                Color.FromArgb(255,139,194,46),
                                Color.FromArgb(255,137,194,46),
                                Color.FromArgb(255,136,193,45),
                                Color.FromArgb(255,134,192,45),
                                Color.FromArgb(255,133,191,44),
                                Color.FromArgb(255,132,190,44),
                                Color.FromArgb(255,131,189,44),
                                Color.FromArgb(255,129,188,43),
                                Color.FromArgb(255,128,187,43),
                                Color.FromArgb(255,127,186,42),
                                Color.FromArgb(255,125,186,42),
                                Color.FromArgb(255,124,184,41),
                                Color.FromArgb(255,122,184,41),
                                Color.FromArgb(255,121,183,40),
                                Color.FromArgb(255,120,182,40),
                                Color.FromArgb(255,119,181,40),
                                Color.FromArgb(255,118,180,39),
                                Color.FromArgb(255,116,179,39),
                                Color.FromArgb(255,115,178,38),
                                Color.FromArgb(255,113,178,38),
                                Color.FromArgb(255,112,177,37),
                                Color.FromArgb(255,111,176,37),
                                Color.FromArgb(255,109,175,36),
                                Color.FromArgb(255,108,174,36),
                                Color.FromArgb(255,107,173,36),
                                Color.FromArgb(255,106,172,35),
                                Color.FromArgb(255,104,171,35),
                                Color.FromArgb(255,103,170,34),
                                Color.FromArgb(255,101,170,34),
                                Color.FromArgb(255,100,169,33),
                                Color.FromArgb(255,98,168,33),
                                Color.FromArgb(255,97,167,32),
                                Color.FromArgb(255,96,166,32),
                                Color.FromArgb(255,95,165,32),
                                Color.FromArgb(255,93,164,31),
                                Color.FromArgb(255,92,163,31),
                                Color.FromArgb(255,91,162,30),
                                Color.FromArgb(255,89,162,30),
                                Color.FromArgb(255,88,160,29),
                                Color.FromArgb(255,86,160,29),
                                Color.FromArgb(255,85,159,28),
                                Color.FromArgb(255,84,158,28),
                                Color.FromArgb(255,83,157,28),
                                Color.FromArgb(255,81,156,27),
                                Color.FromArgb(255,80,155,27),
                                Color.FromArgb(255,79,154,26),
                                Color.FromArgb(255,77,154,26),
                                Color.FromArgb(255,76,152,25),
                                Color.FromArgb(255,74,152,25),
                                Color.FromArgb(255,73,151,24),
                                Color.FromArgb(255,72,150,24),
                                Color.FromArgb(255,70,149,23),
                                Color.FromArgb(255,69,148,23),
                                Color.FromArgb(255,68,147,23),
                                Color.FromArgb(255,67,146,22),
                                Color.FromArgb(255,65,145,22),
                                Color.FromArgb(255,64,144,21),
                                Color.FromArgb(255,62,144,21),
                                Color.FromArgb(255,61,143,20),
                                Color.FromArgb(255,59,142,20),
                                Color.FromArgb(255,58,141,19),
                                Color.FromArgb(255,57,140,19),
                                Color.FromArgb(255,56,139,19),
                                Color.FromArgb(255,54,138,18),
                                Color.FromArgb(255,53,137,18),
                                Color.FromArgb(255,52,136,17),
                                Color.FromArgb(255,50,136,17),
                                Color.FromArgb(255,49,135,16),
                                Color.FromArgb(255,47,134,16),
                                Color.FromArgb(255,46,133,15),
                                Color.FromArgb(255,45,132,15),
                                Color.FromArgb(255,44,131,15),
                                Color.FromArgb(255,42,130,14),
                                Color.FromArgb(255,41,129,14),
                                Color.FromArgb(255,40,128,13),
                                Color.FromArgb(255,38,128,13),
                                Color.FromArgb(255,37,126,12),
                                Color.FromArgb(255,35,126,12),
                                Color.FromArgb(255,34,125,11),
                                Color.FromArgb(255,33,124,11),
                                Color.FromArgb(255,32,123,11),
                                Color.FromArgb(255,31,122,10),
                                Color.FromArgb(255,29,122,10),
                                Color.FromArgb(255,28,120,9),
                                Color.FromArgb(255,26,120,9),
                                Color.FromArgb(255,25,119,8),
                                Color.FromArgb(255,24,118,8),
                                Color.FromArgb(255,22,117,7),
                                Color.FromArgb(255,21,116,7),
                                Color.FromArgb(255,20,115,7),
                                Color.FromArgb(255,19,114,6),
                                Color.FromArgb(255,17,113,6),
                                Color.FromArgb(255,16,112,5),
                                Color.FromArgb(255,14,112,5),
                                Color.FromArgb(255,13,111,4),
                                Color.FromArgb(255,11,110,4),
                                Color.FromArgb(255,10,109,3),
                                Color.FromArgb(255,9,108,3),
                                Color.FromArgb(255,8,107,3),
                                Color.FromArgb(255,6,106,2),
                                Color.FromArgb(255,5,105,2),
                                Color.FromArgb(255,4,104,1),
                                Color.FromArgb(255,2,104,1),
                                Color.FromArgb(255,1,102,0),
                                Color.FromArgb(255,0,102,0),
                                Color.FromArgb(255,0,102,0),
                                Color.FromArgb(255,0,102,0)
        };
        #endregion

        #region Properties
        public Color[] ColourSpectrum { get => _colourSpectrum; }

        public LinearGradientBrush GradientBrush { get => _linearGradientBrush; set => _linearGradientBrush = value; }

        public KryptonPalette Palette { get => _palette; set => _palette = value; }
        #endregion

        #region Designer Code
        private void InitializeComponent()
        {
            this.lbText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbText
            // 
            this.lbText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbText.BackColor = System.Drawing.Color.Transparent;
            this.lbText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbText.Location = new System.Drawing.Point(-1, 0);
            this.lbText.Margin = new System.Windows.Forms.Padding(0);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(107, 22);
            this.lbText.TabIndex = 1;
            this.lbText.Text = "Weak";
            this.lbText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PasswordStrengthControl
            // 
            this.Controls.Add(this.lbText);
            this.Name = "PasswordStrengthControl";
            this.Size = new System.Drawing.Size(105, 22);
            this.Load += new System.EventHandler(this.PasswordStrengthControl_Load);
            this.ResumeLayout(false);

        }
        #endregion

        #region Constructor
        public PasswordStrengthControl()
        {
            InitializeComponent();

            InitialiseKryptonColours();

            PasswordStrength.SetPassword(" ");

            UpdateControl();
        }
        #endregion

        #region Methods
        private void InitialiseKryptonColours()
        {
            lbText.ForeColor = Palette.ColorTable.MenuItemText;
        }

        public void SetPassword(string password)
        {
            PasswordStrength.SetPassword(password);

            UpdateControl();
        }

        private void UpdateControl()
        {
            int score = PasswordStrength.GetPasswordScore(), x1 = score * 4, x2 = x1 + 99;

            lbText.Text = PasswordStrength.GetPasswordStrength();

            if (x2 >= 500)
            {
                x2 = 499;
            }

            Color colour1 = ColourSpectrum[x1], colour2 = ColourSpectrum[x2];

            if (GradientBrush != null)
            {
                GradientBrush.Dispose();

                GradientBrush = null;
            }

            GradientBrush = new LinearGradientBrush(new Point(0, 0), new Point(Width, Height), colour1, colour2);

            Refresh();
        }
        #endregion

        #region Overrides
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            if (GradientBrush != null)
            {
                e.Graphics.FillRectangle(GradientBrush, ClientRectangle);
            }
        }
        #endregion

        private void PasswordStrengthControl_Load(object sender, EventArgs e)
        {
            SetPassword("abc");
        }
    }
}