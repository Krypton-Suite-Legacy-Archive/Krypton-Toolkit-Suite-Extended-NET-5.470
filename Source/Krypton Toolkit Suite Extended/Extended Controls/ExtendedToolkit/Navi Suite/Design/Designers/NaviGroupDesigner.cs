#region License and Copyright
/*
 
Copyright (c) Guifreaks - Jacob Mesu
All rights reserved.

Redistribution and use in source and binary forms, with or without
modification, are permitted provided that the following conditions are met:
    * Redistributions of source code must retain the above copyright
      notice, this list of conditions and the following disclaimer.
    * Redistributions in binary form must reproduce the above copyright
      notice, this list of conditions and the following disclaimer in the
      documentation and/or other materials provided with the distribution.
    * Neither the name of the Guifreaks nor the
      names of its contributors may be used to endorse or promote products
      derived from this software without specific prior written permission.

THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
DISCLAIMED. IN NO EVENT SHALL <COPYRIGHT HOLDER> BE LIABLE FOR ANY
DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
(INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND
ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
(INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

*/
#endregion


using ExtendedControls.ExtendedToolkit.NaviSuite.Main.Controls;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace ExtendedControls.ExtendedToolkit.NaviSuite.Design.Designers
{
    public class NaviGroupDesigner : ParentControlDesigner
    {
        #region Fields

        private IComponentChangeService changeService = null;
        private ISelectionService selectionService = null;
        private NaviGroup m_designingControl;

        #endregion

        #region Static

        public static int LoWord(int dwValue)
        {
            return dwValue & 0xFFFF;
        }

        public static int HiWord(int dwValue)
        {
            return (dwValue >> 16) & 0xFFFF;
        }

        #endregion

        #region Constructor
        #endregion

        #region Properties
        #endregion

        #region Methods

        private void CheckHeaderClick(Point location)
        {
            if (m_designingControl != null)
            {
                if (m_designingControl.HeaderRegion.IsVisible(location))
                {
                    if (selectionService.PrimarySelection == m_designingControl)
                        SetControlProperty("Expanded", !m_designingControl.Expanded);
                }
            }
        }

        private void InitializeServices()
        {
            if (changeService == null)
            {
                this.changeService =
                   GetService(typeof(IComponentChangeService)) as IComponentChangeService;
            }
            if (selectionService == null)
            {
                this.selectionService =
                   GetService(typeof(ISelectionService)) as ISelectionService;
            }
        }

        private void SetControlProperty(string propName, object value)
        {
            PropertyDescriptor propDesc =
               TypeDescriptor.GetProperties(m_designingControl)[propName];

            if (changeService != null)
            {
                // Raise event that we are about to change
                this.changeService.OnComponentChanging(m_designingControl, propDesc);
            }

            // Change to desired value
            object oldValue = propDesc.GetValue(m_designingControl);
            propDesc.SetValue(m_designingControl, value);

            if (changeService != null)
            {
                // Raise event that the component has been changed
                this.changeService.OnComponentChanged(m_designingControl, propDesc, oldValue, value);
            }
        }
        #endregion

        #region Overrides

        protected override void WndProc(ref Message m)
        {
            if (m.HWnd == Control.Handle)
            {
                switch (m.Msg)
                {
                    case 0x202: //WM_LBUTTONUP
                        CheckHeaderClick(new Point(LoWord((int)m.LParam), HiWord((int)m.LParam)));
                        break;
                    default:
                        break;
                }
            }
            base.WndProc(ref m);
        }

        public override void Initialize(System.ComponentModel.IComponent component)
        {
            base.Initialize(component);
            if (component is NaviGroup)
            {
                m_designingControl = (NaviGroup)component;
            }
            InitializeServices();
        }
        #endregion

        #region Event Handling

        #endregion
    }
}