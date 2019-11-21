#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

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