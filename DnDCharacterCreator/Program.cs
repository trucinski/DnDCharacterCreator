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
        private static readonly CharacterSampleNames _characterSampleNames = new CharacterSampleNames();
        

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

                    Console.Clear();
                    _display.CharacterDisplay(characterData);

                    bool creationComplete = false;

                    do
                    {
                        switch (characterData.CreationStep)
                        {
                            case 0:
                                _characterModifiers.CreationStepRace(characterData);
                                _saveCharacter.SaveCharacterData(fileName, characterData);
                                break;
                            case 1:
                                _characterModifiers.CreationStepClass(characterData);
                                _saveCharacter.SaveCharacterData(fileName, characterData);
                                break;
                            case 2:
                                _characterModifiers.CreationStepAbilityScores(characterData);
                                _saveCharacter.SaveCharacterData(fileName, characterData);
                                break;
                            case 3:
                                _characterModifiers.CreationStepSex(characterData);
                                _saveCharacter.SaveCharacterData(fileName, characterData);
                                break;
                            case 4:
                                _characterModifiers.CreationStepName(characterData);
                                _saveCharacter.SaveCharacterData(fileName, characterData);
                                break;
                            case 5:
                                _characterModifiers.CreationStepHeightandWeight(characterData);
                                _saveCharacter.SaveCharacterData(fileName, characterData);
                                break;
                            default:
                                characterData.CreationComplete = true;
                                _saveCharacter.SaveCharacterData(fileName, characterData);
                                creationComplete = true;
                                break;
                        }

                    } while (!creationComplete);

                    string[] dataToPrint = File.ReadAllLines(fileName);
                    foreach (var data in dataToPrint)
                    {
                        Console.WriteLine(data);
                    }
                }

                if (startingChoice.Equals(Constants.numericTwoCheck) || startingChoice.Contains(Constants.contCharCheck))
                {
                    Console.WriteLine(Constants.errorCurrentlyNotImplemented);
                }

                else
                {
                    Console.WriteLine(Constants.errorInvalidChoice);
                }                

                string contProgChoice = Console.ReadLine().ToLower();

                if (contProgChoice.Equals(Constants.numericThreeCheck))
                {
                    contProg = false;
                }

            } while (contProg);
            
            
        }    
    }
}
