using ComponentFactory.Krypton.Toolkit;
using ExtendedControls.ExtendedToolkit.CalendarLibrary;
using ExtendedToolkit.CalendarLibrary;
using System;
using System.Diagnostics;

namespace ExtendedControls.ExtendedToolkit.UI.CalendarLibrary
{
    public partial class AddAppointment : KryptonForm
    {
        #region System
        private KryptonLabel label1;
        private KryptonLabel label2;
        private KryptonLabel lblDescription;
        private KryptonDateTimePicker datePicker;
        private KryptonLabel lblDate;
        private KryptonLabel kryptonLabel1;
        private KryptonTextBox txtKey;
        private KryptonLabel label5;
        private KryptonTextBox txtColour;
        private KryptonCheckBox tentativeCheckBox;
        private KryptonTextBox descriptionTextBox;
        private KryptonButton addItem;
        private KryptonComboBox endMinute;
        private KryptonNumericUpDown endHour;
        private KryptonComboBox startMinute;
        private KryptonNumericUpDown startHour;
        private KryptonPanel kryptonPanel1;

        private void InitializeComponent()
        {
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.txtKey = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtColour = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.tentativeCheckBox = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.descriptionTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.addItem = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.endMinute = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.endHour = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.startMinute = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.startHour = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.label1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.label2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblDescription = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.datePicker = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.lblDate = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.endMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startMinute)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.txtKey);
            this.kryptonPanel1.Controls.Add(this.label5);
            this.kryptonPanel1.Controls.Add(this.txtColour);
            this.kryptonPanel1.Controls.Add(this.tentativeCheckBox);
            this.kryptonPanel1.Controls.Add(this.descriptionTextBox);
            this.kryptonPanel1.Controls.Add(this.addItem);
            this.kryptonPanel1.Controls.Add(this.endMinute);
            this.kryptonPanel1.Controls.Add(this.endHour);
            this.kryptonPanel1.Controls.Add(this.startMinute);
            this.kryptonPanel1.Controls.Add(this.startHour);
            this.kryptonPanel1.Controls.Add(this.label1);
            this.kryptonPanel1.Controls.Add(this.label2);
            this.kryptonPanel1.Controls.Add(this.lblDescription);
            this.kryptonPanel1.Controls.Add(this.datePicker);
            this.kryptonPanel1.Controls.Add(this.lblDate);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(776, 150);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(456, 109);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(189, 29);
            this.txtKey.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKey.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(405, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 26);
            this.label5.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.TabIndex = 50;
            this.label5.Values.Text = "Key:";
            // 
            // txtColour
            // 
            this.txtColour.Location = new System.Drawing.Point(197, 109);
            this.txtColour.Name = "txtColour";
            this.txtColour.Size = new System.Drawing.Size(202, 29);
            this.txtColour.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColour.TabIndex = 49;
            // 
            // tentativeCheckBox
            // 
            this.tentativeCheckBox.Location = new System.Drawing.Point(12, 112);
            this.tentativeCheckBox.Name = "tentativeCheckBox";
            this.tentativeCheckBox.Size = new System.Drawing.Size(99, 26);
            this.tentativeCheckBox.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tentativeCheckBox.TabIndex = 35;
            this.tentativeCheckBox.Values.Text = "Tentative?";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(123, 65);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(522, 29);
            this.descriptionTextBox.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBox.TabIndex = 48;
            // 
            // addItem
            // 
            this.addItem.Location = new System.Drawing.Point(651, 12);
            this.addItem.Name = "addItem";
            this.addItem.Size = new System.Drawing.Size(113, 126);
            this.addItem.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItem.TabIndex = 30;
            this.addItem.Values.Text = "Add Item";
            this.addItem.Click += new System.EventHandler(this.addItem_Click);
            // 
            // endMinute
            // 
            this.endMinute.DropDownWidth = 40;
            this.endMinute.FormattingEnabled = true;
            this.endMinute.Items.AddRange(new object[] {
            "00",
            "30"});
            this.endMinute.Location = new System.Drawing.Point(586, 12);
            this.endMinute.Name = "endMinute";
            this.endMinute.Size = new System.Drawing.Size(59, 27);
            this.endMinute.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endMinute.TabIndex = 47;
            this.endMinute.Text = "00";
            // 
            // endHour
            // 
            this.endHour.Location = new System.Drawing.Point(534, 12);
            this.endHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.endHour.Name = "endHour";
            this.endHour.Size = new System.Drawing.Size(46, 28);
            this.endHour.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endHour.TabIndex = 46;
            // 
            // startMinute
            // 
            this.startMinute.DropDownWidth = 40;
            this.startMinute.FormattingEnabled = true;
            this.startMinute.Items.AddRange(new object[] {
            "00",
            "30"});
            this.startMinute.Location = new System.Drawing.Point(375, 12);
            this.startMinute.Name = "startMinute";
            this.startMinute.Size = new System.Drawing.Size(59, 27);
            this.startMinute.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startMinute.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startMinute.TabIndex = 45;
            this.startMinute.Text = "00";
            this.startMinute.TextChanged += new System.EventHandler(this.startMinute_TextChanged);
            // 
            // startHour
            // 
            this.startHour.Location = new System.Drawing.Point(323, 12);
            this.startHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.startHour.Name = "startHour";
            this.startHour.Size = new System.Drawing.Size(46, 28);
            this.startHour.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startHour.TabIndex = 31;
            this.startHour.ValueChanged += new System.EventHandler(this.startHour_ValueChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(220, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 26);
            this.label1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.TabIndex = 44;
            this.label1.Values.Text = "Start Time:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(440, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 26);
            this.label2.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.TabIndex = 43;
            this.label2.Values.Text = "End Time:";
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(12, 65);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(105, 26);
            this.lblDescription.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.TabIndex = 42;
            this.lblDescription.Values.Text = "Description:";
            // 
            // datePicker
            // 
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(71, 12);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(143, 27);
            this.datePicker.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.TabIndex = 41;
            // 
            // lblDate
            // 
            this.lblDate.Location = new System.Drawing.Point(12, 12);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(53, 26);
            this.lblDate.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.TabIndex = 40;
            this.lblDate.Values.Text = "Date:";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(123, 112);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(68, 26);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 38;
            this.kryptonLabel1.Values.Text = "Colour:";
            // 
            // AddAppointment
            // 
            this.ClientSize = new System.Drawing.Size(776, 150);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddAppointment";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Appointment";
            this.Load += new System.EventHandler(this.AddAppointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.endMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startMinute)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        #region Variables
        private ExtendedToolkit.CalendarLibrary.Calendar _calendar;
        #endregion

        #region Constructors
        public AddAppointment(ref ExtendedToolkit.CalendarLibrary.Calendar calendar)
        {
            InitializeComponent();

            _calendar = calendar;

            datePicker.Value = DateTime.Now;

            startHour.Value = DateTime.Now.Hour;

            startMinute.Text = DateTime.Now.Minute.ToString();
        }
        #endregion

        private void AddAppointment_Load(object sender, EventArgs e)
        {

        }

        private void addItem_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime startTime = new DateTime(datePicker.Value.Year, datePicker.Value.Month, datePicker.Value.Day, (int)startHour.Value, Int32.Parse(startMinute.Text), 0);

                DateTime endTime = new DateTime(datePicker.Value.Year, datePicker.Value.Month, datePicker.Value.Day, (int)endHour.Value, Int32.Parse(endMinute.Text), 0);

                if (endTime.CompareTo(startTime) <= 0)
                {
                    KryptonMessageBox.Show("End time is either same as or before the start time. Please check the times");

                    return;
                }

                if (descriptionTextBox.Text == null || descriptionTextBox.Text.Trim() == String.Empty)
                {
                    KryptonMessageBox.Show("Please enter some description of this item");

                    return;
                }

                _calendar.CalendarItems.Add(new CalendarItem(startTime, endTime, descriptionTextBox.Text, tentativeCheckBox.Checked, txtKey.Text, txtColour.Text));

                _calendar.InitialiseDisplay();
            }
            catch (Exception exc)
            {
                Trace.WriteLine(exc.ToString());
            }
        }

        private void startHour_ValueChanged(object sender, EventArgs e)
        {
            endHour.Value = (startHour.Value == 23) ? 23 : startHour.Value + 1;
        }

        private void startMinute_TextChanged(object sender, EventArgs e)
        {
            if (startMinute.Text == "00")
            {
                endMinute.Text = "30";
            }
            else
            {
                endMinute.Text = "00";
            }
        }
    }
}