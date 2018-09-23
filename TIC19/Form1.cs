using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using TrinityItemCreator.MyClass;

namespace TrinityItemCreator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

        private bool mouseDown;
        private Point lastLocation;

        private void Form1_Shown(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.ShowDialog();
        }

        private void Watermark_myTextBox_Leave(object sender, EventArgs e)
        {
            MyTextBox mTextBox = (MyTextBox)sender;
            if (mTextBox.Text.Length == 0)
                mTextBox.Text = "0";
        }

        private void Watermark_myTextBox_Enter(object sender, EventArgs e)
        {
            MyTextBox mTextBox = (MyTextBox)sender;
            if (mTextBox.Text == "0")
                mTextBox.Text = "";
        }

        private void Watermark_myTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Location = new Point( (Location.X - lastLocation.X) + e.X, (Location.Y - lastLocation.Y) + e.Y );
                Update();
            }
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            var wr = new Window_Resistances(this);
            wr.ShowDialog();
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            var woO = new Window_Other_Options(this);
            woO.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var wcM = new Window_ClassMask(this);
            wcM.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            var wbF = new Window_BagFamilyMask(this);
            wbF.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var wrM = new Window_RaceMask(this);
            wrM.ShowDialog();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            var wfM = new Window_FlagMask(this);
            wfM.ShowDialog();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            var wfEM = new Window_FlagExtraMask(this);
            wfEM.ShowDialog();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            var wfCM = new Window_FlagCustomMask(this);
            wfCM.ShowDialog();
        }

        private void CopyToClipboardCTRLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(QueryHandler.GetExportQuery());
            MessageBox.Show("Copied to clipboard!");
        }

        private void SQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sd = new SaveFileDialog
            {
                FileName = MyData.Field_entry.ToString() + "_" + MyData.Field_name,
                Filter = "SQL File | *.sql"
            };

            if (sd.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(sd.FileName))
                {
                    sw.Write(QueryHandler.GetExportQuery());
                    sw.Flush();
                    sw.Close();
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (ModifierKeys.HasFlag(Keys.Control) && e.KeyCode == Keys.D1)
            {
                var wcM = new Window_ClassMask(this);
                wcM.ShowDialog();
            }
            else if (ModifierKeys.HasFlag(Keys.Control) && e.KeyCode == Keys.D2)
            {
                var wrM = new Window_RaceMask(this);
                wrM.ShowDialog();
            }
            else if (ModifierKeys.HasFlag(Keys.Control) && e.KeyCode == Keys.D3)
            {
                var wbF = new Window_BagFamilyMask(this);
                wbF.ShowDialog();
            }
            else if (ModifierKeys.HasFlag(Keys.Shift) && e.KeyCode == Keys.D1)
            {
                var wfM = new Window_FlagMask(this);
                wfM.ShowDialog();
            }
            else if (ModifierKeys.HasFlag(Keys.Shift) && e.KeyCode == Keys.D2)
            {
                var wfEM = new Window_FlagExtraMask(this);
                wfEM.ShowDialog();
            }
            else if (ModifierKeys.HasFlag(Keys.Shift) && e.KeyCode == Keys.D3)
            {
                var wfCM = new Window_FlagCustomMask(this);
                wfCM.ShowDialog();
            }
            else if (ModifierKeys.HasFlag(Keys.Control) && e.KeyCode == Keys.R)
            {
                var wr = new Window_Resistances(this);
                wr.ShowDialog();
            }
            else if (ModifierKeys.HasFlag(Keys.Control) && e.KeyCode == Keys.O)
            {
                var woO = new Window_Other_Options(this);
                woO.ShowDialog();
            }
        }

        private void ABOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Application developer: [artister.hd@gmail.com] All Rights Reserved!");
        }

        private void MyTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(myTextBox1.Text, out int userVal))
                MyData.Field_entry = userVal;
        }

        private void myTextBox2_TextChanged(object sender, EventArgs e)
        {
            MyData.Field_name = myTextBox2.Text;
        }

        private void myTextBox3_TextChanged(object sender, EventArgs e)
        {
            MyData.Field_description = myTextBox3.Text;
        }

        private void myTextBox4_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(myTextBox4.Text, out int userVal))
                MyData.Field_displayid = userVal;
        }

        private void myTextBox5_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(myTextBox5.Text, out int userVal))
                MyData.Field_ItemLevel = userVal;
        }

        private void myTextBox6_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(myTextBox6.Text, out int userVal))
                MyData.Field_RequiredLevel = userVal;
        }

        private void myTextBox25_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(myTextBox25.Text, out int userVal))
                MyData.Field_BuyPrice = userVal;
        }

        private void myTextBox26_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(myTextBox26.Text, out int userVal))
                MyData.Field_SellPrice = userVal;
        }

        private void myTextBox27_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(myTextBox27.Text, out int userVal))
                MyData.Field_BuyCount = userVal;
        }

        private void myTextBox28_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(myTextBox28.Text, out int userVal))
                MyData.Field_itemset = userVal;
        }

        private void myTextBox29_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(myTextBox29.Text, out int userVal))
                MyData.Field_stackable = userVal;
        }

        private void myTextBox30_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(myTextBox30.Text, out int userVal))
                MyData.Field_maxcount = userVal;
        }

        private void myTextBox61_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(myTextBox61.Text, out int userVal))
                MyData.Field_socketContent_1 = userVal;
        }

        private void myTextBox62_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(myTextBox62.Text, out int userVal))
                MyData.Field_socketContent_2 = userVal;
        }

        private void myTextBox63_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(myTextBox63.Text, out int userVal))
                MyData.Field_socketContent_3 = userVal;
        }

        private void myTextBox31_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(myTextBox31.Text, out int userVal))
                MyData.Field_spellid_1 = userVal;
        }

        private void myTextBox42_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(myTextBox42.Text, out int userVal))
                MyData.Field_spellid_2 = userVal;
        }

        private void myTextBox48_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(myTextBox48.Text, out int userVal))
                MyData.Field_spellid_3 = userVal;
        }

        private void myTextBox54_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(myTextBox54.Text, out int userVal))
                MyData.Field_spellid_4 = userVal;
        }

        private void myTextBox60_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(myTextBox60.Text, out int userVal))
                MyData.Field_spellid_5 = userVal;
        }

        private void myTextBox32_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(myTextBox32.Text, out int userVal))
                MyData.Field_spellcharges_1 = userVal;
        }

        private void myTextBox41_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(myTextBox41.Text, out int userVal))
                MyData.Field_spellcharges_2 = userVal;
        }

        private void myTextBox47_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(myTextBox47.Text, out int userVal))
                MyData.Field_spellcharges_3 = userVal;
        }

        private void myTextBox53_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(myTextBox53.Text, out int userVal))
                MyData.Field_spellcharges_4 = userVal;
        }

        private void myTextBox59_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(myTextBox59.Text, out int userVal))
                MyData.Field_spellcharges_5 = userVal;
        }

        private void myTextBox33_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(myTextBox33.Text, out int userVal))
                MyData.Field_spellppmRate_1 = userVal;
        }

        private void myTextBox40_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(myTextBox40.Text, out int userVal))
                MyData.Field_spellppmRate_2 = userVal;
        }

        private void myTextBox46_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(myTextBox46.Text, out int userVal))
                MyData.Field_spellppmRate_3 = userVal;
        }

        private void myTextBox52_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(myTextBox52.Text, out int userVal))
                MyData.Field_spellppmRate_4 = userVal;
        }

        private void myTextBox58_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(myTextBox58.Text, out int userVal))
                MyData.Field_spellppmRate_5 = userVal;
        }

        private void myTextBox34_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(myTextBox34.Text, out int userVal))
                MyData.Field_spellcooldown_1 = userVal;
        }

        private void myTextBox39_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(myTextBox39.Text, out int userVal))
                MyData.Field_spellcooldown_2 = userVal;
        }

        private void myTextBox45_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(myTextBox45.Text, out int userVal))
                MyData.Field_spellcooldown_3 = userVal;
        }

        private void myTextBox51_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(myTextBox51.Text, out int userVal))
                MyData.Field_spellcooldown_4 = userVal;
        }

        private void myTextBox57_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(myTextBox57.Text, out int userVal))
                MyData.Field_spellcooldown_5 = userVal;
        }

        private void myTextBox35_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(myTextBox35.Text, out int userVal))
                MyData.Field_spellcategory_1 = userVal;
        }

        private void myTextBox38_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(myTextBox38.Text, out int userVal))
                MyData.Field_spellcategory_2 = userVal;
        }

        private void myTextBox44_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(myTextBox44.Text, out int userVal))
                MyData.Field_spellcategory_3 = userVal;
        }

        private void myTextBox50_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(myTextBox50.Text, out int userVal))
                MyData.Field_spellcategory_4 = userVal;
        }

        private void myTextBox56_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(myTextBox56.Text, out int userVal))
                MyData.Field_spellcategory_5 = userVal;
        }

        private void myTextBox36_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(myTextBox36.Text, out int userVal))
                MyData.Field_spellcategorycooldown_1 = userVal;
        }

        private void myTextBox37_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(myTextBox37.Text, out int userVal))
                MyData.Field_spellcategorycooldown_2 = userVal;
        }

        private void myTextBox43_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(myTextBox43.Text, out int userVal))
                MyData.Field_spellcategorycooldown_3 = userVal;
        }

        private void myTextBox49_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(myTextBox49.Text, out int userVal))
                MyData.Field_spellcategorycooldown_4 = userVal;
        }

        private void myTextBox55_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(myTextBox55.Text, out int userVal))
                MyData.Field_spellcategorycooldown_5 = userVal;
        }

        private void myTextBox7_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(myTextBox7.Text, out int userVal))
                MyData.Field_stat_value1 = userVal;
        }

        private void myTextBox8_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(myTextBox8.Text, out int userVal))
                MyData.Field_stat_value2 = userVal;
        }

        private void myTextBox9_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(myTextBox9.Text, out int userVal))
                MyData.Field_stat_value3 = userVal;
        }

        private void myTextBox10_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(myTextBox10.Text, out int userVal))
                MyData.Field_stat_value4 = userVal;
        }

        private void myTextBox11_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(myTextBox11.Text, out int userVal))
                MyData.Field_stat_value5 = userVal;
        }

        private void myTextBox12_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(myTextBox12.Text, out int userVal))
                MyData.Field_stat_value6 = userVal;
        }

        private void myTextBox13_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(myTextBox13.Text, out int userVal))
                MyData.Field_stat_value7 = userVal;
        }

        private void myTextBox14_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(myTextBox14.Text, out int userVal))
                MyData.Field_stat_value8 = userVal;
        }

        private void myTextBox15_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(myTextBox15.Text, out int userVal))
                MyData.Field_stat_value9 = userVal;
        }

        private void myTextBox16_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(myTextBox16.Text, out int userVal))
                MyData.Field_stat_value10 = userVal;
        }

        private void myTextBox23_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(myTextBox23.Text, out int userVal))
                MyData.Field_ScalingStatDistribution = userVal;
        }

        private void myTextBox24_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(myTextBox24.Text, out int userVal))
                MyData.Field_ScalingStatValue = userVal;
        }

        private void myTextBox17_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(myTextBox17.Text, out int userVal))
                MyData.Field_dmg_min1 = userVal;
        }

        private void myTextBox18_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(myTextBox18.Text, out int userVal))
                MyData.Field_dmg_max1 = userVal;
        }

        private void myTextBox20_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(myTextBox20.Text, out int userVal))
                MyData.Field_dmg_min2 = userVal;
        }

        private void myTextBox19_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(myTextBox19.Text, out int userVal))
                MyData.Field_dmg_max2 = userVal;
        }

        private void myTextBox22_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(myTextBox22.Text, out int userVal))
                MyData.Field_delay = userVal;
        }

        private void myTextBox21_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(myTextBox21.Text, out int userVal))
                MyData.Field_RangedModRange = userVal;
        }

        private void myTextBox64_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(myTextBox35.Text, out int userVal))
                MyData.Field_block = userVal;
        }

        private void myTextBox65_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(myTextBox65.Text, out int userVal))
                MyData.Field_armor = userVal;
        }

        private void myTextBox66_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(myTextBox66.Text, out int userVal))
                MyData.Field_ArmorDamageModifier = userVal;
        }

        private void myTextBox67_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(myTextBox67.Text, out int userVal))
                MyData.Field_MaxDurability = userVal;
        }

        private void myTextBox68_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(myTextBox68.Text, out int userVal))
                MyData.Field_ContainerSlots = userVal;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox objComboBox = (ComboBox)sender;
            string s = objComboBox.SelectedItem.ToString();
            MyData.Field_Quality = Convert.ToInt32(s.Remove(s.IndexOf(']')).Substring(s.IndexOf('[') + 1));
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox objComboBox = (ComboBox)sender;
            string s = objComboBox.SelectedItem.ToString();
            MyData.Field_bonding = Convert.ToInt32(s.Remove(s.IndexOf(']')).Substring(s.IndexOf('[') + 1));
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox objComboBox = (ComboBox)sender;
            string s = objComboBox.SelectedItem.ToString();
            MyData.Field_sheath = Convert.ToInt32(s.Remove(s.IndexOf(']')).Substring(s.IndexOf('[') + 1));
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = comboBox4.SelectedItem.ToString();
            MyData.Field_class = Convert.ToInt32(s.Remove(s.IndexOf(']')).Substring(s.IndexOf('[') + 1));

            comboBox5.Items.Clear();
            comboBox5.Items.AddRange(MyData.SubClassArray[comboBox4.SelectedIndex]);

            if (Functions.preLoadSubClassMenu)
                Functions.preLoadSubClassMenu = false;
            else
                comboBox5.SelectedIndex = 0;
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox objComboBox = (ComboBox)sender;
            string s = objComboBox.SelectedItem.ToString();
            MyData.Field_subclass = Convert.ToInt32(s.Remove(s.IndexOf(']')).Substring(s.IndexOf('[') + 1));
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox objComboBox = (ComboBox)sender;
            string s = objComboBox.SelectedItem.ToString();
            MyData.Field_InventoryType = Convert.ToInt32(s.Remove(s.IndexOf(']')).Substring(s.IndexOf('[') + 1));
        }

        private void comboBox20_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox objComboBox = (ComboBox)sender;
            string s = objComboBox.SelectedItem.ToString();
            MyData.Field_Material = Convert.ToInt32(s.Remove(s.IndexOf(']')).Substring(s.IndexOf('[') + 1));
        }

        private void comboBox21_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox objComboBox = (ComboBox)sender;
            string s = objComboBox.SelectedItem.ToString();
            MyData.Field_FoodType = Convert.ToInt32(s.Remove(s.IndexOf(']')).Substring(s.IndexOf('[') + 1));
        }

        private void comboBox22_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox objComboBox = (ComboBox)sender;
            string s = objComboBox.SelectedItem.ToString();
            MyData.Field_TotemCategory = Convert.ToInt32(s.Remove(s.IndexOf(']')).Substring(s.IndexOf('[') + 1));
        }

        private void comboBox28_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox objComboBox = (ComboBox)sender;
            string s = objComboBox.SelectedItem.ToString();
            MyData.Field_socketColor_1 = Convert.ToInt32(s.Remove(s.IndexOf(']')).Substring(s.IndexOf('[') + 1));
        }

        private void comboBox29_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox objComboBox = (ComboBox)sender;
            string s = objComboBox.SelectedItem.ToString();
            MyData.Field_socketColor_2 = Convert.ToInt32(s.Remove(s.IndexOf(']')).Substring(s.IndexOf('[') + 1));
        }

        private void comboBox30_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox objComboBox = (ComboBox)sender;
            string s = objComboBox.SelectedItem.ToString();
            MyData.Field_socketColor_3 = Convert.ToInt32(s.Remove(s.IndexOf(']')).Substring(s.IndexOf('[') + 1));
        }

        private void comboBox31_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox objComboBox = (ComboBox)sender;
            string s = objComboBox.SelectedItem.ToString();
            MyData.Field_socketBonus = Convert.ToInt32(s.Remove(s.IndexOf(']')).Substring(s.IndexOf('[') + 1));
        }

        private void comboBox23_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox objComboBox = (ComboBox)sender;
            string s = objComboBox.SelectedItem.ToString();
            MyData.Field_spelltrigger_1 = Convert.ToInt32(s.Remove(s.IndexOf(']')).Substring(s.IndexOf('[') + 1));
        }

        private void comboBox24_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox objComboBox = (ComboBox)sender;
            string s = objComboBox.SelectedItem.ToString();
            MyData.Field_spelltrigger_2 = Convert.ToInt32(s.Remove(s.IndexOf(']')).Substring(s.IndexOf('[') + 1));
        }

        private void comboBox25_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox objComboBox = (ComboBox)sender;
            string s = objComboBox.SelectedItem.ToString();
            MyData.Field_spelltrigger_3 = Convert.ToInt32(s.Remove(s.IndexOf(']')).Substring(s.IndexOf('[') + 1));
        }

        private void comboBox26_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox objComboBox = (ComboBox)sender;
            string s = objComboBox.SelectedItem.ToString();
            MyData.Field_spelltrigger_4 = Convert.ToInt32(s.Remove(s.IndexOf(']')).Substring(s.IndexOf('[') + 1));
        }

        private void comboBox27_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox objComboBox = (ComboBox)sender;
            string s = objComboBox.SelectedItem.ToString();
            MyData.Field_spelltrigger_5 = Convert.ToInt32(s.Remove(s.IndexOf(']')).Substring(s.IndexOf('[') + 1));
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox objComboBox = (ComboBox)sender;
            string s = objComboBox.SelectedItem.ToString();
            MyData.Field_stat_type1 = Convert.ToInt32(s.Remove(s.IndexOf(']')).Substring(s.IndexOf('[') + 1));
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox objComboBox = (ComboBox)sender;
            string s = objComboBox.SelectedItem.ToString();
            MyData.Field_stat_type2 = Convert.ToInt32(s.Remove(s.IndexOf(']')).Substring(s.IndexOf('[') + 1));
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox objComboBox = (ComboBox)sender;
            string s = objComboBox.SelectedItem.ToString();
            MyData.Field_stat_type3 = Convert.ToInt32(s.Remove(s.IndexOf(']')).Substring(s.IndexOf('[') + 1));
        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox objComboBox = (ComboBox)sender;
            string s = objComboBox.SelectedItem.ToString();
            MyData.Field_stat_type4 = Convert.ToInt32(s.Remove(s.IndexOf(']')).Substring(s.IndexOf('[') + 1));
        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox objComboBox = (ComboBox)sender;
            string s = objComboBox.SelectedItem.ToString();
            MyData.Field_stat_type5 = Convert.ToInt32(s.Remove(s.IndexOf(']')).Substring(s.IndexOf('[') + 1));
        }

        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox objComboBox = (ComboBox)sender;
            string s = objComboBox.SelectedItem.ToString();
            MyData.Field_stat_type6 = Convert.ToInt32(s.Remove(s.IndexOf(']')).Substring(s.IndexOf('[') + 1));
        }

        private void comboBox13_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox objComboBox = (ComboBox)sender;
            string s = objComboBox.SelectedItem.ToString();
            MyData.Field_stat_type7 = Convert.ToInt32(s.Remove(s.IndexOf(']')).Substring(s.IndexOf('[') + 1));
        }

        private void comboBox14_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox objComboBox = (ComboBox)sender;
            string s = objComboBox.SelectedItem.ToString();
            MyData.Field_stat_type8 = Convert.ToInt32(s.Remove(s.IndexOf(']')).Substring(s.IndexOf('[') + 1));
        }

        private void comboBox15_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox objComboBox = (ComboBox)sender;
            string s = objComboBox.SelectedItem.ToString();
            MyData.Field_stat_type9 = Convert.ToInt32(s.Remove(s.IndexOf(']')).Substring(s.IndexOf('[') + 1));
        }

        private void comboBox16_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox objComboBox = (ComboBox)sender;
            string s = objComboBox.SelectedItem.ToString();
            MyData.Field_stat_type10 = Convert.ToInt32(s.Remove(s.IndexOf(']')).Substring(s.IndexOf('[') + 1));
        }

        private void comboBox17_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox objComboBox = (ComboBox)sender;
            string s = objComboBox.SelectedItem.ToString();
            MyData.Field_dmg_type1 = Convert.ToInt32(s.Remove(s.IndexOf(']')).Substring(s.IndexOf('[') + 1));
        }

        private void comboBox18_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox objComboBox = (ComboBox)sender;
            string s = objComboBox.SelectedItem.ToString();
            MyData.Field_dmg_type2 = Convert.ToInt32(s.Remove(s.IndexOf(']')).Substring(s.IndexOf('[') + 1));
        }

        private void comboBox19_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox objComboBox = (ComboBox)sender;
            string s = objComboBox.SelectedItem.ToString();
            MyData.Field_ammo_type = Convert.ToInt32(s.Remove(s.IndexOf(']')).Substring(s.IndexOf('[') + 1));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Functions myF = new Functions(this);
            myF.DelayMainFormPainting();

            // This is happening before closing form2
            if (!Functions.preLoadTemplate)
                myF.LoadDefaultTemplate(99999);
        }

        private void SaveCurrentTemplateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(this);
            form3.ShowDialog();
        }

        private void LoadCustomTemplateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(this);
            form4.ShowDialog();
        }

        private void loadDefaultTemplateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.ShowDialog();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Functions myF = new Functions(this);
            myF.DelayMainFormPainting();
        }
    }
}
