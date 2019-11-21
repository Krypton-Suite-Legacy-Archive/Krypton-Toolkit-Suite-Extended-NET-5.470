using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    public class FileSystemExamples : KryptonForm
    {
        private IOComponents.KryptonFileSystemUserControl kryptonFileSystemUserControl1;

        private void InitializeComponent()
        {
            this.kryptonFileSystemUserControl1 = new IOComponents.KryptonFileSystemUserControl();
            this.SuspendLayout();
            // 
            // kryptonFileSystemUserControl1
            // 
            this.kryptonFileSystemUserControl1.BackColor = System.Drawing.Color.Transparent;
            this.kryptonFileSystemUserControl1.Location = new System.Drawing.Point(37, 26);
            this.kryptonFileSystemUserControl1.Name = "kryptonFileSystemUserControl1";
            this.kryptonFileSystemUserControl1.SelectedPath = "home";
            this.kryptonFileSystemUserControl1.ShowAddressbar = true;
            this.kryptonFileSystemUserControl1.ShowMyDocuments = true;
            this.kryptonFileSystemUserControl1.ShowMyFavorites = true;
            this.kryptonFileSystemUserControl1.ShowMyNetwork = true;
            this.kryptonFileSystemUserControl1.ShowToolbar = true;
            this.kryptonFileSystemUserControl1.Size = new System.Drawing.Size(519, 548);
            this.kryptonFileSystemUserControl1.TabIndex = 0;
            // 
            // FileSystemExamples
            // 
            this.ClientSize = new System.Drawing.Size(1396, 754);
            this.Controls.Add(this.kryptonFileSystemUserControl1);
            this.Name = "FileSystemExamples";
            this.ResumeLayout(false);

        }

        public FileSystemExamples()
        {
            InitializeComponent();
        }
    }
}