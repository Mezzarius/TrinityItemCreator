using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TrinityItemCreator.MyClass;

namespace TrinityItemCreator
{
    public partial class Form_Stats_Generator : Form
    {
        private Form_Main mainForm;
        private static bool[] CheckStatBoxes = new bool[10];
        private static string[] rangeBoxes = { "1000", "10000" };

        public Form_Stats_Generator(Form_Main form1)
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

        private void Window_GenerateStats_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void ButtonCancel_Click(object sender, EventArgs e) => Close();

        private void Window_GenerateStats_Load(object sender, EventArgs e)
        {
            TextBoxRangeMin.Text = rangeBoxes[0];
            TextBoxRangeMax.Text = rangeBoxes[1];

            CheckStat1.Checked = CheckStatBoxes[0];
            CheckStat2.Checked = CheckStatBoxes[1];
            CheckStat3.Checked = CheckStatBoxes[2];
            CheckStat4.Checked = CheckStatBoxes[3];
            CheckStat5.Checked = CheckStatBoxes[4];
            CheckStat6.Checked = CheckStatBoxes[5];
            CheckStat7.Checked = CheckStatBoxes[6];
            CheckStat8.Checked = CheckStatBoxes[7];
            CheckStat9.Checked = CheckStatBoxes[8];
            CheckStat10.Checked = CheckStatBoxes[9];

            ComboBoxStat1.SelectedIndex = ComboBoxStat1.FindString(string.Format("[{0}]", MyData.ItemTemplateValues[28]));
            ComboBoxStat2.SelectedIndex = ComboBoxStat2.FindString(string.Format("[{0}]", MyData.ItemTemplateValues[30]));
            ComboBoxStat3.SelectedIndex = ComboBoxStat3.FindString(string.Format("[{0}]", MyData.ItemTemplateValues[32]));
            ComboBoxStat4.SelectedIndex = ComboBoxStat4.FindString(string.Format("[{0}]", MyData.ItemTemplateValues[34]));
            ComboBoxStat5.SelectedIndex = ComboBoxStat5.FindString(string.Format("[{0}]", MyData.ItemTemplateValues[36]));
            ComboBoxStat6.SelectedIndex = ComboBoxStat6.FindString(string.Format("[{0}]", MyData.ItemTemplateValues[38]));
            ComboBoxStat7.SelectedIndex = ComboBoxStat7.FindString(string.Format("[{0}]", MyData.ItemTemplateValues[40]));
            ComboBoxStat8.SelectedIndex = ComboBoxStat8.FindString(string.Format("[{0}]", MyData.ItemTemplateValues[42]));
            ComboBoxStat9.SelectedIndex = ComboBoxStat9.FindString(string.Format("[{0}]", MyData.ItemTemplateValues[44]));
            ComboBoxStat10.SelectedIndex = ComboBoxStat10.FindString(string.Format("[{0}]", MyData.ItemTemplateValues[46]));

            LabelStatValue1.Text = MyData.ItemTemplateValues[28];
            LabelStatValue2.Text = MyData.ItemTemplateValues[30];
            LabelStatValue3.Text = MyData.ItemTemplateValues[32];
            LabelStatValue4.Text = MyData.ItemTemplateValues[34];
            LabelStatValue5.Text = MyData.ItemTemplateValues[36];
            LabelStatValue6.Text = MyData.ItemTemplateValues[38];
            LabelStatValue7.Text = MyData.ItemTemplateValues[40];
            LabelStatValue8.Text = MyData.ItemTemplateValues[42];
            LabelStatValue9.Text = MyData.ItemTemplateValues[44];
            LabelStatValue10.Text = MyData.ItemTemplateValues[46];
        }

