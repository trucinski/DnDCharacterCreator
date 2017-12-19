using DnDCharacterCreator.Builders;
using DnDCharacterCreator.Data;
using DnDCharacterCreator.Workers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DnDCharacterCreator
{
    class Program
    {
        
        private static readonly Display _display = new Display();
        private static readonly CharacterModifiers _characterModifiers = new CharacterModifiers();
        private static readonly SaveCharacter _saveCharacter = new SaveCharacter();
        private static readonly CharacterDataBuilder _characterDataBuilder = new CharacterDataBuilder();
        

        static void Main(string[] args)
        {
            CharacterData characterData = new CharacterDataBuilder()
                    .Build();
            string fileName = string.Empty;            
            bool contProg = true;

            do
            {
                Console.WriteLine(Constants.startingPrompt);
                string startingChoice = Console.ReadLine();

                if (startingChoice.Equals(Constants.numericOneCheck) || startingChoice.Contains(Constants.newCharCheck))
                {
                    characterData = _characterDataBuilder.Build();

                    Console.WriteLine(Constants.createSavePrompt);
                    fileName = Console.ReadLine() + Constants.createTxtFile;

                    _display.CharacterDisplay(characterData);

                    Console.WriteLine(Constants.startingRacePrompt);

                    bool validStartingRace = false;

                    do
                    {
                        string raceChoice = Console.ReadLine().ToLower();

                        if (raceChoice.Equals(Constants.numericOneCheck) || raceChoice.Equals(Constants.dwarfRaceChoice))
                        {
                            characterData = _characterModifiers.CreateDwarfRace(characterData);
                            characterData.CreationStep += 1;
                            Console.Clear();
                            _display.CharacterDisplay(characterData);
                            validStartingRace = true;
                            break;

                        }

                        if (raceChoice.Equals(Constants.numericTwoCheck) || raceChoice.Equals(Constants.elfRaceChoice))
                        {
                            characterData = _characterModifiers.CreateElfRace(characterData);
                            characterData.CreationStep += 1;
                            Console.Clear();
                            _display.CharacterDisplay(characterData);
                            validStartingRace = true;
                            break;
                        }

                        if (raceChoice.Equals(Constants.numericThreeCheck) || raceChoice.Equals(Constants.halflingRaceChoice))
                        {
                            characterData = _characterModifiers.CreateHalflingRace(characterData);
                            characterData.CreationStep += 1;
                            Console.Clear();
                            _display.CharacterDisplay(characterData);
                            validStartingRace = true;
                            break;
                        }

                        if (raceChoice.Equals(Constants.numericFourCheck) || raceChoice.Equals(Constants.humanRaceChoice))
                        {
                            characterData = _characterModifiers.CreateHumanRace(characterData);
                            characterData.CreationStep += 1;
                            Console.Clear();
                            _display.CharacterDisplay(characterData);
                            validStartingRace = true;
                            break;
                        }

                        if (raceChoice.Equals(Constants.numericFiveCheck) || raceChoice.Equals(Constants.dragonbornRaceChoice))
                        {
                            characterData = _characterModifiers.CreateDragonbornRace(characterData);
                            characterData.CreationStep += 1;
                            Console.Clear();
                            _display.CharacterDisplay(characterData);
                            validStartingRace = true;
                            break;
                        }

                        if (raceChoice.Equals(Constants.numericSixCheck) || raceChoice.Equals(Constants.gnomeRaceChoice))
                        {
                            characterData = _characterModifiers.CreateGnomeRace(characterData);
                            characterData.CreationStep += 1;
                            Console.Clear();
                            _display.CharacterDisplay(characterData);
                            validStartingRace = true;
                            break;
                        }

                        if (raceChoice.Equals(Constants.numericSevenCheck) || raceChoice.Equals(Constants.halfElfRaceChoice))
                        {
                            characterData = _characterModifiers.CreateHalfElfRace(characterData);
                            characterData.CreationStep += 1;
                            Console.Clear();
                            _display.CharacterDisplay(characterData);
                            validStartingRace = true;
                            break;
                        }

                        if (raceChoice.Equals(Constants.numericEightCheck) || raceChoice.Equals(Constants.halfOrcRaceChoice))
                        {
                            characterData = _characterModifiers.CreateHalfOrcRace(characterData);
                            characterData.CreationStep += 1;
                            Console.Clear();
                            _display.CharacterDisplay(characterData);
                            validStartingRace = true;
                            break;
                        }

                        if (raceChoice.Equals(Constants.numericNineCheck) || raceChoice.Equals(Constants.tieflingRaceChoice))
                        {
                            characterData = _characterModifiers.CreateTieflingRace(characterData);
                            characterData.CreationStep += 1;
                            Console.Clear();
                            _display.CharacterDisplay(characterData);
                            validStartingRace = true;
                            break;
                        }

                        else
                        {
                            Console.WriteLine(Constants.errorInvalidRace);
                        }

                    } while (!validStartingRace);

                    _saveCharacter.SaveCharacterData(fileName, characterData);

                    string[] dataToReplace = File.ReadAllLines(fileName);
                    foreach (var data in dataToReplace)
                    {
                        Console.WriteLine(data);
                    }
                }

                if (startingChoice.Equals(Constants.numericTwoCheck) || startingChoice.Contains(Constants.contCharCheck))
                {
                    Console.WriteLine("Currently not implemented.");
                }

                else
                {
                    Console.WriteLine("Invalid Choice.");
                }                

                string contProgChoice = Console.ReadLine().ToLower();

                if (contProgChoice.Equals("3"))
                {
                    contProg = false;
                }

            } while (contProg);
            
            
        }    
    }
}
