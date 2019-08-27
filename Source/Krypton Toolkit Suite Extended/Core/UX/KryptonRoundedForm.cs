using ComponentFactory.Krypton.Toolkit;
using System.ComponentModel;
using System.Windows.Forms;

namespace KryptonToolkitSuiteExtendedCore
{
    [Category("code"), Description("A standard KryptonForm with rounded corners.")]
    public class KryptonRoundedForm : KryptonForm
    {
        #region Variables
        private int _cornerRadius;
        #endregion

        #region Properties
        [Category("Appearance"), DefaultValue(25), Description("Size of corner radius. (-1 is the 'default system look' value)")]
        public int CornerRadius { get => _cornerRadius; set { _cornerRadius = value; Invalidate(); } }
        #endregion

        #region Constructor
        public KryptonRoundedForm()
        {
            CornerRadius = 25;

            StateCommon.Border.Rounding = CornerRadius;
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