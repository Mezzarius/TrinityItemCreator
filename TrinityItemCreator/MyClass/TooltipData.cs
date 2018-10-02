using System;
using TrinityItemCreator.MyClass;

namespace TrinityItemCreator.MyClass
{
    class TooltipData
    {
        public TooltipData() { }
        
        public static string[] HidenSeek = new string[139];

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

            // now handle stats.. next time
        }
    }
}
