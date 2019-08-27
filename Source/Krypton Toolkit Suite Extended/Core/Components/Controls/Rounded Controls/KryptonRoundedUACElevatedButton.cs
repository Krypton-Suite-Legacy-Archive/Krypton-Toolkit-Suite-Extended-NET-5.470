using KryptonToolkitSuiteExtendedCore.Components;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KryptonToolkitSuiteExtendedCore
{
    [ToolboxBitmap(typeof(KryptonUACElevatedButton))]
    public class KryptonRoundedUACElevatedButton : KryptonUACElevatedButton
    {
        #region Variables
        private int _cornerRadius;
        #endregion

        #region Properties
        public int CornerRadius { get => _cornerRadius; set { _cornerRadius = value; Invalidate(); } }
        #endregion

        #region Constructor
        public KryptonRoundedUACElevatedButton()
        {
            CornerRadius = 10;
        }
        #endregion

        #region Override
        protected override void OnPaint(PaintEventArgs e)
        {
            StateCommon.Border.Rounding = CornerRadius;

            base.OnPaint(e);
        }
        #endregion
    }
}