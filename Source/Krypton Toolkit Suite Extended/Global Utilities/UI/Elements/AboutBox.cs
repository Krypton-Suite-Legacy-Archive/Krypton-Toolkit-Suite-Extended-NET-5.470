using ComponentFactory.Krypton.Toolkit;
using Core.Interfaces;
using System;
using System.Drawing;

namespace Core.UI.Elements
{
    public partial class AboutBox : KryptonForm, IAbout
    {
        public AboutBox()
        {
            InitializeComponent();
        }

        public bool UseIcon { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool ShowSystemInformationButton { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime CreationDateTime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ApplicationName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Version ApplicationVersion { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Version FrameworkVersion { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Icon ApplicationIcon { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Bitmap ApplicationIconImage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string AuthourName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string InstallLocation { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}