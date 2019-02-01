using ComponentFactory.Krypton.Toolkit;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.Controls.KryptonControls
{
    /// <summary>
    /// Provide a ComboBox with Krypton styling applied. 
    /// Credits to Ricardo Francisco - http://cid-a2733fd867b9e919.profile.live.com/
    /// </summary>
    [ToolboxItem(true)]
    [System.Drawing.ToolboxBitmapAttribute(typeof(System.Windows.Forms.ComboBox))]
    [DefaultEvent("SelectedIndexChanged")]
    [DefaultProperty("Text")]
    [DefaultBindingProperty("Text")]
    [LookupBindingProperties("DataSource", "DisplayMember", "ValueMember", "SelectedValue")]
    [DesignerCategory("code")]
    [Description("Displays an editable textbox with a drop-down list of permitted values.")]
    [ClassInterface(ClassInterfaceType.AutoDispatch)]
    [ComVisible(true)]
    public class KryptonImageComboBox : ComponentFactory.Krypton.Toolkit.KryptonComboBox
    {

        public KryptonImageComboBox()
            : base()
        {
            this.ComboBox.DrawItem += new DrawItemEventHandler(OnDrawItem);
        }

        protected void OnDrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0)
                return;

            if ((e.State & DrawItemState.ComboBoxEdit) == DrawItemState.ComboBoxEdit && this.Items[e.Index] is KryptonListItem)
            {
                // Always get base implementation to draw the background
                e.DrawBackground();

                // Find correct text color
                Color textColor = this.ComboBox.ForeColor;
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                    textColor = SystemColors.HighlightText;

                // Find correct background color
                Color backColor = this.ComboBox.BackColor;
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                    backColor = SystemColors.Highlight;

                Image image = ((KryptonListItem)this.Items[e.Index]).Image;

                Rectangle textRectangle = textRectangle = new Rectangle(e.Bounds.X + 19, e.Bounds.Y, e.Bounds.Width - 19, e.Bounds.Height);

                // Is there an item to draw
                if (e.Index >= 0)
                {
                    // Set the correct text rendering hint for the text drawing. We only draw if the edit text is enabled so we
                    // just always grab the normal state value. Without this line the wrong hint can occur because it inherits
                    // it from the device context. Resulting in blurred text.
                    e.Graphics.TextRenderingHint = CommonHelper.PaletteTextHintToRenderingHint(StateNormal.ComboBox.PaletteContent.GetContentShortTextHint(PaletteState.Normal));

                    // Draw text using font defined by the control
                    TextRenderer.DrawText(e.Graphics,
                                          this.ComboBox.Text, this.ComboBox.Font,
                                          textRectangle,
                                          textColor, backColor,
                                          TextFormatFlags.TextBoxControl |
                                          TextFormatFlags.NoPadding);
                    if (image != null)
                        e.Graphics.DrawImage(image, new Rectangle(3, 3, 16, 16));
                }
            }
        }

    }
}