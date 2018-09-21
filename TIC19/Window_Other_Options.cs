using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TIC19.MyClass;

namespace TIC19
{
    public partial class Window_Other_Options : Form
    {
        private Form1 mainForm;

        public Window_Other_Options(Form1 form1)
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

        private void Window_Other_Options_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void myTextBox25_TextChanged(object sender, EventArgs e)
        {
            MyTextBox objTextBox = (MyTextBox)sender;

            int userVal;
            if (int.TryParse(objTextBox.Text, out userVal))
                QueryHandler.column_minMoneyLoot = userVal;
        }

        private void myTextBox1_TextChanged(object sender, EventArgs e)
        {
            MyTextBox objTextBox = (MyTextBox)sender;

            int userVal;
            if (int.TryParse(objTextBox.Text, out userVal))
                QueryHandler.column_maxMoneyLoot = userVal;
        }

        private void myTextBox2_TextChanged(object sender, EventArgs e)
        {
            MyTextBox objTextBox = (MyTextBox)sender;

            int userVal;
            if (int.TryParse(objTextBox.Text, out userVal))
                QueryHandler.column_lockid = userVal;
        }

        private void myTextBox3_TextChanged(object sender, EventArgs e)
        {
            MyTextBox objTextBox = (MyTextBox)sender;

            int userVal;
            if (int.TryParse(objTextBox.Text, out userVal))
                QueryHandler.column_PageMaterial = userVal;
        }

        private void myTextBox4_TextChanged(object sender, EventArgs e)
        {
            MyTextBox objTextBox = (MyTextBox)sender;

            int userVal;
            if (int.TryParse(objTextBox.Text, out userVal))
                QueryHandler.column_PageText = userVal;
        }

        private void myTextBox5_TextChanged(object sender, EventArgs e)
        {
            MyTextBox objTextBox = (MyTextBox)sender;

            int userVal;
            if (int.TryParse(objTextBox.Text, out userVal))
                QueryHandler.column_LanguageID = userVal;
        }

        private void myTextBox21_TextChanged(object sender, EventArgs e)
        {
            MyTextBox objTextBox = (MyTextBox)sender;

            int userVal;
            if (int.TryParse(objTextBox.Text, out userVal))
                QueryHandler.column_RequiredReputationFaction = userVal;
        }

        private void myTextBox22_TextChanged(object sender, EventArgs e)
        {
            MyTextBox objTextBox = (MyTextBox)sender;

            int userVal;
            if (int.TryParse(objTextBox.Text, out userVal))
                QueryHandler.column_RequiredReputationRank = userVal;
        }

        private void myTextBox7_TextChanged(object sender, EventArgs e)
        {
            MyTextBox objTextBox = (MyTextBox)sender;

            int userVal;
            if (int.TryParse(objTextBox.Text, out userVal))
                QueryHandler.column_RequiredDisenchantSkill = userVal;
        }

        private void myTextBox8_TextChanged(object sender, EventArgs e)
        {
            MyTextBox objTextBox = (MyTextBox)sender;

            int userVal;
            if (int.TryParse(objTextBox.Text, out userVal))
                QueryHandler.column_DisenchantID = userVal;
        }

        private void myTextBox19_TextChanged(object sender, EventArgs e)
        {
            MyTextBox objTextBox = (MyTextBox)sender;

            int userVal;
            if (int.TryParse(objTextBox.Text, out userVal))
                QueryHandler.column_requiredhonorrank = userVal;
        }

        private void myTextBox20_TextChanged(object sender, EventArgs e)
        {
            MyTextBox objTextBox = (MyTextBox)sender;

            int userVal;
            if (int.TryParse(objTextBox.Text, out userVal))
                QueryHandler.column_RequiredCityRank = userVal;
        }

        private void myTextBox16_TextChanged(object sender, EventArgs e)
        {
            MyTextBox objTextBox = (MyTextBox)sender;

            int userVal;
            if (int.TryParse(objTextBox.Text, out userVal))
                QueryHandler.column_RequiredSkill = userVal;
        }

        private void myTextBox17_TextChanged(object sender, EventArgs e)
        {
            MyTextBox objTextBox = (MyTextBox)sender;

            int userVal;
            if (int.TryParse(objTextBox.Text, out userVal))
                QueryHandler.column_RequiredSkillRank = userVal;
        }

        private void myTextBox18_TextChanged(object sender, EventArgs e)
        {
            MyTextBox objTextBox = (MyTextBox)sender;

            int userVal;
            if (int.TryParse(objTextBox.Text, out userVal))
                QueryHandler.column_requiredspell = userVal;
        }

        private void myTextBox15_TextChanged(object sender, EventArgs e)
        {
            MyTextBox objTextBox = (MyTextBox)sender;

            int userVal;
            if (int.TryParse(objTextBox.Text, out userVal))
                QueryHandler.column_Map = userVal;
        }

        private void myTextBox14_TextChanged(object sender, EventArgs e)
        {
            MyTextBox objTextBox = (MyTextBox)sender;

            int userVal;
            if (int.TryParse(objTextBox.Text, out userVal))
                QueryHandler.column_area = userVal;
        }

        private void myTextBox13_TextChanged(object sender, EventArgs e)
        {
            MyTextBox objTextBox = (MyTextBox)sender;

            int userVal;
            if (int.TryParse(objTextBox.Text, out userVal))
                QueryHandler.column_duration = userVal;
        }

        private void myTextBox6_TextChanged(object sender, EventArgs e)
        {
            MyTextBox objTextBox = (MyTextBox)sender;

            int userVal;
            if (int.TryParse(objTextBox.Text, out userVal))
                QueryHandler.column_startquest = userVal;
        }

        private void myTextBox9_TextChanged(object sender, EventArgs e)
        {
            MyTextBox objTextBox = (MyTextBox)sender;

            int userVal;
            if (int.TryParse(objTextBox.Text, out userVal))
                QueryHandler.column_GemProperties = userVal;
        }

        private void myTextBox10_TextChanged(object sender, EventArgs e)
        {
            MyTextBox objTextBox = (MyTextBox)sender;

            int userVal;
            if (int.TryParse(objTextBox.Text, out userVal))
                QueryHandler.column_HolidayId = userVal;
        }

        private void myTextBox11_TextChanged(object sender, EventArgs e)
        {
            MyTextBox objTextBox = (MyTextBox)sender;

            int userVal;
            if (int.TryParse(objTextBox.Text, out userVal))
                QueryHandler.column_SoundOverrideSubclass = userVal;
        }

        private void myTextBox12_TextChanged(object sender, EventArgs e)
        {
            MyTextBox objTextBox = (MyTextBox)sender;

            int userVal;
            if (int.TryParse(objTextBox.Text, out userVal))
                QueryHandler.column_ItemLimitCategory = userVal;
        }
    }
}
