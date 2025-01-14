﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyGenerator_V2.Sources.Gems
{
    class GemSQLGenerator
    {
        public static void GenerateGemSQL(int PropretiesID, string GemColor,// GemPropreties
            string GemName, int ItemID, int GemDisplayID, string quality)
        {
            StringBuilder Item_Template = new StringBuilder();
            string SubClass, Match;
            // 58601
            SubClass = "";
            Match = "";
            string INSERT = "insert into `item_template` (`entry`, `class`, `subclass`, `SoundOverrideSubclass`, `name`, `displayid`, `Quality`, `Flags`, `FlagsExtra`, `BuyCount`, `BuyPrice`, `SellPrice`, `InventoryType`, `AllowableClass`, `AllowableRace`, `ItemLevel`, `RequiredLevel`, `RequiredSkill`, `RequiredSkillRank`, `requiredspell`, `requiredhonorrank`, `RequiredCityRank`, `RequiredReputationFaction`, `RequiredReputationRank`, `maxcount`, `stackable`, `ContainerSlots`, `StatsCount`, `stat_type1`, `stat_value1`, `stat_type2`, `stat_value2`, `stat_type3`, `stat_value3`, `stat_type4`, `stat_value4`, `stat_type5`, `stat_value5`, `stat_type6`, `stat_value6`, `stat_type7`, `stat_value7`, `stat_type8`, `stat_value8`, `stat_type9`, `stat_value9`, `stat_type10`, `stat_value10`, `ScalingStatDistribution`, `ScalingStatValue`, `dmg_min1`, `dmg_max1`, `dmg_type1`, `dmg_min2`, `dmg_max2`, `dmg_type2`, `armor`, `holy_res`, `fire_res`, `nature_res`, `frost_res`, `shadow_res`, `arcane_res`, `delay`, `ammo_type`, `RangedModRange`, `spellid_1`, `spelltrigger_1`, `spellcharges_1`, `spellppmRate_1`, `spellcooldown_1`, `spellcategory_1`, `spellcategorycooldown_1`, `spellid_2`, `spelltrigger_2`, `spellcharges_2`, `spellppmRate_2`, `spellcooldown_2`, `spellcategory_2`, `spellcategorycooldown_2`, `spellid_3`, `spelltrigger_3`, `spellcharges_3`, `spellppmRate_3`, `spellcooldown_3`, `spellcategory_3`, `spellcategorycooldown_3`, `spellid_4`, `spelltrigger_4`, `spellcharges_4`, `spellppmRate_4`, `spellcooldown_4`, `spellcategory_4`, `spellcategorycooldown_4`, `spellid_5`, `spelltrigger_5`, `spellcharges_5`, `spellppmRate_5`, `spellcooldown_5`, `spellcategory_5`, `spellcategorycooldown_5`, `bonding`, `description`, `PageText`, `LanguageID`, `PageMaterial`, `startquest`, `lockid`, `Material`, `sheath`, `RandomProperty`, `RandomSuffix`, `block`, `itemset`, `MaxDurability`, `area`, `Map`, `BagFamily`, `TotemCategory`, `socketColor_1`, `socketContent_1`, `socketColor_2`, `socketContent_2`, `socketColor_3`, `socketContent_3`, `socketBonus`, `GemProperties`, `RequiredDisenchantSkill`, `ArmorDamageModifier`, `duration`, `ItemLimitCategory`, `HolidayId`, `ScriptName`, `DisenchantID`, `FoodType`, `minMoneyLoot`, `maxMoneyLoot`, `flagsCustom`, `VerifiedBuild`) values";

            switch (GemColor)
            {
                case "Red":
                    SubClass = "0";
                    Match = "Red";
                    break;
                case "Blue":
                    SubClass = "1";
                    Match = "Blue";
                    break;
                case "Yellow":
                    SubClass = "2";
                    Match = "Yellow";
                    break;
                case "Purple":
                    SubClass = "3";
                    Match = "Blue Or Red";
                    break;
                case "Green":
                    SubClass = "4";
                    Match = "Yollow Or Blue";
                    break;
                case "Orange":
                    SubClass = "5";
                    Match = "Yellow Or Red";
                    break;
                case "Meta":
                    SubClass = "6";
                    Match = "todo";
                    break;
            }

            Item_Template.AppendLine(INSERT +
                "('" + ItemID + "','3','" + SubClass + "','-1','" + GemName + "','" + GemDisplayID + "','" + quality + "','0','0','1','360000','90000','0','-1','-1','80','0','0','0','0','0','0','0','0','0','1','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','-1','0','-1','0','0','0','0','-1','0','-1','0','0','0','0','-1','0','-1','0','0','0','0','-1','0','-1','0','0','0','0','-1','0','-1','0','Matches a " + Match + " Socket.','0','0','0','0','0','4','0','0','0','0','0','0','0','0','512','0','0','0','0','0','0','0','0','" + PropretiesID + "','-1','0','0','0','0','','0','0','0','0','0','27500');");

            if (!Directory.Exists("./Gems/SQL"))
                Directory.CreateDirectory("./Gems/SQL");

            File.WriteAllText(@".\Gems\SQL\" + ItemID + ".sql", Item_Template.ToString());
        }
    }
}
