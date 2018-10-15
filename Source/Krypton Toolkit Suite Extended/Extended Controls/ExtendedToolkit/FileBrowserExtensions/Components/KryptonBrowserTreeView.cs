using ComponentFactory.Krypton.Toolkit;
using System.ComponentModel;
using System.Drawing;

namespace ExtendedControls.ExtendedToolkit.FileBrowserExtensions.Components
{
    [ToolboxBitmap(typeof(KryptonTreeView))]
    public partial class KryptonBrowserTreeView : KryptonTreeView
    {
        public KryptonBrowserTreeView()
        {
            InitializeComponent();
        }

        public KryptonBrowserTreeView(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}