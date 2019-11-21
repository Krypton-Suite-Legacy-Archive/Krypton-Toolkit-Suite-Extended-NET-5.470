#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using ComponentFactory.Krypton.Toolkit;
using System;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.Controls
{
    public partial class KryptonExtendedNumericUpDownControl : KryptonNumericUpDown
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
            this.tmrChamge = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // changeTimer
            // 
            this.tmrChamge.Interval = 300;
            this.tmrChamge.Tick += new System.EventHandler(this.Change_Tick);
            // 
            // ExtendedNumericUpDownControl
            // 
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KryptonExtendedNumericUpDownControl_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrChamge;
        #endregion

        public KryptonExtendedNumericUpDownControl()
        {
            InitializeComponent();
        }

        private void Change_Tick(object sender, EventArgs e)
        {

        }

        private void KryptonExtendedNumericUpDownControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9)
            {
                OnValueChanged(EventArgs.Empty);
            }
        }

    }
}