        private void Window_GenerateStats_FormClosed(object sender, FormClosedEventArgs e)
        {
            rangeBoxes[0] = String.IsNullOrEmpty(TextBoxRangeMin.Text) ? "1000" : TextBoxRangeMin.Text;
            rangeBoxes[1] = String.IsNullOrEmpty(TextBoxRangeMax.Text) ? "10000" : TextBoxRangeMax.Text;

            CheckStatBoxes[0] = CheckStat1.Checked;
            CheckStatBoxes[1] = CheckStat2.Checked;
            CheckStatBoxes[2] = CheckStat3.Checked;
            CheckStatBoxes[3] = CheckStat4.Checked;
            CheckStatBoxes[4] = CheckStat5.Checked;
            CheckStatBoxes[5] = CheckStat6.Checked;
            CheckStatBoxes[6] = CheckStat7.Checked;
            CheckStatBoxes[7] = CheckStat8.Checked;
            CheckStatBoxes[8] = CheckStat9.Checked;
            CheckStatBoxes[9] = CheckStat10.Checked;
        }

        private void ButtonGenerate_Click(object sender, EventArgs e)
        {
            /* When you create a Random instance it's seeded with the current time. 
             * So if you create several of them at the same time they'll generate the same random number sequence. 
             * You need to create a single instance of Random and use that. */
            Random random = new Random();

            Functions myF = new Functions();

            if (CheckStat1.Checked)
            {
                // if both are checked or unchecked at the same time
                if (CheckBoxOdd.Checked == CheckBoxEven.Checked)
                    LabelStatValue1.Text = myF.GenerateOddEvenNumber(random, Convert.ToInt32(TextBoxRangeMin.Text), Convert.ToInt32(TextBoxRangeMax.Text), 0).ToString();
                // if checkbox odd is checked
                else if (CheckBoxOdd.Checked)
                    LabelStatValue1.Text = myF.GenerateOddEvenNumber(random, Convert.ToInt32(TextBoxRangeMin.Text), Convert.ToInt32(TextBoxRangeMax.Text), 1).ToString();
                // if checkbox even is checked
                else
                    LabelStatValue1.Text = myF.GenerateOddEvenNumber(random, Convert.ToInt32(TextBoxRangeMin.Text), Convert.ToInt32(TextBoxRangeMax.Text), 2).ToString();
            }

            if (CheckStat2.Checked)
            {
                // if both are checked or unchecked at the same time
                if (CheckBoxOdd.Checked == CheckBoxEven.Checked)
                    LabelStatValue2.Text = myF.GenerateOddEvenNumber(random, Convert.ToInt32(TextBoxRangeMin.Text), Convert.ToInt32(TextBoxRangeMax.Text), 0).ToString();
                // if checkbox odd is checked
                else if (CheckBoxOdd.Checked)
                    LabelStatValue2.Text = myF.GenerateOddEvenNumber(random, Convert.ToInt32(TextBoxRangeMin.Text), Convert.ToInt32(TextBoxRangeMax.Text), 1).ToString();
                // if checkbox even is checked
                else
                    LabelStatValue2.Text = myF.GenerateOddEvenNumber(random, Convert.ToInt32(TextBoxRangeMin.Text), Convert.ToInt32(TextBoxRangeMax.Text), 2).ToString();
            }

            if (CheckStat3.Checked)
            {
                // if both are checked or unchecked at the same time
                if (CheckBoxOdd.Checked == CheckBoxEven.Checked)
                    LabelStatValue3.Text = myF.GenerateOddEvenNumber(random, Convert.ToInt32(TextBoxRangeMin.Text), Convert.ToInt32(TextBoxRangeMax.Text), 0).ToString();
                // if checkbox odd is checked
                else if (CheckBoxOdd.Checked)
                    LabelStatValue3.Text = myF.GenerateOddEvenNumber(random, Convert.ToInt32(TextBoxRangeMin.Text), Convert.ToInt32(TextBoxRangeMax.Text), 1).ToString();
                // if checkbox even is checked
                else
                    LabelStatValue3.Text = myF.GenerateOddEvenNumber(random, Convert.ToInt32(TextBoxRangeMin.Text), Convert.ToInt32(TextBoxRangeMax.Text), 2).ToString();
            }

            if (CheckStat4.Checked)
            {
                // if both are checked or unchecked at the same time
                if (CheckBoxOdd.Checked == CheckBoxEven.Checked)
                    LabelStatValue4.Text = myF.GenerateOddEvenNumber(random, Convert.ToInt32(TextBoxRangeMin.Text), Convert.ToInt32(TextBoxRangeMax.Text), 0).ToString();
                // if checkbox odd is checked
                else if (CheckBoxOdd.Checked)
                    LabelStatValue4.Text = myF.GenerateOddEvenNumber(random, Convert.ToInt32(TextBoxRangeMin.Text), Convert.ToInt32(TextBoxRangeMax.Text), 1).ToString();
                // if checkbox even is checked
                else
                    LabelStatValue4.Text = myF.GenerateOddEvenNumber(random, Convert.ToInt32(TextBoxRangeMin.Text), Convert.ToInt32(TextBoxRangeMax.Text), 2).ToString();
            }

            if (CheckStat5.Checked)
            {
                // if both are checked or unchecked at the same time
                if (CheckBoxOdd.Checked == CheckBoxEven.Checked)
                    LabelStatValue5.Text = myF.GenerateOddEvenNumber(random, Convert.ToInt32(TextBoxRangeMin.Text), Convert.ToInt32(TextBoxRangeMax.Text), 0).ToString();
                // if checkbox odd is checked
                else if (CheckBoxOdd.Checked)
                    LabelStatValue5.Text = myF.GenerateOddEvenNumber(random, Convert.ToInt32(TextBoxRangeMin.Text), Convert.ToInt32(TextBoxRangeMax.Text), 1).ToString();
                // if checkbox even is checked
                else
                    LabelStatValue5.Text = myF.GenerateOddEvenNumber(random, Convert.ToInt32(TextBoxRangeMin.Text), Convert.ToInt32(TextBoxRangeMax.Text), 2).ToString();
            }

            if (CheckStat6.Checked)
            {
                // if both are checked or unchecked at the same time
                if (CheckBoxOdd.Checked == CheckBoxEven.Checked)
                    LabelStatValue6.Text = myF.GenerateOddEvenNumber(random, Convert.ToInt32(TextBoxRangeMin.Text), Convert.ToInt32(TextBoxRangeMax.Text), 0).ToString();
                // if checkbox odd is checked
                else if (CheckBoxOdd.Checked)
                    LabelStatValue6.Text = myF.GenerateOddEvenNumber(random, Convert.ToInt32(TextBoxRangeMin.Text), Convert.ToInt32(TextBoxRangeMax.Text), 1).ToString();
                // if checkbox even is checked
                else
                    LabelStatValue6.Text = myF.GenerateOddEvenNumber(random, Convert.ToInt32(TextBoxRangeMin.Text), Convert.ToInt32(TextBoxRangeMax.Text), 2).ToString();
            }

            if (CheckStat7.Checked)
            {
                // if both are checked or unchecked at the same time
                if (CheckBoxOdd.Checked == CheckBoxEven.Checked)
                    LabelStatValue7.Text = myF.GenerateOddEvenNumber(random, Convert.ToInt32(TextBoxRangeMin.Text), Convert.ToInt32(TextBoxRangeMax.Text), 0).ToString();
                // if checkbox odd is checked
                else if (CheckBoxOdd.Checked)
                    LabelStatValue7.Text = myF.GenerateOddEvenNumber(random, Convert.ToInt32(TextBoxRangeMin.Text), Convert.ToInt32(TextBoxRangeMax.Text), 1).ToString();
                // if checkbox even is checked
                else
                    LabelStatValue7.Text = myF.GenerateOddEvenNumber(random, Convert.ToInt32(TextBoxRangeMin.Text), Convert.ToInt32(TextBoxRangeMax.Text), 2).ToString();
            }

            if (CheckStat8.Checked)
            {
                // if both are checked or unchecked at the same time
                if (CheckBoxOdd.Checked == CheckBoxEven.Checked)
                    LabelStatValue8.Text = myF.GenerateOddEvenNumber(random, Convert.ToInt32(TextBoxRangeMin.Text), Convert.ToInt32(TextBoxRangeMax.Text), 0).ToString();
                // if checkbox odd is checked
                else if (CheckBoxOdd.Checked)
                    LabelStatValue8.Text = myF.GenerateOddEvenNumber(random, Convert.ToInt32(TextBoxRangeMin.Text), Convert.ToInt32(TextBoxRangeMax.Text), 1).ToString();
                // if checkbox even is checked
                else
                    LabelStatValue8.Text = myF.GenerateOddEvenNumber(random, Convert.ToInt32(TextBoxRangeMin.Text), Convert.ToInt32(TextBoxRangeMax.Text), 2).ToString();
            }

            if (CheckStat9.Checked)
            {
                // if both are checked or unchecked at the same time
                if (CheckBoxOdd.Checked == CheckBoxEven.Checked)
                    LabelStatValue9.Text = myF.GenerateOddEvenNumber(random, Convert.ToInt32(TextBoxRangeMin.Text), Convert.ToInt32(TextBoxRangeMax.Text), 0).ToString();
                // if checkbox odd is checked
                else if (CheckBoxOdd.Checked)
                    LabelStatValue9.Text = myF.GenerateOddEvenNumber(random, Convert.ToInt32(TextBoxRangeMin.Text), Convert.ToInt32(TextBoxRangeMax.Text), 1).ToString();
                // if checkbox even is checked
                else
                    LabelStatValue9.Text = myF.GenerateOddEvenNumber(random, Convert.ToInt32(TextBoxRangeMin.Text), Convert.ToInt32(TextBoxRangeMax.Text), 2).ToString();
            }

            if (CheckStat10.Checked)
            {
                // if both are checked or unchecked at the same time
                if (CheckBoxOdd.Checked == CheckBoxEven.Checked)
                    LabelStatValue10.Text = myF.GenerateOddEvenNumber(random, Convert.ToInt32(TextBoxRangeMin.Text), Convert.ToInt32(TextBoxRangeMax.Text), 0).ToString();
                // if checkbox odd is checked
                else if (CheckBoxOdd.Checked)
                    LabelStatValue10.Text = myF.GenerateOddEvenNumber(random, Convert.ToInt32(TextBoxRangeMin.Text), Convert.ToInt32(TextBoxRangeMax.Text), 1).ToString();
                // if checkbox even is checked
                else
                    LabelStatValue10.Text = myF.GenerateOddEvenNumber(random, Convert.ToInt32(TextBoxRangeMin.Text), Convert.ToInt32(TextBoxRangeMax.Text), 2).ToString();
            }
        }

