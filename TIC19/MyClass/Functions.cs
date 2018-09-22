using System.Linq;
using System.Drawing;
using System.Windows.Forms;

namespace TIC19.MyClass
{
    class Functions
    {
        private Form1 mainForm;
        public static bool preLoadTemplate;
        public static int preLoadTemplateID;
        public static bool preLoadSubClassMenu;

        public Functions() { }

        public Functions(Form1 form1)
        {
            mainForm = form1;
        }

        public void UnBlurMainForm()
        {
            foreach (var menuStrip in mainForm.Controls.OfType<MenuStrip>()) menuStrip.Enabled = true;
            foreach (var mtextBox in mainForm.Controls.OfType<MyTextBox>()) mtextBox.Enabled = true;
            foreach (var comboBox in mainForm.Controls.OfType<ComboBox>()) comboBox.Enabled = true;
            foreach (var button in mainForm.Controls.OfType<Button>()) button.Enabled = true;
            foreach (var picBox in mainForm.Controls.OfType<PictureBox>()) picBox.Enabled = true;

            mainForm.panel1.BackColor = Color.DarkSlateGray;
        }

        public void LoadDefaultTemplate(int templateID)
        {
            switch(templateID)
            {
                case 0: // weapon
                    {
                        QueryHandler.column_name = "My One Handed Sword";
                        QueryHandler.column_Quality = 4;
                        QueryHandler.column_sheath = 3;
                        QueryHandler.column_class = 2;
                        QueryHandler.column_subclass = 7;
                        QueryHandler.column_InventoryType = 26;
                        QueryHandler.column_Material = 1;
                        QueryHandler.column_dmg_min1 = 100;
                        QueryHandler.column_dmg_max1 = 200;
                        QueryHandler.column_delay = 1000;

                        preLoadSubClassMenu = true; // temporary fix fo subclass menu selected index
                        break;
                    }
                case 1: // armor
                    {
                        QueryHandler.column_name = "My Helm Cloth";
                        QueryHandler.column_Quality = 4;
                        QueryHandler.column_class = 4;
                        QueryHandler.column_subclass = 1;
                        QueryHandler.column_InventoryType = 2;
                        QueryHandler.column_Material = 7;
                        QueryHandler.column_stat_type1 = 1;
                        QueryHandler.column_stat_type2 = 7;
                        QueryHandler.column_stat_value1 = 10;
                        QueryHandler.column_stat_value2 = 20;
                        QueryHandler.column_armor = 100;

                        preLoadSubClassMenu = true; // temporary fix fo subclass menu selected index
                        break;
                    }
                case 2: // gem
                    {
                        QueryHandler.column_class = 3;
                        QueryHandler.column_subclass = 6;
                        QueryHandler.column_name = "My Meta Gem";
                        QueryHandler.column_description = "Only fits in a meta gem slot.";
                        QueryHandler.column_Material = -1;
                        QueryHandler.column_GemProperties = 942;

                        preLoadSubClassMenu = true; // temporary fix fo subclass menu selected index
                        break;
                    }
                case 3: // projectile
                    {
                        QueryHandler.column_class = 6;
                        QueryHandler.column_subclass = 3;
                        QueryHandler.column_name = "My Projectile Bullets";
                        QueryHandler.column_description = "More Pew Pew,Less QQ";
                        QueryHandler.column_BuyCount = 200;
                        QueryHandler.column_stackable = 200;
                        QueryHandler.column_Material = 2;
                        QueryHandler.column_dmg_min1 = 100;
                        QueryHandler.column_dmg_max1 = 200;
                        QueryHandler.column_delay = 1000;

                        preLoadSubClassMenu = true; // temporary fix fo subclass menu selected index
                        break;
                    }
                case 4:// container
                    {
                        QueryHandler.column_class = 1;
                        QueryHandler.column_name = "My Fancy Container";
                        QueryHandler.column_description = "Some Extra Slots";
                        QueryHandler.column_ContainerSlots = 36;
                        QueryHandler.column_Material = 8;

                        preLoadSubClassMenu = true; // temporary fix fo subclass menu selected index
                        break;
                    }
                case 5: // quiver
                    {
                        QueryHandler.column_class = 11;
                        QueryHandler.column_subclass = 2;
                        QueryHandler.column_name = "My Fancy Quiver for Arrows";
                        QueryHandler.column_description = "Some Extra Space for Arrows";
                        QueryHandler.column_ContainerSlots = 36;
                        QueryHandler.column_Material = 8;

                        preLoadSubClassMenu = true; // temporary fix fo subclass menu selected index
                        break;
                    }
                case 6: // glyph
                    {
                        QueryHandler.column_class = 16;
                        QueryHandler.column_subclass = 11;
                        QueryHandler.column_name = "My Custom Glyph";
                        QueryHandler.column_Material = 4;
                        QueryHandler.column_Flags = 64;
                        QueryHandler.column_spellid_1 = 65244;
                        QueryHandler.column_spellcooldown_1 = 0;
                        QueryHandler.column_BagFamily = 16;

                        preLoadSubClassMenu = true; // temporary fix fo subclass menu selected index
                        break;
                    }
                case 7: // recipe
                    {
                        QueryHandler.column_class = 9;
                        QueryHandler.column_subclass = 2;
                        QueryHandler.column_name = "My Custom Recipe";
                        QueryHandler.column_Material = -1;
                        QueryHandler.column_Flags = 64;
                        QueryHandler.column_spellid_1 = 483;
                        QueryHandler.column_spellcharges_1 = -1;
                        QueryHandler.column_spellppmRate_1 = -1;
                        QueryHandler.column_spellid_2 = 3336;
                        QueryHandler.column_spelltrigger_2 = 6;
                        QueryHandler.column_spellcooldown_2 = -1;
                        QueryHandler.column_spellcategorycooldown_2 = -1;

                        preLoadSubClassMenu = true; // temporary fix fo subclass menu selected index
                        break;
                    }
                case 8: // quest
                    {
                        QueryHandler.column_class = 12;
                        QueryHandler.column_subclass = 0;
                        QueryHandler.column_name = "My Custom Quest Item";
                        QueryHandler.column_Material = -1;
                        QueryHandler.column_startquest = 337;

                        preLoadSubClassMenu = true; // temporary fix fo subclass menu selected index
                        break;
                    }
                case 9: // key
                    {
                        QueryHandler.column_class = 13;
                        QueryHandler.column_subclass = 0;
                        QueryHandler.column_name = "My Custom Key Item";
                        QueryHandler.column_Material = -1;
                        QueryHandler.column_Flags = 64;
                        QueryHandler.column_spellid_1 = 42323;
                        QueryHandler.column_spellcharges_1 = -1;
                        QueryHandler.column_spellppmRate_1 = -1;
                        QueryHandler.column_spellcooldown_1 = -1;
                        QueryHandler.column_spellcategorycooldown_1 = -1;
                        QueryHandler.column_BagFamily = 256;

                        preLoadSubClassMenu = true; // temporary fix fo subclass menu selected index
                        break;
                    }
                case 10: // reagent
                    {
                        QueryHandler.column_class = 5;
                        QueryHandler.column_subclass = 0;
                        QueryHandler.column_name = "My Custom Reagent";
                        QueryHandler.column_description = "This is a custom reagent item";
                        QueryHandler.column_Material = 2;
                        QueryHandler.column_stackable = 10;

                        preLoadSubClassMenu = true; // temporary fix fo subclass menu selected index
                        break;
                    }
                case 11: // trade good
                    {
                        break;
                    }
                case 12: // consumable
                    {
                        break;
                    }
                case 13: // misc
                    {
                        break;
                    }
                default:
                    {
                        preLoadSubClassMenu = false;
                        // any other template id
                        break;
                    }
            }
            

            // TEXTBOX
            mainForm.myTextBox1.Text = QueryHandler.column_entry.ToString();
            mainForm.myTextBox2.Text = QueryHandler.column_name;
            mainForm.myTextBox3.Text = QueryHandler.column_description;
            mainForm.myTextBox4.Text = QueryHandler.column_displayid.ToString();
            mainForm.myTextBox5.Text = QueryHandler.column_ItemLevel.ToString();
            mainForm.myTextBox6.Text = QueryHandler.column_RequiredLevel.ToString();
            mainForm.myTextBox7.Text = QueryHandler.column_stat_value1.ToString();
            mainForm.myTextBox8.Text = QueryHandler.column_stat_value2.ToString();
            mainForm.myTextBox9.Text = QueryHandler.column_stat_value3.ToString();
            mainForm.myTextBox10.Text = QueryHandler.column_stat_value4.ToString();
            mainForm.myTextBox11.Text = QueryHandler.column_stat_value5.ToString();
            mainForm.myTextBox12.Text = QueryHandler.column_stat_value6.ToString();
            mainForm.myTextBox13.Text = QueryHandler.column_stat_value7.ToString();
            mainForm.myTextBox14.Text = QueryHandler.column_stat_value8.ToString();
            mainForm.myTextBox15.Text = QueryHandler.column_stat_value9.ToString();
            mainForm.myTextBox16.Text = QueryHandler.column_stat_value10.ToString();
            mainForm.myTextBox17.Text = QueryHandler.column_dmg_min1.ToString();
            mainForm.myTextBox18.Text = QueryHandler.column_dmg_max1.ToString();
            mainForm.myTextBox19.Text = QueryHandler.column_dmg_max2.ToString();
            mainForm.myTextBox20.Text = QueryHandler.column_dmg_min2.ToString();
            mainForm.myTextBox21.Text = QueryHandler.column_RangedModRange.ToString();
            mainForm.myTextBox22.Text = QueryHandler.column_delay.ToString();
            mainForm.myTextBox23.Text = QueryHandler.column_ScalingStatDistribution.ToString();
            mainForm.myTextBox24.Text = QueryHandler.column_ScalingStatValue.ToString();
            mainForm.myTextBox25.Text = QueryHandler.column_BuyPrice.ToString();
            mainForm.myTextBox26.Text = QueryHandler.column_SellPrice.ToString();
            mainForm.myTextBox27.Text = QueryHandler.column_BuyCount.ToString();
            mainForm.myTextBox28.Text = QueryHandler.column_itemset.ToString();
            mainForm.myTextBox29.Text = QueryHandler.column_stackable.ToString();
            mainForm.myTextBox30.Text = QueryHandler.column_maxcount.ToString();
            mainForm.myTextBox31.Text = QueryHandler.column_spellid_1.ToString();
            mainForm.myTextBox32.Text = QueryHandler.column_spellcharges_1.ToString();
            mainForm.myTextBox33.Text = QueryHandler.column_spellppmRate_1.ToString();
            mainForm.myTextBox34.Text = QueryHandler.column_spellcooldown_1.ToString();
            mainForm.myTextBox35.Text = QueryHandler.column_spellcategory_1.ToString();
            mainForm.myTextBox36.Text = QueryHandler.column_spellcategorycooldown_1.ToString();
            mainForm.myTextBox37.Text = QueryHandler.column_spellcategorycooldown_2.ToString();
            mainForm.myTextBox38.Text = QueryHandler.column_spellcategory_2.ToString();
            mainForm.myTextBox39.Text = QueryHandler.column_spellcooldown_2.ToString();
            mainForm.myTextBox40.Text = QueryHandler.column_spellppmRate_2.ToString();
            mainForm.myTextBox41.Text = QueryHandler.column_spellcharges_2.ToString();
            mainForm.myTextBox42.Text = QueryHandler.column_spellid_2.ToString();
            mainForm.myTextBox43.Text = QueryHandler.column_spellcategorycooldown_3.ToString();
            mainForm.myTextBox44.Text = QueryHandler.column_spellcategory_3.ToString();
            mainForm.myTextBox45.Text = QueryHandler.column_spellcooldown_3.ToString();
            mainForm.myTextBox46.Text = QueryHandler.column_spellppmRate_3.ToString();
            mainForm.myTextBox47.Text = QueryHandler.column_spellcharges_3.ToString();
            mainForm.myTextBox48.Text = QueryHandler.column_spellid_3.ToString();
            mainForm.myTextBox49.Text = QueryHandler.column_spellcategorycooldown_4.ToString();
            mainForm.myTextBox50.Text = QueryHandler.column_spellcategory_4.ToString();
            mainForm.myTextBox51.Text = QueryHandler.column_spellcooldown_4.ToString();
            mainForm.myTextBox52.Text = QueryHandler.column_spellppmRate_4.ToString();
            mainForm.myTextBox53.Text = QueryHandler.column_spellcharges_4.ToString();
            mainForm.myTextBox54.Text = QueryHandler.column_spellid_4.ToString();
            mainForm.myTextBox55.Text = QueryHandler.column_spellcategorycooldown_5.ToString();
            mainForm.myTextBox56.Text = QueryHandler.column_spellcategory_5.ToString();
            mainForm.myTextBox57.Text = QueryHandler.column_spellcooldown_5.ToString();
            mainForm.myTextBox58.Text = QueryHandler.column_spellppmRate_5.ToString();
            mainForm.myTextBox59.Text = QueryHandler.column_spellcharges_5.ToString();
            mainForm.myTextBox60.Text = QueryHandler.column_spellid_5.ToString();
            mainForm.myTextBox61.Text = QueryHandler.column_socketContent_1.ToString();
            mainForm.myTextBox62.Text = QueryHandler.column_socketContent_2.ToString();
            mainForm.myTextBox63.Text = QueryHandler.column_socketContent_3.ToString();
            mainForm.myTextBox64.Text = QueryHandler.column_block.ToString();
            mainForm.myTextBox65.Text = QueryHandler.column_armor.ToString();
            mainForm.myTextBox66.Text = QueryHandler.column_ArmorDamageModifier.ToString();
            mainForm.myTextBox67.Text = QueryHandler.column_MaxDurability.ToString();
            mainForm.myTextBox68.Text = QueryHandler.column_ContainerSlots.ToString();

            // COMBOBOX
            mainForm.comboBox1.SelectedIndex = mainForm.comboBox1.FindString(string.Format("[{0}]", QueryHandler.column_Quality));
            mainForm.comboBox2.SelectedIndex = mainForm.comboBox2.FindString(string.Format("[{0}]", QueryHandler.column_bonding));
            mainForm.comboBox3.SelectedIndex = mainForm.comboBox3.FindString(string.Format("[{0}]", QueryHandler.column_sheath));
            mainForm.comboBox4.SelectedIndex = mainForm.comboBox4.FindString(string.Format("[{0}]", QueryHandler.column_class));
            mainForm.comboBox5.SelectedIndex = mainForm.comboBox5.FindString(string.Format("[{0}]", QueryHandler.column_subclass));
            mainForm.comboBox6.SelectedIndex = mainForm.comboBox6.FindString(string.Format("[{0}]", QueryHandler.column_InventoryType));
            mainForm.comboBox7.SelectedIndex = mainForm.comboBox7.FindString(string.Format("[{0}]", QueryHandler.column_stat_type1));
            mainForm.comboBox8.SelectedIndex = mainForm.comboBox8.FindString(string.Format("[{0}]", QueryHandler.column_stat_type2));
            mainForm.comboBox9.SelectedIndex = mainForm.comboBox9.FindString(string.Format("[{0}]", QueryHandler.column_stat_type3));
            mainForm.comboBox10.SelectedIndex = mainForm.comboBox10.FindString(string.Format("[{0}]", QueryHandler.column_stat_type4));
            mainForm.comboBox11.SelectedIndex = mainForm.comboBox11.FindString(string.Format("[{0}]", QueryHandler.column_stat_type5));
            mainForm.comboBox12.SelectedIndex = mainForm.comboBox12.FindString(string.Format("[{0}]", QueryHandler.column_stat_type6));
            mainForm.comboBox13.SelectedIndex = mainForm.comboBox13.FindString(string.Format("[{0}]", QueryHandler.column_stat_type7));
            mainForm.comboBox14.SelectedIndex = mainForm.comboBox14.FindString(string.Format("[{0}]", QueryHandler.column_stat_type8));
            mainForm.comboBox15.SelectedIndex = mainForm.comboBox15.FindString(string.Format("[{0}]", QueryHandler.column_stat_type9));
            mainForm.comboBox16.SelectedIndex = mainForm.comboBox16.FindString(string.Format("[{0}]", QueryHandler.column_stat_type10));
            mainForm.comboBox17.SelectedIndex = mainForm.comboBox17.FindString(string.Format("[{0}]", QueryHandler.column_dmg_type1));
            mainForm.comboBox18.SelectedIndex = mainForm.comboBox18.FindString(string.Format("[{0}]", QueryHandler.column_dmg_type2));
            mainForm.comboBox19.SelectedIndex = mainForm.comboBox19.FindString(string.Format("[{0}]", QueryHandler.column_ammo_type));
            mainForm.comboBox20.SelectedIndex = mainForm.comboBox20.FindString(string.Format("[{0}]", QueryHandler.column_Material)); // [-1] consumable at index 0
            mainForm.comboBox21.SelectedIndex = mainForm.comboBox21.FindString(string.Format("[{0}]", QueryHandler.column_FoodType));
            mainForm.comboBox22.SelectedIndex = mainForm.comboBox22.FindString(string.Format("[{0}]", QueryHandler.column_TotemCategory));
            mainForm.comboBox23.SelectedIndex = mainForm.comboBox23.FindString(string.Format("[{0}]", QueryHandler.column_spelltrigger_1));
            mainForm.comboBox24.SelectedIndex = mainForm.comboBox24.FindString(string.Format("[{0}]", QueryHandler.column_spelltrigger_2));
            mainForm.comboBox25.SelectedIndex = mainForm.comboBox25.FindString(string.Format("[{0}]", QueryHandler.column_spelltrigger_3));
            mainForm.comboBox26.SelectedIndex = mainForm.comboBox26.FindString(string.Format("[{0}]", QueryHandler.column_spelltrigger_4));
            mainForm.comboBox27.SelectedIndex = mainForm.comboBox27.FindString(string.Format("[{0}]", QueryHandler.column_spelltrigger_5));
            mainForm.comboBox28.SelectedIndex = mainForm.comboBox28.FindString(string.Format("[{0}]", QueryHandler.column_socketColor_1));
            mainForm.comboBox29.SelectedIndex = mainForm.comboBox29.FindString(string.Format("[{0}]", QueryHandler.column_socketColor_2));
            mainForm.comboBox30.SelectedIndex = mainForm.comboBox30.FindString(string.Format("[{0}]", QueryHandler.column_socketColor_3));
            mainForm.comboBox31.SelectedIndex = mainForm.comboBox31.FindString(string.Format("[{0}]", QueryHandler.column_socketBonus));

            preLoadTemplate = false;
        }
    }
}
