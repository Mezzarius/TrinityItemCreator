using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrinityItemCreator.MyClass;

namespace TrinityItemCreator
{
    public partial class Form3 : Form
    {
        private Form1 mainForm;

        public Form3(Form1 form1)
        {
            InitializeComponent();
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

        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
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

        private void Button15_Click(object sender, EventArgs e)
        {
            string path = "templates";

            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            string filepath = string.Format(path + @"\{0}.txt", myTextBox2.Text);
            if (myTextBox2.Text != "Required!")
            {
                if (!File.Exists(filepath))
                {
                    using (TextWriter tw = new StreamWriter(filepath))
                    {
                        tw.Write(GetTemplateDataAsString());
                        tw.Close();
                    }
                    Close();
                }
                else
                {
                    label1.Text = "Name already in use!";
                    label1.ForeColor = Color.Red;
                }
            }
            else
                label1.Text = "Please use a valid name!";
        }

        private string GetTemplateDataAsString()
        {
            string TDataString;
            TDataString = QueryHandler.column_entry.ToString() + "\r\n" +
            QueryHandler.column_class.ToString() + "\r\n" +
            QueryHandler.column_subclass.ToString() + "\r\n" +
            QueryHandler.column_SoundOverrideSubclass.ToString() + "\r\n" +
            QueryHandler.column_name + "\r\n" +
            QueryHandler.column_displayid.ToString() + "\r\n" +
            QueryHandler.column_Quality.ToString() + "\r\n" +
            QueryHandler.column_Flags.ToString() + "\r\n" +
            QueryHandler.column_FlagsExtra.ToString() + "\r\n" +
            QueryHandler.column_BuyCount.ToString() + "\r\n" +
            QueryHandler.column_BuyPrice.ToString() + "\r\n" +
            QueryHandler.column_SellPrice.ToString() + "\r\n" +
            QueryHandler.column_InventoryType.ToString() + "\r\n" +
            QueryHandler.column_AllowableClass.ToString() + "\r\n" +
            QueryHandler.column_AllowableRace.ToString() + "\r\n" +
            QueryHandler.column_ItemLevel.ToString() + "\r\n" +
            QueryHandler.column_RequiredLevel.ToString() + "\r\n" +
            QueryHandler.column_RequiredSkill.ToString() + "\r\n" +
            QueryHandler.column_RequiredSkillRank.ToString() + "\r\n" +
            QueryHandler.column_requiredspell.ToString() + "\r\n" +
            QueryHandler.column_requiredhonorrank.ToString() + "\r\n" +
            QueryHandler.column_RequiredCityRank.ToString() + "\r\n" +
            QueryHandler.column_RequiredReputationFaction.ToString() + "\r\n" +
            QueryHandler.column_RequiredReputationRank.ToString() + "\r\n" +
            QueryHandler.column_maxcount.ToString() + "\r\n" +
            QueryHandler.column_stackable.ToString() + "\r\n" +
            QueryHandler.column_ContainerSlots.ToString() + "\r\n" +
            QueryHandler.column_StatsCount.ToString() + "\r\n" +
            QueryHandler.column_stat_type1.ToString() + "\r\n" +
            QueryHandler.column_stat_value1.ToString() + "\r\n" +
            QueryHandler.column_stat_type2.ToString() + "\r\n" +
            QueryHandler.column_stat_value2.ToString() + "\r\n" +
            QueryHandler.column_stat_type3.ToString() + "\r\n" +
            QueryHandler.column_stat_value3.ToString() + "\r\n" +
            QueryHandler.column_stat_type4.ToString() + "\r\n" +
            QueryHandler.column_stat_value4.ToString() + "\r\n" +
            QueryHandler.column_stat_type5.ToString() + "\r\n" +
            QueryHandler.column_stat_value5.ToString() + "\r\n" +
            QueryHandler.column_stat_type6.ToString() + "\r\n" +
            QueryHandler.column_stat_value6.ToString() + "\r\n" +
            QueryHandler.column_stat_type7.ToString() + "\r\n" +
            QueryHandler.column_stat_value7.ToString() + "\r\n" +
            QueryHandler.column_stat_type8.ToString() + "\r\n" +
            QueryHandler.column_stat_value8.ToString() + "\r\n" +
            QueryHandler.column_stat_type9.ToString() + "\r\n" +
            QueryHandler.column_stat_value9.ToString() + "\r\n" +
            QueryHandler.column_stat_type10.ToString() + "\r\n" +
            QueryHandler.column_stat_value10.ToString() + "\r\n" +
            QueryHandler.column_ScalingStatDistribution.ToString() + "\r\n" +
            QueryHandler.column_ScalingStatValue.ToString() + "\r\n" +
            QueryHandler.column_dmg_min1.ToString() + "\r\n" +
            QueryHandler.column_dmg_max1.ToString() + "\r\n" +
            QueryHandler.column_dmg_type1.ToString() + "\r\n" +
            QueryHandler.column_dmg_min2.ToString() + "\r\n" +
            QueryHandler.column_dmg_max2.ToString() + "\r\n" +
            QueryHandler.column_dmg_type2.ToString() + "\r\n" +
            QueryHandler.column_armor.ToString() + "\r\n" +
            QueryHandler.column_holy_res.ToString() + "\r\n" +
            QueryHandler.column_fire_res.ToString() + "\r\n" +
            QueryHandler.column_nature_res.ToString() + "\r\n" +
            QueryHandler.column_frost_res.ToString() + "\r\n" +
            QueryHandler.column_shadow_res.ToString() + "\r\n" +
            QueryHandler.column_arcane_res.ToString() + "\r\n" +
            QueryHandler.column_delay.ToString() + "\r\n" +
            QueryHandler.column_ammo_type.ToString() + "\r\n" +
            QueryHandler.column_RangedModRange.ToString() + "\r\n" +
            QueryHandler.column_spellid_1.ToString() + "\r\n" +
            QueryHandler.column_spelltrigger_1.ToString() + "\r\n" +
            QueryHandler.column_spellcharges_1.ToString() + "\r\n" +
            QueryHandler.column_spellppmRate_1.ToString() + "\r\n" +
            QueryHandler.column_spellcooldown_1.ToString() + "\r\n" +
            QueryHandler.column_spellcategory_1.ToString() + "\r\n" +
            QueryHandler.column_spellcategorycooldown_1.ToString() + "\r\n" +
            QueryHandler.column_spellid_2.ToString() + "\r\n" +
            QueryHandler.column_spelltrigger_2.ToString() + "\r\n" +
            QueryHandler.column_spellcharges_2.ToString() + "\r\n" +
            QueryHandler.column_spellppmRate_2.ToString() + "\r\n" +
            QueryHandler.column_spellcooldown_2.ToString() + "\r\n" +
            QueryHandler.column_spellcategory_2.ToString() + "\r\n" +
            QueryHandler.column_spellcategorycooldown_2.ToString() + "\r\n" +
            QueryHandler.column_spellid_3.ToString() + "\r\n" +
            QueryHandler.column_spelltrigger_3.ToString() + "\r\n" +
            QueryHandler.column_spellcharges_3.ToString() + "\r\n" +
            QueryHandler.column_spellppmRate_3.ToString() + "\r\n" +
            QueryHandler.column_spellcooldown_3.ToString() + "\r\n" +
            QueryHandler.column_spellcategory_3.ToString() + "\r\n" +
            QueryHandler.column_spellcategorycooldown_3.ToString() + "\r\n" +
            QueryHandler.column_spellid_4.ToString() + "\r\n" +
            QueryHandler.column_spelltrigger_4.ToString() + "\r\n" +
            QueryHandler.column_spellcharges_4.ToString() + "\r\n" +
            QueryHandler.column_spellppmRate_4.ToString() + "\r\n" +
            QueryHandler.column_spellcooldown_4.ToString() + "\r\n" +
            QueryHandler.column_spellcategory_4.ToString() + "\r\n" +
            QueryHandler.column_spellcategorycooldown_4.ToString() + "\r\n" +
            QueryHandler.column_spellid_5.ToString() + "\r\n" +
            QueryHandler.column_spelltrigger_5.ToString() + "\r\n" +
            QueryHandler.column_spellcharges_5.ToString() + "\r\n" +
            QueryHandler.column_spellppmRate_5.ToString() + "\r\n" +
            QueryHandler.column_spellcooldown_5.ToString() + "\r\n" +
            QueryHandler.column_spellcategory_5.ToString() + "\r\n" +
            QueryHandler.column_spellcategorycooldown_5.ToString() + "\r\n" +
            QueryHandler.column_bonding.ToString() + "\r\n" +
            QueryHandler.column_description + "\r\n" +
            QueryHandler.column_PageText.ToString() + "\r\n" +
            QueryHandler.column_LanguageID.ToString() + "\r\n" +
            QueryHandler.column_PageMaterial.ToString() + "\r\n" +
            QueryHandler.column_startquest.ToString() + "\r\n" +
            QueryHandler.column_lockid.ToString() + "\r\n" +
            QueryHandler.column_Material.ToString() + "\r\n" +
            QueryHandler.column_sheath.ToString() + "\r\n" +
            QueryHandler.column_RandomProperty.ToString() + "\r\n" +
            QueryHandler.column_RandomSuffix.ToString() + "\r\n" +
            QueryHandler.column_block.ToString() + "\r\n" +
            QueryHandler.column_itemset.ToString() + "\r\n" +
            QueryHandler.column_MaxDurability.ToString() + "\r\n" +
            QueryHandler.column_area.ToString() + "\r\n" +
            QueryHandler.column_Map.ToString() + "\r\n" +
            QueryHandler.column_BagFamily.ToString() + "\r\n" +
            QueryHandler.column_TotemCategory.ToString() + "\r\n" +
            QueryHandler.column_socketColor_1.ToString() + "\r\n" +
            QueryHandler.column_socketContent_1.ToString() + "\r\n" +
            QueryHandler.column_socketColor_2.ToString() + "\r\n" +
            QueryHandler.column_socketContent_2.ToString() + "\r\n" +
            QueryHandler.column_socketColor_3.ToString() + "\r\n" +
            QueryHandler.column_socketContent_3.ToString() + "\r\n" +
            QueryHandler.column_socketBonus.ToString() + "\r\n" +
            QueryHandler.column_GemProperties.ToString() + "\r\n" +
            QueryHandler.column_RequiredDisenchantSkill.ToString() + "\r\n" +
            QueryHandler.column_ArmorDamageModifier.ToString() + "\r\n" +
            QueryHandler.column_duration.ToString() + "\r\n" +
            QueryHandler.column_ItemLimitCategory.ToString() + "\r\n" +
            QueryHandler.column_HolidayId.ToString() + "\r\n" +
            QueryHandler.column_ScriptName + "\r\n" +
            QueryHandler.column_DisenchantID.ToString() + "\r\n" +
            QueryHandler.column_FoodType.ToString() + "\r\n" +
            QueryHandler.column_minMoneyLoot.ToString() + "\r\n" +
            QueryHandler.column_maxMoneyLoot.ToString() + "\r\n" +
            QueryHandler.column_flagsCustom.ToString() + "\r\n" +
            QueryHandler.column_VerifiedBuild.ToString() + "\r\n";

            return TDataString;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