        private void CheckStat1_CheckedChanged(object sender, EventArgs e)
        {
            ComboBoxStat1.Enabled = CheckStat1.Checked;
        }

        private void CheckStat2_CheckedChanged(object sender, EventArgs e)
        {
            ComboBoxStat2.Enabled = CheckStat2.Checked;
        }

        private void CheckStat3_CheckedChanged(object sender, EventArgs e)
        {
            ComboBoxStat3.Enabled = CheckStat3.Checked;
        }

        private void CheckStat4_CheckedChanged(object sender, EventArgs e)
        {
            ComboBoxStat4.Enabled = CheckStat4.Checked;
        }

        private void CheckStat5_CheckedChanged(object sender, EventArgs e)
        {
            ComboBoxStat5.Enabled = CheckStat5.Checked;
        }

        private void CheckStat6_CheckedChanged(object sender, EventArgs e)
        {
            ComboBoxStat6.Enabled = CheckStat6.Checked;
        }

        private void CheckStat7_CheckedChanged(object sender, EventArgs e)
        {
            ComboBoxStat7.Enabled = CheckStat7.Checked;
        }

        private void CheckStat8_CheckedChanged(object sender, EventArgs e)
        {
            ComboBoxStat8.Enabled = CheckStat8.Checked;
        }

