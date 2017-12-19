using DnDCharacterCreator.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCharacterCreator.Workers
{
    class CharacterModifiers
    {


        public CharacterData CreateDwarfRace(CharacterData characterdata)
        {
            CharacterData _characterData = characterdata;

            Console.WriteLine(_characterData.Level);

            _characterData.Constitution += 2;
            _characterData.Speed += 25;

            Console.WriteLine(Constants.dwarfSubRacePrompt);

            bool validSubRace = false;
            do
            {
                string dwarfSubRace = Console.ReadLine().ToLower();

                if (dwarfSubRace.Equals(Constants.numericOneCheck) || dwarfSubRace.Contains(Constants.hillDwarfRaceCheck))
                {
                    _characterData.Race = Constants.hillDwarfRace;
                    _characterData.Wisdom += 1;
                    validSubRace = true;
                    break;
                }

                if (dwarfSubRace.Equals(Constants.numericTwoCheck) || dwarfSubRace.Contains(Constants.mountDwarfRaceCheck))
                {
                    _characterData.Race = Constants.mountainDwarfRace;
                    _characterData.Strength += 2;
                    validSubRace = true;
                    break;
                }

                else
                {
                    Console.WriteLine(Constants.errorInvalidSubRace);
                }

            } while (!validSubRace);

            Console.WriteLine(_characterData.Level);
            return _characterData;
        }

        public CharacterData CreateElfRace(CharacterData characterdata)
        {
            CharacterData _characterData = characterdata;

            _characterData.Dexterity += 2;
            _characterData.Speed += 30;

            Console.WriteLine(Constants.elfSubRacePrompt);

            bool validSubRace = false;
            do
            {
                string elfSubRace = Console.ReadLine().ToLower();

                if (elfSubRace.Equals(Constants.numericOneCheck) || elfSubRace.Contains(Constants.highElfRaceCheck))
                {
                    _characterData.Race = Constants.highElfRace;
                    _characterData.Intelligence += 1;
                    validSubRace = true;
                    break;
                }

                if (elfSubRace.Equals(Constants.numericTwoCheck) || elfSubRace.Contains(Constants.woodElfRaceCheck))
                {
                    _characterData.Race = Constants.woodElfRace;
                    _characterData.Wisdom += 1;
                    _characterData.Speed = 35;
                    validSubRace = true;
                    break;
                }

                if (elfSubRace.Equals(Constants.numericThreeCheck) || elfSubRace.Contains(Constants.darkElfRaceCheck))
                {
                    _characterData.Race = Constants.darkElfRace;
                    _characterData.Charisma += 1;
                    validSubRace = true;
                    break;
                }

                else
                {
                    Console.WriteLine(Constants.errorInvalidSubRace);
                }

            } while (!validSubRace);

            return _characterData;
        }

        public CharacterData CreateHalflingRace(CharacterData characterdata)
        {
            CharacterData _characterData = characterdata;

            _characterData.Dexterity += 2;
            _characterData.Speed += 25;

            Console.WriteLine(Constants.halflingSubRacePrompt);

            bool validSubRace = false;
            do
            {
                string halflingSubRace = Console.ReadLine().ToLower();

                if (halflingSubRace.Equals(Constants.numericOneCheck) || halflingSubRace.Contains(Constants.lightfootRaceCheck))
                {
                    _characterData.Race = Constants.lightfootRace;
                    _characterData.Charisma += 1;
                    validSubRace = true;
                    break;
                }

                if (halflingSubRace.Equals(Constants.numericTwoCheck) || halflingSubRace.Contains(Constants.stoutRaceCheck))
                {
                    _characterData.Race = Constants.stoutRace;
                    _characterData.Constitution += 1;
                    validSubRace = true;
                    break;
                }
                
                else
                {
                    Console.WriteLine(Constants.errorInvalidSubRace);
                }

            } while (!validSubRace);

            return _characterData;
        }

        public CharacterData CreateHumanRace(CharacterData characterdata)
        {
            CharacterData _characterData = characterdata;

            _characterData.Strength += 1;
            _characterData.Dexterity += 1;
            _characterData.Constitution += 1;
            _characterData.Intelligence += 1;
            _characterData.Wisdom += 1;
            _characterData.Charisma += 1;
            _characterData.Speed += 30;
            _characterData.Race = Constants.humanRace;

            return _characterData;
        }

        public CharacterData CreateDragonbornRace(CharacterData characterdata)
        {
            CharacterData _characterData = characterdata;

            _characterData.Strength += 2;
            _characterData.Charisma += 1;
            _characterData.Speed += 30;
            _characterData.Race = Constants.dragonbornRace;          

            return _characterData;
        }

        public CharacterData CreateGnomeRace(CharacterData characterdata)
        {
            CharacterData _characterData = characterdata;

            _characterData.Dexterity += 2;
            _characterData.Speed += 25;

            Console.WriteLine(Constants.gnomeSubRacePrompt);

            bool validSubRace = false;
            do
            {
                string gnomeSubRace = Console.ReadLine().ToLower();

                if (gnomeSubRace.Equals(Constants.numericOneCheck) || gnomeSubRace.Contains(Constants.forestGnomeRaceCheck))
                {
                    _characterData.Race = Constants.forestGnomeRace;
                    _characterData.Dexterity += 1;
                    validSubRace = true;
                    break;
                }

                if (gnomeSubRace.Equals(Constants.numericTwoCheck) || gnomeSubRace.Contains(Constants.rockGnomeRaceCheck))
                {
                    _characterData.Race = Constants.rockGnomeRace;
                    _characterData.Constitution += 1;
                    validSubRace = true;
                    break;
                }

                else
                {
                    Console.WriteLine(Constants.errorInvalidSubRace);
                }

            } while (!validSubRace);

            return _characterData;
        }

        public CharacterData CreateHalfElfRace(CharacterData characterdata)
        {
            CharacterData _characterData = characterdata;

            _characterData.Charisma += 2;
            _characterData.Race = Constants.halfElfRace;

            string firstAbilityChoice = string.Empty;
            
            for (int i = 1; i < 3; i++)
            {
                Console.WriteLine("Choose an ability to increase by +1." +
                    "\nStrength" +
                    "\nDexterity" +
                    "\nConstitution" +
                    "\nIntelligence" +
                    "\nWisdom");
                bool assignAbilityIncrease = false;

                do
                {
                    string abilityChoice = Console.ReadLine().ToLower();

                    if (abilityChoice.Equals(firstAbilityChoice))
                    {
                        Console.WriteLine("You already increased that ability. Try Again.");
                        continue;
                    }
                    
                    switch (abilityChoice)
                    {
                        case "strength":
                            firstAbilityChoice = abilityChoice;
                            _characterData.Strength += 1;
                            assignAbilityIncrease = true;
                            break;
                        case "dexterity":
                            firstAbilityChoice = abilityChoice;
                            _characterData.Dexterity += 1;
                            assignAbilityIncrease = true;
                            break;
                        case "constitution":
                            firstAbilityChoice = abilityChoice;
                            _characterData.Constitution += 1;
                            assignAbilityIncrease = true;
                            break;
                        case "intelligence":
                            firstAbilityChoice = abilityChoice;
                            _characterData.Intelligence += 1;
                            assignAbilityIncrease = true;
                            break;
                        case "wisdom":
                            firstAbilityChoice = abilityChoice;
                            _characterData.Wisdom += 1;
                            assignAbilityIncrease = true;
                            break;
                        default:
                            Console.WriteLine("Invalid Ability Input. Try again.");
                            break;
                    }

                } while (!assignAbilityIncrease);             

            }

            return _characterData;
        }

        public CharacterData CreateHalfOrcRace(CharacterData characterdata)
        {
            CharacterData _characterData = characterdata;

            _characterData.Strength += 2;
            _characterData.Constitution += 1;
            _characterData.Speed += 30;
            _characterData.Race = Constants.halfOrcRace;

            return _characterData;
        }

        public CharacterData CreateTieflingRace(CharacterData characterdata)
        {
            CharacterData _characterData = characterdata;

            _characterData.Intelligence += 1;
            _characterData.Charisma += 2;
            _characterData.Speed += 30;
            _characterData.Race = Constants.tieflingRace;

            return _characterData;
        }
    }
}
