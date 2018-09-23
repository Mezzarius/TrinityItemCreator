using System;
using System.Drawing;
using System.Windows.Forms;
using TrinityItemCreator.MyClass;

namespace TrinityItemCreator
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

        private void Watermark_MyTextBox_Leave(object sender, EventArgs e)
        {
            MyTextBox mTextBox = (MyTextBox)sender;
            if (mTextBox.Text.Length == 0)
                mTextBox.Text = "0";
        }

        private void Watermark_MyTextBox_Enter(object sender, EventArgs e)
        {
            MyTextBox mTextBox = (MyTextBox)sender;
            if (mTextBox.Text == "0")
                mTextBox.Text = "";
        }

        private void Watermark_MyTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void MyTextBox25_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(MyTextBox25.Text, out int userVal))
                QueryHandler.column_minMoneyLoot = userVal;
        }

        private void MyTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(MyTextBox1.Text, out int userVal))
                QueryHandler.column_maxMoneyLoot = userVal;
        }

        private void MyTextBox2_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(MyTextBox2.Text, out int userVal))
                QueryHandler.column_lockid = userVal;
        }

        private void MyTextBox3_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(MyTextBox3.Text, out int userVal))
                QueryHandler.column_PageMaterial = userVal;
        }

        private void MyTextBox4_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(MyTextBox4.Text, out int userVal))
                QueryHandler.column_PageText = userVal;
        }

        private void MyTextBox5_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(MyTextBox5.Text, out int userVal))
                QueryHandler.column_LanguageID = userVal;
        }

        private void MyTextBox21_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(MyTextBox21.Text, out int userVal))
                QueryHandler.column_RequiredReputationFaction = userVal;
        }

        private void MyTextBox22_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(MyTextBox2.Text, out int userVal))
                QueryHandler.column_RequiredReputationRank = userVal;
        }

        private void MyTextBox7_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(MyTextBox7.Text, out int userVal))
                QueryHandler.column_RequiredDisenchantSkill = userVal;
        }

        private void MyTextBox8_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(MyTextBox8.Text, out int userVal))
                QueryHandler.column_DisenchantID = userVal;
        }

        private void MyTextBox19_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(MyTextBox19.Text, out int userVal))
                QueryHandler.column_requiredhonorrank = userVal;
        }

        private void MyTextBox20_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(MyTextBox20.Text, out int userVal))
                QueryHandler.column_RequiredCityRank = userVal;
        }

        private void MyTextBox16_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(MyTextBox16.Text, out int userVal))
                QueryHandler.column_RequiredSkill = userVal;
        }

        private void MyTextBox17_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(MyTextBox17.Text, out int userVal))
                QueryHandler.column_RequiredSkillRank = userVal;
        }

        private void MyTextBox18_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(MyTextBox18.Text, out int userVal))
                QueryHandler.column_requiredspell = userVal;
        }

        private void MyTextBox15_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(MyTextBox15.Text, out int userVal))
                QueryHandler.column_Map = userVal;
        }

        private void MyTextBox14_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(MyTextBox14.Text, out int userVal))
                QueryHandler.column_area = userVal;
        }

        private void MyTextBox13_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(MyTextBox13.Text, out int userVal))
                QueryHandler.column_duration = userVal;
        }

        private void MyTextBox6_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(MyTextBox6.Text, out int userVal))
                QueryHandler.column_startquest = userVal;
        }

        private void MyTextBox9_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(MyTextBox9.Text, out int userVal))
                QueryHandler.column_GemProperties = userVal;
        }

        private void MyTextBox10_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(MyTextBox10.Text, out int userVal))
                QueryHandler.column_HolidayId = userVal;
        }

        private void MyTextBox11_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(MyTextBox11.Text, out int userVal))
                QueryHandler.column_SoundOverrideSubclass = userVal;
        }

        private void MyTextBox12_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(MyTextBox12.Text, out int userVal))
                QueryHandler.column_ItemLimitCategory = userVal;
        }

        private void Window_Other_Options_Load(object sender, EventArgs e)
        {
            MyTextBox1.Text = QueryHandler.column_maxMoneyLoot.ToString();
            MyTextBox2.Text = QueryHandler.column_lockid.ToString();
            MyTextBox3.Text = QueryHandler.column_PageMaterial.ToString();
            MyTextBox4.Text = QueryHandler.column_PageText.ToString();
            MyTextBox5.Text = QueryHandler.column_LanguageID.ToString();
            MyTextBox6.Text = QueryHandler.column_startquest.ToString();
            MyTextBox7.Text = QueryHandler.column_RequiredDisenchantSkill.ToString();
            MyTextBox8.Text = QueryHandler.column_DisenchantID.ToString();
            MyTextBox9.Text = QueryHandler.column_GemProperties.ToString();
            MyTextBox10.Text = QueryHandler.column_HolidayId.ToString();
            MyTextBox11.Text = QueryHandler.column_SoundOverrideSubclass.ToString();
            MyTextBox12.Text = QueryHandler.column_ItemLimitCategory.ToString();
            MyTextBox13.Text = QueryHandler.column_duration.ToString();
            MyTextBox14.Text = QueryHandler.column_area.ToString();
            MyTextBox15.Text = QueryHandler.column_Map.ToString();
            MyTextBox16.Text = QueryHandler.column_RequiredSkill.ToString();
            MyTextBox17.Text = QueryHandler.column_RequiredSkillRank.ToString();
            MyTextBox18.Text = QueryHandler.column_requiredspell.ToString();
            MyTextBox19.Text = QueryHandler.column_requiredhonorrank.ToString();
            MyTextBox20.Text = QueryHandler.column_RequiredCityRank.ToString();
            MyTextBox21.Text = QueryHandler.column_RequiredReputationFaction.ToString();
            MyTextBox22.Text = QueryHandler.column_RequiredReputationRank.ToString();
            MyTextBox25.Text = QueryHandler.column_minMoneyLoot.ToString();
        }
    }
}
