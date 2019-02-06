using System;
using System.ComponentModel.Design;
using System.Reflection;

namespace ExtendedFileDialogs.Designer
{
    public class KryptonTaskDialogDesigner : ComponentDesigner
    {
        public override DesignerVerbCollection Verbs
        {
            get
            {
                DesignerVerbCollection verbs = new DesignerVerbCollection();

                verbs.Add(new DesignerVerb(Properties.Resources.Preview, new EventHandler(Preview)));

                return verbs;
            }
        }

        private void Preview(object sender, EventArgs e)
        {
            Type typeKryptonTaskDiolog = Component.GetType();

            MethodInfo showDialog = typeKryptonTaskDiolog.GetMethod("ShowDialog", Type.EmptyTypes);

            if (showDialog != null)
            {
                showDialog.Invoke(Component, null);
            }
        }
    }
}