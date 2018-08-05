using EasyScintilla;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tooling.Properties;

namespace Tooling.Classes.Other
{
    public class FileCreator
    {
        #region Variables

        #endregion

        #region Constructors
        public FileCreator()
        {

        }
        #endregion

        #region Methods
        public void GenerateNewFile(SimpleEditor editor)
        {
            editor.Text = string.Format(Resources.FreshFile, DateTime.Now.ToString());
        }
        #endregion
    }
}