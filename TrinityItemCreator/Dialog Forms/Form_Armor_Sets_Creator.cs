using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrinityItemCreator.Dialog_Forms
{
    public partial class Form_Armor_Sets_Creator : Form
    {
        private Form_Main mainForm;
        private CheckBox[] slots;
        private CheckBox[] options;
        private ComboBox[] stats;
        private MyTextBox[] values;
        private List<string> myquery = new List<string>();
        private int[] tier1;
        private int[] tier2;
        private int[] tier3;
        private int[] tier4;
        private int[] tier5;
        private int[] tier6;
        private int[] tier7;
        private int[] tier8;
        private int[] tier9;
        private int[] tier10;

        public Form_Armor_Sets_Creator(Form_Main form1)
        {
            InitializeComponent();

            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);

            mainForm = form1;

            slots = new[] { Helm, Shoulders, Chest, Wrists, Hands, Waist, Legs, Feet };
            options = new[] { AllClasses, AllRaces, NoMoneyCost, NoSellPrice, NoFlags };
            stats = new[] { stat1, stat2, stat3, stat4, stat5, stat6, stat7, stat8, stat9, stat10 };
            values = new[] { value1, value2, value3, value4, value5, value6, value7, value8, value9, value10 };

            InitializeTier1();
            InitializeTier2();
            InitializeTier3();
            InitializeTier4();
            InitializeTier5();
            InitializeTier6();
            InitializeTier7();
            InitializeTier8();
            InitializeTier9();
            InitializeTier10();
        }

        private void InitializeTier1()
        {
            tier1[1] = 209;         //warrior
            tier1[2] = 208;         //paladin
            tier1[4] = 206;         //hunter
            tier1[8] = 204;         //rogue
            tier1[16] = 202;        //priest
            tier1[64] = 207;        //shaman
            tier1[128] = 201;       //mage
            tier1[256] = 203;       //warlock
            tier1[1024] = 205;      //druid
        }

        private void InitializeTier2()
        {
            tier2[1] = 218;         //warrior
            tier2[2] = 217;         //paladin
            tier2[4] = 215;         //hunter
            tier2[8] = 213;         //rogue
            tier2[16] = 211;        //priest
            tier2[64] = 216;        //shaman
            tier2[128] = 213;       //mage
            tier2[256] = 212;       //warlock
            tier2[1024] = 214;      //druid
        }

        private void InitializeTier3()
        {
            tier3[1] = 523;         //warrior
            tier3[2] = 528;         //paladin
            tier3[4] = 530;         //hunter
            tier3[8] = 524;         //rogue
            tier3[16] = 525;        //priest
            tier3[64] = 527;        //shaman
            tier3[128] = 526;       //mage
            tier3[256] = 529;       //warlock
            tier3[1024] = 521;      //druid
        }

        private void InitializeTier4()
        {
            tier4[1] = 523;         //warrior
            tier4[2] = 528;         //paladin
            tier4[4] = 530;         //hunter
            tier4[8] = 524;         //rogue
            tier4[16] = 525;        //priest
            tier4[64] = 527;        //shaman
            tier4[128] = 526;       //mage
            tier4[256] = 529;       //warlock
            tier4[1024] = 521;      //druid
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

        private void Form_Armor_Sets_Creator_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void ButtonFinish_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form_Armor_Sets_Creator_Load(object sender, EventArgs e)
        {
            BaseStatsFrom.SelectedIndex = 0;
            ChbAllSlots.Checked = true;
            foreach (var cbox in Controls.OfType<ComboBox>()) cbox.SelectedIndex = 0;
        }

        private void BaseStatsSetID_TextChanged(object sender, EventArgs e)
        {
            uint.TryParse(BaseStatsSetID.Text, out uint SetID);
            if (SetID != 0)
            {
                BaseStatsFrom.Enabled = false;

            }
            else
            {
                BaseStatsFrom.Enabled = true;
            }
        }

        private void ChbAllSlots_CheckedChanged(object sender, EventArgs e)
        {
            if (ChbAllSlots.Checked) // select all and disable
            {
                foreach (var slot in slots)
                {
                    slot.Enabled = false;
                    slot.Checked = true;
                }
            }
            else // unselect all and renable
            {
                foreach (var slot in slots)
                {
                    slot.Enabled = true;
                    slot.Checked = false;
                }
            }
        }

        private void ChbAllOptions_CheckedChanged(object sender, EventArgs e)
        {
            if (ChbAllOptions.Checked) // select all and disable
            {
                foreach (var option in options)
                {
                    option.Enabled = false;
                    option.Checked = true;
                }
            }
            else // unselect all and renable
            {
                foreach (var option in options)
                {
                    option.Enabled = true;
                    option.Checked = false;
                }
            }
        }

        private void ButtonSelectAll_Click(object sender, EventArgs e)
        {
            string sqlquery = GetSQLQuery();
        }

        private string GetSQLQuery()
        {
            string table_temp = "item_template_copy_temp";

            myquery.Clear();
            myquery.Add($"CREATE TABLE IF NOT EXISTS {table_temp} LIKE item_template;");

            if (BaseStatsFrom.Enabled)
            {
                if (BaseStatsFrom.SelectedIndex == 0) // tier 1
                {
                    string s = BaseStatsFrom.SelectedItem.ToString();
                    uint.TryParse(s.Remove(s.IndexOf(']')).Substring(s.IndexOf('[') + 1), out uint classid);
                    string qline = "WHERE itemset IN(";

                    if (classid == 1) // warrior
                        qline += "209";

                            qline += ")";
                }
            }
            else
            {

            }

            return string.Empty;
        }
    }
}
