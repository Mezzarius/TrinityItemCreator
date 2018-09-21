using System;
using System.Drawing;
using System.Windows.Forms;
using TIC19.MyClass;

namespace TIC19
{
    public partial class Window_Resistances : Form
    {
        private Form1 mainForm;

        public Window_Resistances(Form1 form1)
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

        private void Watermark_myTextBox_Leave(object sender, EventArgs e)
        {
            MyTextBox mTextBox = (MyTextBox)sender;
            if (mTextBox.Text.Length == 0)
            {
                mTextBox.Text = "Required!";
                mTextBox.ForeColor = Color.Red;
            }
        }

        private void Watermark_myTextBox_Enter(object sender, EventArgs e)
        {
            MyTextBox mTextBox = (MyTextBox)sender;
            if (mTextBox.Text == "Required!")
            {
                mTextBox.Text = "";
                mTextBox.ForeColor = Color.DimGray;
            }
        }

        private void Watermark_myTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Window_Resistances_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void myTextBox5_TextChanged(object sender, EventArgs e)
        {
            MyTextBox objTextBox = (MyTextBox)sender;

            int userVal;
            if (int.TryParse(objTextBox.Text, out userVal))
                QueryHandler.column_holy_res = userVal;
        }

        private void myTextBox1_TextChanged(object sender, EventArgs e)
        {
            MyTextBox objTextBox = (MyTextBox)sender;

            int userVal;
            if (int.TryParse(objTextBox.Text, out userVal))
                QueryHandler.column_frost_res = userVal;
        }

        private void myTextBox2_TextChanged(object sender, EventArgs e)
        {
            MyTextBox objTextBox = (MyTextBox)sender;

            int userVal;
            if (int.TryParse(objTextBox.Text, out userVal))
                QueryHandler.column_fire_res = userVal;
        }

        private void myTextBox6_TextChanged(object sender, EventArgs e)
        {
            MyTextBox objTextBox = (MyTextBox)sender;

            int userVal;
            if (int.TryParse(objTextBox.Text, out userVal))
                QueryHandler.column_shadow_res = userVal;
        }

        private void myTextBox4_TextChanged(object sender, EventArgs e)
        {
            MyTextBox objTextBox = (MyTextBox)sender;

            int userVal;
            if (int.TryParse(objTextBox.Text, out userVal))
                QueryHandler.column_nature_res = userVal;
        }

        private void myTextBox3_TextChanged(object sender, EventArgs e)
        {
            MyTextBox objTextBox = (MyTextBox)sender;

            int userVal;
            if (int.TryParse(objTextBox.Text, out userVal))
                QueryHandler.column_arcane_res = userVal;
        }
    }
}
