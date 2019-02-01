using ComponentFactory.Krypton.Toolkit;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.Controls.KryptonControls
{
    public class KryptonPowerComboBox : ComponentFactory.Krypton.Toolkit.KryptonComboBox
    {
        //Members
        private IPalette _palette;
        private PaletteRedirect _paletteRedirect;
        private PaletteBackInheritRedirect _paletteBack;
        private PaletteBorderInheritRedirect _paletteBorder;
        private PaletteContentInheritRedirect _paletteContent;

        //APIs
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int SendMessage(System.IntPtr hWnd, int Msg, System.Int32 wParam, System.IntPtr lParam);

        //properties
        private string mDividerFormat = "";
        private Color mGroupColor = System.Drawing.SystemColors.WindowText;
        private System.Windows.Forms.CheckState[] mItemsChecks;
        private bool mCheckBoxes;
        private System.Windows.Forms.CheckState mChecked = CheckState.Unchecked;
        private Color mGridColor = Color.FromArgb(240, 248, 255);

        //vars - last selected item
        private char mItemSeparator1 = ',';
        private char mItemSeparator2 = '&';
        private Int32 mHoverIndex;
        private double mHoverIndex_Dec;

        //events
        public delegate void ItemHoverEventHandler(Int32 eIndex);
        public event ItemHoverEventHandler ItemHover;
        public delegate void ItemCheckedEventHandler(Int32 eIndex);
        public event ItemCheckedEventHandler ItemChecked;

        //vars
        private Int32 mLastSelectedIndex = -1;
        private Timer mTimer;
        private Int32 mFirerTimer;
        private Int32 mKillEvents1; // kills _SelectectedIndexChange ON ForceRedraw
        private Int32 mKillEvents2; // kills _OnDrawItem ON FroceRedraw
        private Int32 mKillEvents3; // kills .ItemsChecks ON Click Selecting (not programatic selecting of .ItemsChecks)
        private Int32 mLastMessage;


        //constructor
        public KryptonPowerComboBox()
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.SetStyle(ControlStyles.EnableNotifyMessage, true);
            UpdateStyles();

            this.ComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBox.DrawItem += new DrawItemEventHandler(OnDrawItem);
            this.ForeColor = this.ComboBox.ForeColor;
            this.Font = this.ComboBox.Font;

            // Cache the current global palette setting
            _palette = KryptonManager.CurrentGlobalPalette;

            // Hook into palette events
            if (_palette != null)
                _palette.PalettePaint += new EventHandler<PaletteLayoutEventArgs>(OnPalettePaint);

            // We want to be notified whenever the global palette changes
            KryptonManager.GlobalPaletteChanged += new EventHandler(OnGlobalPaletteChanged);

            // Create redirection object to the base palette
            _paletteRedirect = new PaletteRedirect(_palette);
            _paletteBack = new PaletteBackInheritRedirect(_paletteRedirect);
            _paletteBorder = new PaletteBorderInheritRedirect(_paletteRedirect);
            _paletteContent = new PaletteContentInheritRedirect(_paletteRedirect);

            InitColours();

            if (_alternateRowColorEnabled) this.GridColour = _alternateRowColor;
        }

        private Color _alternateRowColor = Color.LightGray;
        [Browsable(true), Category("Appearance-Extended")]
        [DefaultValue("Color.Gray")]
        public Color AlternateRowColour
        {
            get { return _alternateRowColor; }
            set { _alternateRowColor = value; Invalidate(); }
        }

        private Boolean _alternateRowColorEnabled = true;
        [Browsable(true), Category("Appearance-Extended")]
        [DefaultValue("true")]
        public Boolean AlternateRowColourEnabled
        {
            get { return _alternateRowColorEnabled; }
            set { _alternateRowColorEnabled = value; Invalidate(); }
        }

        //properties
        [System.ComponentModel.Description("Use this property to set divider flag. Recommend you use three hyphens ---."), System.ComponentModel.Category("Power Properties")]
        public string DividerFormat
        {
            get
            {
                return mDividerFormat;
            }
            set
            {
                mDividerFormat = value;
            }
        }
        [System.ComponentModel.Description("Use this property to set the ForeColor of the grouping text."), System.ComponentModel.Category("Power Properties")]
        public Color GroupColour
        {
            get
            {
                return mGroupColor;
            }
            set
            {
                mGroupColor = value;
            }
        }
        [System.ComponentModel.Description("Use this property to set the BackColor of the grid."), System.ComponentModel.Category("Power Properties")]
        public Color GridColour
        {
            get
            {
                return _alternateRowColor;
            }
            set
            {
                _alternateRowColor = value;
            }
        }
        [System.ComponentModel.Description("Use this property to enable checkboxes."), System.ComponentModel.Category("Power Properties")]
        public bool CheckBoxes
        {
            get
            {
                return mCheckBoxes;
            }
            set
            {
                mCheckBoxes = value;
            }
        }
        [System.ComponentModel.Description("Use this property to set CheckBox's default value."), System.ComponentModel.Category("Power Properties")]
        public System.Windows.Forms.CheckState Checked
        {
            get
            {
                return mChecked;
            }
            set
            {
                mChecked = value;
            }
        }
        [System.ComponentModel.Description("Use this property to set item separator1 character."), System.ComponentModel.Category("Power Properties")]
        public char ItemSeparator1
        {
            get
            {
                return mItemSeparator1;
            }
            set
            {
                mItemSeparator1 = value;
            }
        }
        [System.ComponentModel.Description("Use this property to set item separator2 character."), System.ComponentModel.Category("Power Properties")]
        public char ItemSeparator2
        {
            get
            {
                return mItemSeparator2;
            }
            set
            {
                mItemSeparator2 = value;
            }
        }
        //ORIGINAL LINE: Public Property ItemsChecks(ByVal xIndex As Int32) As System.Windows.Forms.CheckState
        //INSTANT C# NOTE: C# does not support parameterized properties - the following property has been divided into two methods:
        [System.ComponentModel.Description("Use this property to get/set corresponding checkboc values."), System.ComponentModel.Category("Power Properties")]
        public System.Windows.Forms.CheckState get_ItemsChecks(Int32 xIndex)
        {
            try
            {
                return mItemsChecks[xIndex];
            }
            catch
            {
                return CheckState.Unchecked;
            }
        }
        public void set_ItemsChecks(Int32 xIndex, System.Windows.Forms.CheckState value)
        {
            StretchArray();

            if (xIndex < 0 | xIndex > this.Items.Count)
            {
                return;
            }

            if (mKillEvents3 != 0)
            {
                mItemsChecks[xIndex] = value;
            }
            else
            {
                if (this.CheckBoxes)
                {
                    StretchArray(); //clefranc BUG3
                    if (!this.DroppedDown)
                    {
                        if (mItemsChecks == null)
                        {

                            if (this.mChecked == CheckState.Checked)
                            {
                                CheckAll();
                            }
                            else
                            {
                                CheckNone();
                            }
                        }
                        else
                        {
                            mItemsChecks[xIndex] = value;
                            this.Text = FormatCheckString();
                        }
                    }
                }
            }

        }

        //overrides
        protected override void OnDropDownClosed(System.EventArgs e)
        {

            mKillEvents1 = 0; //clefranc BUG2
            base.OnDropDownClosed(e);
            if (this.CheckBoxes)
            {
                this.Text = FormatCheckString();
            }

        }
        protected override void OnSelectedIndexChanged(System.EventArgs e)
        {
            Int32 i = 0;


            if (mKillEvents1 != 0 || SelectedIndex == -1)
            {
                base.OnSelectedIndexChanged(e);
                return;
            }

            if (this.DividerFormat.Length > 0 && IsItemAGroup(SelectedIndex))
            {
                if (!this.CheckBoxes)
                {
                    this.SelectedIndex = mLastSelectedIndex;
                    return;
                }
                else
                {
                    mKillEvents3 += 1;
                    i = SelectedIndex;
                    do
                    {
                        i += 1;
                        if (i > (this.Items.Count - 1))
                        {
                            break;
                        }
                        if (IsItemAGroup(i))
                        {
                            break;
                        }
                        this.SelectedIndex = i;
                    } while (true);
                    mKillEvents3 -= 1;
                    base.OnSelectedIndexChanged(e);
                    return;
                }
            }
            //2 - standard event stuff
            mLastSelectedIndex = this.SelectedIndex;
            base.OnSelectedIndexChanged(e);

            //3 - toggle checkbox/force redraw
            if (this.CheckBoxes && SelectedIndex > -1)
            {
                try
                {
                    mKillEvents3 += 1;
                    if (this.get_ItemsChecks(this.SelectedIndex) == CheckState.Checked)
                    {
                        this.set_ItemsChecks(this.SelectedIndex, CheckState.Unchecked);
                    }
                    else
                    {
                        this.set_ItemsChecks(this.SelectedIndex, CheckState.Checked);
                    }
                    if (ItemChecked != null)
                        ItemChecked(SelectedIndex);
                    mKillEvents3 -= 1;
                    PrepareTimer();
                }
                catch (Exception ex)
                { Console.WriteLine(ex.Message); }
            }
        }

        protected virtual void OnDrawItem(Object sender, DrawItemEventArgs e)
        {
            Int32 zX1 = 0;
            Pen zPen = null;
            float zWidth = 0F;
            string zText = null;
            Font zFont = null;
            Color zFore = new Color();
            System.Windows.Forms.VisualStyles.CheckBoxState zState = 0;
            //1 - Exit
            if (e.Index < 0)
            {
                //base.OnDrawItem(this,e);
                return;
            }
            //2 - Grouping
            if (this.Items[e.Index].ToString().Contains(this.mDividerFormat) & mDividerFormat.Length > 0)
            {
                e.DrawBackground();
                if (DataSource == null) //TN Engineers
                {
                    zText = this.Items[e.Index].ToString();
                }
                else
                {
                    zText = ((System.Data.DataRowView)(this.Items[e.Index]))[this.DisplayMember].ToString();
                }
                zText = this.Items[e.Index].ToString();
                zText = " " + zText.Replace(this.mDividerFormat, "") + " ";
                zFont = new Font(Font, FontStyle.Bold);
                if (e.BackColor == System.Drawing.SystemColors.Highlight)
                {
                    zFore = Color.Gainsboro;
                }
                else
                {
                    zFore = this.GroupColour;
                }
                zPen = new Pen(zFore);
                zWidth = e.Graphics.MeasureString(zText, zFont).Width;
                zX1 = Convert.ToInt32(e.Bounds.Width - zWidth) / 2;
                e.Graphics.DrawRectangle(zPen, new Rectangle(e.Bounds.X, e.Bounds.Y + e.Bounds.Height / 2, zX1, 1));
                e.Graphics.DrawRectangle(zPen, new Rectangle(e.Bounds.Width - zX1, e.Bounds.Y + e.Bounds.Height / 2, e.Bounds.Width, 1));
                e.Graphics.DrawString(zText, zFont, new SolidBrush(zFore), zX1, e.Bounds.Top);
            }
            else
            {
                //3 - ItemBackColor
                if (mKillEvents2 == 0)
                {
                    //INSTANT C# NOTE: The following VB 'Select Case' included range-type or non-constant 'Case' expressions and was converted to C# 'if-else' logic:
                    // Select Case true
                    //ORIGINAL LINE: Case System.Convert.ToBoolean(e.State And DrawItemState.Selected)
                    //not used With Krypton
                    if (true == System.Convert.ToBoolean(e.State & DrawItemState.Selected))
                    {
                        // e.DrawBackground();
                    }
                    //ORIGINAL LINE: Case e.Index % 2 = 0
                    else if (true == (e.Index % 2 == 0))
                    {
                        e.Graphics.FillRectangle(new SolidBrush(Color.White), e.Bounds);
                    }
                    //ORIGINAL LINE: Case Else
                    else
                    {
                        if (_alternateRowColorEnabled)
                        {
                            e.Graphics.FillRectangle(new SolidBrush(_alternateRowColor), e.Bounds);
                        }
                        else
                        {
                            e.Graphics.FillRectangle(new SolidBrush(Color.White), e.Bounds);
                        }
                    }

                }
                //4 - ItemText ( _SearchPoint1)
                if (this.DataSource == null) //TN Engineers
                {
                    if (true != System.Convert.ToBoolean(e.State & DrawItemState.Selected))
                    {
                        //not used anymore
                        //e.Graphics.DrawString(this.Items[e.Index].ToString(), Font, new SolidBrush(e.ForeColor), e.Bounds.Left, e.Bounds.Top);

                        //Using Krypton Text renderer routine
                        DrawItemText(ref e, this.Items[e.Index].ToString());

                    }
                }
                else
                {
                    if (true != System.Convert.ToBoolean(e.State & DrawItemState.Selected))
                    {
                        //not used anymore
                        //e.Graphics.DrawString(((System.Data.DataRowView)(this.Items[e.Index]))[this.DisplayMember].ToString(), Font, new SolidBrush(e.ForeColor), e.Bounds.Left, e.Bounds.Top);

                        //Using Krypton Text renderer routine
                        DrawItemText(ref e, ((System.Data.DataRowView)(this.Items[e.Index]))[this.DisplayMember].ToString());

                    }
                }
                //5 - CheckBox
                if (mCheckBoxes)
                {
                    if (System.Convert.ToBoolean(e.State & DrawItemState.Selected))
                    {
                        if (this.get_ItemsChecks(e.Index) == CheckState.Checked)
                        {
                            zState = System.Windows.Forms.VisualStyles.CheckBoxState.CheckedHot;
                        }
                        else
                        {
                            zState = System.Windows.Forms.VisualStyles.CheckBoxState.UncheckedHot;
                        }
                    }
                    else
                    {
                        if (this.get_ItemsChecks(e.Index) == CheckState.Checked)
                        {
                            zState = System.Windows.Forms.VisualStyles.CheckBoxState.CheckedNormal;
                        }
                        else
                        {
                            zState = System.Windows.Forms.VisualStyles.CheckBoxState.UncheckedNormal;
                        }
                    }
                    zX1 = this.FontHeight;
                    zPen = new Pen(Color.Black, 1F);
                    zPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                    System.Windows.Forms.CheckBoxRenderer.DrawCheckBox(e.Graphics, new System.Drawing.Point(e.Bounds.X + e.Bounds.Width - 15, e.Bounds.Y + 1 + ((e.Bounds.Height - 13) / 2)), e.Bounds, "", this.Font, false, zState);
                }
            }
            //6 - Base event
            //base.OnDrawItem(this,e);
        }

        private void DrawItemText(ref DrawItemEventArgs e, string Text)
        {
            Rectangle rect = e.Bounds;

            // Find correct text color
            Color textColor = this.ComboBox.ForeColor;
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                textColor = SystemColors.HighlightText;

            // Find correct background color
            Color backColor = this.ComboBox.BackColor;
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                backColor = SystemColors.Highlight;

            e.Graphics.TextRenderingHint = CommonHelper.PaletteTextHintToRenderingHint(StateNormal.Item.PaletteContent.GetContentShortTextHint(PaletteState.Normal));

            TextFormatFlags flags = TextFormatFlags.TextBoxControl | TextFormatFlags.NoPadding;

            // Use the correct prefix setting
            flags |= TextFormatFlags.NoPrefix;

            rect.Offset(4, 2);

            // Draw text using font defined by the control
            TextRenderer.DrawText(e.Graphics,
                                  Text, Font,
                                  rect,
                                  textColor, Color.Transparent,
                                  flags);
        }

        protected override void OnKeyDown(System.Windows.Forms.KeyEventArgs e) //FIX for keyboard handling
        {

            if (this.SelectedIndex < 0) //clefranc BUG1, als removed = sign since 0 is valid item index
            {
                return;
            }

            if (this.DroppedDown && e.KeyCode == Keys.Space)
            {
                mKillEvents3 += 1;
                e.SuppressKeyPress = true;
                if (this.CheckBoxes)
                {
                    if (this.get_ItemsChecks(this.SelectedIndex) == CheckState.Checked)
                    {
                        this.set_ItemsChecks(this.SelectedIndex, CheckState.Unchecked);
                    }
                    else
                    {
                        this.set_ItemsChecks(this.SelectedIndex, CheckState.Checked);
                    }
                    mKillEvents3 -= 1;
                }
                else
                {
                    this.DroppedDown = false;
                }
                PrepareTimer();
            }

            if (e.KeyCode == Keys.F4) //clefranc BUG2
            {
                if (this.DroppedDown)
                {
                    mKillEvents1 += 1;
                }
            }

            base.OnKeyDown(e);

        }
        public new object DataSource //TN Engineers
        {
            get
            {
                return base.DataSource;
            }
            set
            {
                mKillEvents1 += 1;
                base.DataSource = value;
                mKillEvents1 -= 1;
            }
        }
        protected override void WndProc(ref System.Windows.Forms.Message m)
        {

            const Int32 WM_SETCURSOR = 32;
            const Int32 WM_COMMAND = 273;
            const int WM_CTLCOLORLISTBOX = 308;
            const Int32 CB_ADDSTRING = 323;
            const Int32 CB_GETCURSEL = 327;
            const Int32 WM_LBUTTONUP = 514;
            const Int32 OCM_COMMAND = 8465;

            //Trace.WriteLine(System.DateTime.Now.Millisecond.ToString + " " + m.HWnd.ToString + " " + m.Msg.ToString + " " + m.WParam.ToString + " " + m.LParam.ToString)

            //INSTANT C# NOTE: The following VB 'Select Case' included range-type or non-constant 'Case' expressions and was converted to C# 'if-else' logic:
            // Select Case true
            //\\\\\ WM_CTLCOLORLISTBOX - ItemHover
            //ORIGINAL LINE: Case m.Msg = WM_CTLCOLORLISTBOX Or m.Msg = WM_SETCURSOR
            if (true == (m.Msg == WM_CTLCOLORLISTBOX || m.Msg == WM_SETCURSOR))
            {
                GetHoverIndexFromCursor();
                if (mHoverIndex_Dec >= 0)
                {
                    if (mHoverIndex > -1 & mHoverIndex < this.Items.Count && this.DroppedDown)
                    {
                        if (ItemHover != null)
                            ItemHover(mHoverIndex);
                    }
                }

                //\\\\\ CB_ADDSTRING - Match the CheckState array to exactly = ItemList size
            }
            //ORIGINAL LINE: Case m.Msg = CB_ADDSTRING //NEW stretch array on item adding, this event will fire even if ItemList was defined in IDE
            else if (true == (m.Msg == CB_ADDSTRING)) //NEW stretch array on item adding, this event will fire even if ItemList was defined in IDE
            {
                StretchArray();

                //\\\\\ WM_COMMAND
            }
            //ORIGINAL LINE: Case m.Msg = WM_COMMAND AndAlso m.WParam = new System.IntPtr(66536)
            else if (true == (m.Msg == WM_COMMAND && m.WParam == new System.IntPtr(66536)))
            {
                if (mLastMessage == 8235) //FIX for ignoring SIC event on keyboard controlling i.e. F4 + down arrow
                {
                    mHoverIndex = this.SelectedIndex;
                    if (ItemHover != null)
                        ItemHover(mHoverIndex);
                    mLastMessage = m.Msg;
                    return;
                }
                //1 - normal behaviour when no checkboxes
                if (!this.mCheckBoxes)
                {
                    base.WndProc(ref m);
                    return;
                }
                //2 - (NEW) nulls MouseWheel on not .DropDown
                if (!this.DroppedDown)
                {
                    return;
                }
                //3 - ClickEvent reconstruction (cancelled) child events from WM_COMMAND MSG
                SendMessage(this.Handle, OCM_COMMAND, 591814, new IntPtr(1705748)); //1
                SendMessage(this.Handle, OCM_COMMAND, 67526, new IntPtr(1705748)); //2 SelectedIndexChange
                SendMessage(this.Handle, CB_GETCURSEL, 0, new IntPtr(0)); //3
                SendMessage(this.Handle, WM_LBUTTONUP, 0, new IntPtr(721012)); //4
                //4 - cancels event
                return;
            }

            mLastMessage = m.Msg;
            base.WndProc(ref m);

        }

        //subs
        private void PrepareTimer()
        {
            mTimer = null;
            mTimer = new Timer();
            mTimer.Interval = 64;
            mTimer.Enabled = true;
            mTimer.Tick += mTimer_Tick;
            mFirerTimer = 1;
        }
        private void mTimer_Tick(object sender, System.EventArgs e)
        {
            if (mFirerTimer > 0)
            {
                mTimer.Enabled = false;
                mTimer.Dispose();
                ForceRedraw();
                this.Text = FormatCheckString();
                mFirerTimer = 0;
            }
        }

        //private
        private void StretchArray()
        {

            Array.Resize(ref mItemsChecks, this.Items.Count);

        }
        private void GetHoverIndexFromCursor()
        {
            Int32 yPos = 0;
            yPos = this.PointToClient(Cursor.Position).Y;
            if (this.DropDownStyle == ComboBoxStyle.Simple)
            {
                yPos -= (this.ItemHeight + 10);
            }
            else
            {
                yPos -= (this.Size.Height + 1);
            }
            mHoverIndex_Dec = yPos / (double)this.ItemHeight;
            mHoverIndex = System.Convert.ToInt32(Math.Floor(mHoverIndex_Dec));

        }
        private void ForceRedraw()
        {
            if (this.Items.Count > 0)
            {
                mKillEvents1 += 1;
                mKillEvents2 += 1;
                if (this.SelectedIndex == this.Items.Count - 1)
                {
                    this.SelectedIndex -= 1;
                    mKillEvents2 -= 1;
                    this.SelectedIndex += 1;
                    mKillEvents1 -= 1;
                }
                else
                {
                    this.SelectedIndex += 1;
                    mKillEvents2 -= 1;
                    this.SelectedIndex -= 1;
                    mKillEvents1 -= 1;
                }
            }
        }
        private string FormatCheckString()
        {
            //NOTE returns "a,b & c" for internal use
            Int32 i = 0;
            System.Text.StringBuilder sb = new System.Text.StringBuilder("");
            string s = null;
            string zFirst = null;
            string zLast = null;
            Int32 zLastComa = 0;
            string zSpace = " ";
            if (!this.CheckBoxes)
            {
                return this.Text;
            }
            for (i = 0; i < this.Items.Count; i++)
            {
                if (IsItemAGroup(i))
                {
                    continue;
                }
                if (this.get_ItemsChecks(i) == CheckState.Checked)
                {
                    if (DataSource == null) //TN Engineers
                    {
                        sb.Append(this.Items[i].ToString());
                    }
                    else
                    {
                        sb.Append(((System.Data.DataRowView)(this.Items[i]))[this.DisplayMember].ToString());
                    }
                    sb.Append(mItemSeparator1);
                }
            }
            s = sb.ToString();
            if (s.Length == 0)
            {
                return "";
            }
            s = s.Substring(0, s.Length - 1);
            zLastComa = s.LastIndexOf(mItemSeparator1);
            if (zLastComa != -1)
            {
                zLast = s.Substring(zLastComa);
                zFirst = s.Substring(0, zLastComa);
                s = zFirst + zSpace + zLast.Replace(Convert.ToString(mItemSeparator1), Convert.ToString(mItemSeparator2) + zSpace);
                return s;
            }
            else
            {
                return s + " ";
            }
        }
        private bool IsItemAGroup(Int32 xIndex)
        {
            if (this.mDividerFormat.Length > 0 && this.Items[xIndex].ToString().Contains(this.mDividerFormat))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        //public
        public void CheckAll()
        {

            Int32 i = 0;

            if (!mCheckBoxes)
            {
                return;
            }
            StretchArray(); //NOTE can be fired before an CB_ADDSTRING msg
            for (i = 0; i <= mItemsChecks.GetUpperBound(0); i++)
            {
                if (!(IsItemAGroup(i)))
                {
                    mItemsChecks[i] = CheckState.Checked;
                }
            }
            this.Text = FormatCheckString();

        }
        public void CheckNone()
        {

            Int32 i = 0;

            if (!mCheckBoxes)
            {
                return;
            }
            StretchArray(); //NOTE can be fired before an CB_ADDSTRING msg
            for (i = 0; i <= mItemsChecks.GetUpperBound(0); i++)
            {
                if (!(IsItemAGroup(i)))
                {
                    mItemsChecks[i] = CheckState.Unchecked;
                }
            }
            this.Text = FormatCheckString();

        }

        //personal methods

        public string CHECKED2CSV()
        {
            return CHECKED2CSV(false);
        }

        //INSTANT C# NOTE: Overloaded method(s) are created above to convert the following method having optional parameters:
        //ORIGINAL LINE: Public Function CHECKED2CSV(Optional ByVal xGravelWrap As Boolean = false) As String
        public string CHECKED2CSV(bool xGravelWrap)
        {
            //NOTE returns "a,b,c" for external user
            Int32 i = 0;
            System.Text.StringBuilder sb = new System.Text.StringBuilder("");
            string s = null;
            for (i = 0; i < this.Items.Count; i++)
            {
                if (IsItemAGroup(i))
                {
                    continue;
                }
                if (get_ItemsChecks(i) == CheckState.Checked)
                {
                    if (DataSource == null) //TN Engineers
                    {

                        if (xGravelWrap)
                        {
                            sb.Append("`" + this.Items[i].ToString() + "`,");
                        }
                        else
                        {
                            sb.Append(this.Items[i].ToString() + ",");
                        }

                    }
                    else
                    {
                        sb.Append(((System.Data.DataRowView)(this.Items[i]))[this.ValueMember].ToString() + ",");
                    }
                }
            }
            s = sb.ToString();
            if (s.Length > 0)
            {
                s = s.Substring(0, s.Length - 1);
            }
            return s;
        }

        public string CHECKED2IDCSV()
        {
            return CHECKED2IDCSV(true);
        }

        //INSTANT C# NOTE: Overloaded method(s) are created above to convert the following method having optional parameters:
        //ORIGINAL LINE: Public Function CHECKED2IDCSV(Optional ByVal xZeroBound As Boolean = true) As String
        public string CHECKED2IDCSV(bool xZeroBound)
        {
            Int32 i = 0;
            Int32 c = 0;
            Int32 a = 0;
            System.Text.StringBuilder sb = new System.Text.StringBuilder("");
            string s = null;
            if (xZeroBound)
            {
                a = 0;
            }
            else
            {
                a = 1;
            }
            for (i = 0; i < this.Items.Count; i++)
            {
                if (IsItemAGroup(i))
                {
                    continue;
                }
                if (this.get_ItemsChecks(i) == CheckState.Checked)
                {
                    if (this.mDividerFormat.Length > 0)
                    {
                        sb.Append((c + a).ToString() + ",");
                    }
                    else
                    {
                        sb.Append((i + a).ToString() + ",");
                    }
                }

                c += 1;
            }
            s = sb.ToString();
            if (s.Length > 0)
            {
                s = s.Substring(0, s.Length - 1);
            }
            return s;
        }
        public string CHECKED2BITSHIFT()
        {
            Int32 i = 0;
            Int32 c = 1;
            Int32 a = 0;
            for (i = 0; i < this.Items.Count; i++)
            {
                if (IsItemAGroup(i))
                {
                    continue;
                }
                if (this.get_ItemsChecks(i) != CheckState.Checked)
                {
                    a += c;
                }
                c = (c * 2);
            }
            return a.ToString();
        }

        #region Krypton

        private void InitColours()
        {
            _alternateRowColor = _palette.ColorTable.ToolStripContentPanelGradientBegin;
        }

        //Kripton Palette Events
        private new void OnGlobalPaletteChanged(object sender, EventArgs e)
        {
            // Unhook events from old palette
            if (_palette != null)
                _palette.PalettePaint -= new EventHandler<PaletteLayoutEventArgs>(OnPalettePaint);

            // Cache the new IPalette that is the global palette
            _palette = KryptonManager.CurrentGlobalPalette;
            _paletteRedirect.Target = _palette;

            // Hook into events for the new palette
            if (_palette != null)
            {
                _palette.PalettePaint += new EventHandler<PaletteLayoutEventArgs>(OnPalettePaint);
                InitColours();
            }

            // Change of palette means we should repaint to show any changes
            Invalidate();
        }

        //Kripton Palette Events
        private void OnPalettePaint(object sender, PaletteLayoutEventArgs e)
        {
            Invalidate();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {

                if (_palette != null)
                {
                    _palette.PalettePaint -= new EventHandler<PaletteLayoutEventArgs>(OnPalettePaint);
                    _palette = null;
                }


                KryptonManager.GlobalPaletteChanged -= new EventHandler(OnGlobalPaletteChanged);
            }

            base.Dispose(disposing);
        }
        #endregion
    }
}