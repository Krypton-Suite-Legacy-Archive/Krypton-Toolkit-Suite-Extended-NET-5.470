using System.Collections;
using System.Windows.Forms.Design;

namespace ExtendedControls.ExtendedToolkit.Wizard.Classes
{
    public class InfoContainerDesigner : ParentControlDesigner
    {
        protected override void PreFilterProperties(IDictionary properties)
        {
            base.PreFilterProperties(properties);

            if (properties.Contains("BackgroundImage") == true)
            {
                properties.Remove("BackgroundImage");
            }
        }
    }
}