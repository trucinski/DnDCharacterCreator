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
        public const string startingRacePrompt = "What race is your character?" +
                    "\n1 - Dwarf (+2 CON, 25 Speed)" +
                    "\n2 - Elf (+2 DEX, 30 Speed)" +
                    "\n3 - Halfling (+2 DEX, 25 Speed)" +
                    "\n4 - Human (+1 all, 30 Speed)" +
                    "\n5 - Dragonborn (+2 STR, +1 CHA, 30 Speed)" +
                    "\n6 - Gnome (+2 INT, 25 Speed)" +
                    "\n7 - Half-Elf (+2 CHA, +1 to two abilities of your choice, 30 Speed)" +
                    "\n8 - Half-Orc (+2 STR, +1 CON, 30 Speed)" +
                    "\n9 - Tiefling (+1 INT, +2 CON, 30 Speed)";

        public const string errorInvalidRace = "Invalid Race. Try Again.";
        public const string errorInvalidSubRace = "Invlaid Sub-Race. Try Again.";

        public const string dwarfRaceChoice = "dwarf";
        public const string dwarfSubRacePrompt = "Choose a sub-race:" +
                "\n1 - Hill Dwarf (+1 WIS, +1 HP Max/Level)" +
                "\n2 - Mountain Dwarf (+2 STR)";
        public const string hillDwarfRace = "Hill Dwarf";
        public const string mountainDwarfRace = "Mountain Dwarf";
        public const string hillDwarfRaceCheck = "hill";
        public const string mountDwarfRaceCheck = "mountain";

        public const string elfRaceChoice = "elf";
        public const string elfSubRacePrompt = "Choose a sub-race:" +
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
        public const string halflingSubRacePrompt = "Choose a sub-race:" +
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
        public const string gnomeSubRacePrompt = "Choose a sub-race:" +
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



        public const string createTxtFile = ".txt";

        public const string characterDisplayOne = "Class: {0} Level: {1} Background: {2} Player Name: {3}";
        public const string characterDisplayTwo = "Race: {0} Alignment: {1} Experience Points: {2}";
        public const string characterDisplayThree = "Speed: {0} Initiative: {1} Armor Class: {2}";
        public const string characterDisplayFour = "Perception: {0} Proficiency Bonus: {1} Inspiration: {2}";
        public const string characterDisplayAbility = "\nSTR: {0}({6}) DEX: {1}({7}) CON: {2}({8}) INT: {3}({9}) WIS: {4}({10}) CHA: {5}({11})";

    }
}
