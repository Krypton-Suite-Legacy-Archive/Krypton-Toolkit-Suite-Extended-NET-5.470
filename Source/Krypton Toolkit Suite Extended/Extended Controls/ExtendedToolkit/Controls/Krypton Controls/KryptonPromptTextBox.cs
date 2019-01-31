using ComponentFactory.Krypton.Toolkit;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace ExtendedControls.ExtendedToolkit.Controls
{
    [ToolboxBitmap(typeof(KryptonTextBox))]
    [ToolboxItem(true)]
    [ToolStripItemDesignerAvailability(ToolStripItemDesignerAvailability.All)]
    public class KryptonPromptTextBox : TextBox
    {
        #region Constants
        private const int WM_SETFOCUS = 7, WM_KILLFOCUS = 8, WM_ERASEBKGND = 14, WM_PAINT = 15;
        #endregion

        #region Variables
        private bool _focusSelect = true, _drawPrompt = true;
        private string _promptText = string.Empty;
        private Color _promptTextColour = SystemColors.GrayText;
        private Font _promptTypeface = null;
        #endregion

        #region Properties
        public bool DrawPrompt { get { return _drawPrompt; } set { _drawPrompt = value; } }

        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Category("Appearance")]
        public string PromptText { get { return _promptText; } set { _promptText = value; } }

        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Category("Appearance")]
        [Description("The ForeColour to use when displaying the PromptText.")]
        public Color PromptForeColour
        {
            get { return _promptTextColour; }
            set { _promptTextColour = value; Invalidate(); }
        }

        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Category("Appearance")]
        [Description("The typeface to use when displaying the PromptText.")]
        public Font PromptTypeface
        {
            get { return _promptTypeface; }
            set { _promptTypeface = value; Invalidate(); }
        }

        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Category("Behavior")]
        [Description("Automatically select the text when control receives the focus.")]
        public bool FocusSelect
        {
            get { return _focusSelect; }
            set { _focusSelect = value; }
        }
        #endregion

        #region Constructor
        public KryptonPromptTextBox()
        {
            PromptTypeface = Font;
        }
        #endregion

        #region Overrides
        protected override void OnEnter(EventArgs e)
        {
            if (Text.Length > 0 && FocusSelect)
            {
                SelectAll();
            }

            base.OnEnter(e);
        }

        protected override void OnTextAlignChanged(EventArgs e)
        {
            base.OnTextAlignChanged(e);

            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (DrawPrompt && Text.Length == 0)
            {
                DrawTextPrompt(e.Graphics);
            }
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_SETFOCUS:
                    DrawPrompt = false;
                    break;
                case WM_KILLFOCUS:
                    DrawPrompt = true;
                    break;
            }

            base.WndProc(ref m);

            // Only draw the prompt on the WM_PAINT event and when the Text property is empty
            if (m.Msg == WM_PAINT && DrawPrompt && Text.Length == 0 && !GetStyle(ControlStyles.UserPaint))
            {
                DrawTextPrompt();
            }
        }
        #endregion

        #region Methods
        protected virtual void DrawTextPrompt()
        {
            using (Graphics g = CreateGraphics())
            {
                DrawTextPrompt(g);
            }
        }

        protected virtual void DrawTextPrompt(Graphics g)
        {
            TextFormatFlags flags = TextFormatFlags.NoPadding | TextFormatFlags.Top | TextFormatFlags.EndEllipsis;

            Rectangle rect = ClientRectangle;

            // Offset the rectangle based on the HorizontalAlignment, 
            // otherwise the display looks a little strange
            switch (TextAlign)
            {
                case HorizontalAlignment.Center:
                    flags = flags | TextFormatFlags.HorizontalCenter;

                    rect.Offset(0, 1);
                    break;
                case HorizontalAlignment.Left:
                    flags = flags | TextFormatFlags.Left;

                    rect.Offset(1, 1);
                    break;
                case HorizontalAlignment.Right:
                    flags = flags | TextFormatFlags.Right;

                    rect.Offset(0, 1);
                    break;
            }

            // Draw the prompt text using TextRenderer
            TextRenderer.DrawText(g, _promptText, _promptTypeface, rect, _promptTextColour, BackColor, flags);
        }
        #endregion
    }
}