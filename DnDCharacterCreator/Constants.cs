using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCharacterCreator
{
    class Constants
    {
        public const string startingPrompt = "What do you want to do? " +
                "\n1 - Create New Character" +
                "\n2 - Open Created Character";
        public const string createSavePrompt = "Name character save file (no spaces).";
        public const string stepOneRacePrompt = "\nWhat race is your character?" +
                    "\n1 - Dwarf (+2 CON, 25 Speed)" +
                    "\n2 - Elf (+2 DEX, 30 Speed)" +
                    "\n3 - Halfling (+2 DEX, 25 Speed)" +
                    "\n4 - Human (+1 all, 30 Speed)" +
                    "\n5 - Dragonborn (+2 STR, +1 CHA, 30 Speed)" +
                    "\n6 - Gnome (+2 INT, 25 Speed)" +
                    "\n7 - Half-Elf (+2 CHA, +1 to two abilities of your choice, 30 Speed)" +
                    "\n8 - Half-Orc (+2 STR, +1 CON, 30 Speed)" +
                    "\n9 - Tiefling (+1 INT, +2 CON, 30 Speed)";
        public const string stepTwoClassPrompt = "\nChoose a class for your character:" +
                        "\n1 - Barbarian (d12 Hit Die, Primary: STR, Saving Throw Prof: STR & CON)" +
                        "\n2 - Bard (d8 Hit Die, Primary: CHA, Saving Throw Prof: DEX & CHA)" +
                        "\n3 - Cleric (d8 Hit Die, Primary: WIS, Saving Throw Prof: WIS & CHA)" +
                        "\n4 - Druid (d8 Hit Die, Primary: WIS, Saving Throw Prof: INT & WIS)" +
                        "\n5 - Fighter (d10 Hit Die, Primary: STR or DEX, Saving Throw Prof: STR & CON)" +
                        "\n6 - Monk (d8 Hit Die, Primary: DEX & WIS, Saving Throw Prof: STR & DEX)" +
                        "\n7 - Paladin (d10 Hit Die, Primary: STR & CHA, Saving Throw Prof: WIS & CHA)" +
                        "\n8 - Ranger (d10 Hit Die, Primary: DEX & WIS, Saving Throw Prof: STR & DEX)" +
                        "\n9 - Rogue (d8 Hit Die, Primary: DEX, Saving Throw Prof: DEX & INT)" +
                        "\n10 - Sorcerer (d6 Hit Die, Primary: CHA, Saving Throw Prof: CON & CHA)" +
                        "\n11 - Warlock (d8 Hit Die, Primary: CHA, Saving Throw Prof: WIS & CHA)" +
                        "\n12 - Wizard (d6 Hit Die, Primary: INT, Saving Throw Prof: INT & WIS";
        public const string stepThreeSexPrompt = "Choose your sex:" +
                        "\n1 - Female" +
                        "\n2 - Male";

        public const string errorCurrentlyNotImplemented = "Currently Not Implemented.";
        public const string errorInvalidChoice = "Invalid Choice. Try Again.";
        public const string errorInvalidRace = "Invalid Race. Try Again.";
        public const string errorInvalidSubRace = "Invlaid Sub-Race. Try Again.";
        public const string errorInvalidClass = "Invalid Class. Try Again.";
        public const string errorInvalidSex = "Invalid Sex. Try Again.";

        public const string dwarfRaceChoice = "dwarf";
        public const string dwarfSubRacePrompt = "\nChoose a sub-race:" +
                "\n1 - Hill Dwarf (+1 WIS, +1 HP Max/Level)" +
                "\n2 - Mountain Dwarf (+2 STR)";
        public const string hillDwarfRace = "Hill Dwarf";
        public const string mountainDwarfRace = "Mountain Dwarf";
        public const string hillDwarfRaceCheck = "hill";
        public const string mountDwarfRaceCheck = "mountain";

        public const string elfRaceChoice = "elf";
        public const string elfSubRacePrompt = "\nChoose a sub-race:" +
                "\n1 - High Elf (+1 INT)" +
                "\n2 - Wood Elf (+1 WIS, 35 Speed)" +
                "\n3 - Dark Elf (+1 CHA)";
        public const string highElfRaceCheck = "high";
        public const string highElfRace = "High Elf";
        public const string woodElfRaceCheck = "wood";
        public const string woodElfRace = "Wood Elf";
        public const string darkElfRaceCheck = "dark";
        public const string darkElfRace = "Dark Elf";

        public const string halflingRaceChoice = "halfling";
        public const string halflingSubRacePrompt = "\nChoose a sub-race:" +
                "\n1 - Lightfoot (+1 CHA)" +
                "\n2 - Stout (+1 CON)";
        public const string lightfootRaceCheck = "lightfoot";
        public const string lightfootRace = "LightFoot Halfling";
        public const string stoutRaceCheck = "stout";
        public const string stoutRace = "Stout Halfling";

        public const string humanRaceChoice = "human";
        public const string humanRace = "Human";

        public const string dragonbornRaceChoice = "dragonborn";
        public const string dragonbornRace = "Dragonborn";

        public const string gnomeRaceChoice = "gnome";
        public const string gnomeSubRacePrompt = "\nChoose a sub-race:" +
                "\n1 - Forest (+1 DEX)" +
                "\n2 - Rock (+1 CON)";
        public const string forestGnomeRaceCheck = "forest";
        public const string forestGnomeRace = "Forest Gnome";
        public const string rockGnomeRaceCheck = "rock";
        public const string rockGnomeRace = "Rock Gnome";

        public const string halfElfRaceChoice = "half-elf";
        public const string halfElfRace = "Half-Elf";

        public const string halfOrcRaceChoice = "half-orc";
        public const string halfOrcRace = "Half-Orc";

        public const string tieflingRaceChoice = "tiefling";
        public const string tieflingRace = "Tiefling";

        public const string sizeTiny = "Tiny";
        public const string sizeSmall = "Small";
        public const string sizeMedium = "Medium";
        public const string sizeLarge = "Large";
        public const string sizeHuge = "Huge";
        public const string sizeGargantuan = "Gargantuan";

        public const string barbarianClassChoice = "barbarian";
        public const string barbarianClass = " Barbarian ";

        public const string bardClassChoice = "bard";
        public const string bardClass = " Bard ";

        public const string clericClassChoice = "cleric";
        public const string clericClass = " Cleric ";

        public const string druidClassChoice = "druid";
        public const string druidClass = " Druid ";

        public const string fighterClassChoice = "fighter";
        public const string fighterClass = " Fighter ";

        public const string monkClassChoice = "monk";
        public const string monkClass = " Monk ";

        public const string paladinClassChoice = "paladin";
        public const string paladinClass = " Paladin ";

        public const string rangerClassChoice = "ranger";
        public const string rangerClass = " Ranger ";

        public const string rogueClassChoice = "rogue";
        public const string rogueClass = " Rogue ";

        public const string sorcererClassChoice = "sorcerer";
        public const string sorcererClass = " Sorcerer ";

        public const string warlockClassChoice = "warlock";
        public const string warlockClass = " Warlock ";

        public const string wizardClassChoice = "wizard";
        public const string wizardClass = " Wizard ";

        public const string sexMaleCheck = "male";
        public const string sexMale = "Male";
        public const string sexFemaleCheck = "female";
        public const string sexFemale = "Female";

        public static readonly int[] standardScores = { 15, 14, 13, 12, 10, 8 };
        public const string newCharCheck = "new";
        public const string contCharCheck = "open";
        public const string numericOneCheck = "1";
        public const string numericTwoCheck = "2";
        public const string numericThreeCheck = "3";
        public const string numericFourCheck = "4";
        public const string numericFiveCheck = "5";
        public const string numericSixCheck = "6";
        public const string numericSevenCheck = "7";
        public const string numericEightCheck = "8";
        public const string numericNineCheck = "9";
        public const string numericTenCheck = "10";
        public const string numericElevenCheck = "11";
        public const string numericTwelveCheck = "12";

        public const string createTxtFile = ".txt";

        public const string characterDisplayOne = "Class:{0} Level: {1} Background: {2} Character Name: {3}";        
        public const string characterDisplayTwo = "Race: {0} Alignment: {1} Experience Points: {2}";
        public const string characterDisplayThree = "Speed: {0} Initiative: {1} Armor Class: {2}";
        public const string characterDisplayFour = "Perception: {0} Proficiency Bonus: {1} Inspiration: {2}";
        public const string characterDisplayHP = "Current Hit Points: {0}({1}), d{2} Hit Die Available {3}({4})";
        public const string characterDisplayAbility = "\nSTR: {0}({6}) DEX: {1}({7}) CON: {2}({8}) INT: {3}({9}) WIS: {4}({10}) CHA: {5}({11})";

        public const string characterInfoDisplayOne = "Sex: {0} Height: {1} Weight: {2} Carry Weight: {3}";
        public const string characterInfoDisplayTwo = "Eye Color: {0} Skin Color: {1}, Hair Color: {2}";
    }
}
