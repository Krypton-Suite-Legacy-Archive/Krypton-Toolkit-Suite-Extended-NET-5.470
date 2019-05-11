#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using ExtendedControls.Enumerations;
using ExtendedControls.ExtendedToolkit.UI.Colours;
using ExtendedControls.Interfaces.Colours;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.Controls.Colours
{
    public partial class ColourEditorUserControl : UserControl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColourEditorUserControl));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.customColoursTabPage = new System.Windows.Forms.TabPage();
            this.customColourEditorControl = new CustomColourEditorUserControl();
            this.webColoursTabPage = new System.Windows.Forms.TabPage();
            this.webColourEditorControl = new WebColourEditorUserControl();
            this.browserSafeColoursTabPage = new System.Windows.Forms.TabPage();
            this.browserSafeColourEditorControl = new BrowserSafeColourEditorUserControl();
            this.systemColoursTabPage = new System.Windows.Forms.TabPage();
            this.systemColourEditorControl = new SystemColourEditorUserControl();
            this.schemeColoursTabPage = new System.Windows.Forms.TabPage();
            this.schemesColourEditorControl = new SchemesColourEditorUserControl();
            this.tabPagesImageList = new System.Windows.Forms.ImageList(this.components);
            this.tabControl.SuspendLayout();
            this.customColoursTabPage.SuspendLayout();
            this.webColoursTabPage.SuspendLayout();
            this.browserSafeColoursTabPage.SuspendLayout();
            this.systemColoursTabPage.SuspendLayout();
            this.schemeColoursTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            resources.ApplyResources(this.tabControl, "tabControl");
            this.tabControl.Controls.Add(this.customColoursTabPage);
            this.tabControl.Controls.Add(this.webColoursTabPage);
            this.tabControl.Controls.Add(this.browserSafeColoursTabPage);
            this.tabControl.Controls.Add(this.systemColoursTabPage);
            this.tabControl.Controls.Add(this.schemeColoursTabPage);
            this.tabControl.ImageList = this.tabPagesImageList;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.TabControl_SelectedIndexChanged);
            // 
            // customColorsTabPage
            // 
            this.customColoursTabPage.Controls.Add(this.customColourEditorControl);
            resources.ApplyResources(this.customColoursTabPage, "customColorsTabPage");
            this.customColoursTabPage.Name = "customColorsTabPage";
            this.customColoursTabPage.UseVisualStyleBackColor = true;
            // 
            // customColourEditorControl
            // 
            resources.ApplyResources(this.customColourEditorControl, "customColourEditorControl");
            this.customColourEditorControl.Name = "customColourEditorControl";
            this.customColourEditorControl.SelectedColour = System.Drawing.Color.Empty;
            this.customColourEditorControl.NeedUpdateUI += new System.EventHandler(this.CustomColourEditorControl_NeedUpdateUI);
            // 
            // webColorsTabPage
            // 
            this.webColoursTabPage.Controls.Add(this.webColourEditorControl);
            resources.ApplyResources(this.webColoursTabPage, "webColoursTabPage");
            this.webColoursTabPage.Name = "webColoursTabPage";
            this.webColoursTabPage.UseVisualStyleBackColor = true;
            // 
            // webColourEditorControl
            // 
            resources.ApplyResources(this.webColourEditorControl, "webColourEditorControl");
            this.webColourEditorControl.Name = "webColourEditorControl";
            this.webColourEditorControl.SelectedColour = System.Drawing.Color.Empty;
            this.webColourEditorControl.NeedUpdateUI += new System.EventHandler(this.WebColourEditorControl_NeedUpdateUI);
            // 
            // browserSafeColorsTabPage
            // 
            this.browserSafeColoursTabPage.Controls.Add(this.browserSafeColourEditorControl);
            resources.ApplyResources(this.browserSafeColoursTabPage, "browserSafeColoursTabPage");
            this.browserSafeColoursTabPage.Name = "browserSafeColoursTabPage";
            this.browserSafeColoursTabPage.UseVisualStyleBackColor = true;
            // 
            // browserSafeColourEditorControl
            // 
            resources.ApplyResources(this.browserSafeColourEditorControl, "browserSafeColourEditorControl");
            this.browserSafeColourEditorControl.Name = "browserSafeColourEditorControl";
            this.browserSafeColourEditorControl.SelectedColour = System.Drawing.Color.Empty;
            this.browserSafeColourEditorControl.NeedUpdateUI += new System.EventHandler(this.BrowserSafeColourEditorControl_NeedUpdateUI);
            // 
            // systemColorsTabPage
            // 
            this.systemColoursTabPage.Controls.Add(this.systemColourEditorControl);
            resources.ApplyResources(this.systemColoursTabPage, "systemColorsTabPage");
            this.systemColoursTabPage.Name = "systemColorsTabPage";
            this.systemColoursTabPage.UseVisualStyleBackColor = true;
            // 
            // systemColourEditorControl
            // 
            resources.ApplyResources(this.systemColourEditorControl, "systemColourEditorControl");
            this.systemColourEditorControl.Name = "systemColourEditorControl";
            this.systemColourEditorControl.SelectedColour = System.Drawing.Color.Empty;
            this.systemColourEditorControl.NeedUpdateUI += new System.EventHandler(this.SystemColourEditorControl_NeedUpdateUI);
            // 
            // schemeColorsTabPage
            // 
            this.schemeColoursTabPage.Controls.Add(this.schemesColourEditorControl);
            resources.ApplyResources(this.schemeColoursTabPage, "schemeColoursTabPage");
            this.schemeColoursTabPage.Name = "schemeColoursTabPage";
            this.schemeColoursTabPage.UseVisualStyleBackColor = true;
            // 
            // schemesColourEditorControl
            // 
            resources.ApplyResources(this.schemesColourEditorControl, "schemesColourEditorControl");
            this.schemesColourEditorControl.Name = "schemesColourEditorControl";
            this.schemesColourEditorControl.SelectedColour = System.Drawing.Color.Empty;
            this.schemesColourEditorControl.NeedUpdateUI += new System.EventHandler(this.SchemesColourEditorControl_NeedUpdateUI);
            // 
            // tabPagesImageList
            // 
            this.tabPagesImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("tabPagesImageList.ImageStream")));
            this.tabPagesImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.tabPagesImageList.Images.SetKeyName(0, "colorwheel.png");
            this.tabPagesImageList.Images.SetKeyName(1, "brush1.png");
            this.tabPagesImageList.Images.SetKeyName(2, "window_colors.png");
            this.tabPagesImageList.Images.SetKeyName(3, "monitor_rgb.png");
            this.tabPagesImageList.Images.SetKeyName(4, "earth.png");
            // 
            // ColorEditorUserControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl);
            this.MinimumSize = new System.Drawing.Size(442, 398);
            this.Name = "ColourEditorUserControl";
            this.Load += new System.EventHandler(this.ColourEditorUserControl_Load);
            this.tabControl.ResumeLayout(false);
            this.customColoursTabPage.ResumeLayout(false);
            this.webColoursTabPage.ResumeLayout(false);
            this.browserSafeColoursTabPage.ResumeLayout(false);
            this.systemColoursTabPage.ResumeLayout(false);
            this.schemeColoursTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage customColoursTabPage;
        private System.Windows.Forms.TabPage webColoursTabPage;
        private System.Windows.Forms.TabPage systemColoursTabPage;
        private System.Windows.Forms.TabPage schemeColoursTabPage;
        private System.Windows.Forms.ImageList tabPagesImageList;
        private CustomColourEditorUserControl customColourEditorControl;
        private WebColourEditorUserControl webColourEditorControl;
        private SystemColourEditorUserControl systemColourEditorControl;
        private SchemesColourEditorUserControl schemesColourEditorControl;
        private System.Windows.Forms.TabPage browserSafeColoursTabPage;
        private BrowserSafeColourEditorUserControl browserSafeColourEditorControl;

        #endregion

        private bool _tabSet;

        /// <summary>
        /// Initializes a new instance of the 
        /// <see cref="ColourEditorUserControl"/> class.
        /// </summary>
        public ColourEditorUserControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Occurs when the parent needs to update command states.
        /// </summary>
        public event EventHandler NeedUpdateUI;

        /// <summary>
        /// Gets or sets the external provider.
        /// </summary>
        /// <value>The external provider.</value>
        [Browsable(false)]
        public IExternalColourEditorInformationProvider ExternalColourEditorInformationProvider
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the selected color.
        /// </summary>
        /// <value>The color of the selected.</value>
        [Browsable(false)]
        public Color SelectedColour
        {
            get
            {
                if (DesignMode)
                {
                    return Color.Empty;
                }
                else
                {
                    if (tabControl.SelectedTab == customColoursTabPage)
                    {
                        return customColourEditorControl.SelectedColour;
                    }
                    else if (tabControl.SelectedTab == browserSafeColoursTabPage)
                    {
                        return browserSafeColourEditorControl.SelectedColour;
                    }
                    else if (tabControl.SelectedTab == webColoursTabPage)
                    {
                        return webColourEditorControl.SelectedColour;
                    }
                    else if (tabControl.SelectedTab == systemColoursTabPage)
                    {
                        return systemColourEditorControl.SelectedColour;
                    }
                    else if (tabControl.SelectedTab == schemeColoursTabPage)
                    {
                        return schemesColourEditorControl.SelectedColour;
                    }
                    else
                    {
                        Debug.Assert(false);
                        return Color.Empty;
                    }
                }
            }
            set
            {
                if (!DesignMode)
                {
                    customColourEditorControl.SelectedColour = value;
                    webColourEditorControl.SelectedColour = value;
                    browserSafeColourEditorControl.SelectedColour = value;
                    systemColourEditorControl.SelectedColour = value;
                    schemesColourEditorControl.SelectedColour = value;

                    TryToSetCorrectTabPage(value);
                }
            }
        }

        private static readonly ColourLookupElement[] _defaultLookupOrder =
            new[]
            {
                ColourLookupElement.BROWSERSAFECOLOURS,
                ColourLookupElement.WEBCOLOURS,
                ColourLookupElement.SYSTEMCOLOURS,
                ColourLookupElement.SCHEMECOLOURS,
                ColourLookupElement.CUSTOMCOLOURS
            };

        /// <summary>
        /// Tries to set correct tab page.
        /// </summary>
        private void TryToSetCorrectTabPage(Color colour)
        {
            TabPage tabPage = null;

            if (colour == Color.Empty)
            {
                colour = Color.Transparent;
            }


            if (colour == Color.Transparent)
            {
                if (webColourEditorControl.ContainsColor(colour))
                {
                    tabPage = webColoursTabPage;
                }
            }
            else
            {
                var lookupOrder = new List<ColourLookupElement>(_defaultLookupOrder);

                if (ExternalColourEditorInformationProvider != null)
                {
                    ExternalColourEditorInformationProvider.AdjustColourSettingLookupOrder(
                        lookupOrder);

                    // Add again to be safe if the call should have removed some.
                    lookupOrder.AddRange(_defaultLookupOrder);
                }

                // --

                foreach (var element in lookupOrder)
                {
                    switch (element)
                    {
                        case ColourLookupElement.BROWSERSAFECOLOURS:
                            if (browserSafeColourEditorControl.ContainsColour(colour))
                            {
                                tabPage = browserSafeColoursTabPage;
                            }
                            break;

                        default:
                            tabPage = customColoursTabPage;
                            break;

                        case ColourLookupElement.SCHEMECOLOURS:
                            if (AllowColourSchemes &&
                                schemesColourEditorControl.ContainsColour(colour))
                            {
                                tabPage = schemeColoursTabPage;
                            }
                            break;

                        case ColourLookupElement.SYSTEMCOLOURS:
                            if (systemColourEditorControl.ContainsColour(colour))
                            {
                                tabPage = systemColoursTabPage;
                            }
                            break;

                        case ColourLookupElement.WEBCOLOURS:
                            if (webColourEditorControl.ContainsColor(colour))
                            {
                                tabPage = webColoursTabPage;
                            }
                            break;
                    }

                    if (tabPage != null)
                    {
                        break;
                    }
                }
            }

            if (tabPage == null)
            {
                tabPage = customColoursTabPage;
            }


            tabControl.SelectedTab = tabPage;
            _tabSet = true;
        }

        /// <summary>
        /// Gets the store ID.
        /// </summary>
        /// <value>The store ID.</value>
        internal string StoreID
        {
            get
            {
                return string.Format(@"{0}.{1}.{2}.{3}", ((ColourEditorForm)Parent).StoreID, GetType().Name, Name, Text);
            }
        }

        /// <summary>
        /// Gets a value indicating whether [allow color schemes].
        /// </summary>
        /// <value><c>true</c> if [allow color schemes]; otherwise, <c>false</c>.</value>
        private bool AllowColourSchemes
        {
            get
            {
                if (ExternalColourEditorInformationProvider == null)
                {
                    return false;
                }
                else
                {
                    var colourSchemes =
                        ExternalColourEditorInformationProvider.ColourSchemes;

                    if (colourSchemes == null || colourSchemes.Length <= 0)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
        }

        /// <summary>
        /// Handles the Load event of the <see cref="ColourEditorUserControl"/> control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void ColourEditorUserControl_Load(
            object sender,
            EventArgs e)
        {
            if (ExternalColourEditorInformationProvider != null && !_tabSet)
            {
                tabControl.SelectedIndex = Convert.ToInt32(
                    ExternalColourEditorInformationProvider.RestorePerUserPerWorkstationValue(
                        StoreID + @".TabControl.SelectedIndex",
                        tabControl.SelectedIndex.ToString()));
            }

            if (!AllowColourSchemes)
            {
                tabControl.TabPages.Remove(schemeColoursTabPage);
            }
        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ExternalColourEditorInformationProvider != null)
            {
                ExternalColourEditorInformationProvider.SavePerUserPerWorkstationValue(
                    StoreID + @".TabControl.SelectedIndex",
                    tabControl.SelectedIndex.ToString());
            }

            if (NeedUpdateUI != null)
            {
                NeedUpdateUI(this, EventArgs.Empty);
            }
        }

        private void CustomColourEditorControl_NeedUpdateUI(object sender, EventArgs e)
        {
            if (NeedUpdateUI != null)
            {
                NeedUpdateUI(this, EventArgs.Empty);
            }
        }

        private void SystemColourEditorControl_NeedUpdateUI(object sender, EventArgs e)
        {
            // Redirect.
            CustomColourEditorControl_NeedUpdateUI(null, null);
        }

        private void SchemesColourEditorControl_NeedUpdateUI(object sender, EventArgs e)
        {
            // Redirect.
            CustomColourEditorControl_NeedUpdateUI(null, null);
        }

        private void WebColourEditorControl_NeedUpdateUI(object sender, EventArgs e)
        {
            // Redirect.
            CustomColourEditorControl_NeedUpdateUI(null, null);
        }

        private void BrowserSafeColourEditorControl_NeedUpdateUI(object sender, EventArgs e)
        {
            // Redirect.
            CustomColourEditorControl_NeedUpdateUI(null, null);
        }
    }
}