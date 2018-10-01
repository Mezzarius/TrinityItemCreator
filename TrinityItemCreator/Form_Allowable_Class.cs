using System;
using System.Linq;
using System.Windows.Forms;
using TrinityItemCreator.MyClass;

namespace TrinityItemCreator
{
    public partial class Form_Allowable_Class : Form
    {
        private Form_Main mainForm;
        private static bool mIsChecked = false;

        public Form_Allowable_Class(Form_Main form1)
        {
            InitializeComponent();

            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);

            mainForm = form1;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        private void Watermark_myTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            MyTextBox myTextBox = (MyTextBox)sender;
            if (myTextBox.Text.Length <= 1 && e.KeyChar == (char)Keys.Back)
                e.Handled = true;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void ButtonSelectAll_Click(object sender, EventArgs e)
        {
            foreach (var chkBox in Controls.OfType<CheckBox>())
                chkBox.Checked = mIsChecked ? false : true;

            mIsChecked = mIsChecked ? false : true;
        }

        private void ButtonFinish_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Window_ClassMask_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void TextBoxClassMask_TextChanged(object sender, EventArgs e)
        {
            int _mask = Convert.ToInt32(TextBoxClassMask.Text) < 0 ? 1535 : Convert.ToInt32(TextBoxClassMask.Text);

            foreach (var checkBox in Controls.OfType<CheckBox>())
                checkBox.Checked = Convert.ToBoolean(_mask & Convert.ToInt32(checkBox.Tag));

            MyData.Field_AllowableClass = _mask == 0 ? -1 : _mask;
        }

        private void Window_ClassMask_Load(object sender, EventArgs e)
        {
            MyData.Field_AllowableClass = MyData.Field_AllowableClass == -1 ? 0 : MyData.Field_AllowableClass;

            foreach (var checkBox in Controls.OfType<CheckBox>())
            {
                checkBox.CheckedChanged += new EventHandler(HandleCheckBoxState);
                checkBox.Click += new EventHandler(ResetManualTextBoxClassMask);

                if ((MyData.Field_AllowableClass & Convert.ToInt32(checkBox.Tag)) != 0)
                    checkBox.Checked = true;
                else
                    TextBoxClassMask.Text = MyData.Field_AllowableClass.ToString(); // contains different class mask then add full class mask to text box
            }
        }
        
        private void HandleCheckBoxState(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;

            if (checkBox.Checked)
            {
                if ((MyData.Field_AllowableClass & Convert.ToInt32(checkBox.Tag)) == 0)
                    MyData.Field_AllowableClass += Convert.ToInt32(checkBox.Tag);
            }
            else
            {
                if ((MyData.Field_AllowableClass & Convert.ToInt32(checkBox.Tag)) != 0)
                    MyData.Field_AllowableClass -= Convert.ToInt32(checkBox.Tag);
            }

            if (MyData.Field_AllowableClass == 0)
                MyData.Field_AllowableClass = -1;
        }

        private void ResetManualTextBoxClassMask(object sender, EventArgs e)
        {
            TextBoxClassMask.Text = "0";
        }
    }
}
