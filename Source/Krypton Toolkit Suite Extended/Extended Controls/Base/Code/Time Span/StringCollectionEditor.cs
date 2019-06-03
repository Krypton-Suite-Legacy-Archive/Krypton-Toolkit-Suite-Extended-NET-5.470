using ComponentFactory.Krypton.Toolkit;
using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Windows.Forms;

namespace ExtendedControls.Base.Code.TimeSpan
{
    public class StringCollectionEditor : CollectionEditor
    {
        protected virtual string InstructionText => null;

        protected virtual string FormTitle => null;

        protected override CollectionForm CreateCollectionForm() => new StringCollectionForm(this);

        public StringCollectionEditor(Type type) : base(type)
        {
        }

        private class StringCollectionForm : CollectionForm
        {
            #region Variables
            private KryptonButton _kbtnCancel, _kbtnOk;

            private readonly StringCollectionEditor _editor;

            private KryptonLabel _klblInstruction;

            private TableLayoutPanel _tlpOkCancelTableLayoutPanel;

            private KryptonTextBox _ktxtEntry;
            #endregion

            #region Designer Code
            private void InitializeComponent()
            {
                var manager = new ComponentResourceManager(Type.GetType("System.Windows.Forms.Design.StringCollectionEditor, System.Design"));
                _klblInstruction = new KryptonLabel();
                _ktxtEntry = new KryptonTextBox();
                _kbtnOk = new KryptonButton();
                _kbtnCancel = new KryptonButton();
                _tlpOkCancelTableLayoutPanel = new TableLayoutPanel();
                _tlpOkCancelTableLayoutPanel.SuspendLayout();
                SuspendLayout();
                manager.ApplyResources(_klblInstruction, "klblInstruction");
                _klblInstruction.Margin = new Padding(3, 1, 3, 0);
                _klblInstruction.Name = "klblInstruction";
                if (_editor.InstructionText != null)
                    _klblInstruction.Text = _editor.InstructionText;
                _ktxtEntry.AcceptsTab = true;
                _ktxtEntry.AcceptsReturn = true;
                manager.ApplyResources(_ktxtEntry, "ktxtEntry");
                _ktxtEntry.Name = "ktxtEntry";
                manager.ApplyResources(_kbtnOk, "okButton");
                _kbtnOk.DialogResult = DialogResult.OK;
                _kbtnOk.Margin = new Padding(0, 0, 3, 0);
                _kbtnOk.Name = "okButton";
                manager.ApplyResources(_kbtnCancel, "cancelButton");
                _kbtnCancel.DialogResult = DialogResult.Cancel;
                _kbtnCancel.Margin = new Padding(3, 0, 0, 0);
                _kbtnCancel.Name = "cancelButton";
                manager.ApplyResources(_tlpOkCancelTableLayoutPanel, "tlpOkCancelTableLayoutPanel");
                _tlpOkCancelTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
                _tlpOkCancelTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
                _tlpOkCancelTableLayoutPanel.Controls.Add(_kbtnOk, 0, 0);
                _tlpOkCancelTableLayoutPanel.Controls.Add(_kbtnCancel, 1, 0);
                _tlpOkCancelTableLayoutPanel.Name = "tlpOkCancelTableLayoutPanel";
                _tlpOkCancelTableLayoutPanel.RowStyles.Add(new RowStyle());
                manager.ApplyResources(this, "$this");
                AutoScaleMode = AutoScaleMode.Font;
                Controls.Add(_tlpOkCancelTableLayoutPanel);
                Controls.Add(_klblInstruction);
                Controls.Add(_ktxtEntry);
                HelpButton = true;
                MaximizeBox = false;
                MinimizeBox = false;
                Name = "StringCollectionEditor";
                ShowIcon = false;
                ShowInTaskbar = false;
                if (_editor.FormTitle != null)
                    Text = _editor.FormTitle;
                _tlpOkCancelTableLayoutPanel.ResumeLayout(false);
                _tlpOkCancelTableLayoutPanel.PerformLayout();
                HelpRequested += StringCollectionForm_HelpRequested;
                ResumeLayout(false);
                PerformLayout();
            }
            #endregion

            #region Constructor
            public StringCollectionForm(CollectionEditor editor) : base(editor)
            {
                _editor = (StringCollectionEditor)editor;

                InitializeComponent();

                HookEvents();
            }
            #endregion

            private void HookEvents()
            {
                _ktxtEntry.KeyDown += Entry_KeyDown;

                _kbtnOk.Click += Ok_Click;

                HelpButtonClicked += StringCollectionForm_HelpButtonClicked;
            }

            private void StringCollectionForm_HelpButtonClicked(object sender, CancelEventArgs e)
            {
                e.Cancel = true;

                _editor.ShowHelp();
            }

            private void Ok_Click(object sender, EventArgs e)
            {
                var separator = new[] { '\n' };

                var trimChars = new[] { '\r' };

                var stringArray = _ktxtEntry.Text.Split(separator);

                var items = Items;

                var length = stringArray.Length;

                for (var i = 0; i < length; i++)
                {
                    stringArray[i] = stringArray[i].Trim(trimChars);
                }

                var flag = true;

                if (length == items.Length)
                {
                    var index = 0;

                    while (index < length)
                    {
                        if (!stringArray[index].Equals((string)items[index]))
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
                    if (stringArray.Length > 0 && stringArray[stringArray.Length - 1].Length == 0)
                    {
                        length--;
                    }

                    var objectArray = new object[length];

                    for (var j = 0; j < length; j++)
                    {
                        objectArray[j] = stringArray[j];
                    }

                    Items = objectArray;
                }
            }

            private void Entry_KeyDown(object sender, KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Escape)
                {
                    _kbtnCancel.PerformClick();

                    e.Handled = true;
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

                _ktxtEntry.Text = str;
            }

            private void StringCollectionForm_HelpRequested(object sender, HelpEventArgs hlpevent)
            {
                _editor.ShowHelp();
            }
        }
    }
}