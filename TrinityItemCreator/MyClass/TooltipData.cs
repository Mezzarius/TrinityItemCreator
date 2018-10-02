using System;
using TrinityItemCreator.MyClass;

namespace TrinityItemCreator.MyClass
{
    class TooltipData
    {
        public TooltipData() { }
        
        public static string[] HidenSeek = new string[139];

        private string[] StatsArray =
        {
            "Mana",
            "Health",
            null, // 2 : stat doesnt exist
            "Agility",
            "Strength",
            "Intellect",
            "Spirit",
            "Stamina",
            null, // 8 : stat doesnt exist
            null, // 9 : stat doesnt exist
            null, // 10 : stat doesnt exist
            null, // 11 : stat doesnt exist
            "Increases your defense rating by",
            "Increases your dodge rating by",
            "Increases your parry rating by",
            "Increases your melee hit rating by",
            "Increases your ranged hit rating by",
            "Increases your spell hit rating by",
            "Increases your melee crit rating by",
            "Increases your ranged crit rating by",
            "Increases melee hit taken rating by",
            "Increases ranged hit taken rating by",
            "Increases spell hit taken rating by",
            "Increases melee crit taken rating by",
            "Increases ranged crit taken rating by",
            "Increases spell crit taken rating by",
            "Increases melee haste rating by",
            "Increases ranged haste rating by",
            "Increases spell haste rating by",
            "Increases hit rating by",
            "Increases crit rating by",
            "Increases hit taken rating by",
            "Increases crit taken rating by",
            "Increases resilience by",
            "Increases haste rating by",
            "Increases expertise rating by",
            "Increases attack power by",
            "Increases ranged attack power by",
            "Increases feral attack power by",
            "Increases healing done by your spells by",
            "Increases damage done by your spells by",
            "Increases mana regeneration by",
            "Increases armor penetration rating by",
            "Increases attack power by",
            "Increases spell power by",
            "Increases health regeneration by",
            "Increases spell penetration by",
            "Increases the block value by your shield by",
        };

        private string[] SpellTriggerArray =
        {
            "Use:",
            "Equip:",
            "Chance on Hit:",
            "Use:", // soulstone
            "Instant Use:",
            "Use: Teaches you"
        };

