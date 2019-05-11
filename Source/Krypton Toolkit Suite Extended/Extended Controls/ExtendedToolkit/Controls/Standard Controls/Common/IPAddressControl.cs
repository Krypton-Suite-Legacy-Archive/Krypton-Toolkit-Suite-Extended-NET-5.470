#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.Controls.StandardControls.Common
{
    [System.Drawing.ToolboxBitmap(typeof(MaskedTextBox)), ToolboxItem(false)]
    public partial class IPAddressControl : MaskedTextBox
    {
        #region Designer Code
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected new void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ResumeLayout(false);

        }

        #endregion
        #endregion

        private char[] _octetSplitter = new char[] { '.' };
        private Int32 _spaceForEachOctet;
        private ErrorProvider _errorProvider;
        private enum ConvertDirection { AddWhitespace, RemoveWhitespace };


        /// <summary> The IP address </summary>
        public override string Text
        {
            set { base.Text = convert(ConvertDirection.AddWhitespace, value); }
            get { return convert(ConvertDirection.RemoveWhitespace, base.Text); }
        }

        public IPAddressControl()
        {
            base.ForeColor = System.Drawing.Color.Black;
            base.Mask = " 099 . 099 . 099 . 099 ";
            base.PromptChar = ' ';
            base.Text = "127.  0.  0.  1";

            this.Size = new System.Drawing.Size(180, 20);
            this.KeyPress += new KeyPressEventHandler(IPAddressControl_KeyPress);   // Used to advance the cursor inside the MTB
            this.LostFocus += new EventHandler(IPAddressControl_LostFocus); // Used for validation 

            _spaceForEachOctet = base.Text.IndexOf('.') + 1;  // Dependent on the MASK you set above

            _errorProvider = new System.Windows.Forms.ErrorProvider();
            _errorProvider.SetIconAlignment(this, ErrorIconAlignment.MiddleLeft);
        }

        private void IPAddressControl_LostFocus(object sender, EventArgs e)
        {
            //
            //  validate each octet
            //
            foreach (string curOctet in this.Text.Split(_octetSplitter))
            {
                try
                {
                    Int32 iVal = Int32.Parse(curOctet);

                    if (iVal < 0 || iVal > 254)
                    {
                        _errorProvider.SetError(this, "Invalid IP address specified!");
                        return;
                    }
                }
                catch
                {
                    _errorProvider.SetError(this, "Invalid IP address specified!");
                    return;
                }
            }

            _errorProvider.Clear();  // No errors with any of the ip address
        }

        private void IPAddressControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '.' && e.KeyChar != '\t')   // Only advance if the period key or Tab key is pressed
                return;

            //
            //  Move to the next octet
            //
            Int32 curOctetIndex = this.SelectionStart / _spaceForEachOctet;
            this.Select((curOctetIndex + 1) * _spaceForEachOctet, 0);
        }

        /// <summary>
        /// Converts a string from the 'pretty' spaced version to a tight no-whitespaced version (and vice versa)
        /// </summary>
        /// <param name="dir">Add or remove the whitespace</param>
        /// <param name="ipToConvert">The string you want to convert</param>
        /// <returns>Converted string</returns>
        private string convert(ConvertDirection dir, string ipToConvert)
        {
            if (ipToConvert == null)
                return "";

            string[] ip = ipToConvert.Split(_octetSplitter);
            string finalIP = "";

            try
            {
                if (dir == ConvertDirection.AddWhitespace)  // Add whitespace when you're setting pushing an IP against the mask
                {
                    for (int i = 0; i < _spaceForEachOctet - 2; i++)
                        finalIP += ip[i].PadLeft(_spaceForEachOctet - 2, ' ');
                }
                else
                {
                    for (int i = 0; i < ip.Length; i++)     // Remove whitespace when you're exposing the IP to external classes
                        finalIP += ip[i].Trim() + ".";

                    finalIP = finalIP.Length > 0 ? finalIP.Substring(0, finalIP.Length - 1) : finalIP; // Get rid of the last period (when applicable)
                }
            }
            catch
            {
            }

            return finalIP;
        }

    }
}