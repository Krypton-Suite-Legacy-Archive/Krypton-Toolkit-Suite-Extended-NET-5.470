using ComponentFactory.Krypton.Toolkit;
using ExtendedControls.Interfaces.Colours;
using ExtendedControls.Interfaces.ColourSchemes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.Controls.Colours
{
    public partial class SchemesColourEditorUserControl : UserControl
    {
        #region System

        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.coloursListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.schemesComboBox = new KryptonComboBox();
            this.SuspendLayout();
            // 
            // colorsListView
            // 
            this.coloursListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.coloursListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.coloursListView.FullRowSelect = true;
            this.coloursListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.coloursListView.HideSelection = false;
            this.coloursListView.Location = new System.Drawing.Point(0, 27);
            this.coloursListView.MultiSelect = false;
            this.coloursListView.Name = "colorsListView";
            this.coloursListView.OwnerDraw = true;
            this.coloursListView.ShowGroups = false;
            this.coloursListView.ShowItemToolTips = true;
            this.coloursListView.Size = new System.Drawing.Size(150, 123);
            this.coloursListView.TabIndex = 1;
            this.coloursListView.UseCompatibleStateImageBehavior = false;
            this.coloursListView.View = System.Windows.Forms.View.Details;
            this.coloursListView.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.ColoursListView_DrawColumnHeader);
            this.coloursListView.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.ColoursListView_DrawItem);
            this.coloursListView.SelectedIndexChanged += new System.EventHandler(this.ColoursListView_SelectedIndexChanged);
            this.coloursListView.SizeChanged += new System.EventHandler(this.ColoursListView_SizeChanged);
            this.coloursListView.DoubleClick += new System.EventHandler(this.ColoursListView_DoubleClick);
            this.coloursListView.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.ColoursListView_DrawSubItem);
            this.coloursListView.Click += new System.EventHandler(this.ColoursListView_Click);
            // 
            // schemesComboBox
            // 
            this.schemesComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.schemesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.schemesComboBox.FormattingEnabled = true;
            this.schemesComboBox.Location = new System.Drawing.Point(0, 0);
            this.schemesComboBox.MaxDropDownItems = 20;
            this.schemesComboBox.Name = "schemesComboBox";
            this.schemesComboBox.Size = new System.Drawing.Size(150, 21);
            this.schemesComboBox.TabIndex = 0;
            this.schemesComboBox.SelectedIndexChanged += new System.EventHandler(this.SchemesComboBox_SelectedIndexChanged);
            // 
            // SchemesColorEditorUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.schemesComboBox);
            this.Controls.Add(this.coloursListView);
            this.Name = "SchemesColorEditorUserControl";
            this.Load += new System.EventHandler(this.SchemesColoUrEditorUserControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView coloursListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private KryptonComboBox schemesComboBox;

        #endregion

        private bool _ignoreListViewChanges;
        private bool _ignoreComboBoxChanges = true;
        private IColourScheme[] _cacheFor_ColourSchemes;
        private ListViewItem _needEnsureVisibleListViewItem;

        public SchemesColourEditorUserControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Occurs when the parent needs to update command states.
        /// </summary>
        public event EventHandler NeedUpdateUI;

        /// <summary>
        /// Gets the color of the selected.
        /// </summary>
        /// <value>The color of the selected.</value>
        [Browsable(false)]
        public Color SelectedColour
        {
            get
            {
                if (coloursListView.SelectedItems.Count == 1)
                {
                    return (Color)coloursListView.SelectedItems[0].Tag;
                }
                else
                {
                    return Color.Empty;
                }
            }
            set
            {
                if (!DesignMode)
                {
                    CheckEnsureFilled();

                    // First, look in the currently selected scheme.
                    foreach (ListViewItem listViewItem in coloursListView.Items)
                    {
                        var colour = (Color)listViewItem.Tag;

                        if (colour == value)
                        {
                            coloursListView.SelectedItems.Clear();

                            DoSelectItem(listViewItem);
                            return;
                        }
                    }

                    var selectedSchemeIndex = schemesComboBox.SelectedIndex;

                    // --

                    // Not found, try other schemes.

                    for (var i = 0; i < schemesComboBox.Items.Count; ++i)
                    {
                        if (i != selectedSchemeIndex)
                        {
                            var scheme = (IColourScheme)schemesComboBox.Items[i];

                            foreach (var colour in scheme.Colours)
                            {
                                if (colour == value)
                                {
                                    // Found. Select the scheme, then the color.
                                    schemesComboBox.SelectedItem = scheme;

                                    // Now the colors are filled, select.
                                    foreach (ListViewItem listViewItem in coloursListView.Items)
                                    {
                                        var c = (Color)listViewItem.Tag;

                                        if (c == value)
                                        {
                                            DoSelectItem(listViewItem);
                                            return;
                                        }
                                    }

                                    // Never should reach here.
                                    Debug.Assert(false);
                                }
                            }
                        }
                    }

                    // --

                    // Still not found.
                    coloursListView.SelectedItems.Clear();
                }
            }
        }

        /// <summary>
        /// Does the select item.
        /// </summary>
        /// <param name="listViewItem">The list view item.</param>
        private void DoSelectItem(ListViewItem listViewItem)
        {
            coloursListView.SelectedItems.Clear();

            listViewItem.Selected = true;
            listViewItem.Focused = true;

            listViewItem.EnsureVisible();

            _needEnsureVisibleListViewItem = listViewItem;

            coloursListView.Select();
            coloursListView.Focus();
        }

        /// <summary>
        /// Gets the external provider.
        /// </summary>
        /// <value>The external provider.</value>
        private IExternalColourEditorInformationProvider ExternalColourEditorInformationProvider
        {
            get
            {
                var c = Parent;

                while (c != null && !(c is ColourEditorUserControl))
                {
                    c = c.Parent;
                }

                if (c == null)
                {
                    return null;
                }
                else
                {
                    var ceuc = (ColourEditorUserControl)c;

                    return ceuc.ExternalColourEditorInformationProvider;
                }
            }
        }

        /// <summary>
        /// Gets the color schemes.
        /// </summary>
        /// <value>The color schemes.</value>
        private IColourScheme[] ColourSchemes
        {
            get
            {
                if (_cacheFor_ColourSchemes == null)
                {
                    var informationProvider = ExternalColourEditorInformationProvider;

                    if (informationProvider == null || informationProvider.ColourSchemes == null)
                    {
                        _cacheFor_ColourSchemes = null;
                    }
                    else
                    {
                        _cacheFor_ColourSchemes = informationProvider.ColourSchemes;
                    }
                }

                return _cacheFor_ColourSchemes;
            }
        }

        private void ColoursListView_Click(object sender, EventArgs e)
        {

        }

        private void ColoursListView_DoubleClick(object sender, EventArgs e)
        {

        }

        private void ColoursListView_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void ColoursListView_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = false;
        }

        private void ColoursListView_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            e.DrawDefault = false;

            var color = (Color)e.Item.Tag;

            Brush backgroundBrush;
            Brush textBrush;

            if (e.Item.Selected)
            {
                backgroundBrush = SystemBrushes.Highlight;
                textBrush = SystemBrushes.HighlightText;
            }
            else
            {
                backgroundBrush = SystemBrushes.Window;
                textBrush = SystemBrushes.WindowText;
            }

            e.Graphics.FillRectangle(
                backgroundBrush,
                e.Bounds);

            const int squareDistance = 1;
            var squareWidth = (e.Bounds.Height - 2) * 2 * squareDistance;
            var squareHeight = e.Bounds.Height - 2 * squareDistance;

            var offsetX = e.Bounds.Left + squareDistance;
            var offsetY = e.Bounds.Top + squareDistance;

            var r = new Rectangle(
                offsetX, offsetY,
                squareWidth,
                squareHeight);

            using (Brush brush = new SolidBrush(color))
            {
                e.Graphics.FillRectangle(brush, r);
            }

            var r2 = new Rectangle(
                r.Left, r.Top, r.Width - 1, r.Height - 1);
            var pen = SystemPens.ControlDarkDark;
            e.Graphics.DrawRectangle(pen, r2);

            offsetX += squareWidth + squareDistance * 2;

            var rf = new RectangleF(
                offsetX, e.Bounds.Top,
                e.Bounds.Width - offsetX,
                e.Bounds.Height);

            e.Graphics.DrawString(e.Item.Text, e.Item.Font, textBrush, rf);
        }

        private void ColoursListView_SizeChanged(object sender, EventArgs e)
        {
            coloursListView.Columns[0].Width = coloursListView.ClientSize.Width - 1;
        }

        private void SchemesColoUrEditorUserControl_Load(object sender, EventArgs e)
        {
            CheckEnsureFilled();

            if (_needEnsureVisibleListViewItem != null)
            {
                DoSelectItem(_needEnsureVisibleListViewItem);
            }
            else
            {
                // None selected, restore saved selected index.

                if (ExternalColourEditorInformationProvider != null)
                {
                    schemesComboBox.SelectedIndex = Convert.ToInt32(ExternalColourEditorInformationProvider.RestorePerUserPerWorkstationValue(StoreID + @".SchemesComboBox.SelectedIndex", schemesComboBox.SelectedIndex.ToString()));
                }
            }

            SaveState();
            _ignoreComboBoxChanges = false;

            ColoursListView_SizeChanged(null, null);
        }

        /// <summary>
        /// Gets the store ID.
        /// </summary>
        /// <value>The store ID.</value>
        private string StoreID
        {
            get
            {
                return string.Format(@"{0}.{1}.{2}.{3}", ((ColourEditorUserControl)Parent.Parent.Parent).StoreID, GetType().Name, Name, Text);
            }
        }


        /// <summary>
        /// Handles the SelectedIndexChanged event of the schemesComboBox 
        /// control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance 
        /// containing the event data.</param>
        private void SchemesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_ignoreComboBoxChanges)
            {
                SaveState();
            }

            coloursListView.BeginUpdate();
            _ignoreListViewChanges = true;
            try
            {
                coloursListView.Items.Clear();

                if (schemesComboBox.SelectedItem != null)
                {
                    var colourScheme = (IColourScheme)schemesComboBox.SelectedItem;

                    var schemeColours = colourScheme.Colours;

                    if (schemeColours != null && schemeColours.Length > 0)
                    {
                        var colors = new List<Color>(schemeColours);

                        // --

                        var ep = ExternalColourEditorInformationProvider;

                        foreach (var color in colors)
                        {
                            var displayText = ConvertColourToHtmlColour(color);

                            // Allow externally to reformat.
                            if (ep != null)
                            {
                                ep.FormatDisplayText(
                                    color,
                                    ref displayText);
                            }

                            var lvi =
                                new ListViewItem
                                {
                                    Text = displayText,
                                    Tag = color
                                };

                            coloursListView.Items.Add(lvi);
                        }
                    }
                }

                ColoursListView_SizeChanged(null, null);
            }
            finally
            {
                coloursListView.EndUpdate();
                _ignoreListViewChanges = false;
            }

            if (NeedUpdateUI != null)
            {
                NeedUpdateUI(this, EventArgs.Empty);
            }
        }

        private void SaveState()
        {
            if (ExternalColourEditorInformationProvider != null)
            {
                ExternalColourEditorInformationProvider.SavePerUserPerWorkstationValue(StoreID + @".SchemesComboBox.SelectedIndex", schemesComboBox.SelectedIndex.ToString());
            }
        }

        private void ColoursListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_ignoreListViewChanges)
            {
                if (NeedUpdateUI != null)
                {
                    NeedUpdateUI(this, EventArgs.Empty);
                }
            }
        }

        public bool ContainsColour(Color value)
        {
            var schemes = ColourSchemes;

            if (schemes != null)
            {
                foreach (var colourScheme in ColourSchemes)
                {
                    foreach (var colour in colourScheme.Colours)
                    {
                        if (colour == value)
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        private void CheckEnsureFilled()
        {
            var schemes = ColourSchemes;

            if (schemes != null)
            {
                if (schemesComboBox.Items.Count <= 0)
                {
                    schemesComboBox.DisplayMember = @"Name";
                    schemesComboBox.Items.AddRange(schemes);

                    if (schemesComboBox.Items.Count > 0)
                    {
                        schemesComboBox.SelectedIndex = 0;
                    }
                }
            }
        }

        #region Color methods.
        // ------------------------------------------------------------------

        public static bool IsNamedHtmlColour(Color colour)
        {
            return colour == Color.Transparent || KnownColourValues.ContainsKey(colour);
        }

        public static string GetNamedHtmlColour(Color colour)
        {
            if (colour == Color.Transparent)
            {
                return @"transparent";
            }
            else
            {
                if (IsNamedHtmlColour(colour))
                {
                    return KnownColourValues[colour];
                }
                else
                {
                    return ConvertColourToHtmlColour(colour);
                }
            }
        }

        /// <summary>
        /// Converts the color to a HTML color.
        /// </summary>
        /// <param name="colour">The color.</param>
        /// <returns>Returns a format "#RRGGBB".</returns>
        public static string ConvertColourToHtmlColour(Color colour)
        {
            if (colour == Color.Transparent)
            {
                return @"transparent";
            }
            else if (KnownColourValues.ContainsKey(colour))
            {
                return KnownColourValues[colour];
            }
            else
            {
                // Not found or non-matching.
                return @"#" + colour.R.ToString(@"X2") + colour.G.ToString(@"X2") + colour.B.ToString(@"X2");
            }
        }

        private static Dictionary<string, Color> _knownColourNames;
        private static Dictionary<Color, string> _knownColourValues;

        private static Dictionary<string, Color> KnownColourNames
        {
            get
            {
                if (_knownColourNames == null)
                {
                    _knownColourNames = new Dictionary<string, Color>();

                    _knownColourNames[@"aqua"] = Color.Aqua;
                    _knownColourNames[@"black"] = Color.Black;
                    _knownColourNames[@"blue"] = Color.Blue;
                    _knownColourNames[@"fuchsia"] = Color.Fuchsia;
                    _knownColourNames[@"gray"] = Color.Gray;
                    _knownColourNames[@"green"] = Color.Green;
                    _knownColourNames[@"lime"] = Color.Lime;
                    _knownColourNames[@"maroon"] = Color.Maroon;
                    _knownColourNames[@"navy"] = Color.Navy;
                    _knownColourNames[@"olive"] = Color.Olive;
                    _knownColourNames[@"orange"] = Color.Orange;
                    _knownColourNames[@"purple"] = Color.Purple;
                    _knownColourNames[@"red"] = Color.Red;
                    _knownColourNames[@"silver"] = Color.Silver;
                    _knownColourNames[@"teal"] = Color.Teal;
                    _knownColourNames[@"white"] = Color.White;
                    _knownColourNames[@"yellow"] = Color.Yellow;

                    // The reverse lookup.
                    _knownColourValues = new Dictionary<Color, string>();

                    foreach (var pair in _knownColourNames)
                    {
                        _knownColourValues[pair.Value] = pair.Key;
                    }
                }

                return _knownColourNames;
            }
        }

        private static Dictionary<Color, string> KnownColourValues
        {
            get
            {
                if (_knownColourValues == null)
                {
                    // Just access once.
                    var n = KnownColourNames;
                    Debug.Assert(n != null);
                }

                return _knownColourValues;
            }
        }

        /// <summary>
        /// Converts a HTML color to a color structure.
        /// </summary>
        /// <param name="htmlColour">the HTML color.</param>
        /// <returns>Returns the color structure.</returns>
        public static Color? ConvertHtmlColourToColour(string htmlColour)
        {
            if (string.IsNullOrEmpty(htmlColour))
            {
                return null;
            }
            else if (htmlColour == @"transparent")
            {
                return Color.Transparent;
            }
            else if (KnownColourNames.ContainsKey(htmlColour))
            {
                return KnownColourNames[htmlColour];
            }
            else
            {
                htmlColour = htmlColour.Trim().Trim('#').Trim();

                if (htmlColour.Length != 6)
                {
                    return null;
                }
                else
                {
                    var r = Convert.ToInt32(htmlColour.Substring(0, 2), 16);
                    var g = Convert.ToInt32(htmlColour.Substring(2, 2), 16);
                    var b = Convert.ToInt32(htmlColour.Substring(4, 2), 16);

                    return Color.FromArgb(r, g, b);
                }
            }
        }

        /// <summary>
        /// Gets the color of the complementary.
        /// </summary>
        /// <param name="colour">The color.</param>
        /// <returns></returns>
        /// <remarks>
        /// http://www.markus-keppeler.de/programme/komplement/
        /// </remarks>
        public static Color GetComplementaryColour(Color colour)
        {
            return Color.FromArgb(255 - colour.R, 255 - colour.G, 255 - colour.B);
        }

        // ------------------------------------------------------------------
        #endregion
    }
}