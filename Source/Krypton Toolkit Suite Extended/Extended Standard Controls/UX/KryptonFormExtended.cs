using ComponentFactory.Krypton.Toolkit;
using System.ComponentModel;
using System.Windows.Forms;

namespace ExtendedStandardControls
{
    public class KryptonFormExtended : KryptonForm
    {
        #region Variables
        private int _cornerRoundingRadius;
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the corner rounding radius.
        /// </summary>
        /// <value>
        /// The corner rounding radius.
        /// </value>
        [DefaultValue(-1), Description("Defines the corner roundness on the current window (-1 is the default look).")]
        public int CornerRoundingRadius { get => _cornerRoundingRadius; set { _cornerRoundingRadius = value; Invalidate(); } }
        #endregion

        #region Constructor
        public KryptonFormExtended()
        {
            CornerRoundingRadius = -1;


            UpdateCornerRoundingRadius(CornerRoundingRadius);
        }
        #endregion

        #region Methods
        private void UpdateCornerRoundingRadius(int roundnessValue) => StateCommon.Border.Rounding = roundnessValue;
        #endregion

        #region Override
        protected override void OnPaint(PaintEventArgs e)
        {

            UpdateCornerRoundingRadius(CornerRoundingRadius);

            base.OnPaint(e);
        }
        #endregion
    }
}