        public void UpdateHidenSeekArray()
        {
            if (MyData.Field_name.Length == 0)
                HidenSeek[0] = "<No Name>";
            else
                HidenSeek[0] = MyData.Field_name;

            if (MyData.Field_bonding == 1)
                HidenSeek[1] = "Binds when picked up";
            else if (MyData.Field_bonding == 2)
                HidenSeek[1] = "Binds when equipped";
            else if (MyData.Field_bonding == 3)
                HidenSeek[1] = "Binds when used";
            else
                HidenSeek[1] = null;


            if (MyData.Field_maxcount > 0)
                HidenSeek[2] = MyData.Field_maxcount > 1 ? $"Unique ({MyData.Field_maxcount})" : "Unique";
            else
                HidenSeek[2] = null;

            switch(MyData.Field_InventoryType)
            {
                case 1: HidenSeek[3] = "Head"; break;
                case 2: HidenSeek[3] = "Necklace"; break;
                case 3: HidenSeek[3] = "Shoulder"; break;
                case 4: HidenSeek[3] = "Shirt"; break;
                case 5: HidenSeek[3] = "Chest"; break;
                case 6: HidenSeek[3] = "Waist"; break;
                case 7: HidenSeek[3] = "Legs"; break;
                case 8: HidenSeek[3] = "Foot"; break;
                case 9: HidenSeek[3] = "Wrist"; break;
                case 10: HidenSeek[3] = "Hands"; break;
                case 11: HidenSeek[3] = "Ring"; break;
                case 12: HidenSeek[3] = "Trinket"; break;
                case 13: HidenSeek[3] = "One-Hand"; break;
                case 14: HidenSeek[3] = "Shield"; break;
                case 15: HidenSeek[3] = "Bow"; break;
                case 16: HidenSeek[3] = "Cloak"; break;
                case 17: HidenSeek[3] = "Two-Hand"; break;
                case 18:
                {
                    if (MyData.Field_class == 1) // bags
                    {
                        switch (MyData.Field_subclass)
                        {
                            case 0: HidenSeek[3] = $"{MyData.Field_ContainerSlots} Slots Bag"; break;
                            case 1: HidenSeek[3] = $"{MyData.Field_ContainerSlots} Slots Soul Bag"; break;
                            case 2: HidenSeek[3] = $"{MyData.Field_ContainerSlots} Slots Herb Bag"; break;
                            case 3: HidenSeek[3] = $"{MyData.Field_ContainerSlots} Slots Enchanting Bag"; break;
                            case 4: HidenSeek[3] = $"{MyData.Field_ContainerSlots} Slots Engineering Bag"; break;
                            case 5: HidenSeek[3] = $"{MyData.Field_ContainerSlots} Slots Gem Bag"; break;
                            case 6: HidenSeek[3] = $"{MyData.Field_ContainerSlots} Slots Mining Bag"; break;
                            case 7: HidenSeek[3] = $"{MyData.Field_ContainerSlots} Slots Leatherworking Bag"; break;
                            case 8: HidenSeek[3] = $"{MyData.Field_ContainerSlots} Slots Inscription Bag"; break;
                        }
                    }
                    break;
                }
                case 19: HidenSeek[3] = "Tabard"; break;
                case 20: HidenSeek[3] = "Robe"; break;
                case 21: HidenSeek[3] = "Main Hand"; break;
                case 22: HidenSeek[3] = "Off Hand"; break;
                case 23: HidenSeek[3] = "Holdable"; break;
                case 24:
                {
                    HidenSeek[3] = "Projectile";

                    if (MyData.Field_class == 6) // projectile
                    {
                        switch (MyData.Field_subclass)
                        {
                            case 2: HidenSeek[4] = "Arrow"; break;
                            case 3: HidenSeek[4] = "Bullet"; break;
                        }
                    }
                    break;
                }
                // skip 25
                case 26:
                {
                    HidenSeek[3] = "Ranged";

                    if (MyData.Field_class == 6) // projectile
                    {
                        switch (MyData.Field_subclass)
                        {
                            case 2: HidenSeek[4] = "Bow"; break;
                            case 3: HidenSeek[4] = "Gun"; break;
                            case 19: HidenSeek[4] = "Wand"; break;
                        }
                    }
                    break;
                }
                case 27:
                {
                    if (MyData.Field_class == 11) // quiver
                    {
                        switch (MyData.Field_subclass)
                        {
                            case 2: HidenSeek[3] = $"{MyData.Field_ContainerSlots} Slots Quiver"; break;
                            case 3: HidenSeek[3] = $"{MyData.Field_ContainerSlots} Slots Ammo Pouch"; break;
                        }
                    }
                    break;
                    }
                case 28:
                {
                    HidenSeek[3] = "Relic";

                    if (MyData.Field_class == 4) // armor
                    {
                        switch (MyData.Field_subclass)
                        {
                            case 7: HidenSeek[4] = "Libram"; break;
                            case 8: HidenSeek[4] = "Idol"; break;
                            case 9: HidenSeek[4] = "Totem"; break;
                            case 10: HidenSeek[4] = "Sigil"; break;
                        }
                    }
                    break;
                }
            } // HidenSeek[4] = subclass right text ^

            if (MyData.Field_dmg_min1 > 0 && MyData.Field_dmg_max1 > 0)
            {
                switch (MyData.Field_dmg_type1)
                {
                    case 0: HidenSeek[5] = $"{MyData.Field_dmg_min1} - {MyData.Field_dmg_max1} Damage"; break;
                    case 1: HidenSeek[5] = $"{MyData.Field_dmg_min1} - {MyData.Field_dmg_max1} Holy Damage"; break;
                    case 2: HidenSeek[5] = $"{MyData.Field_dmg_min1} - {MyData.Field_dmg_max1} Fire Damage"; break;
                    case 3: HidenSeek[5] = $"{MyData.Field_dmg_min1} - {MyData.Field_dmg_max1} Nature Damage"; break;
                    case 4: HidenSeek[5] = $"{MyData.Field_dmg_min1} - {MyData.Field_dmg_max1} Frost Damage"; break;
                    case 5: HidenSeek[5] = $"{MyData.Field_dmg_min1} - {MyData.Field_dmg_max1} Shadow Damage"; break;
                    case 6: HidenSeek[5] = $"{MyData.Field_dmg_min1} - {MyData.Field_dmg_max1} Arcane Damage"; break;
                }
                // right side text ((Min Weapon Damage + Max Weapon Damage) / 2) / Weapon Speed
                HidenSeek[6] = $"Speed {Math.Round((((MyData.Field_dmg_min1 + MyData.Field_dmg_max1) / 2) / MyData.Field_delay), 2 )}";
            }

            if (MyData.Field_dmg_min2 > 0 && MyData.Field_dmg_max2 > 0)
            {
                switch (MyData.Field_dmg_type2)
                {
                    case 0: HidenSeek[7] = $"+{MyData.Field_dmg_min2} - {MyData.Field_dmg_max2} Damage"; break;
                    case 1: HidenSeek[7] = $"+{MyData.Field_dmg_min2} - {MyData.Field_dmg_max2} Holy Damage"; break;
                    case 2: HidenSeek[7] = $"+{MyData.Field_dmg_min2} - {MyData.Field_dmg_max2} Fire Damage"; break;
                    case 3: HidenSeek[7] = $"+{MyData.Field_dmg_min2} - {MyData.Field_dmg_max2} Nature Damage"; break;
                    case 4: HidenSeek[7] = $"+{MyData.Field_dmg_min2} - {MyData.Field_dmg_max2} Frost Damage"; break;
                    case 5: HidenSeek[7] = $"+{MyData.Field_dmg_min2} - {MyData.Field_dmg_max2} Shadow Damage"; break;
                    case 6: HidenSeek[7] = $"+{MyData.Field_dmg_min2} - {MyData.Field_dmg_max2} Arcane Damage"; break;
                }
            }
            if (MyData.Field_armor > 0)
                HidenSeek[8] = $"+{MyData.Field_armor}";

            if (MyData.Field_block > 0)
                HidenSeek[9] = $"+{MyData.Field_block}";

            // white stats
            if (MyData.Field_stat_value1 > 0 && MyData.Field_stat_type1 <= 7)
                HidenSeek[10] = $"+{MyData.Field_stat_value1} {StatsArray[MyData.Field_stat_type1]}";

            if (MyData.Field_stat_value2 > 0 && MyData.Field_stat_type2 <= 7)
                HidenSeek[11] = $"+{MyData.Field_stat_value2} {StatsArray[MyData.Field_stat_type2]}";

            if (MyData.Field_stat_value3 > 0 && MyData.Field_stat_type3 <= 7)
                HidenSeek[12] = $"+{MyData.Field_stat_value3} {StatsArray[MyData.Field_stat_type3]}";

            if (MyData.Field_stat_value4 > 0 && MyData.Field_stat_type4 <= 7)
                HidenSeek[13] = $"+{MyData.Field_stat_value4} {StatsArray[MyData.Field_stat_type4]}";

            if (MyData.Field_stat_value5 > 0 && MyData.Field_stat_type5 <= 7)
                HidenSeek[14] = $"+{MyData.Field_stat_value5} {StatsArray[MyData.Field_stat_type5]}";

            if (MyData.Field_stat_value6 > 0 && MyData.Field_stat_type6 <= 7)
                HidenSeek[15] = $"+{MyData.Field_stat_value6} {StatsArray[MyData.Field_stat_type6]}";

            if (MyData.Field_stat_value7 > 0 && MyData.Field_stat_type7 <= 7)
                HidenSeek[16] = $"+{MyData.Field_stat_value7} {StatsArray[MyData.Field_stat_type7]}";

            if (MyData.Field_stat_value8 > 0 && MyData.Field_stat_type8 <= 7)
                HidenSeek[17] = $"+{MyData.Field_stat_value8} {StatsArray[MyData.Field_stat_type8]}";

            if (MyData.Field_stat_value9 > 0 && MyData.Field_stat_type9 <= 7)
                HidenSeek[18] = $"+{MyData.Field_stat_value9} {StatsArray[MyData.Field_stat_type9]}";

            if (MyData.Field_stat_value10 > 0 && MyData.Field_stat_type10 <= 7)
                HidenSeek[19] = $"+{MyData.Field_stat_value10} {StatsArray[MyData.Field_stat_type10]}";
            

            // socket color 1
            if (MyData.Field_socketColor_1 == 1)
                HidenSeek[20] = "Prismatic";
            else if (MyData.Field_socketColor_1 == 2)
                HidenSeek[21] = "Red";
            else if (MyData.Field_socketColor_1 == 4)
                HidenSeek[22] = "Yellow";
            else if (MyData.Field_socketColor_1 == 8)
                HidenSeek[23] = "Blue";

            // socket color 2
            if (MyData.Field_socketColor_2 == 1)
                HidenSeek[24] = "Prismatic";
            else if (MyData.Field_socketColor_2 == 2)
                HidenSeek[24] = "Red";
            else if (MyData.Field_socketColor_2 == 4)
                HidenSeek[24] = "Yellow";
            else if (MyData.Field_socketColor_2 == 8)
                HidenSeek[24] = "Blue";

            // socket color 3
            if (MyData.Field_socketColor_3 == 1)
                HidenSeek[25] = "Prismatic";
            else if (MyData.Field_socketColor_3 == 2)
                HidenSeek[25] = "Red";
            else if (MyData.Field_socketColor_3 == 4)
                HidenSeek[25] = "Yellow";
            else if (MyData.Field_socketColor_3 == 8)
                HidenSeek[25] = "Blue";

            if (MyData.Field_socketBonus == 3312)
                HidenSeek[26] = "+8 Strength";
            else if (MyData.Field_socketBonus == 3313)
                HidenSeek[26] = "+8 Agility";
            else if (MyData.Field_socketBonus == 3305)
                HidenSeek[26] = "+12 Stamina";
            else if (MyData.Field_socketBonus == 3353)
                HidenSeek[26] = "+8 Intellect";
            else if (MyData.Field_socketBonus == 2872)
                HidenSeek[26] = "+9 Healing";
            else if (MyData.Field_socketBonus == 3753)
                HidenSeek[26] = "+9 Spell Power";
            else if (MyData.Field_socketBonus == 3877)
                HidenSeek[26] = "+16 Attack Power";

            if (MyData.Field_MaxDurability > 0)
                HidenSeek[27] = $"Durability {MyData.Field_MaxDurability} / {MyData.Field_MaxDurability}";

            string[] classList = new string[10];
            if ((MyData.Field_AllowableClass & 1) != 0)
                classList[0] = "Warrior";
            if ((MyData.Field_AllowableClass & 2) != 0)
                classList[1] = "Paladin";
            if ((MyData.Field_AllowableClass & 3) != 0)
                classList[2] = "Hunter";
            if ((MyData.Field_AllowableClass & 4) != 0)
                classList[3] = "Rogue";
            if ((MyData.Field_AllowableClass & 5) != 0)
                classList[4] = "Priest";
            if ((MyData.Field_AllowableClass & 6) != 0)
                classList[5] = "Death Knight";
            if ((MyData.Field_AllowableClass & 7) != 0)
                classList[6] = "Shaman";
            if ((MyData.Field_AllowableClass & 8) != 0)
                classList[7] = "Mage";
            if ((MyData.Field_AllowableClass & 9) != 0)
                classList[8] = "Warlock";
            if ((MyData.Field_AllowableClass & 11) != 0)
                classList[9] = "Druid";

            if (classList.Length != 10 && classList.Length > 0)
                HidenSeek[28] = "Classes:";

            foreach (string lclass in classList)
                HidenSeek[28] += $" {lclass}";

            if (MyData.Field_RequiredLevel > 0)
                HidenSeek[29] = $"Required Level {MyData.Field_RequiredLevel}";

            if (MyData.Field_ItemLevel > 0)
                HidenSeek[30] = $"Item Level {MyData.Field_ItemLevel}";

            // green stats
            if (MyData.Field_stat_value1 > 0 && MyData.Field_stat_type1 >= 12)
                HidenSeek[31] = $"Equip: {MyData.Field_stat_value1} {StatsArray[MyData.Field_stat_type1]}";

            if (MyData.Field_stat_value2 > 0 && MyData.Field_stat_type2 <= 12)
                HidenSeek[32] = $"Equip: {MyData.Field_stat_value2} {StatsArray[MyData.Field_stat_type2]}";

            if (MyData.Field_stat_value3 > 0 && MyData.Field_stat_type3 <= 12)
                HidenSeek[33] = $"Equip: {MyData.Field_stat_value3} {StatsArray[MyData.Field_stat_type3]}";

            if (MyData.Field_stat_value4 > 0 && MyData.Field_stat_type4 <= 12)
                HidenSeek[34] = $"Equip: {MyData.Field_stat_value4} {StatsArray[MyData.Field_stat_type4]}";

            if (MyData.Field_stat_value5 > 0 && MyData.Field_stat_type5 <= 12)
                HidenSeek[35] = $"Equip: {MyData.Field_stat_value5} {StatsArray[MyData.Field_stat_type5]}";

            if (MyData.Field_stat_value6 > 0 && MyData.Field_stat_type6 <= 12)
                HidenSeek[36] = $"Equip: {MyData.Field_stat_value6} {StatsArray[MyData.Field_stat_type6]}";

            if (MyData.Field_stat_value7 > 0 && MyData.Field_stat_type7 <= 12)
                HidenSeek[37] = $"Equip: {MyData.Field_stat_value7} {StatsArray[MyData.Field_stat_type7]}";

            if (MyData.Field_stat_value8 > 0 && MyData.Field_stat_type8 <= 12)
                HidenSeek[38] = $"Equip: {MyData.Field_stat_value8} {StatsArray[MyData.Field_stat_type8]}";

            if (MyData.Field_stat_value9 > 0 && MyData.Field_stat_type9 <= 12)
                HidenSeek[39] = $"Equip: {MyData.Field_stat_value9} {StatsArray[MyData.Field_stat_type9]}";

            if (MyData.Field_stat_value10 > 0 && MyData.Field_stat_type10 <= 12)
                HidenSeek[40] = $"Equip: {MyData.Field_stat_value10} {StatsArray[MyData.Field_stat_type10]}";

            if (MyData.Field_spellid_1 != 0)
                HidenSeek[41] = $"{SpellTriggerArray[MyData.Field_spelltrigger_1]} Spell id <{MyData.Field_spellid_1}>";
            if (MyData.Field_spellcooldown_1 > 0)
                HidenSeek[41] += $" ({MyData.Field_spellcooldown_1} Cooldown)";

            if (MyData.Field_spellid_2 != 0)
                HidenSeek[42] = $"{SpellTriggerArray[MyData.Field_spelltrigger_2]} Spell id <{MyData.Field_spellid_2}>";
            if (MyData.Field_spellcooldown_2 > 0)
                HidenSeek[42] += $" ({MyData.Field_spellcooldown_2} Cooldown)";

            if (MyData.Field_spellid_3 != 0)
                HidenSeek[43] = $"{SpellTriggerArray[MyData.Field_spelltrigger_3]} Spell id <{MyData.Field_spellid_3}>";
            if (MyData.Field_spellcooldown_3 > 0)
                HidenSeek[43] += $" ({MyData.Field_spellcooldown_3} Cooldown)";

            if (MyData.Field_spellid_4 != 0)
                HidenSeek[44] = $"{SpellTriggerArray[MyData.Field_spelltrigger_4]} Spell id <{MyData.Field_spellid_4}>";
            if (MyData.Field_spellcooldown_4 > 0)
                HidenSeek[44] += $" ({MyData.Field_spellcooldown_4} Cooldown)";

            if (MyData.Field_spellid_5 != 0)
                HidenSeek[45] = $"{SpellTriggerArray[MyData.Field_spelltrigger_5]} Spell id <{MyData.Field_spellid_5}>";
            if (MyData.Field_spellcooldown_5 > 0)
                HidenSeek[45] += $" ({MyData.Field_spellcooldown_5} Cooldown)";

            HidenSeek[46] = MyData.Field_description;

        }
    }
}
