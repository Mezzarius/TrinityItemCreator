namespace TrinityItemCreator.MyClass
{
    class MyData
    {
        public MyData() { }

        public string GetTemplateDataAsString()
        {
            string d1 = "\r\n", dend = "\r\n";

            string TDataString =
            Field_entry.ToString()
            + d1 + Field_class.ToString()
            + d1 + Field_subclass.ToString()
            + d1 + Field_SoundOverrideSubclass.ToString()
            + d1 + Field_name
            + d1 + Field_displayid.ToString()
            + d1 + Field_Quality.ToString()
            + d1 + Field_Flags.ToString()
            + d1 + Field_FlagsExtra.ToString()
            + d1 + Field_BuyCount.ToString()
            + d1 + Field_BuyPrice.ToString()
            + d1 + Field_SellPrice.ToString()
            + d1 + Field_InventoryType.ToString()
            + d1 + Field_AllowableClass.ToString()
            + d1 + Field_AllowableRace.ToString()
            + d1 + Field_ItemLevel.ToString()
            + d1 + Field_RequiredLevel.ToString()
            + d1 + Field_RequiredSkill.ToString()
            + d1 + Field_RequiredSkillRank.ToString()
            + d1 + Field_requiredspell.ToString()
            + d1 + Field_requiredhonorrank.ToString()
            + d1 + Field_RequiredCityRank.ToString()
            + d1 + Field_RequiredReputationFaction.ToString()
            + d1 + Field_RequiredReputationRank.ToString()
            + d1 + Field_maxcount.ToString()
            + d1 + Field_stackable.ToString()
            + d1 + Field_ContainerSlots.ToString()
            + d1 + Field_StatsCount.ToString()
            + d1 + Field_stat_type1.ToString()
            + d1 + Field_stat_value1.ToString()
            + d1 + Field_stat_type2.ToString()
            + d1 + Field_stat_value2.ToString()
            + d1 + Field_stat_type3.ToString()
            + d1 + Field_stat_value3.ToString()
            + d1 + Field_stat_type4.ToString()
            + d1 + Field_stat_value4.ToString()
            + d1 + Field_stat_type5.ToString()
            + d1 + Field_stat_value5.ToString()
            + d1 + Field_stat_type6.ToString()
            + d1 + Field_stat_value6.ToString()
            + d1 + Field_stat_type7.ToString()
            + d1 + Field_stat_value7.ToString()
            + d1 + Field_stat_type8.ToString()
            + d1 + Field_stat_value8.ToString()
            + d1 + Field_stat_type9.ToString()
            + d1 + Field_stat_value9.ToString()
            + d1 + Field_stat_type10.ToString()
            + d1 + Field_stat_value10.ToString()
            + d1 + Field_ScalingStatDistribution.ToString()
            + d1 + Field_ScalingStatValue.ToString()
            + d1 + Field_dmg_min1.ToString()
            + d1 + Field_dmg_max1.ToString()
            + d1 + Field_dmg_type1.ToString()
            + d1 + Field_dmg_min2.ToString()
            + d1 + Field_dmg_max2.ToString()
            + d1 + Field_dmg_type2.ToString()
            + d1 + Field_armor.ToString()
            + d1 + Field_holy_res.ToString()
            + d1 + Field_fire_res.ToString()
            + d1 + Field_nature_res.ToString()
            + d1 + Field_frost_res.ToString()
            + d1 + Field_shadow_res.ToString()
            + d1 + Field_arcane_res.ToString()
            + d1 + Field_delay.ToString()
            + d1 + Field_ammo_type.ToString()
            + d1 + Field_RangedModRange.ToString()
            + d1 + Field_spellid_1.ToString()
            + d1 + Field_spelltrigger_1.ToString()
            + d1 + Field_spellcharges_1.ToString()
            + d1 + Field_spellppmRate_1.ToString()
            + d1 + Field_spellcooldown_1.ToString()
            + d1 + Field_spellcategory_1.ToString()
            + d1 + Field_spellcategorycooldown_1.ToString()
            + d1 + Field_spellid_2.ToString()
            + d1 + Field_spelltrigger_2.ToString()
            + d1 + Field_spellcharges_2.ToString()
            + d1 + Field_spellppmRate_2.ToString()
            + d1 + Field_spellcooldown_2.ToString()
            + d1 + Field_spellcategory_2.ToString()
            + d1 + Field_spellcategorycooldown_2.ToString()
            + d1 + Field_spellid_3.ToString()
            + d1 + Field_spelltrigger_3.ToString()
            + d1 + Field_spellcharges_3.ToString()
            + d1 + Field_spellppmRate_3.ToString()
            + d1 + Field_spellcooldown_3.ToString()
            + d1 + Field_spellcategory_3.ToString()
            + d1 + Field_spellcategorycooldown_3.ToString()
            + d1 + Field_spellid_4.ToString()
            + d1 + Field_spelltrigger_4.ToString()
            + d1 + Field_spellcharges_4.ToString()
            + d1 + Field_spellppmRate_4.ToString()
            + d1 + Field_spellcooldown_4.ToString()
            + d1 + Field_spellcategory_4.ToString()
            + d1 + Field_spellcategorycooldown_4.ToString()
            + d1 + Field_spellid_5.ToString()
            + d1 + Field_spelltrigger_5.ToString()
            + d1 + Field_spellcharges_5.ToString()
            + d1 + Field_spellppmRate_5.ToString()
            + d1 + Field_spellcooldown_5.ToString()
            + d1 + Field_spellcategory_5.ToString()
            + d1 + Field_spellcategorycooldown_5.ToString()
            + d1 + Field_bonding.ToString()
            + d1 + Field_description
            + d1 + Field_PageText.ToString()
            + d1 + Field_LanguageID.ToString()
            + d1 + Field_PageMaterial.ToString()
            + d1 + Field_startquest.ToString()
            + d1 + Field_lockid.ToString()
            + d1 + Field_Material.ToString()
            + d1 + Field_sheath.ToString()
            + d1 + Field_RandomProperty.ToString()
            + d1 + Field_RandomSuffix.ToString()
            + d1 + Field_block.ToString()
            + d1 + Field_itemset.ToString()
            + d1 + Field_MaxDurability.ToString()
            + d1 + Field_area.ToString()
            + d1 + Field_Map.ToString()
            + d1 + Field_BagFamily.ToString()
            + d1 + Field_TotemCategory.ToString()
            + d1 + Field_socketColor_1.ToString()
            + d1 + Field_socketContent_1.ToString()
            + d1 + Field_socketColor_2.ToString()
            + d1 + Field_socketContent_2.ToString()
            + d1 + Field_socketColor_3.ToString()
            + d1 + Field_socketContent_3.ToString()
            + d1 + Field_socketBonus.ToString()
            + d1 + Field_GemProperties.ToString()
            + d1 + Field_RequiredDisenchantSkill.ToString()
            + d1 + Field_ArmorDamageModifier.ToString()
            + d1 + Field_duration.ToString()
            + d1 + Field_ItemLimitCategory.ToString()
            + d1 + Field_HolidayId.ToString()
            + d1 + Field_ScriptName
            + d1 + Field_DisenchantID.ToString()
            + d1 + Field_FoodType.ToString()
            + d1 + Field_minMoneyLoot.ToString()
            + d1 + Field_maxMoneyLoot.ToString()
            + d1 + Field_flagsCustom.ToString()
            + d1 + Field_VerifiedBuild.ToString() + dend;

            return TDataString;
        }

        public static string[][] SubClassArray = new string[][]
        {
            // 0 : Consumables
            new string[] {
                "[0] Consumable",
                "[1] Potion",
                "[2] Elixir",
                "[3] Flask",
                "[4] Scroll",
                "[5] Food & Drink",
                "[6] Item Enhancement",
                "[7] Bandage",
                "[8] Other"
            },
            // 1 : Container
            new string[] {
                "[0] Bag",
                "[1] Soul Bag",
                "[2] Herb Bag",
                "[3] Enchanting Bag",
                "[4] Engineering Bag",
                "[5] Gem Bag",
                "[6] Mining Bag",
                "[7] Leatherworking Bag",
                "[8] Inscription Bag"
            },
            // 2 : Weapon
            new string[] {
                "[0] Axe One-Handed",
                "[1] Axe Two-Handed",
                "[2] Bow",
                "[3] Gun",
                "[4] Mace One-Handed",
                "[5] Mace Two-Handed",
                "[6] Polearm",
                "[7] Sword One-Handed",
                "[8] Sword Two-Handed",
                "[9] Obsolete",
                "[10] Staff",
                "[11] Exotic 1",
                "[12] Exotic 2",
                "[13] Fist Weapon",
                "[14] Miscellaneous",
                "[15] Dagger",
                "[16] Thrown",
                "[17] Spear",
                "[18] Crossbow",
                "[19] Wand",
                "[20] Fishing Pole"
            },
            
            // 3 : Gem
            new string[] {
                "[0] Red",
                "[1] Blue",
                "[2] Yellow",
                "[3] Purple",
                "[4] Green",
                "[5] Orange",
                "[6] Meta",
                "[7] Simple",
                "[8] Prismatic"
            },
            
            // 4 : Armor
            new string[] {
                "[0] Miscellaneous",
                "[1] Cloth",
                "[2] Leather",
                "[3] Mail",
                "[4] Plate",
                "[5] Blucker (OBSOLETE)",
                "[6] Shield",
                "[7] Libram",
                "[8] Idol",
                "[9] Totem",
                "[10] Sigil"
            },
            
            // 5 : Reagent
            new string[] {
                "[0] Reagent"
            },
            
            // 6 : Projectile
            new string[] {
                "[0] Wand (OBSOLETE)",
                "[1] Bolt (OBSOLETE)",
                "[2] Arrow",
                "[3] Bullet",
                "[4] Thrown (OBSOLETE)"
            },
            
            // 7 : Trade Goods
            new string[] {
                "[0] Trade Goods",
                "[1] Parts",
                "[2] Explosives",
                "[3] Devices",
                "[4] Jewelcrafting",
                "[5] Cloth",
                "[6] Leather",
                "[7] Metal & Stone",
                "[8] Meat",
                "[9] Herb",
                "[10] Elemental",
                "[11] Other",
                "[12] Enchantment",
                "[13] Materials",
                "[14] Armor Enchantment",
                "[15] Weapon Enchantment"
            },
            
            // 8 : Generic
            new string[] {
                "[0] Generic (OBSOLETE)"
            },
            
            // 9 : Recipe
            new string[] {
                "[0] Book",
                "[1] Leatherworking",
                "[2] Tailoring",
                "[3] Engineering",
                "[4] Blacksmithing",
                "[5] Cooking",
                "[6] Alchemy",
                "[7] First Aid",
                "[8] Enchanting",
                "[9] Fishing",
                "[10] Jewelcrafting"
            },
            
            // 10 : Money
            new string[] {
                "[0] Money (OBSOLETE)"
            },
            
            // 11 : Quiver
            new string[] {
                "[0] Quiver (OBSOLETE)",
                "[1] Quiver (OBSOLETE)",
                "[2] Quiver",
                "[3] Money Pouch"
            },
            
            // 12 : Quest
            new string[] {
                "[0] Quest"
            },
            
            // 13 : Key
            new string[] {
                "[0] Key",
                "[1] Lockpick"
            },
            
            // 14 : Permanent
            new string[] {
                "[0] Permanent"
            },
            
            // 15 : Miscellaneous
            new string[] {
                "[0] Junk",
                "[1] Reagent",
                "[2] Pet",
                "[3] Holiday",
                "[4] Other",
                "[5] Mount"
            },
            
            // 16 : Glyph
            new string[] {
                "[1] Warrior",
                "[2] Paladin",
                "[3] Hunter",
                "[4] Rogue",
                "[5] Priest",
                "[6] Death Knight",
                "[7] Shaman",
                "[8] Mage",
                "[9] Warlock",
                "[11] Druid"
            }
        };

        public static ulong
            Field_Flags;

        public static string
            Field_name = "",
            Field_description = "",
            Field_ScriptName = "";

        public static float
            Field_dmg_min1 = 0,
            Field_dmg_max1 = 0,
            Field_dmg_min2 = 0,
            Field_dmg_max2 = 0,
            Field_RangedModRange = 0,
            Field_spellppmRate_1 = 0,
            Field_spellppmRate_2 = 0,
            Field_spellppmRate_3 = 0,
            Field_spellppmRate_4 = 0,
            Field_spellppmRate_5 = 0,
            Field_ArmorDamageModifier = 0;

        public static int
            Field_entry = 0,
            Field_class = 0,
            Field_subclass = 0,
            Field_SoundOverrideSubclass = -1,
            Field_displayid = 0,
            Field_Quality = 0,
            Field_FlagsExtra = 0,
            Field_BuyCount = 1,
            Field_BuyPrice = 0,
            Field_SellPrice = 0,
            Field_InventoryType = 0,
            Field_AllowableClass = -1,
            Field_AllowableRace = -1,
            Field_ItemLevel = 0,
            Field_RequiredLevel = 0,
            Field_RequiredSkill = 0,
            Field_RequiredSkillRank = 0,
            Field_requiredspell = 0,
            Field_requiredhonorrank = 0,
            Field_RequiredCityRank = 0,
            Field_RequiredReputationFaction = 0,
            Field_RequiredReputationRank = 0,
            Field_maxcount = 0,
            Field_stackable = -1,
            Field_ContainerSlots = 0,
            Field_StatsCount  = 10,
            Field_stat_type1 = 0,
            Field_stat_value1 = 0,
            Field_stat_type2 = 0,
            Field_stat_value2 = 0,
            Field_stat_type3 = 0,
            Field_stat_value3 = 0,
            Field_stat_type4 = 0,
            Field_stat_value4 = 0,
            Field_stat_type5 = 0,
            Field_stat_value5 = 0,
            Field_stat_type6 = 0,
            Field_stat_value6 = 0,
            Field_stat_type7 = 0,
            Field_stat_value7 = 0,
            Field_stat_type8 = 0,
            Field_stat_value8 = 0,
            Field_stat_type9 = 0,
            Field_stat_value9 = 0,
            Field_stat_type10 = 0,
            Field_stat_value10 = 0,
            Field_ScalingStatDistribution = 0,
            Field_ScalingStatValue = 0,
            Field_dmg_type1 = 0,
            Field_dmg_type2 = 0,
            Field_armor = 0,
            Field_holy_res = 0,
            Field_fire_res = 0,
            Field_nature_res = 0,
            Field_frost_res = 0,
            Field_shadow_res = 0,
            Field_arcane_res = 0,
            Field_delay = 0,
            Field_ammo_type = 0,
            Field_spellid_1 = 0,
            Field_spelltrigger_1 = 0,
            Field_spellcharges_1 = 0,
            Field_spellcooldown_1 = -1,
            Field_spellcategory_1 = 0,
            Field_spellcategorycooldown_1 = -1,
            Field_spellid_2 = 0,
            Field_spelltrigger_2 = 0,
            Field_spellcharges_2 = 0,
            Field_spellcooldown_2 = -1,
            Field_spellcategory_2 = 0,
            Field_spellcategorycooldown_2 = -1,
            Field_spellid_3 = 0,
            Field_spelltrigger_3 = 0,
            Field_spellcharges_3 = 0,
            Field_spellcooldown_3 = -1,
            Field_spellcategory_3 = 0,
            Field_spellcategorycooldown_3 = -1,
            Field_spellid_4 = 0,
            Field_spelltrigger_4 = 0,
            Field_spellcharges_4 = 0,
            Field_spellcooldown_4 = -1,
            Field_spellcategory_4 = 0,
            Field_spellcategorycooldown_4 = -1,
            Field_spellid_5 = 0,
            Field_spelltrigger_5 = 0,
            Field_spellcharges_5 = 0,
            Field_spellcooldown_5 = -1,
            Field_spellcategory_5 = 0,
            Field_spellcategorycooldown_5 = -1,
            Field_bonding = 0,
            Field_PageText = 0,
            Field_LanguageID = 0,
            Field_PageMaterial = 0,
            Field_startquest = 0,
            Field_lockid = 0,
            Field_Material = 0,
            Field_sheath = 0,
            Field_RandomProperty = 0,
            Field_RandomSuffix = 0,
            Field_block = 0,
            Field_itemset = 0,
            Field_MaxDurability = 0,
            Field_area = 0,
            Field_Map = 0,
            Field_BagFamily = 0,
            Field_TotemCategory = 0,
            Field_socketColor_1 = 0,
            Field_socketContent_1 = 0,
            Field_socketColor_2 = 0,
            Field_socketContent_2 = 0,
            Field_socketColor_3 = 0,
            Field_socketContent_3 = 0,
            Field_socketBonus = 0,
            Field_GemProperties = 0,
            Field_duration = 0,
            Field_ItemLimitCategory = 0,
            Field_HolidayId = 0,
            Field_DisenchantID = 0,
            Field_FoodType = 0,
            Field_minMoneyLoot = 0,
            Field_maxMoneyLoot = 0,
            Field_flagsCustom = 0,
            Field_VerifiedBuild = 1,
            Field_RequiredDisenchantSkill = -1;
    }
}
