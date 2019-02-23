using System;
using System.ComponentModel.Design;
using System.Windows.Forms.Design;

namespace ExtendedControls.ExtendedToolkit.Wizard.Classes
{
    /// <summary>
    /// Summary description for WizardPageDesigner.
    /// </summary>
    public class WizardPageDesigner : ParentControlDesigner
    {
        public override DesignerVerbCollection Verbs
        {
            get
            {
                DesignerVerbCollection verbs = new DesignerVerbCollection();
                verbs.Add(new DesignerVerb("Remove Page", new EventHandler(handleRemovePage)));

                return verbs;
            }
        }

        private void handleRemovePage(object sender, EventArgs e)
        {
            WizardPage page = this.Control as WizardPage;

            IDesignerHost h = (IDesignerHost)GetService(typeof(IDesignerHost));
            IComponentChangeService c = (IComponentChangeService)GetService(typeof(IComponentChangeService));

            DesignerTransaction dt = h.CreateTransaction("Remove Page");

            if (page.Parent is Controls.KryptonWizard)
            {
                Controls.KryptonWizard wiz = page.Parent as Controls.KryptonWizard;

                c.OnComponentChanging(wiz, null);
                //Drop from wizard
                wiz.Pages.Remove(page);
                wiz.Controls.Remove(page);
                c.OnComponentChanged(wiz, null, null, null);
                h.DestroyComponent(page);
            }
            else
            {
                c.OnComponentChanging(page, null);
                //Mark for destruction
                page.Dispose();
                c.OnComponentChanged(page, null, null, null);
            }
            dt.Commit();
        }

    }
}