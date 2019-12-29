using ComponentFactory.Krypton.Toolkit;
using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Windows.Forms;

namespace ExtendedControls.Base.Code.TimeSpanExtended
{
    public class ExposedStringCollectionEditor : CollectionEditor
    {
        // Methods
        public ExposedStringCollectionEditor(Type type)
            : base(type)
        {
        }

        protected virtual string InstructionText => null;
        protected virtual string FormTitle => null;

        protected override CollectionForm CreateCollectionForm() => new StringCollectionForm(this);

        // Nested Types
        private class StringCollectionForm : CollectionForm
        {
            // Fields
            private KryptonButton cancelButton;
            private readonly ExposedStringCollectionEditor editor;
            private KryptonLabel instruction;
            private KryptonButton okButton;
            private TableLayoutPanel okCancelTableLayoutPanel;
            private KryptonTextBox textEntry;

            // Methods
            public StringCollectionForm(CollectionEditor editor)
                : base(editor)
            {
                this.editor = (ExposedStringCollectionEditor)editor;
                InitializeComponent();
                HookEvents();
            }

            private void Edit1_keyDown(object sender, KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Escape)
                {
                    cancelButton.PerformClick();
                    e.Handled = true;
                }
            }

            private void Form_HelpRequested(object sender, HelpEventArgs e)
            {
                editor.ShowHelp();
            }

            private void HookEvents()
            {
                textEntry.KeyDown += Edit1_keyDown;
                okButton.Click += OKButton_click;
                HelpButtonClicked += StringCollectionEditor_HelpButtonClicked;
            }

            private void InitializeComponent()
            {
                var manager = new ComponentResourceManager(Type.GetType("System.Windows.Forms.Design.StringCollectionEditor, System.Design"));
                instruction = new KryptonLabel();
                textEntry = new KryptonTextBox();
                okButton = new KryptonButton();
                cancelButton = new KryptonButton();
                okCancelTableLayoutPanel = new TableLayoutPanel();
                okCancelTableLayoutPanel.SuspendLayout();
                SuspendLayout();
                manager.ApplyResources(instruction, "instruction");
                instruction.Margin = new Padding(3, 1, 3, 0);
                instruction.Name = "instruction";
                if (editor.InstructionText != null)
                    instruction.Text = editor.InstructionText;
                textEntry.AcceptsTab = true;
                textEntry.AcceptsReturn = true;
                manager.ApplyResources(textEntry, "textEntry");
                textEntry.Name = "textEntry";
                manager.ApplyResources(okButton, "okButton");
                okButton.DialogResult = DialogResult.OK;
                okButton.Margin = new Padding(0, 0, 3, 0);
                okButton.Name = "okButton";
                manager.ApplyResources(cancelButton, "cancelButton");
                cancelButton.DialogResult = DialogResult.Cancel;
                cancelButton.Margin = new Padding(3, 0, 0, 0);
                cancelButton.Name = "cancelButton";
                manager.ApplyResources(okCancelTableLayoutPanel, "okCancelTableLayoutPanel");
                okCancelTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
                okCancelTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
                okCancelTableLayoutPanel.Controls.Add(okButton, 0, 0);
                okCancelTableLayoutPanel.Controls.Add(cancelButton, 1, 0);
                okCancelTableLayoutPanel.Name = "okCancelTableLayoutPanel";
                okCancelTableLayoutPanel.RowStyles.Add(new RowStyle());
                manager.ApplyResources(this, "$this");
                AutoScaleMode = AutoScaleMode.Font;
                Controls.Add(okCancelTableLayoutPanel);
                Controls.Add(instruction);
                Controls.Add(textEntry);
                HelpButton = true;
                MaximizeBox = false;
                MinimizeBox = false;
                Name = "StringCollectionEditor";
                ShowIcon = false;
                ShowInTaskbar = false;
                if (editor.FormTitle != null)
                    Text = editor.FormTitle;
                okCancelTableLayoutPanel.ResumeLayout(false);
                okCancelTableLayoutPanel.PerformLayout();
                HelpRequested += Form_HelpRequested;
                ResumeLayout(false);
                PerformLayout();
            }

            private void OKButton_click(object sender, EventArgs e)
            {
                var separator = new[] { '\n' };
                var trimChars = new[] { '\r' };
                var strArray = textEntry.Text.Split(separator);
                var items = Items;
                var length = strArray.Length;
                for (var i = 0; i < length; i++)
                {
                    strArray[i] = strArray[i].Trim(trimChars);
                }
                var flag = true;
                if (length == items.Length)
                {
                    var index = 0;
                    while (index < length)
                    {
                        if (!strArray[index].Equals((string)items[index]))
                        {
                            break;
                        }
                        index++;
                    }
                    if (index == length)
                    {
                        flag = false;
                    }
                }
                if (!flag)
                {
                    DialogResult = DialogResult.Cancel;
                }
                else
                {
                    if (strArray.Length > 0 && strArray[strArray.Length - 1].Length == 0)
                    {
                        length--;
                    }
                    var objArray2 = new object[length];
                    for (var j = 0; j < length; j++)
                    {
                        objArray2[j] = strArray[j];
                    }
                    Items = objArray2;
                }
            }

            protected override void OnEditValueChanged()
            {
                var items = Items;
                var str = string.Empty;
                for (var i = 0; i < items.Length; i++)
                {
                    var s = items[i] as string;
                    if (s != null)
                    {
                        str = str + s;
                        if (i != items.Length - 1)
                        {
                            str = str + "\r\n";
                        }
                    }
                }
                textEntry.Text = str;
            }

            private void StringCollectionEditor_HelpButtonClicked(object sender, CancelEventArgs e)
            {
                e.Cancel = true;
                editor.ShowHelp();
            }
        }
    }
}