using ExtendedControls.Base.Code.Colours;
using System.Drawing;
using System.Windows.Forms.Design;

namespace ExtendedControls.ExtendedToolkit.Controls.Colours
{
    public partial class ColourUI : ColourEditorUserControl
    {
        #region System

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
        }

        #endregion

        #endregion

        private IWindowsFormsEditorService _edSvc;
        private object _value;
        private ColourTypeEditorDropDown _editor;

        public ColourUI(ColourTypeEditorDropDown editor)
        {
            _editor = editor;

            InitializeComponent();
        }

        /// <summary>
        /// Gets the value.
        /// </summary>
        /// <value>The value.</value>
        public object Value
        {
            get
            {
                //return _value;
                return SelectedColour;
            }
        }

        private void adjustColorUIHeight()
        {
            Size = MinimumSize;
        }

        public void Start(
            IWindowsFormsEditorService edSvc,
            object value)
        {
            _edSvc = edSvc;
            _value = value;
            adjustColorUIHeight();

            if (value != null)
            {
                var colour = (Color)value;
                SelectedColour = colour;
            }
        }

        public void End()
        {
            _edSvc = null;
            _value = null;
        }
    }
}