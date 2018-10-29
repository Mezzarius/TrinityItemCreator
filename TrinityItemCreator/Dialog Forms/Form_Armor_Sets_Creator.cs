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

    public Form_Armor_Sets_Creator(Form_Main form1)
        {
            InitializeComponent();

            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);

            mainForm = form1;

            slots = new[] { Helm, Shoulders, Chest, Wrists, Hands, Waist, Legs, Feet };
            options = new[] { AllClasses, AllRaces, NoMoneyCost, NoSellPrice, NoFlags };
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


            return string.Empty;
        }
    }
}
