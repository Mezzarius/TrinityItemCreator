using System;
using System.Linq;
using System.Windows.Forms;
using TrinityItemCreator.MyClass;

namespace TrinityItemCreator
{
    public partial class Window_RaceMask : Form
    {
        private Form1 mainForm;
        private static bool mIsChecked = false;

        public Window_RaceMask(Form1 form1)
        {
            InitializeComponent();

            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);

            mainForm = form1;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                var parms = base.CreateParams;
                parms.Style &= ~0x02000000;  // Turn off WS_CLIPCHILDREN
                return parms;
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

        private void Window_RaceMask_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void TextBoxRaceMask_TextChanged(object sender, EventArgs e)
        {
            int _mask = Convert.ToInt32(TextBoxRaceMask.Text) < 0 ? 1791 : Convert.ToInt32(TextBoxRaceMask.Text);

            foreach (var checkBox in Controls.OfType<CheckBox>())
                checkBox.Checked = Convert.ToBoolean(_mask & Convert.ToInt32(checkBox.Tag));

            MyData.Field_AllowableRace = _mask;
        }

        private void Window_RaceMask_Load(object sender, EventArgs e)
        {
            MyData.Field_AllowableRace = MyData.Field_AllowableRace == -1 ? 0 : MyData.Field_AllowableRace;

            foreach (var checkBox in Controls.OfType<CheckBox>())
            {
                checkBox.CheckedChanged += new EventHandler(HandleCheckBoxState);
                checkBox.Click += new EventHandler(ResetManualTextBoxRaceMask);

                if ((MyData.Field_AllowableRace & Convert.ToInt32(checkBox.Tag)) != 0)
                    checkBox.Checked = true;
                else
                    TextBoxRaceMask.Text = MyData.Field_AllowableRace.ToString(); // contains different class mask then add full class mask to text box
            }
        }

        private void HandleCheckBoxState(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;

            if (checkBox.Checked)
            {
                if ((MyData.Field_AllowableRace & Convert.ToInt32(checkBox.Tag)) == 0)
                    MyData.Field_AllowableRace += Convert.ToInt32(checkBox.Tag);
            }
            else
            {
                if ((MyData.Field_AllowableRace & Convert.ToInt32(checkBox.Tag)) != 0)
                    MyData.Field_AllowableRace -= Convert.ToInt32(checkBox.Tag);
            }
        }

        private void ResetManualTextBoxRaceMask(object sender, EventArgs e)
        {
            TextBoxRaceMask.Text = "0";
        }
    }
}
