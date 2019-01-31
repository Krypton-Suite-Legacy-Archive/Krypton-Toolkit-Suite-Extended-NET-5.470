using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.Controls
{
    [ComVisible(false)]
    [ClassInterfaceAttribute(ClassInterfaceType.AutoDispatch)]
    public partial class ExtendedKryptonLinkLabel : KryptonLinkLabel, IButtonControl
    {
        public DialogResult DialogResult { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void NotifyDefault(bool value)
        {
            throw new NotImplementedException();
        }

        public void PerformClick()
        {
            throw new NotImplementedException();
        }
    }
}