        private void CheckStat9_CheckedChanged(object sender, EventArgs e)
        {
            ComboBoxStat9.Enabled = CheckStat9.Checked;
        }

        private void CheckStat10_CheckedChanged(object sender, EventArgs e)
        {
            ComboBoxStat10.Enabled = CheckStat10.Checked;
        }

        private void ButtonApply_Click(object sender, EventArgs e)
        {
            if (CheckStat1.Checked)
            {
                string s = ComboBoxStat1.SelectedItem.ToString();
                MyData.ItemTemplateValues[28] = s.Remove(s.IndexOf(']')).Substring(s.IndexOf('[') + 1);
                MyData.ItemTemplateValues[29] = LabelStatValue1.Text;
            }

            if (CheckStat2.Checked)
            {
                string s = ComboBoxStat2.SelectedItem.ToString();
                MyData.ItemTemplateValues[30] = s.Remove(s.IndexOf(']')).Substring(s.IndexOf('[') + 1);
                MyData.ItemTemplateValues[31] = LabelStatValue2.Text;
            }

            if (CheckStat3.Checked)
            {
                string s = ComboBoxStat3.SelectedItem.ToString();
                MyData.ItemTemplateValues[32] = s.Remove(s.IndexOf(']')).Substring(s.IndexOf('[') + 1);
                MyData.ItemTemplateValues[33] = LabelStatValue3.Text;
            }

            if (CheckStat4.Checked)
            {
                string s = ComboBoxStat4.SelectedItem.ToString();
                MyData.ItemTemplateValues[34] = s.Remove(s.IndexOf(']')).Substring(s.IndexOf('[') + 1);
                MyData.ItemTemplateValues[35] = LabelStatValue4.Text;
            }

            if (CheckStat5.Checked)
            {
                string s = ComboBoxStat5.SelectedItem.ToString();
                MyData.ItemTemplateValues[36] = s.Remove(s.IndexOf(']')).Substring(s.IndexOf('[') + 1);
                MyData.ItemTemplateValues[37] = LabelStatValue5.Text;
            }

            if (CheckStat6.Checked)
            {
                string s = ComboBoxStat6.SelectedItem.ToString();
                MyData.ItemTemplateValues[38] = s.Remove(s.IndexOf(']')).Substring(s.IndexOf('[') + 1);
                MyData.ItemTemplateValues[39] = LabelStatValue6.Text;
            }

            if (CheckStat7.Checked)
            {
                string s = ComboBoxStat7.SelectedItem.ToString();
                MyData.ItemTemplateValues[40] = s.Remove(s.IndexOf(']')).Substring(s.IndexOf('[') + 1);
                MyData.ItemTemplateValues[41] = LabelStatValue7.Text;
            }

            if (CheckStat8.Checked)
            {
                string s = ComboBoxStat8.SelectedItem.ToString();
                MyData.ItemTemplateValues[42] = s.Remove(s.IndexOf(']')).Substring(s.IndexOf('[') + 1);
                MyData.ItemTemplateValues[43] = LabelStatValue8.Text;
            }

            if (CheckStat9.Checked)
            {
                string s = ComboBoxStat9.SelectedItem.ToString();
                MyData.ItemTemplateValues[44] = s.Remove(s.IndexOf(']')).Substring(s.IndexOf('[') + 1);
                MyData.ItemTemplateValues[45] = LabelStatValue9.Text;
            }

            if (CheckStat10.Checked)
            {
                string s = ComboBoxStat10.SelectedItem.ToString();
                MyData.ItemTemplateValues[46] = s.Remove(s.IndexOf(']')).Substring(s.IndexOf('[') + 1);
                MyData.ItemTemplateValues[47] = LabelStatValue10.Text;
            }

            var myF = new Functions(mainForm);
            myF.LoadDefaultTemplate(1000);
            Close();
        }
    }
}
