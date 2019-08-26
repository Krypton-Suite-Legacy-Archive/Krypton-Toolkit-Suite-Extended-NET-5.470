using ComponentFactory.Krypton.Toolkit;
using System;

namespace KryptonSparkle.UX
{
    public class KryptonSparkleMainWindows : KryptonForm, IDisposable
    {
        private KryptonPanel kryptonPanel1;
        private ExtendedStandardControls.KryptonLabelExtended kryptonLabelExtended1;
        private KryptonListBox klstActions;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KryptonSparkleMainWindows));
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.klstActions = new ComponentFactory.Krypton.Toolkit.KryptonListBox();
            this.kryptonLabelExtended1 = new ExtendedStandardControls.KryptonLabelExtended();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonLabelExtended1);
            this.kryptonPanel1.Controls.Add(this.klstActions);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(527, 351);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // klstActions
            // 
            this.klstActions.Location = new System.Drawing.Point(12, 48);
            this.klstActions.Name = "klstActions";
            this.klstActions.Size = new System.Drawing.Size(503, 291);
            this.klstActions.TabIndex = 1;
            // 
            // kryptonLabelExtended1
            // 
            this.kryptonLabelExtended1.Image = null;
            this.kryptonLabelExtended1.Location = new System.Drawing.Point(12, 12);
            this.kryptonLabelExtended1.LongTextTypeface = null;
            this.kryptonLabelExtended1.Name = "kryptonLabelExtended1";
            this.kryptonLabelExtended1.ShortTextTypeface = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabelExtended1.Size = new System.Drawing.Size(305, 21);
            this.kryptonLabelExtended1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabelExtended1.TabIndex = 1;
            this.kryptonLabelExtended1.TextColourOne = System.Drawing.Color.Empty;
            this.kryptonLabelExtended1.TextColourTwo = System.Drawing.Color.Empty;
            this.kryptonLabelExtended1.Values.Text = "KryptonSparkle - Background Activity Monitor";
            // 
            // KryptonSparkleMainWindows
            // 
            this.ClientSize = new System.Drawing.Size(527, 351);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KryptonSparkleMainWindows";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Software Update - Debug Window";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        /// <summary>
        /// Reports a message
        /// </summary>
        /// <param name="message">the message</param>
        public void Report(String message)
        {
            if (klstActions.InvokeRequired)
                klstActions.Invoke(new Action<String>(Report), message);
            else
            {
                // build the message 
                DateTime c = DateTime.Now;
                String msg = "[" + c.ToLongTimeString() + "." + c.Millisecond + "] " + message;

                // report the message into ui
                klstActions.Items.Add(msg);
            }
        }
        #region IDisposable Members

        void IDisposable.Dispose()
        {
            // close the base
            Dispose();
        }
        #endregion
    }
}