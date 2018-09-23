namespace TrinityItemCreator.MyClass
{
    class QueryHandler
    {
        public QueryHandler() { }

        public static string GetExportQuery()
        {
            string VQuery = "";

            VQuery = "INSERT INTO `item_template` (`entry`, " +
            // COLUMNS ---------------------------------------------------------------
                        "`class`, " +
                        "`subclass`, " +
                        "`SoundOverrideSubclass`, " +
                        "`name`, " +
                        "`displayid`, " +
                        "`Quality`, " +
                        "`Flags`, " +
                        "`FlagsExtra`, " +
                        "`BuyCount`, " +
                        "`BuyPrice`, " +
                        "`SellPrice`, " +
                        "`InventoryType`, " +
                        "`AllowableClass`, " +
                        "`AllowableRace`, " +
                        "`ItemLevel`, " +
                        "`RequiredLevel`, " +
                        "`RequiredSkill`, " +
                        "`RequiredSkillRank`, " +
                        "`requiredspell`, " +
                        "`requiredhonorrank`, " +
                        "`RequiredCityRank`, " +
                        "`RequiredReputationFaction`, " +
                        "`RequiredReputationRank`, " +
                        "`maxcount`, " +
                        "`stackable`, " +
                        "`ContainerSlots`, " +
                        "`StatsCount`, " +
                        "`stat_type1`, " +
                        "`stat_value1`, " +
                        "`stat_type2`, " +
                        "`stat_value2`, " +
                        "`stat_type3`, " +
                        "`stat_value3`, " +
                        "`stat_type4`, " +
                        "`stat_value4`, " +
                        "`stat_type5`, " +
                        "`stat_value5`, " +
                        "`stat_type6`, " +
                        "`stat_value6`, " +
                        "`stat_type7`, " +
                        "`stat_value7`, " +
                        "`stat_type8`, " +
                        "`stat_value8`, " +
                        "`stat_type9`, " +
                        "`stat_value9`, " +
                        "`stat_type10`, " +
                        "`stat_value10`, " +
                        "`ScalingStatDistribution`, " +
                        "`ScalingStatValue`, " +
                        "`dmg_min1`, " +
                        "`dmg_max1`, " +
                        "`dmg_type1`, " +
                        "`dmg_min2`, " +
                        "`dmg_max2`, " +
                        "`dmg_type2`, " +
                        "`armor`, " +
                        "`holy_res`, " +
                        "`fire_res`, " +
                        "`nature_res`, " +
                        "`frost_res`, " +
                        "`shadow_res`, " +
                        "`arcane_res`, " +
                        "`delay`, " +
                        "`ammo_type`, " +
                        "`RangedModRange`, " +
                        "`spellid_1`, " +
                        "`spelltrigger_1`, " +
                        "`spellcharges_1`, " +
                        "`spellppmRate_1`, " +
                        "`spellcooldown_1`, " +
                        "`spellcategory_1`, " +
                        "`spellcategorycooldown_1`, " +
                        "`spellid_2`, " +
                        "`spelltrigger_2`, " +
                        "`spellcharges_2`, " +
                        "`spellppmRate_2`, " +
                        "`spellcooldown_2`, " +
                        "`spellcategory_2`, " +
                        "`spellcategorycooldown_2`, " +
                        "`spellid_3`, " +
                        "`spelltrigger_3`, " +
                        "`spellcharges_3`, " +
                        "`spellppmRate_3`, " +
                        "`spellcooldown_3`, " +
                        "`spellcategory_3`, " +
                        "`spellcategorycooldown_3`, " +
                        "`spellid_4`, " +
                        "`spelltrigger_4`, " +
                        "`spellcharges_4`, " +
                        "`spellppmRate_4`, " +
                        "`spellcooldown_4`, " +
                        "`spellcategory_4`, " +
                        "`spellcategorycooldown_4`, " +
                        "`spellid_5`, " +
                        "`spelltrigger_5`, " +
                        "`spellcharges_5`, " +
                        "`spellppmRate_5`, " +
                        "`spellcooldown_5`, " +
                        "`spellcategory_5`, " +
                        "`spellcategorycooldown_5`, " +
                        "`bonding`, " +
                        "`description`, " +
                        "`PageText`, " +
                        "`LanguageID`, " +
                        "`PageMaterial`, " +
                        "`startquest`, " +
                        "`lockid`, " +
                        "`Material`, " +
                        "`sheath`, " +
                        "`RandomProperty`, " +
                        "`RandomSuffix`, " +
                        "`block`, " +
                        "`itemset`, " +
                        "`MaxDurability`, " +
                        "`area`, " +
                        "`Map`, " +
                        "`BagFamily`, " +
                        "`TotemCategory`, " +
                        "`socketColor_1`, " +
                        "`socketContent_1`, " +
                        "`socketColor_2`, " +
                        "`socketContent_2`, " +
                        "`socketColor_3`, " +
                        "`socketContent_3`, " +
                        "`socketBonus`, " +
                        "`GemProperties`, " +
                        "`RequiredDisenchantSkill`, " +
                        "`ArmorDamageModifier`, " +
                        "`duration`, " +
                        "`ItemLimitCategory`, " +
                        "`HolidayId`, " +
                        "`ScriptName`, " +
                        "`DisenchantID`, " +
                        "`FoodType`, " +
                        "`minMoneyLoot`, " +
                        "`maxMoneyLoot`, " +
                        "`flagsCustom`, " +
                        "`VerifiedBuild`) VALUES \n(" +
            // VALUES ---------------------------------------------------------------
                        column_entry.ToString() + ", " +
                        column_class.ToString() + ", " +
                        column_subclass.ToString() + ", " +
                        column_SoundOverrideSubclass.ToString() + ", " +
                        "'" + column_name + "', " +
                        column_displayid.ToString() + ", " +
                        column_Quality.ToString() + ", " +
                        column_Flags.ToString() + ", " +
                        column_FlagsExtra.ToString() + ", " +
                        column_BuyCount.ToString() + ", " +
                        column_BuyPrice.ToString() + ", " +
                        column_SellPrice.ToString() + ", " +
                        column_InventoryType.ToString() + ", " +
                        column_AllowableClass.ToString() + ", " +
                        column_AllowableRace.ToString() + ", " +
                        column_ItemLevel.ToString() + ", " +
                        column_RequiredLevel.ToString() + ", " +
                        column_RequiredSkill.ToString() + ", " +
                        column_RequiredSkillRank.ToString() + ", " +
                        column_requiredspell.ToString() + ", " +
                        column_requiredhonorrank.ToString() + ", " +
                        column_RequiredCityRank.ToString() + ", " +
                        column_RequiredReputationFaction.ToString() + ", " +
                        column_RequiredReputationRank.ToString() + ", " +
                        column_maxcount.ToString() + ", " +
                        column_stackable.ToString() + ", " +
                        column_ContainerSlots.ToString() + ", " +
                        column_StatsCount.ToString() + ", " +
                        column_stat_type1.ToString() + ", " +
                        column_stat_value1.ToString() + ", " +
                        column_stat_type2.ToString() + ", " +
                        column_stat_value2.ToString() + ", " +
                        column_stat_type3.ToString() + ", " +
                        column_stat_value3.ToString() + ", " +
                        column_stat_type4.ToString() + ", " +
                        column_stat_value4.ToString() + ", " +
                        column_stat_type5.ToString() + ", " +
                        column_stat_value5.ToString() + ", " +
                        column_stat_type6.ToString() + ", " +
                        column_stat_value6.ToString() + ", " +
                        column_stat_type7.ToString() + ", " +
                        column_stat_value7.ToString() + ", " +
                        column_stat_type8.ToString() + ", " +
                        column_stat_value8.ToString() + ", " +
                        column_stat_type9.ToString() + ", " +
                        column_stat_value9.ToString() + ", " +
                        column_stat_type10.ToString() + ", " +
                        column_stat_value10.ToString() + ", " +
                        column_ScalingStatDistribution.ToString() + ", " +
                        column_ScalingStatValue.ToString() + ", " +
                        column_dmg_min1.ToString() + ", " +
                        column_dmg_max1.ToString() + ", " +
                        column_dmg_type1.ToString() + ", " +
                        column_dmg_min2.ToString() + ", " +
                        column_dmg_max2.ToString() + ", " +
                        column_dmg_type2.ToString() + ", " +
                        column_armor.ToString() + ", " +
                        column_holy_res.ToString() + ", " +
                        column_fire_res.ToString() + ", " +
                        column_nature_res.ToString() + ", " +
                        column_frost_res.ToString() + ", " +
                        column_shadow_res.ToString() + ", " +
                        column_arcane_res.ToString() + ", " +
                        column_delay.ToString() + ", " +
                        column_ammo_type.ToString() + ", " +
                        column_RangedModRange.ToString() + ", " +
                        column_spellid_1.ToString() + ", " +
                        column_spelltrigger_1.ToString() + ", " +
                        column_spellcharges_1.ToString() + ", " +
                        column_spellppmRate_1.ToString() + ", " +
                        column_spellcooldown_1.ToString() + ", " +
                        column_spellcategory_1.ToString() + ", " +
                        column_spellcategorycooldown_1.ToString() + ", " +
                        column_spellid_2.ToString() + ", " +
                        column_spelltrigger_2.ToString() + ", " +
                        column_spellcharges_2.ToString() + ", " +
                        column_spellppmRate_2.ToString() + ", " +
                        column_spellcooldown_2.ToString() + ", " +
                        column_spellcategory_2.ToString() + ", " +
                        column_spellcategorycooldown_2.ToString() + ", " +
                        column_spellid_3.ToString() + ", " +
                        column_spelltrigger_3.ToString() + ", " +
                        column_spellcharges_3.ToString() + ", " +
                        column_spellppmRate_3.ToString() + ", " +
                        column_spellcooldown_3.ToString() + ", " +
                        column_spellcategory_3.ToString() + ", " +
                        column_spellcategorycooldown_3.ToString() + ", " +
                        column_spellid_4.ToString() + ", " +
                        column_spelltrigger_4.ToString() + ", " +
                        column_spellcharges_4.ToString() + ", " +
                        column_spellppmRate_4.ToString() + ", " +
                        column_spellcooldown_4.ToString() + ", " +
                        column_spellcategory_4.ToString() + ", " +
                        column_spellcategorycooldown_4.ToString() + ", " +
                        column_spellid_5.ToString() + ", " +
                        column_spelltrigger_5.ToString() + ", " +
                        column_spellcharges_5.ToString() + ", " +
                        column_spellppmRate_5.ToString() + ", " +
                        column_spellcooldown_5.ToString() + ", " +
                        column_spellcategory_5.ToString() + ", " +
                        column_spellcategorycooldown_5.ToString() + ", " +
                        column_bonding.ToString() + ", " +
                        "'" + column_description + "', " +
                        column_PageText.ToString() + ", " +
                        column_LanguageID.ToString() + ", " +
                        column_PageMaterial.ToString() + ", " +
                        column_startquest.ToString() + ", " +
                        column_lockid.ToString() + ", " +
                        column_Material.ToString() + ", " +
                        column_sheath.ToString() + ", " +
                        column_RandomProperty.ToString() + ", " +
                        column_RandomSuffix.ToString() + ", " +
                        column_block.ToString() + ", " +
                        column_itemset.ToString() + ", " +
                        column_MaxDurability.ToString() + ", " +
                        column_area.ToString() + ", " +
                        column_Map.ToString() + ", " +
                        column_BagFamily.ToString() + ", " +
                        column_TotemCategory.ToString() + ", " +
                        column_socketColor_1.ToString() + ", " +
                        column_socketContent_1.ToString() + ", " +
                        column_socketColor_2.ToString() + ", " +
                        column_socketContent_2.ToString() + ", " +
                        column_socketColor_3.ToString() + ", " +
                        column_socketContent_3.ToString() + ", " +
                        column_socketBonus.ToString() + ", " +
                        column_GemProperties.ToString() + ", " +
                        column_RequiredDisenchantSkill.ToString() + ", " +
                        column_ArmorDamageModifier.ToString() + ", " +
                        column_duration.ToString() + ", " +
                        column_ItemLimitCategory.ToString() + ", " +
                        column_HolidayId.ToString() + ", " +
                        "'" + column_ScriptName + "', " +
                        column_DisenchantID.ToString() + ", " +
                        column_FoodType.ToString() + ", " +
                        column_minMoneyLoot.ToString() + ", " +
                        column_maxMoneyLoot.ToString() + ", " +
                        column_flagsCustom.ToString() + ", " +
                        column_VerifiedBuild.ToString() + ");";

            return VQuery;
        }

        public static int column_entry { get; set; }
        public static int column_class { get; set; }
        public static int column_subclass { get; set; }
        public static int column_SoundOverrideSubclass { get; set; } = -1;
        public static string column_name { get; set; }
        public static int column_displayid { get; set; }
        public static int column_Quality { get; set; }
        public static ulong column_Flags { get; set; }
        public static int column_FlagsExtra { get; set; }
        public static int column_BuyCount { get; set; } = 1;
        public static int column_BuyPrice { get; set; }
        public static int column_SellPrice { get; set; }
        public static int column_InventoryType { get; set; }
        public static int column_AllowableClass { get; set; } = -1;
        public static int column_AllowableRace { get; set; } = -1;
        public static int column_ItemLevel { get; set; }
        public static int column_RequiredLevel { get; set; }
        public static int column_RequiredSkill { get; set; }
        public static int column_RequiredSkillRank { get; set; }
        public static int column_requiredspell { get; set; }
        public static int column_requiredhonorrank { get; set; }
        public static int column_RequiredCityRank { get; set; }
        public static int column_RequiredReputationFaction { get; set; }
        public static int column_RequiredReputationRank { get; set; }
        public static int column_maxcount { get; set; }
        public static int column_stackable { get; set; } = 1;
        public static int column_ContainerSlots { get; set; }
        public static int column_StatsCount { get; set; } = 10;
        public static int column_stat_type1 { get; set; }
        public static int column_stat_value1 { get; set; }
        public static int column_stat_type2 { get; set; }
        public static int column_stat_value2 { get; set; }
        public static int column_stat_type3 { get; set; }
        public static int column_stat_value3 { get; set; }
        public static int column_stat_type4 { get; set; }
        public static int column_stat_value4 { get; set; }
        public static int column_stat_type5 { get; set; }
        public static int column_stat_value5 { get; set; }
        public static int column_stat_type6 { get; set; }
        public static int column_stat_value6 { get; set; }
        public static int column_stat_type7 { get; set; }
        public static int column_stat_value7 { get; set; }
        public static int column_stat_type8 { get; set; }
        public static int column_stat_value8 { get; set; }
        public static int column_stat_type9 { get; set; }
        public static int column_stat_value9 { get; set; }
        public static int column_stat_type10 { get; set; }
        public static int column_stat_value10 { get; set; }
        public static int column_ScalingStatDistribution { get; set; }
        public static int column_ScalingStatValue { get; set; }
        public static float column_dmg_min1 { get; set; }
        public static float column_dmg_max1 { get; set; }
        public static int column_dmg_type1 { get; set; }
        public static float column_dmg_min2 { get; set; }
        public static float column_dmg_max2 { get; set; }
        public static int column_dmg_type2 { get; set; }
        public static int column_armor { get; set; }
        public static int column_holy_res { get; set; }
        public static int column_fire_res { get; set; }
        public static int column_nature_res { get; set; }
        public static int column_frost_res { get; set; }
        public static int column_shadow_res { get; set; }
        public static int column_arcane_res { get; set; }
        public static int column_delay { get; set; }
        public static int column_ammo_type { get; set; }
        public static float column_RangedModRange { get; set; }
        public static int column_spellid_1 { get; set; }
        public static int column_spelltrigger_1 { get; set; }
        public static int column_spellcharges_1 { get; set; }
        public static float column_spellppmRate_1 { get; set; }
        public static int column_spellcooldown_1 { get; set; } = -1;
        public static int column_spellcategory_1 { get; set; }
        public static int column_spellcategorycooldown_1 { get; set; } = -1;
        public static int column_spellid_2 { get; set; }
        public static int column_spelltrigger_2 { get; set; }
        public static int column_spellcharges_2 { get; set; }
        public static float column_spellppmRate_2 { get; set; }
        public static int column_spellcooldown_2 { get; set; } = -1;
        public static int column_spellcategory_2 { get; set; }
        public static int column_spellcategorycooldown_2 { get; set; } = -1;
        public static int column_spellid_3 { get; set; }
        public static int column_spelltrigger_3 { get; set; }
        public static int column_spellcharges_3 { get; set; }
        public static float column_spellppmRate_3 { get; set; }
        public static int column_spellcooldown_3 { get; set; } = -1;
        public static int column_spellcategory_3 { get; set; }
        public static int column_spellcategorycooldown_3 { get; set; } = -1;
        public static int column_spellid_4 { get; set; }
        public static int column_spelltrigger_4 { get; set; }
        public static int column_spellcharges_4 { get; set; }
        public static float column_spellppmRate_4 { get; set; }
        public static int column_spellcooldown_4 { get; set; } = -1;
        public static int column_spellcategory_4 { get; set; }
        public static int column_spellcategorycooldown_4 { get; set; } = -1;
        public static int column_spellid_5 { get; set; }
        public static int column_spelltrigger_5 { get; set; }
        public static int column_spellcharges_5 { get; set; }
        public static float column_spellppmRate_5 { get; set; }
        public static int column_spellcooldown_5 { get; set; } = -1;
        public static int column_spellcategory_5 { get; set; }
        public static int column_spellcategorycooldown_5 { get; set; } = -1;
        public static int column_bonding { get; set; }
        public static string column_description { get; set; }
        public static int column_PageText { get; set; }
        public static int column_LanguageID { get; set; }
        public static int column_PageMaterial { get; set; }
        public static int column_startquest { get; set; }
        public static int column_lockid { get; set; }
        public static int column_Material { get; set; }
        public static int column_sheath { get; set; }
        public static int column_RandomProperty { get; set; }
        public static int column_RandomSuffix { get; set; }
        public static int column_block { get; set; }
        public static int column_itemset { get; set; }
        public static int column_MaxDurability { get; set; }
        public static int column_area { get; set; }
        public static int column_Map { get; set; }
        public static int column_BagFamily { get; set; }
        public static int column_TotemCategory { get; set; }
        public static int column_socketColor_1 { get; set; }
        public static int column_socketContent_1 { get; set; }
        public static int column_socketColor_2 { get; set; }
        public static int column_socketContent_2 { get; set; }
        public static int column_socketColor_3 { get; set; }
        public static int column_socketContent_3 { get; set; }
        public static int column_socketBonus { get; set; }
        public static int column_GemProperties { get; set; }
        public static int column_RequiredDisenchantSkill { get; set; } = -1;
        public static float column_ArmorDamageModifier { get; set; }
        public static int column_duration { get; set; }
        public static int column_ItemLimitCategory { get; set; }
        public static int column_HolidayId { get; set; }
        public static string column_ScriptName { get; set; }
        public static int column_DisenchantID { get; set; }
        public static int column_FoodType { get; set; }
        public static int column_minMoneyLoot { get; set; }
        public static int column_maxMoneyLoot { get; set; }
        public static int column_flagsCustom { get; set; }
        public static int column_VerifiedBuild { get; set; } = 1;
    }
}
