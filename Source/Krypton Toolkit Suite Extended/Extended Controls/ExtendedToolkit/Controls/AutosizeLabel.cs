using ComponentFactory.Krypton.Toolkit;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.Controls
{
    /// <summary>
    /// A multi-line label that resizes with the content. Adapted from (https://github.com/Nexus-Mods/Nexus-Mod-Manager/blob/master/UI/Controls/AutosizeLabel.cs)
    /// </summary>
    /// <remarks>
    /// Currently, the label only resizes its height.
    /// </remarks>
    [ToolboxBitmap(typeof(KryptonLabel))]
    [Description("A multi-line label that resizes with the content. Adapted from (https://github.com/Nexus-Mods/Nexus-Mod-Manager/blob/master/UI/Controls/AutosizeLabel.cs)")]
    public class AutosizeLabel : ScrollableControl
    {
        /// <summary>
        /// A <see cref="RichTextBox"/> that is styled to behave like a label.
        /// </summary>
        private class KryptonRichTextLabel : RichTextBox
        {
            #region Fields
            private bool _allowSelection = false;
            #endregion

            #region Properties

            /// <summary>
            /// Gets or sets whether text selection is allowed.
            /// </summary>
            /// <value>Whether text selection is allowed.</value>
            [Browsable(true)]
            [Category("Behavior")]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
            [DefaultValue(false)]
            public bool AllowSelection
            {
                get
                {
                    return _allowSelection;
                }
                set
                {
                    if (_allowSelection != value)
                    {
                        _allowSelection = value;
                        if (_allowSelection)
                            this.Enter -= new EventHandler(AutosizeLabel_Enter);
                        else
                            this.Enter += new EventHandler(AutosizeLabel_Enter);
                    }
                }
            }

            /// <summary>
            /// Gets or sets whether the label is multiline.
            /// </summary>
            /// <remarks>
            /// Since the label autosizes, this is always true.
            /// </remarks>
            /// <value>Always <c>true</c>.</value>
            [DefaultValue(true)]
            public new bool Multiline
            {
                get
                {
                    return base.Multiline;
                }
                set
                {
                    base.Multiline = true;
                }
            }

            /// <summary>
            /// Gets or sets whether the label is readonly.
            /// </summary>
            /// <remarks>
            /// Since this is a label, this is always true.
            /// </remarks>
            /// <value>Always <c>true</c>.</value>
            [DefaultValue(true)]
            public new bool ReadOnly
            {
                get
                {
                    return base.ReadOnly;
                }
                set
                {
                    base.ReadOnly = true;
                }
            }

            /// <summary>
            /// Gets or sets whether the label has a tab stop.
            /// </summary>
            /// <remarks>
            /// Since this is a label, this is always false.
            /// </remarks>
            /// <value>Always <c>false</c>.</value>
            [DefaultValue(false)]
            public new bool TabStop
            {
                get
                {
                    return base.TabStop;
                }
                set
                {
                    base.TabStop = false;
                }
            }

            #endregion

            #region Constructors
            /// <summary>
            /// The default constructor.
            /// </summary>
            public KryptonRichTextLabel()
            {
                //set this to true so that when we set AllowSelection to false,
                // the setter doesn't short circuit, and actually performs the
                // required set up.

                _allowSelection = true;

                SetTextColour();
            }
            #endregion

            #region Overrides
            /// <summary>
            /// Makes sure all text doesn't look disabled.
            /// </summary>
            /// <param name="e">A <see cref="EventArgs"/> describing the event arguments.</param>
            protected override void OnTextChanged(EventArgs e)
            {
                base.OnTextChanged(e);

                SetTextColour();
            }

            /// <summary>
            /// Resizes the label as the content size changes.
            /// </summary>
            /// <param name="e">A <see cref="ContentsResizedEventArgs"/> describing the event arguments.</param>
            protected override void OnContentsResized(ContentsResizedEventArgs e)
            {
                if (!AllowSelection)
                {
                    Height = e.NewRectangle.Height + 5;
                }

                base.OnContentsResized(e);
            }

            /// <summary>
            /// Raises the <see cref="KryptonRichTextBox.LinkClicked"/> event.
            /// </summary>
            /// <remarks>
            /// This ask the OS to launch the clicked link.
            /// </remarks>
            /// <param name="e">A <see cref="LinkClickedEventArgs"/> describing the event arguments.</param>
            protected override void OnLinkClicked(LinkClickedEventArgs e)
            {
                Uri newURL = new Uri(e.LinkText);

                Process.Start(newURL.ToString());

                base.OnLinkClicked(e);
            }
            #endregion

            #region Methods
            /// <summary>
            /// Forces the text colour not to look disabled.
            /// </summary>
            private void SetTextColour()
            {
                SelectAll();

                SelectionColor = ForeColor;

                Select(0, 0);
            }
            #endregion

            #region Event Handlers
            /// <summary>
            /// Handles the <see cref="Control.Enter"/> event of the autosize label.
            /// </summary>
            /// <remarks>
            /// This gives the hidden scrollable panel focus instead of the label,
            /// so that the user can't select any text.
            /// </remarks>
            /// <param name="sender">The object that raised the event.</param>
            /// <param name="e">An <see cref="EventArgs"/> describing the event arguments.</param>
            public void AutosizeLabel_Enter(object sender, EventArgs e)
            {
                Parent.Focus();
            }
            #endregion
        }

        #region Fields
        KryptonRichTextLabel _richTextLabel = new KryptonRichTextLabel();

        private RichTextBoxScrollBars _richTextBoxScrollBars = RichTextBoxScrollBars.None;
        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets whether text selection is allowed.
        /// </summary>
        /// <value>Whether text selection is allowed.</value>
        [Browsable(true)]
        [Category("Behavior")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [DefaultValue(false)]
        public bool AllowSelection
        {
            get
            {
                return _richTextLabel.AllowSelection;
            }
            set
            {
                if (_richTextLabel.AllowSelection != value)
                {
                    _richTextLabel.AllowSelection = value;
                    base.Cursor = value ? Cursors.IBeam : Cursors.Arrow;
                    _richTextLabel.Cursor = value ? Cursors.IBeam : Cursors.Arrow;
                    SetUpScrollHandling();
                }
            }
        }

        /// <summary>
        /// Gets or sets whether the label is multiline.
        /// </summary>
        /// <remarks>
        /// Since the label autosizes, this is always true.
        /// </remarks>
        /// <value>Always <c>true</c>.</value>
        [Browsable(true)]
        [Category("Behavior")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [DefaultValue(true)]
        public bool Multiline
        {
            get
            {
                return _richTextLabel.Multiline;
            }
            set
            {
                _richTextLabel.Multiline = true;
            }
        }

        /// <summary>
        /// Gets or sets whether the label has scrollbars.
        /// </summary>
        /// <value>Whether the label has scrollbars.</value>
        [Browsable(true)]
        [Category("Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [DefaultValue(typeof(RichTextBoxScrollBars), "None")]
        public RichTextBoxScrollBars ScrollBars
        {
            get
            {
                return _richTextBoxScrollBars;
            }
            set
            {
                if (_richTextBoxScrollBars != value)
                {
                    _richTextBoxScrollBars = value;
                    SetUpScrollHandling();
                }
            }
        }

        /// <summary>
        /// Gets or sets the border style.
        /// </summary>
        /// <value>The border style.</value>
        [Browsable(true)]
        [Category("Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [DefaultValue(typeof(BorderStyle), "None")]
        public BorderStyle BorderStyle
        {
            get
            {
                return _richTextLabel.BorderStyle;
            }
            set
            {
                _richTextLabel.BorderStyle = value;
            }
        }

        /// <summary>
        /// Gets or sets the back colour.
        /// </summary>
        /// <value>The back colour.</value>
        [DefaultValue(typeof(SystemColors), "Control")]
        public override Color BackColor
        {
            get
            {
                return base.BackColor;
            }
            set
            {
                base.BackColor = value;
                _richTextLabel.BackColor = value;
            }
        }

        /// <summary>
        /// Gets or sets the text colour.
        /// </summary>
        /// <value>The text colour.</value>
        [Browsable(true)]
        [Category("Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [DefaultValue(typeof(SystemColors), "ControlText")]
        public override Color ForeColor
        {
            get
            {
                return _richTextLabel.ForeColor;
            }
            set
            {
                _richTextLabel.ForeColor = value;
            }
        }

        /// <summary>
        /// Gets or sets the text font.
        /// </summary>
        /// <value>The text font.</value>
        public override Font Font
        {
            get
            {
                return base.Font;
            }
            set
            {
                _richTextLabel.Font = value;
                base.Font = value;
            }
        }

        /// <summary>
        /// Gets or sets the label's text.
        /// </summary>
        /// <value>The label's text.</value>
        public override string Text
        {
            get
            {
                return _richTextLabel.Text;
            }
            set
            {
                _richTextLabel.Text = value;
            }
        }

        /// <summary>
        /// Gets or sets whether the label is readonly.
        /// </summary>
        /// <remarks>
        /// Since this is a label, this is always true.
        /// </remarks>
        /// <value>Always <c>true</c>.</value>
        [Browsable(true)]
        [Category("Behavior")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [DefaultValue(true)]
        public bool ReadOnly
        {
            get
            {
                return _richTextLabel.ReadOnly;
            }
            set
            {
                _richTextLabel.ReadOnly = true;
            }
        }

        /// <summary>
        /// Gets or sets whether the label will automatically detect, and create links for, URLs.
        /// </summary>
        /// <value>Whether the label will automatically detect, and create links for, URLs.</value>
        [Browsable(true)]
        [Category("Behavior")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [DefaultValue(true)]
        public bool DetectUrls
        {
            get
            {
                return _richTextLabel.DetectUrls;
            }
            set
            {
                _richTextLabel.DetectUrls = true;
            }
        }

        /// <summary>
        /// Gets or sets whether the label has a tab stop.
        /// </summary>
        /// <remarks>
        /// Since this is a label, this is always false.
        /// </remarks>
        /// <value>Always <c>false</c>.</value>
        [Browsable(true)]
        [Category("Behavior")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [DefaultValue(false)]
        public new bool TabStop
        {
            get
            {
                return _richTextLabel.TabStop;
            }
            set
            {
                _richTextLabel.TabStop = false;
            }
        }

        /// <summary>
        /// Gets or sets the cursor for the label.
        /// </summary>
        /// <remarks>
        /// Since this is a label, this is always an arrow.
        /// </remarks>
        /// <value>Always <see cref="Cursors.Arrow"/>.</value>
        [DefaultValue(typeof(Cursors), "Arrow")]
        public override Cursor Cursor
        {
            get
            {
                return base.Cursor;
            }
            set
            {
            }
        }

        #endregion

        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public AutosizeLabel()
        {
            AutoScroll = true;

            _richTextLabel.ContentsResized += new ContentsResizedEventHandler(Label_ContentsResized);

            _richTextLabel.TextChanged += new EventHandler(Label_TextChanged);

            Controls.Add(_richTextLabel);

            Multiline = true;

            ScrollBars = RichTextBoxScrollBars.None;

            BorderStyle = BorderStyle.None;

            BackColor = SystemColors.Control;

            ReadOnly = true;

            TabStop = false;

            base.Cursor = Cursors.Arrow;

            AllowSelection = false;

            SetUpScrollHandling();
        }
        #endregion

        #region Event Handlers
        /// <summary>
        /// Handles the <see cref="RichTextBox.ContentsResized"/> event of the rich text label.
        /// </summary>
        /// <remarks>
        /// Resizes the label as the content size changes.
        /// </remarks>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">A <see cref="ContentsResizedEventArgs"/> describing the event arguments.</param>
        private void Label_ContentsResized(object sender, ContentsResizedEventArgs e)
        {
            if (AllowSelection || (_richTextBoxScrollBars == RichTextBoxScrollBars.None))
            {
                Height = e.NewRectangle.Height + 5;
            }
        }

        /// <summary>
        /// Handles the <see cref="Control.TextChanged"/> event of the rich text label.
        /// </summary>
        /// <remarks>
        /// Raises the <see cref="Control.TextChanged"/> event for the control.
        /// </remarks>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">An <see cref="EventArgs"/> describing the event arguments.</param>
        private void Label_TextChanged(object sender, EventArgs e)
        {
            OnTextChanged(e);
        }
        #endregion

        #region Methods
        /// <summary>
        /// Sets up the control to handle srolling.
        /// </summary>
        private void SetUpScrollHandling()
        {
            if (AllowSelection)
            {
                _richTextLabel.ScrollBars = _richTextBoxScrollBars;

                _richTextLabel.Dock = DockStyle.Fill;
            }
            else
            {
                _richTextLabel.ScrollBars = RichTextBoxScrollBars.None;

                switch (_richTextBoxScrollBars)
                {
                    case RichTextBoxScrollBars.None:
                        break;
                    case RichTextBoxScrollBars.Horizontal:
                        _richTextLabel.Dock = DockStyle.Left;
                        break;
                    case RichTextBoxScrollBars.Vertical:
                        _richTextLabel.Dock = DockStyle.Top;
                        break;
                    case RichTextBoxScrollBars.Both:
                        break;
                    case RichTextBoxScrollBars.ForcedHorizontal:
                        break;
                    case RichTextBoxScrollBars.ForcedVertical:
                        break;
                    case RichTextBoxScrollBars.ForcedBoth:
                        break;
                    default:
                        _richTextLabel.Dock = DockStyle.Fill;
                        break;
                }
            }
        }
        #endregion
    }
}