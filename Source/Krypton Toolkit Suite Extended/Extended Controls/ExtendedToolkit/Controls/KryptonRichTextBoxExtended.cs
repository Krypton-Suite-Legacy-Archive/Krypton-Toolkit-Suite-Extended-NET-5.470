using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Drawing;
using ComponentFactory.Krypton.Toolkit;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace ExtendedControls.ExtendedToolkit.Controls
{
    /// <summary>
    /// A <see cref="KryptonRichTextBox"/> control with some extra features.
    /// </summary>
    [Description("A KryptonRichTextBox control with some extra features.")]
    [ToolboxBitmap(typeof(KryptonRichTextBox))]
    [ToolboxItem(true)]
    public class KryptonRichTextBoxExtended : KryptonRichTextBox
    {
        #region Constants
        private const double anInch = 14.5;

        private const int WM_USER = 1024, EM_FORMATRANGE = 1081, EM_SETEVENTMASK = 1073, EM_GETPARAFORMAT = 1085, EM_SETPARAFORMAT = 1095, EM_SETTYPOGRAPHYOPTIONS = 1226, WM_SETREDRAW = 11, TO_ADVANCEDTYPOGRAPHY = 1, PFM_ALIGNMENT = 8, SCF_SELECTION = 1;
        #endregion

        #region Variables
        private int _updating = 0, _oldEventMask = 0;

        private PARAFORMAT _pFormat;
        #endregion

        #region Enumerations
        public enum TextAlignment
        {
            LEFT = 1,
            CENTRE = 2,
            RIGHT = 3,
            JUSTIFY = 4
        }
        #endregion

        #region Structures
        private struct CHARRANGE
        {
            public int cpMin;

            public int cpMax;
        }

        private struct FORMATRANGE
        {
            public IntPtr hdc;

            public IntPtr hdcTarget;

            public RECT rc;

            public RECT rcPage;

            public CHARRANGE chrg;
        }

        private struct PARAFORMAT
        {
            public int cbSize;

            public uint dwMask;

            public short wNumbering;

            public short wReserved;

            public int dxStartIndent;

            public int dxRightIndent;

            public int dxOffset;

            public short wAlignment;

            public short cTabCount;

            public int[] rgxTabs;

            public int dySpaceBefore;

            public int dySpaceAfter;

            public int dyLineSpacing;

            public short sStyle;

            public byte bLineSpacingRule;

            public byte bOutlineLevel;

            public short wShadingWeight;

            public short wShadingStyle;

            public short wNumberingStart;

            public short wNumberingStyle;

            public short wNumberingTab;

            public short wBorderSpace;

            public short wBorderWidth;

            public short wBorders;
        }

        private struct RECT
        {
            public int Left;

            public int Top;

            public int Right;

            public int Bottom;
        }
        #endregion

        #region DLL Imports
        [DllImport("USER32", CharSet = CharSet.Ansi, EntryPoint = "SendMessageA", ExactSpelling = true, SetLastError = true)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);

        [DllImport("user32", CharSet = CharSet.Auto, ExactSpelling = false)]
        private static extern int SendMessage(HandleRef hWnd, int msg, int wParam, int lParam);

        [DllImport("user32", CharSet = CharSet.Auto, ExactSpelling = false)]
        private static extern int SendMessage(HandleRef hWnd, int msg, int wParam, ref PARAFORMAT lp);
        #endregion

        #region Properties
        public new TextAlignment SelectionAlignment
        {
            get
            {
                TextAlignment textAlignment;

                PARAFORMAT pARAFORMAT = new PARAFORMAT()
                {
                    cbSize = Marshal.SizeOf<PARAFORMAT>(_pFormat)
                };

                _pFormat = pARAFORMAT;

                SendMessage(new HandleRef(this, Handle), 1085, 1, ref _pFormat);

                if ((_pFormat.dwMask & 8) == 0)
                {
                    textAlignment = TextAlignment.LEFT;
                }
                else
                {
                    textAlignment = (TextAlignment)_pFormat.wAlignment;
                }

                return textAlignment;
            }

            set
            {
                PARAFORMAT pARAFORMAT = new PARAFORMAT()
                {
                    cbSize = Marshal.SizeOf<PARAFORMAT>(_pFormat),
                    dwMask = 8,
                    wAlignment = (short)value
                };

                _pFormat = pARAFORMAT;

                SendMessage(new HandleRef(this, Handle), 1095, 1, ref _pFormat);
            }
        }
        #endregion

        #region Constructors
        [DebuggerNonUserCode]
        public KryptonRichTextBoxExtended()
        {
            Font = new Font("Segoe UI", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
        }
        #endregion

        #region Methods
        public void BeginUpdate()
        {
            _updating++;

            if (_updating < 1)
            {
                _oldEventMask = SendMessage(new HandleRef(this, Handle), 1073, 0, 0);

                SendMessage(new HandleRef(this, Handle), 11, 0, 0);
            }
        }
        #endregion
    }
}