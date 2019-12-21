#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using ComponentFactory.Krypton.Toolkit;

namespace ExtendedDialogs.Dialogs.IO.Old
{
    public class KryptonInputBoxExtendedTest : KryptonForm
    {
        private Controls.UserControls.KryptonInputBoxExtended kryptonInputBoxExtended1;

        private void InitializeComponent()
        {
            this.kryptonInputBoxExtended1 = new ExtendedDialogs.Controls.UserControls.KryptonInputBoxExtended();
            this.SuspendLayout();
            // 
            // kryptonInputBoxExtended1
            // 
            this.kryptonInputBoxExtended1.AbortText = null;
            this.kryptonInputBoxExtended1.BackColor = System.Drawing.Color.Transparent;
            this.kryptonInputBoxExtended1.CancelText = null;
            this.kryptonInputBoxExtended1.ControlTypeface = null;
            this.kryptonInputBoxExtended1.CustomIcon = null;
            this.kryptonInputBoxExtended1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonInputBoxExtended1.HintText = null;
            this.kryptonInputBoxExtended1.InputBoxButtons = ExtendedDialogs.Enumerations.InputBoxButtons.OK;
            this.kryptonInputBoxExtended1.InputBoxIcon = ExtendedDialogs.Enumerations.InputBoxIcon.CUSTOM;
            this.kryptonInputBoxExtended1.InputBoxIconImageSize = ExtendedDialogs.Enumerations.InputBoxIconImageSize.CUSTOM;
            this.kryptonInputBoxExtended1.InputBoxMessageRightToLeft = ExtendedDialogs.Enumerations.InputBoxMessageRightToLeft.NO;
            this.kryptonInputBoxExtended1.InputBoxType = ExtendedDialogs.Enumerations.InputBoxType.COMBOBOX;
            this.kryptonInputBoxExtended1.ItemList = null;
            this.kryptonInputBoxExtended1.Language = ExtendedDialogs.Enumerations.Language.CZECH;
            this.kryptonInputBoxExtended1.Location = new System.Drawing.Point(0, 0);
            this.kryptonInputBoxExtended1.MessageText = null;
            this.kryptonInputBoxExtended1.MessageTextAlignment = ExtendedDialogs.Enumerations.InputBoxMessageTextAlignment.LEFT;
            this.kryptonInputBoxExtended1.MessageTypeface = null;
            this.kryptonInputBoxExtended1.Name = "kryptonInputBoxExtended1";
            this.kryptonInputBoxExtended1.NoText = null;
            this.kryptonInputBoxExtended1.OkText = null;
            this.kryptonInputBoxExtended1.Size = new System.Drawing.Size(580, 265);
            this.kryptonInputBoxExtended1.TabIndex = 0;
            this.kryptonInputBoxExtended1.UserInputTextAlignment = PaletteRelativeAlign.Near;
            this.kryptonInputBoxExtended1.UserSelectionTextAlignment = PaletteRelativeAlign.Near;
            this.kryptonInputBoxExtended1.YesText = null;
            // 
            // KryptonInputBoxExtendedTest
            // 
            this.ClientSize = new System.Drawing.Size(580, 265);
            this.Controls.Add(this.kryptonInputBoxExtended1);
            this.Name = "KryptonInputBoxExtendedTest";
            this.ResumeLayout(false);

        }
    }
}