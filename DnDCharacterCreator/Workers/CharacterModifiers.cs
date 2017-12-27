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
        private static readonly Display _display = new Display();
        private static readonly Random _random = new Random();
        
        public CharacterData CreationStepRace(CharacterData characterdata)
        {
            CharacterData characterData = characterdata;

            Console.WriteLine(Constants.stepOneRacePrompt);

            bool validStartingRace = false;

            do
            {
                string raceChoice = Console.ReadLine().ToLower();

                if (raceChoice.Equals(Constants.numericOneCheck) || raceChoice.Equals(Constants.dwarfRaceChoice))
                {
                    characterData = CreateDwarfRace(characterData);
                    validStartingRace = true;
                    break;

                }

                if (raceChoice.Equals(Constants.numericTwoCheck) || raceChoice.Equals(Constants.elfRaceChoice))
                {
                    characterData = CreateElfRace(characterData);
                    break;
                }

                if (raceChoice.Equals(Constants.numericThreeCheck) || raceChoice.Equals(Constants.halflingRaceChoice))
                {
                    characterData = CreateHalflingRace(characterData);
                    validStartingRace = true;
                    break;
                }

                if (raceChoice.Equals(Constants.numericFourCheck) || raceChoice.Equals(Constants.humanRaceChoice))
                {
                    characterData = CreateHumanRace(characterData);
                    validStartingRace = true;
                    break;
                }

                if (raceChoice.Equals(Constants.numericFiveCheck) || raceChoice.Equals(Constants.dragonbornRaceChoice))
                {
                    characterData = CreateDragonbornRace(characterData);
                    validStartingRace = true;
                    break;
                }

                if (raceChoice.Equals(Constants.numericSixCheck) || raceChoice.Equals(Constants.gnomeRaceChoice))
                {
                    characterData = CreateGnomeRace(characterData);
                    validStartingRace = true;
                    break;
                }

                if (raceChoice.Equals(Constants.numericSevenCheck) || raceChoice.Equals(Constants.halfElfRaceChoice))
                {
                    characterData = CreateHalfElfRace(characterData);
                    validStartingRace = true;
                    break;
                }

                if (raceChoice.Equals(Constants.numericEightCheck) || raceChoice.Equals(Constants.halfOrcRaceChoice))
                {
                    characterData = CreateHalfOrcRace(characterData);
                    validStartingRace = true;
                    break;
                }

                if (raceChoice.Equals(Constants.numericNineCheck) || raceChoice.Equals(Constants.tieflingRaceChoice))
                {
                    characterData = CreateTieflingRace(characterData);
                    validStartingRace = true;
                    break;
                }

                else
                {
                    Console.WriteLine(Constants.errorInvalidRace);
                }

            } while (!validStartingRace);

            characterData.CreationStep += 1;
            Console.Clear();
            _display.CharacterDisplay(characterData);

            return characterData;
        }

        public CharacterData CreationStepClass(CharacterData characterdata)
        {
            CharacterData characterData = characterdata;

            Console.WriteLine(Constants.stepTwoClassPrompt);

            bool validStartingClass = false;

            do
            {
                string classChoice = Console.ReadLine().ToLower();

                if (classChoice.Equals(Constants.numericOneCheck) || classChoice.Equals(Constants.barbarianClassChoice))
                {
                    characterData = CreateBarbarianClass(characterData);
                    validStartingClass = true;
                    break;

                }

                if (classChoice.Equals(Constants.numericTwoCheck) || classChoice.Equals(Constants.bardClassChoice))
                {
                    characterData = CreateBardClass(characterData);;
                    validStartingClass = true;
                    break;
                }

                if (classChoice.Equals(Constants.numericThreeCheck) || classChoice.Equals(Constants.clericClassChoice))
                {
                    characterData = CreateClericClass(characterData);
                    validStartingClass = true;
                    break;
                }

                if (classChoice.Equals(Constants.numericFourCheck) || classChoice.Equals(Constants.druidClassChoice))
                {
                    characterData = CreateDruidClass(characterData);
                    validStartingClass = true;
                    break;
                }

                if (classChoice.Equals(Constants.numericFiveCheck) || classChoice.Equals(Constants.fighterClassChoice))
                {
                    characterData = CreateFighterClass(characterData);
                    validStartingClass = true;
                    break;
                }

                if (classChoice.Equals(Constants.numericSixCheck) || classChoice.Equals(Constants.monkClassChoice))
                {
                    characterData = CreateMonkClass(characterData);
                    validStartingClass = true;
                    break;
                }

                if (classChoice.Equals(Constants.numericSevenCheck) || classChoice.Equals(Constants.paladinClassChoice))
                {
                    characterData = CreatePaladinClass(characterData);
                    validStartingClass = true;
                    break;
                }

                if (classChoice.Equals(Constants.numericEightCheck) || classChoice.Equals(Constants.rangerClassChoice))
                {
                    characterData = CreateRangerClass(characterData);
                    validStartingClass = true;
                    break;
                }

                if (classChoice.Equals(Constants.numericNineCheck) || classChoice.Equals(Constants.rogueClassChoice))
                {
                    characterData = CreateRogueClass(characterData);
                    validStartingClass = true;
                    break;
                }

                if (classChoice.Equals(Constants.numericTenCheck) || classChoice.Equals(Constants.sorcererClassChoice))
                {
                    characterData = CreateSorcererClass(characterData);
                    validStartingClass = true;
                    break;
                }

                if (classChoice.Equals(Constants.numericElevenCheck) || classChoice.Equals(Constants.warlockClassChoice))
                {
                    characterData = CreateWarlockClass(characterData);
                    validStartingClass = true;
                    break;
                }

                if (classChoice.Equals(Constants.numericTwelveCheck) || classChoice.Equals(Constants.wizardClassChoice))
                {
                    characterData = CreateWizardClass(characterData);
                    validStartingClass = true;
                    break;
                }

                else
                {
                    Console.WriteLine(Constants.errorInvalidClass);
                }

            } while (!validStartingClass);

            characterData.CreationStep += 1;
            Console.Clear();
            _display.CharacterDisplay(characterData);

            return characterData;
        }

        public CharacterData CreationStepSex(CharacterData characterdata)
        {
            CharacterData characterData = characterdata;

            Console.WriteLine(Constants.stepThreeSexPrompt);

            bool validSex = false;

            do
            {
                string sexChoice = Console.ReadLine().ToLower();

                if (sexChoice.Equals(Constants.numericOneCheck) || sexChoice.Equals(Constants.sexFemaleCheck))
                {
                    characterData.Sex = Constants.sexFemale;                    
                    validSex = true;
                    break;
                }

                if (sexChoice.Equals(Constants.numericTwoCheck) || sexChoice.Equals(Constants.sexMaleCheck))
                {
                    characterData.Sex = Constants.sexMale;                    
                    validSex = true;
                    break;
                }

                else
                {
                    Console.WriteLine(Constants.errorInvalidSex);
                }

            } while (!validSex);

            characterData.CreationStep += 1;
            Console.Clear();
            _display.CharacterDisplay(characterData);

            return characterData;
        }

        public CharacterData CreationStepName(CharacterData characterdata)
        {
            CharacterData characterData = characterdata;

            Console.WriteLine("Choose a first name for your charater from below or input your own.");

            switch (characterData.Sex.ToLower())
            {                
                case "female":
                    switch (characterData.Race)
                    {
                        case "dwarf":                            
                            Console.WriteLine(CharacterSampleNames.dwarfFemaleNames);
                            characterData.Name = Console.ReadLine();                            
                            break;
                        case "elf":
                            Console.WriteLine(CharacterSampleNames.elfFemaleNames);
                            characterData.Name = Console.ReadLine();
                            break;
                        case "halfling":
                            Console.WriteLine(CharacterSampleNames.halflingFemaleNames);
                            characterData.Name = Console.ReadLine();
                            break;
                        case "human":
                            switch (characterData.HumanEthnicity)
                            {
                                case "calishite":
                                    Console.WriteLine(CharacterSampleNames.humanCalishiteFemaleNames);
                                    characterData.Name = Console.ReadLine();
                                    break;
                                case "chondathan":
                                    Console.WriteLine(CharacterSampleNames.humanChondathanFemaleNames);
                                    characterData.Name = Console.ReadLine();
                                    break;
                                case "damaran":
                                    Console.WriteLine(CharacterSampleNames.humanDamaranFemaleNames);
                                    characterData.Name = Console.ReadLine();
                                    break;
                                case "illuskan":
                                    Console.WriteLine(CharacterSampleNames.humanIlluskanFemaleNames);
                                    characterData.Name = Console.ReadLine();
                                    break;
                                case "mulan":
                                    Console.WriteLine(CharacterSampleNames.humanMulanFemaleNames);
                                    characterData.Name = Console.ReadLine();
                                    break;
                                case "rashemi":
                                    Console.WriteLine(CharacterSampleNames.humanRashemiFemaleNames);
                                    characterData.Name = Console.ReadLine();
                                    break;
                                case "shou":
                                    Console.WriteLine(CharacterSampleNames.humanShouFemaleNames);
                                    characterData.Name = Console.ReadLine();
                                    break;
                                case "tethyrian":
                                    Console.WriteLine(CharacterSampleNames.humanTethyrianFemaleNames);
                                    characterData.Name = Console.ReadLine();
                                    break;
                                case "turami":
                                    Console.WriteLine(CharacterSampleNames.humanTuramiFemaleNames);
                                    characterData.Name = Console.ReadLine();
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case "dragonborn":
                            Console.WriteLine(CharacterSampleNames.dragonbornFemaleNames);
                            characterData.Name = Console.ReadLine();
                            break;
                        case "gnome":
                            Console.WriteLine(CharacterSampleNames.gnomeFemaleNames);
                            characterData.Name = Console.ReadLine();
                            break;
                        case "half-elf":
                            Console.WriteLine(CharacterSampleNames.elfFemaleNames);
                            characterData.Name = Console.ReadLine();
                            break;
                        case "half-orc":
                            Console.WriteLine(CharacterSampleNames.halfOrcFemaleNames);
                            characterData.Name = Console.ReadLine();
                            break;
                        case "tiefling":
                            Console.WriteLine(CharacterSampleNames.tieflingFemaleNames);
                            characterData.Name = Console.ReadLine();
                            break;
                        default:
                            break;
                    }
                    break;

                case "male":
                    switch (characterData.Race)
                    {
                        case "dwarf":
                            Console.WriteLine(CharacterSampleNames.dwarfMaleNames);
                            characterData.Name = Console.ReadLine();
                            break;
                        case "elf":
                            Console.WriteLine(CharacterSampleNames.elfMaleNames);
                            characterData.Name = Console.ReadLine();
                            break;
                        case "halfling":
                            Console.WriteLine(CharacterSampleNames.halfingMaleNames);
                            characterData.Name = Console.ReadLine();
                            break;
                        case "human":
                            switch (characterData.HumanEthnicity)
                            {
                                case "calishite":
                                    Console.WriteLine(CharacterSampleNames.humanCalishiteMaleNames);
                                    characterData.Name = Console.ReadLine();
                                    break;
                                case "chondathan":
                                    Console.WriteLine(CharacterSampleNames.humanChondathanMaleNames);
                                    characterData.Name = Console.ReadLine();
                                    break;
                                case "damaran":
                                    Console.WriteLine(CharacterSampleNames.humanDamaranMaleNames);
                                    characterData.Name = Console.ReadLine();
                                    break;
                                case "illuskan":
                                    Console.WriteLine(CharacterSampleNames.humanIlluskanMaleNames);
                                    characterData.Name = Console.ReadLine();
                                    break;
                                case "mulan":
                                    Console.WriteLine(CharacterSampleNames.humanMulanMaleNames);
                                    characterData.Name = Console.ReadLine();
                                    break;
                                case "rashemi":
                                    Console.WriteLine(CharacterSampleNames.humanRashemiMaleNames);
                                    characterData.Name = Console.ReadLine();
                                    break;
                                case "shou":
                                    Console.WriteLine(CharacterSampleNames.humanShouMaleNames);
                                    characterData.Name = Console.ReadLine();
                                    break;
                                case "tethyrian":
                                    Console.WriteLine(CharacterSampleNames.humanTethyrianMaleNames);
                                    characterData.Name = Console.ReadLine();
                                    break;
                                case "turami":
                                    Console.WriteLine(CharacterSampleNames.humanTuramiMaleNames);
                                    characterData.Name = Console.ReadLine();
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case "dragonborn":
                            Console.WriteLine(CharacterSampleNames.dragonbornMaleNames);
                            characterData.Name = Console.ReadLine();
                            break;
                        case "gnome":
                            Console.WriteLine(CharacterSampleNames.gnomeMaleNames);
                            characterData.Name = Console.ReadLine();
                            break;
                        case "half-elf":
                            Console.WriteLine(CharacterSampleNames.elfMaleNames);
                            characterData.Name = Console.ReadLine();
                            break;
                        case "half-orc":
                            Console.WriteLine(CharacterSampleNames.halfOrcMaleNames);
                            characterData.Name = Console.ReadLine();
                            break;
                        case "tiefling":
                            Console.WriteLine(CharacterSampleNames.tieflingMaleNames);
                            characterData.Name = Console.ReadLine();
                            break;
                        default:
                            break;
                    }
                    break;

                default:
                    break;
            }

            if (!(characterData.Race.Equals("half-orc")))
            {
                Console.WriteLine("Choose a surname or clan name from below or input your own.");

                switch (characterData.Race)
                {
                    case "dwarf":
                        Console.WriteLine(CharacterSampleNames.dwarfClanNames);
                        characterData.Name += " " + Console.ReadLine();
                        break;
                    case "elf":
                        Console.WriteLine(CharacterSampleNames.elfFamilyNames);
                        characterData.Name += " " + Console.ReadLine();
                        break;
                    case "halfling":
                        Console.WriteLine(CharacterSampleNames.halflingFamilyNames);
                        characterData.Name += " " + Console.ReadLine();
                        break;
                    case "human":
                        switch (characterData.HumanEthnicity)
                        {
                            case "calishite":
                                Console.WriteLine(CharacterSampleNames.humanCalishiteSurnames);
                                characterData.Name += " " + Console.ReadLine();
                                break;
                            case "chondathan":
                                Console.WriteLine(CharacterSampleNames.humanChondathanSurnames);
                                characterData.Name += " " + Console.ReadLine();
                                break;
                            case "damaran":
                                Console.WriteLine(CharacterSampleNames.humanDamaranSurnames);
                                characterData.Name += " " + Console.ReadLine();
                                break;
                            case "illuskan":
                                Console.WriteLine(CharacterSampleNames.humanIlluskanSurnames);
                                characterData.Name += " " + Console.ReadLine();
                                break;
                            case "mulan":
                                Console.WriteLine(CharacterSampleNames.humanMulanSurnames);
                                characterData.Name += " " + Console.ReadLine();
                                break;
                            case "rashemi":
                                Console.WriteLine(CharacterSampleNames.humanRashemiSurnames);
                                characterData.Name += " " + Console.ReadLine();
                                break;
                            case "shou":
                                Console.WriteLine(CharacterSampleNames.humanShouSurnames);
                                characterData.Name = Console.ReadLine() + " " + characterData.Name;
                                break;
                            case "tethyrian":
                                Console.WriteLine(CharacterSampleNames.humanTethyrianSurnames);
                                characterData.Name += " " + Console.ReadLine();
                                break;
                            case "turami":
                                Console.WriteLine(CharacterSampleNames.humanTuramiSurnames);
                                characterData.Name += " " + Console.ReadLine();
                                break;
                            default:
                                break;
                        }
                        break;
                    case "dragonborn":
                        Console.WriteLine(CharacterSampleNames.dragonbornSurnames);
                        characterData.Name += " " + Console.ReadLine();
                        break;
                    case "gnome":
                        Console.WriteLine(CharacterSampleNames.gnomeSurnames);
                        characterData.Name += " " + Console.ReadLine();

                        Console.WriteLine("Choose a nickname from below or input your own.");
                        Console.WriteLine(CharacterSampleNames.gnomeNicknames);
                        characterData.Name += " " + Console.ReadLine();
                        break;
                    case "half-elf":
                        Console.WriteLine(CharacterSampleNames.elfFamilyNames);
                        characterData.Name += " " + Console.ReadLine();
                        break;
                    case "tiefling":
                        Console.WriteLine(CharacterSampleNames.dwarfFemaleNames);
                        characterData.Name += " " + Console.ReadLine();
                        break;
                    default:
                        break;
                }
            }
            
            characterData.CreationStep += 1;
            Console.Clear();
            _display.CharacterDisplay(characterData);

            return characterData;
        }

        public CharacterData CreationStepAbilityScores(CharacterData characterdata)
        {
            CharacterData _characterData = characterdata;

            Console.WriteLine("How would you like to determine your ability scores?" +
                "\n1 - Use standard set of scores" +
                "\n2 - Roll for scores" +
                "\n3 - Customize scores at cost");

            int[] scoresToAssign = new int[6];

            bool validDetermineMethod = false;

            do
            {
                string determineChoice = Console.ReadLine().ToLower();

                if (determineChoice.Equals(Constants.numericOneCheck) || determineChoice.Contains("standard"))
                {
                    Array.Copy(Constants.standardScores, scoresToAssign, 6);
                    validDetermineMethod = true;
                    break;
                }

                if (determineChoice.Equals(Constants.numericTwoCheck) || determineChoice.Contains("roll"))
                {
                    int[] scoresToCheck = new int[4];

                    for (int i = 0; i < 6; i++)
                    {
                        for (int j = 0; j < 4; j++)
                        {
                            scoresToCheck[j] = _random.Next(1, 7);
                        }

                        Array.Sort(scoresToCheck);
                        Array.Reverse(scoresToCheck);

                        scoresToAssign[i] = scoresToCheck[0] + scoresToCheck[1] + scoresToCheck[2];

                    }

                    validDetermineMethod = true;
                    break;
                }

                if (determineChoice.Equals(Constants.numericThreeCheck) || determineChoice.Contains("custom"))
                {
                    int pointsToSpend = 27;

                    for (int i = 0; i < 6; i++)
                    {  
                        Console.Clear();
                        Console.WriteLine("Points to spend: {0}", pointsToSpend);
                        Console.WriteLine("Ability Score Costs: " +
                            "\n15: 9 points - 11: 3 points" +
                            "\n14: 7 points - 10: 2 points" +
                            "\n13: 5 points -  9: 1 point" +
                            "\n12: 4 points -  8: 0 points");

                        if (i.Equals(0))
                        {
                            Console.WriteLine("Choose your first ability score to use.");
                        }

                        if (i.Equals(5))
                        {
                            Console.WriteLine("Choose your last ability score to use.");
                        }

                        if (i > 0 && i < 5) 
                        {
                            Console.WriteLine("Choose your next abilty score to use.");
                        }

                        bool validScoreChoice = false;

                        do
                        {
                            bool validIntScore = false;
                            validIntScore = Int32.TryParse(Console.ReadLine(), out int scoreChoice);

                            if (!validIntScore)
                            {
                                Console.WriteLine("Input wasn't a number. Try Again.");
                                continue;
                            }

                            if (validIntScore)
                            {
                                int pointsToCheck = 0;
                                switch (scoreChoice)
                                {
                                    case 15:
                                        pointsToCheck = 9;
                                        if ((pointsToSpend - pointsToCheck) < 0)
                                        {
                                            Console.WriteLine("Not enough points to spend. Try Again.");
                                            break;
                                        }
                                        scoresToAssign[i] = scoreChoice;
                                        validScoreChoice = true;
                                        break;
                                    case 14:
                                        pointsToCheck = 7;
                                        if ((pointsToSpend - pointsToCheck) < 0)
                                        {
                                            Console.WriteLine("Not enough points to spend. Try Again.");
                                            break;
                                        }
                                        scoresToAssign[i] = scoreChoice;
                                        validScoreChoice = true;
                                        break;
                                    case 13:
                                        pointsToCheck = 5;
                                        if ((pointsToSpend - pointsToCheck) < 0)
                                        {
                                            Console.WriteLine("Not enough points to spend. Try Again.");
                                            break;
                                        }
                                        scoresToAssign[i] = scoreChoice;
                                        validScoreChoice = true;
                                        break;
                                    case 12:
                                        pointsToCheck = 4;
                                        if ((pointsToSpend - pointsToCheck) < 0)
                                        {
                                            Console.WriteLine("Not enough points to spend. Try Again.");
                                            break;
                                        }
                                        scoresToAssign[i] = scoreChoice;
                                        validScoreChoice = true;
                                        break;
                                    case 11:
                                        pointsToCheck = 3;
                                        if ((pointsToSpend - pointsToCheck) < 0)
                                        {
                                            Console.WriteLine("Not enough points to spend. Try Again.");
                                            break;
                                        }
                                        scoresToAssign[i] = scoreChoice;
                                        validScoreChoice = true;
                                        break;
                                    case 10:
                                        pointsToCheck = 2;
                                        if ((pointsToSpend - pointsToCheck) < 0)
                                        {
                                            Console.WriteLine("Not enough points to spend. Try Again.");
                                            break;
                                        }
                                        scoresToAssign[i] = scoreChoice;
                                        validScoreChoice = true;
                                        break;
                                    case 9:
                                        pointsToCheck = 1;
                                        if ((pointsToSpend - pointsToCheck) < 0)
                                        {
                                            Console.WriteLine("Not enough points to spend. Try Again.");
                                            break;
                                        }
                                        scoresToAssign[i] = scoreChoice;
                                        validScoreChoice = true;
                                        break;
                                    case 8:
                                        pointsToCheck = 0;
                                        scoresToAssign[i] = scoreChoice;
                                        validScoreChoice = true;
                                        break;
                                    default:
                                        Console.WriteLine("Invalid Score Input. Try Again.");
                                        break;
                                }

                                pointsToSpend -= pointsToCheck;                                
                                
                            }

                        } while (!validScoreChoice);
                        
                    }

                    validDetermineMethod = true;
                    break;
                }

            } while (!validDetermineMethod);

            string abilityRecommendations = string.Empty;
            
            switch (_characterData.CharClass.ToLower())
            {
                case " barbarian ":
                    abilityRecommendations = "Recommended Scores: Highest in Strength, Second in Constitution.";
                    _characterData = AssignAbilityScores(scoresToAssign, _characterData, abilityRecommendations);
                    break;
                case " bard ":
                    abilityRecommendations = "Recommended Scores: Highest in Charisma, Second in Dexterity.";
                    _characterData = AssignAbilityScores(scoresToAssign, _characterData, abilityRecommendations);
                    break;
                case " cleric ":
                    abilityRecommendations = "Recommended Scores: Highest in Wisdom, Second in Strength or Constitution.";
                    _characterData = AssignAbilityScores(scoresToAssign, _characterData, abilityRecommendations);
                    break;
                case " druid ":
                    abilityRecommendations = "Recommended Scores: Highest in Wisdom, Second in Constitution.";
                    _characterData = AssignAbilityScores(scoresToAssign, _characterData, abilityRecommendations);
                    break;
                case " fighter ":
                    abilityRecommendations = "Recommended Scores: Highest in Strength or Dexterity (Depending on weapon focus)" +
                        "\nSecond in Constitution (Or Intelligence if playing Eldritch Knight archetype).";
                    _characterData = AssignAbilityScores(scoresToAssign, _characterData, abilityRecommendations);
                    break;
                case " monk ":
                    abilityRecommendations = "Recommended Scores: Highest in Dexterity, Second in Wisdom.";
                    _characterData = AssignAbilityScores(scoresToAssign, _characterData, abilityRecommendations);
                    break;
                case " paladin ":
                    abilityRecommendations = "Recommended Scores: Highest in Strength, Second in Charisma.";
                    _characterData = AssignAbilityScores(scoresToAssign, _characterData, abilityRecommendations);
                    break;
                case " ranger ":
                    abilityRecommendations = "Recommended Scores: Highest in Dexterity (Or Strength if focus is two-weapon fighting)" +
                        "\nSecond in Wisdom.";
                    _characterData = AssignAbilityScores(scoresToAssign, _characterData, abilityRecommendations);
                    break;
                case " rogue ":
                    abilityRecommendations = "Recommended Scores: Highest in Dexterity" +
                        "\nSecond in Intelligence (Investigation checks or Arcane Trickster archetype) or Charisma (Deception and social interaction)";
                    _characterData = _characterData = AssignAbilityScores(scoresToAssign, _characterData, abilityRecommendations);
                    break;
                case " sorcerer ":
                    abilityRecommendations = "Recommended Scores: Highest in Charisma, Second in Constitution.";
                    _characterData = AssignAbilityScores(scoresToAssign, _characterData, abilityRecommendations);
                    break;
                case " warlock ":
                    abilityRecommendations = "Recommended Scores: Highest in Charisma, Second in Constitution.";
                    _characterData = AssignAbilityScores(scoresToAssign, _characterData, abilityRecommendations);
                    break;
                case " wizard ":
                    abilityRecommendations = "Recommended Scores: Highest in Intelligence" +
                        "\nSecond in Constitution or Dexterity (Charisma for School of Enchantment).";
                    _characterData = AssignAbilityScores(scoresToAssign, _characterData, abilityRecommendations);
                    break;
                default:
                    break;
            }

            _characterData.CurrentHitPoints += _characterData.ConstitutionMod;
            _characterData.MaxHitPoints += _characterData.ConstitutionMod;
            _characterData.CreationStep += 1;
            Console.Clear();
            _display.CharacterDisplay(_characterData);

            return _characterData;
        }

        public CharacterData CreationStepHeightandWeight(CharacterData characterdata)
        {
            Console.WriteLine("Would you like to choose your height and weight or a random height and weight?" +
                "\n1 - Choose Height and Weight" +
                "\n2 - Random Height and Weight");

            bool validChoice = false;

            do
            {
                string heightAndWeightChoice = Console.ReadLine().ToLower();

                if (heightAndWeightChoice.Equals("1") || heightAndWeightChoice.Contains("choose"))
                {

                    string heightRange = string.Empty;
                    string weightRange = string.Empty;

                    switch (characterdata.Race.ToLower())
                    {
                        case "dwarf":
                            switch (characterdata.SubRace.ToLower())
                            {
                                case "hill dwarf":
                                    heightRange = "Average height in range 44-52 inches";
                                    weightRange = "Average weight in range 115-211 lbs.";
                                    break;
                                case "mountain dwarf":
                                    heightRange = "Average height in range 48-56 inches";
                                    weightRange = "Average weight in range 130-226 lbs.";
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case "elf":
                            switch (characterdata.SubRace.ToLower())
                            {
                                case "high elf":
                                    heightRange = "Average height in range 54-74 inches";
                                    weightRange = "Average weight in range 90-170 lbs.";
                                    break;
                                case "wood elf":
                                    heightRange = "Average height in range 54-74 inches";
                                    weightRange = "Average weight in range 100-180 lbs.";
                                    break;
                                case "dark elf":
                                    heightRange = "Average height in range 53-65 inches";
                                    weightRange = "Average weight in range 75-147 lbs.";
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case "halfling":
                            heightRange = "Average height in range 31-39 inches";
                            weightRange = "Average weight in range 35-43 lbs.";
                            break;
                        case "human":
                            heightRange = "Average height in range 56-76 inches";
                            weightRange = "Average weight in range 110-211 lbs.";
                            break;
                        case "dragonborn":
                            heightRange = "Average height in range 66-82 inches";
                            weightRange = "Average weight in range 175-367 lbs.";
                            break;
                        case "gnome":
                            heightRange = "Average height in range 35-43 inches";
                            weightRange = "Average weight in range 35-43 lbs.";
                            break;
                        case "half-elf":
                            heightRange = "Average height in range 57-73 inches";
                            weightRange = "Average weight in range 110-238 lbs.";
                            break;
                        case "half-orc":
                            heightRange = "Average height in range 58-78 inches";
                            weightRange = "Average weight in range 140-380 lbs.";
                            break;
                        case "tiefling":
                            heightRange = "Average height in range 57-73 inches";
                            weightRange = "Average weight in range 110-238 lbs.";
                            break;                            
                        default:
                            break;
                    }
                    characterdata = ChooseHeightandWeight(characterdata, heightRange, weightRange);
                    validChoice = true;
                    break;
                }

                if (heightAndWeightChoice.Equals("2") || heightAndWeightChoice.Contains("random"))
                {
                    int heightbase = 0;
                    int heightDie = 0;
                    int weightBase = 0;
                    int weightDie = 0;
                    int weightRolls = 2;

                    switch (characterdata.Race.ToLower())
                    {
                        case "dwarf":
                            switch (characterdata.SubRace.ToLower())
                            {
                                case "hill dwarf":
                                    heightbase = 44;
                                    heightDie = 4;
                                    weightBase = 115;
                                    weightDie = 6;
                                    break;
                                case "mountain dwarf":
                                    heightbase = 48;
                                    heightDie = 4;
                                    weightBase = 130;
                                    weightDie = 6;
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case "elf":
                            switch (characterdata.SubRace.ToLower())
                            {
                                case "high elf":
                                    heightbase = 54;
                                    heightDie = 10;
                                    weightBase = 90;
                                    weightDie = 4;
                                    weightRolls = 1;
                                    break;
                                case "wood elf":
                                    heightbase = 54;
                                    heightDie = 10;
                                    weightBase = 100;
                                    weightDie = 4;
                                    weightRolls = 1;
                                    break;
                                case "dark elf":
                                    heightbase = 53;
                                    heightDie = 6;
                                    weightBase = 75;
                                    weightDie = 6;
                                    weightRolls = 1;
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case "halfling":
                            heightbase = 31;
                            heightDie = 4;
                            weightBase = 35;
                            weightDie = 1;
                            weightRolls = 1;
                            break;
                        case "human":
                            heightbase = 56;
                            heightDie = 10;
                            weightBase = 110;
                            weightDie = 4;
                            break;
                        case "dragonborn":
                            heightbase = 66;
                            heightDie = 8;
                            weightBase = 175;
                            weightDie = 6;
                            break;
                        case "gnome":
                            heightbase = 35;
                            heightDie = 4;
                            weightBase = 35;
                            weightDie = 1;
                            weightRolls = 1;
                            break;
                        case "half-elf":
                            heightbase = 57;
                            heightDie = 8;
                            weightBase = 110;
                            weightDie = 4;
                            break;
                        case "half-orc":
                            heightbase = 58;
                            heightDie = 10;
                            weightBase = 140;
                            weightDie = 6;
                            break;
                        case "tiefling":
                            heightbase = 57;
                            heightDie = 8;
                            weightBase = 110;
                            weightDie = 4;
                            break;
                        default:
                            break;
                    }

                    characterdata = RandomHeightandWeight(characterdata, heightbase, heightDie, weightBase, weightDie, weightRolls);
                    validChoice = true;
                    break;
                }

                else
                {
                    Console.WriteLine("Invalid Choice. Try again.");
                }

            } while (!validChoice);

            characterdata.CreationStep += 1;
            Console.Clear();
            _display.CharacterDisplay(characterdata);
            return characterdata;
        }        

        public CharacterData CreateDwarfRace(CharacterData characterdata)
        {
            CharacterData _characterData = characterdata;

            _characterData.Race = Constants.dwarfRaceChoice;
            Console.WriteLine(_characterData.Level);

            _characterData.Constitution += 2;
            _characterData.Speed += 25;
            _characterData.Size = Constants.sizeMedium;

            Console.WriteLine(Constants.dwarfSubRacePrompt);

            bool validSubRace = false;
            do
            {
                string dwarfSubRace = Console.ReadLine().ToLower();

                if (dwarfSubRace.Equals(Constants.numericOneCheck) || dwarfSubRace.Contains(Constants.hillDwarfRaceCheck))
                {
                    _characterData.SubRace = Constants.hillDwarfRace;
                    _characterData.Wisdom += 1;
                    validSubRace = true;
                    break;
                }

                if (dwarfSubRace.Equals(Constants.numericTwoCheck) || dwarfSubRace.Contains(Constants.mountDwarfRaceCheck))
                {
                    _characterData.SubRace = Constants.mountainDwarfRace;
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

            _characterData.Race = Constants.elfRaceChoice;

            _characterData.Dexterity += 2;
            _characterData.Speed += 30;
            _characterData.Size = Constants.sizeMedium;

            Console.WriteLine(Constants.elfSubRacePrompt);

            bool validSubRace = false;
            do
            {
                string elfSubRace = Console.ReadLine().ToLower();

                if (elfSubRace.Equals(Constants.numericOneCheck) || elfSubRace.Contains(Constants.highElfRaceCheck))
                {
                    _characterData.SubRace = Constants.highElfRace;
                    _characterData.Intelligence += 1;
                    validSubRace = true;
                    break;
                }

                if (elfSubRace.Equals(Constants.numericTwoCheck) || elfSubRace.Contains(Constants.woodElfRaceCheck))
                {
                    _characterData.SubRace = Constants.woodElfRace;
                    _characterData.Wisdom += 1;
                    _characterData.Speed = 35;
                    validSubRace = true;
                    break;
                }

                if (elfSubRace.Equals(Constants.numericThreeCheck) || elfSubRace.Contains(Constants.darkElfRaceCheck))
                {
                    _characterData.SubRace = Constants.darkElfRace;
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

            _characterData.Race = Constants.halflingRaceChoice;

            _characterData.Dexterity += 2;
            _characterData.Speed += 25;
            _characterData.Size = Constants.sizeSmall;

            Console.WriteLine(Constants.halflingSubRacePrompt);

            bool validSubRace = false;
            do
            {
                string halflingSubRace = Console.ReadLine().ToLower();

                if (halflingSubRace.Equals(Constants.numericOneCheck) || halflingSubRace.Contains(Constants.lightfootRaceCheck))
                {
                    _characterData.SubRace = Constants.lightfootRace;
                    _characterData.Charisma += 1;
                    validSubRace = true;
                    break;
                }

                if (halflingSubRace.Equals(Constants.numericTwoCheck) || halflingSubRace.Contains(Constants.stoutRaceCheck))
                {
                    _characterData.SubRace = Constants.stoutRace;
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
            _characterData.Race = Constants.humanRaceChoice;
            _characterData.Size = Constants.sizeMedium;

            Console.WriteLine("Choose an ethnicity: " +
                                "\n1 - Calishite (Southwest Faerun, Hair: Brown, Skin: Brown, Eyes: Brown)" +
                                "\n2 - Chondathan (Central Faerun, Hair: Varies, Skin: Tawny, Eyes: Brown or Green)" +
                                "\n3 - Damaran (Northwest Faerun, Hair: Brown-Black, Skin: Tawny-Fair, Eyes: Varies/Brown)" +
                                "\n4 - Illuskan (North-Northwest Faerun, Hair: Varies/Raven Black, Skin: Fair, Eyes: Blue-Gray" +
                                "\n5 - Mulan (East-Southest Faerun, Hair: Dark Brown-Black/Shaved, Skin: Amber, Eyes: Hazel-Brown" +
                                "\n6 - Rashemi (East Faerun, Hair: Black, Skin: Dusky, Eyes: Dark" +
                                "\n7 - Shou (Far East Faerun, Hair: Black, Skin: Yellowish Bronze, Eyes: Dark" +
                                "\n8 - Tethyrian (West Faerun, Hair: Varies/Brown, Skin: Dusky-Fair, Eyes: Varies/Blue" +
                                "\n9 - Turami (South Faerun, Hair: Black, Skin: Dark Mahogany, Eyes: Dark");

            bool validEthnicity = false;

            do
            {
                string ethnicityChoice = Console.ReadLine().ToLower();

                if (ethnicityChoice.Equals(Constants.numericOneCheck) || ethnicityChoice.Equals(CharacterSampleNames.humanCalishiteEthnicity.ToLower()))
                {
                    _characterData.HumanEthnicity = CharacterSampleNames.humanCalishiteEthnicity.ToLower();
                    _characterData.SubRace = CharacterSampleNames.humanCalishiteEthnicity + " " + Constants.humanRace;
                    validEthnicity = true;
                    break;
                }

                if (ethnicityChoice.Equals(Constants.numericTwoCheck) || ethnicityChoice.Equals(CharacterSampleNames.humanChondathanEthnicity.ToLower()))
                {
                    _characterData.HumanEthnicity = CharacterSampleNames.humanChondathanEthnicity.ToLower();
                    _characterData.SubRace = CharacterSampleNames.humanChondathanEthnicity + " " + Constants.humanRace;
                    validEthnicity = true;
                    break;
                }

                if (ethnicityChoice.Equals(Constants.numericThreeCheck) || ethnicityChoice.Equals(CharacterSampleNames.humanDamaranEthnicity.ToLower()))
                {
                    _characterData.HumanEthnicity = CharacterSampleNames.humanDamaranEthnicity.ToLower();
                    _characterData.SubRace = CharacterSampleNames.humanDamaranEthnicity + " " + Constants.humanRace;
                    validEthnicity = true;
                    break;
                }

                if (ethnicityChoice.Equals(Constants.numericFourCheck) || ethnicityChoice.Equals(CharacterSampleNames.humanIlluskanEthnicity.ToLower()))
                {
                    _characterData.HumanEthnicity = CharacterSampleNames.humanIlluskanEthnicity.ToLower();
                    _characterData.SubRace = CharacterSampleNames.humanIlluskanEthnicity + " " + Constants.humanRace;
                    validEthnicity = true;
                    break;
                }

                if (ethnicityChoice.Equals(Constants.numericFiveCheck) || ethnicityChoice.Equals(CharacterSampleNames.humanMulanEthnicity.ToLower()))
                {
                    _characterData.HumanEthnicity = CharacterSampleNames.humanMulanEthnicity.ToLower();
                    _characterData.SubRace = CharacterSampleNames.humanMulanEthnicity + " " + Constants.humanRace;
                    validEthnicity = true;
                    break;
                }

                if (ethnicityChoice.Equals(Constants.numericSixCheck) || ethnicityChoice.Equals(CharacterSampleNames.humanRashemiEthnicity.ToLower()))
                {
                    _characterData.HumanEthnicity = CharacterSampleNames.humanRashemiEthnicity.ToLower();
                    _characterData.SubRace = CharacterSampleNames.humanRashemiEthnicity + " " + Constants.humanRace;
                    validEthnicity = true;
                    break;
                }

                if (ethnicityChoice.Equals(Constants.numericSevenCheck) || ethnicityChoice.Equals(CharacterSampleNames.humanShouEthnicity.ToLower()))
                {
                    _characterData.HumanEthnicity = CharacterSampleNames.humanShouEthnicity.ToLower();
                    _characterData.SubRace = CharacterSampleNames.humanShouEthnicity + " " + Constants.humanRace;
                    validEthnicity = true;
                    break;
                }

                if (ethnicityChoice.Equals(Constants.numericEightCheck) || ethnicityChoice.Equals(CharacterSampleNames.humanTethyrianEthnicity.ToLower()))
                {
                    _characterData.HumanEthnicity = CharacterSampleNames.humanTethyrianEthnicity.ToLower();
                    _characterData.SubRace = CharacterSampleNames.humanTethyrianEthnicity + " " + Constants.humanRace;
                    validEthnicity = true;
                    break;
                }

                if (ethnicityChoice.Equals(Constants.numericNineCheck) || ethnicityChoice.Equals(CharacterSampleNames.humanTuramiEthnicity.ToLower()))
                {
                    _characterData.HumanEthnicity = CharacterSampleNames.humanTuramiEthnicity.ToLower();
                    _characterData.SubRace = CharacterSampleNames.humanTuramiEthnicity + " " + Constants.humanRace;
                    validEthnicity = true;
                    break;
                }

                else
                {
                    Console.WriteLine("Invalid Ethnicity. Try Again.");
                }

            } while (!validEthnicity);

            return _characterData;
        }

        public CharacterData CreateDragonbornRace(CharacterData characterdata)
        {
            CharacterData _characterData = characterdata;

            _characterData.Strength += 2;
            _characterData.Charisma += 1;
            _characterData.Speed += 30;
            _characterData.Race = Constants.dragonbornRaceChoice;
            _characterData.SubRace = Constants.dragonbornRace;
            _characterData.Size = Constants.sizeMedium;

            return _characterData;
        }

        public CharacterData CreateGnomeRace(CharacterData characterdata)
        {
            CharacterData _characterData = characterdata;

            _characterData.Race = Constants.gnomeRaceChoice;

            _characterData.Dexterity += 2;
            _characterData.Speed += 25;
            _characterData.Size = Constants.sizeSmall;

            Console.WriteLine(Constants.gnomeSubRacePrompt);

            bool validSubRace = false;
            do
            {
                string gnomeSubRace = Console.ReadLine().ToLower();

                if (gnomeSubRace.Equals(Constants.numericOneCheck) || gnomeSubRace.Contains(Constants.forestGnomeRaceCheck))
                {
                    _characterData.SubRace = Constants.forestGnomeRace;
                    _characterData.Dexterity += 1;
                    validSubRace = true;
                    break;
                }

                if (gnomeSubRace.Equals(Constants.numericTwoCheck) || gnomeSubRace.Contains(Constants.rockGnomeRaceCheck))
                {
                    _characterData.SubRace = Constants.rockGnomeRace;
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
            _characterData.Race = Constants.halfElfRaceChoice;
            _characterData.SubRace = Constants.halfElfRace;
            _characterData.Size = Constants.sizeMedium;
            
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
            _characterData.Race = Constants.halfOrcRaceChoice;
            _characterData.SubRace = Constants.halfOrcRace;
            _characterData.Size = Constants.sizeMedium;

            return _characterData;
        }

        public CharacterData CreateTieflingRace(CharacterData characterdata)
        {
            CharacterData _characterData = characterdata;

            _characterData.Intelligence += 1;
            _characterData.Charisma += 2;
            _characterData.Speed += 30;
            _characterData.Race = Constants.tieflingRaceChoice;
            _characterData.SubRace = Constants.tieflingRace;
            _characterData.Size = Constants.sizeMedium;

            return _characterData;
        }

        public CharacterData CreateBarbarianClass(CharacterData characterdata)
        {
            CharacterData _characterdata = characterdata;

            _characterdata.HitDieValue = 12;
            _characterdata.CurrentHitDieTotal = 1;
            _characterdata.MaxHitDieTotal = 1;
            _characterdata.MaxHitPoints = 12;
            _characterdata.CurrentHitPoints = 12;
            _characterdata.CharClass = Constants.barbarianClass;

            Console.WriteLine("Choose the primal path of your rage:" +
                "\n1 - Path of the Berserker" +
                "\n2 - Path of the Totem Warrior");

            bool validPathChoice = false;

            do
            {
                string pathChoice = Console.ReadLine().ToLower();

                if (pathChoice.Equals(Constants.numericOneCheck) || pathChoice.Contains("berserker")) 
                {
                    _characterdata.ClassArchetype = "Berserker";
                    validPathChoice = true;
                    break;
                }

                if(pathChoice.Equals(Constants.numericTwoCheck) || pathChoice.Contains("totem"))
                {
                    Console.WriteLine("Choose your Totem Animal:" +
                        "\n1 - Bear" +
                        "\n2 - Eagle" +
                        "\n3 - Wolf");

                    bool validTotemAnimal = false;

                    do
                    {
                        string totemAnimalChoice = Console.ReadLine().ToLower();

                        if (totemAnimalChoice.Equals(Constants.numericOneCheck) || totemAnimalChoice.Equals("bear"))
                        {
                            _characterdata.ClassArchetype = "Bear Totem Warrior";
                            validTotemAnimal = true;
                            break;
                        }

                        if (totemAnimalChoice.Equals(Constants.numericTwoCheck) || totemAnimalChoice.Equals("eagle"))
                        {
                            _characterdata.ClassArchetype = "Eagle Totem Warrior";
                            validTotemAnimal = true;
                            break;
                        }

                        if (totemAnimalChoice.Equals(Constants.numericThreeCheck) || totemAnimalChoice.Equals("wolf"))
                        {
                            _characterdata.ClassArchetype = "Wolf Totem Warrior";
                            validTotemAnimal = true;
                            break;
                        }

                        else
                        {
                            Console.WriteLine("Invalid Totem Animal. Try Again.");                   
                        }

                    } while (!validTotemAnimal);

                    validPathChoice = true;
                    break;
                }

                else
                {
                    Console.WriteLine("Invalid Path. Try Again.");
                }

            } while (!validPathChoice);            

            return _characterdata;
        }

        public CharacterData CreateBardClass(CharacterData characterdata)
        {
            CharacterData _characterdata = characterdata;

            _characterdata.HitDieValue = 8;
            _characterdata.CurrentHitDieTotal = 1;
            _characterdata.MaxHitDieTotal = 1;
            _characterdata.MaxHitPoints = 8;
            _characterdata.CurrentHitPoints = 8;
            _characterdata.CharClass = Constants.bardClass;

            Console.WriteLine("Choose a Bard's College to join at Bard level 3:" +
                "\n1 - College of Lore" +
                "\n2 - College of Valor");

            bool validCollegeChoice = false;

            do
            {
                string collegeChoice = Console.ReadLine().ToLower();

                if (collegeChoice.Equals(Constants.numericOneCheck) || collegeChoice.Contains("lore"))
                {
                    _characterdata.ClassArchetype = "College of Lore";
                    validCollegeChoice = true;
                    break;
                }

                if (collegeChoice.Equals(Constants.numericTwoCheck) || collegeChoice.Contains("valor"))
                {
                    _characterdata.ClassArchetype = "College of Valor";
                    validCollegeChoice = true;
                    break;
                }

                else
                {
                    Console.WriteLine("Invalid college choice. Try again.");
                }

            } while (!validCollegeChoice);

            return _characterdata;
        }

        public CharacterData CreateClericClass(CharacterData characterdata)
        {
            CharacterData _characterdata = characterdata;

            _characterdata.HitDieValue = 8;
            _characterdata.CurrentHitDieTotal = 1;
            _characterdata.MaxHitDieTotal = 1;
            _characterdata.MaxHitPoints = 8;
            _characterdata.CurrentHitPoints = 8;
            _characterdata.CharClass = Constants.clericClass;

            Console.WriteLine("Choose your domian of worship:" +
                "\n1 - Knowledge Domain" +
                "\n2 - Life Domain" +
                "\n3 - Light Domain" +
                "\n4 - Nature Domain" +
                "\n5 - Tempest Domain" +
                "\n6 - Trickery Domain" +
                "\n7 - War Domain");

            bool validDomainChoice = false;

            do
            {
                string domainChoice = Console.ReadLine().ToLower();

                if (domainChoice.Equals(Constants.numericOneCheck) || domainChoice.Contains("knowledge"))
                {
                    _characterdata.ClassArchetype = "Knowledge Cleric";
                    validDomainChoice = true;
                    break;
                }

                if (domainChoice.Equals(Constants.numericTwoCheck) || domainChoice.Contains("life"))
                {
                    _characterdata.ClassArchetype = "Life Cleric";
                    validDomainChoice = true;
                    break;
                }

                if (domainChoice.Equals(Constants.numericThreeCheck) || domainChoice.Contains("light"))
                {
                    _characterdata.ClassArchetype = "Light Cleric";
                    validDomainChoice = true;
                    break;
                }

                if (domainChoice.Equals(Constants.numericFourCheck) || domainChoice.Contains("nature"))
                {
                    _characterdata.ClassArchetype = "Nature Cleric";
                    validDomainChoice = true;
                    break;
                }

                if (domainChoice.Equals(Constants.numericFiveCheck) || domainChoice.Contains("tempest"))
                {
                    _characterdata.ClassArchetype = "Tempest Cleric";
                    validDomainChoice = true;
                    break;
                }

                if (domainChoice.Equals(Constants.numericSixCheck) || domainChoice.Contains("trickery"))
                {
                    _characterdata.ClassArchetype = "Trickery Cleric";
                    validDomainChoice = true;
                    break;
                }

                if (domainChoice.Equals(Constants.numericSevenCheck) || domainChoice.Contains("war"))
                {
                    _characterdata.ClassArchetype = "War Cleric";
                    validDomainChoice = true;
                    break;
                }

                else
                {
                    Console.WriteLine("Invalid Domain. Try again");
                }

            } while (!validDomainChoice);

            return _characterdata;
        }

        public CharacterData CreateDruidClass(CharacterData characterdata)
        {
            CharacterData _characterdata = characterdata;

            _characterdata.HitDieValue = 8;
            _characterdata.CurrentHitDieTotal = 1;
            _characterdata.MaxHitDieTotal = 1;
            _characterdata.MaxHitPoints = 8;
            _characterdata.CurrentHitPoints = 8;
            _characterdata.CharClass = Constants.druidClass;

            Console.WriteLine("Choose which druid circle to idenitfy with at Druid level 2:" +
                "\n1 - Circle of the Land" +
                "\n2 - Circle of the Moon");

            bool validCircleChoice = false;

            do
            {
                string circleChoice = Console.ReadLine().ToLower();

                if (circleChoice.Equals(Constants.numericOneCheck) || circleChoice.Contains("land"))
                {
                    Console.WriteLine("Choose the land where you became a druid:" +
                        "\n1 - Arctic" +
                        "\n2 - Coast" +
                        "\n3 - Desert" +
                        "\n4 - Forest" +
                        "\n5 - Grassland" +
                        "\n6 - Mountain" +
                        "\n7 - Swamp" +
                        "\n8 - Underdark");

                    bool validLandChoice = false;

                    do
                    {
                        string landChoice = Console.ReadLine().ToLower();

                        if (landChoice.Equals("1") || landChoice.Equals("arctic"))
                        {
                            _characterdata.ClassArchetype = "Arctic Circle Druid";
                            validLandChoice = true;
                            break;
                        }

                        if (landChoice.Equals("2") || landChoice.Equals("coast"))
                        {
                            _characterdata.ClassArchetype = "Coast Circle Druid";
                            validLandChoice = true;
                            break;
                        }

                        if (landChoice.Equals("3") || landChoice.Equals("desert"))
                        {
                            _characterdata.ClassArchetype = "Desert Circle Druid";
                            validLandChoice = true;
                            break;
                        }

                        if (landChoice.Equals("4") || landChoice.Equals("forest"))
                        {
                            _characterdata.ClassArchetype = "Forest Circle Druid";
                            validLandChoice = true;
                            break;
                        }

                        if (landChoice.Equals("5") || landChoice.Equals("grassland"))
                        {
                            _characterdata.ClassArchetype = "Grassland Circle Druid";
                            validLandChoice = true;
                            break;
                        }

                        if (landChoice.Equals("6") || landChoice.Equals("mountain"))
                        {
                            _characterdata.ClassArchetype = "Mountain Circle Druid";
                            validLandChoice = true;
                            break;
                        }

                        if (landChoice.Equals("7") || landChoice.Equals("swamp"))
                        {
                            _characterdata.ClassArchetype = "Swamp Circle Druid";
                            validLandChoice = true;
                            break;
                        }

                        if (landChoice.Equals("8") || landChoice.Equals("underdark"))
                        {
                            _characterdata.ClassArchetype = "Underdark Circle Druid";
                            validLandChoice = true;
                            break;
                        }

                        else
                        {
                            Console.WriteLine("Invalid land choice. Try again.");
                        }

                    } while (!validLandChoice);

                    validCircleChoice = true;
                    break;
                }

                if (circleChoice.Equals("2") || circleChoice.Contains("moon"))
                {
                    _characterdata.ClassArchetype = "Moon Circle Druid";
                    validCircleChoice = true;
                    break;
                }

                else
                {
                    Console.WriteLine("Invalid circle choice, Try again.");
                }

            } while (!validCircleChoice);
            
            return _characterdata;
        }

        public CharacterData CreateFighterClass(CharacterData characterdata)
        {
            CharacterData _characterdata = characterdata;

            _characterdata.HitDieValue = 10;
            _characterdata.CurrentHitDieTotal = 1;
            _characterdata.MaxHitDieTotal = 1;
            _characterdata.MaxHitPoints = 10;
            _characterdata.CurrentHitPoints = 10;
            _characterdata.CharClass = Constants.fighterClass;

            Console.WriteLine("Choose a fighting style specialty: " +
                "\n1 - Archery" +
                "\n2 - Defense" +
                "\n3 - Dueling" +
                "\n4 - Great Weapon Fighting" +
                "\n5 - Protection" +
                "\n6 - Two-Weapon Fighting");

            bool validFightingStyle = false;

            do
            {
                string fightingStyleChoice = Console.ReadLine().ToLower();

                if (fightingStyleChoice.Equals("1") || fightingStyleChoice.Contains("archery"))
                {
                    _characterdata.ClassArchetype = "Archery ";
                    validFightingStyle = true;
                    break;
                }

                if (fightingStyleChoice.Equals("2") || fightingStyleChoice.Contains("defense"))
                {
                    _characterdata.ClassArchetype = "Defense ";
                    validFightingStyle = true;
                    break;
                }

                if (fightingStyleChoice.Equals("3") || fightingStyleChoice.Contains("dueling"))
                {
                    _characterdata.ClassArchetype = "Dueling ";
                    validFightingStyle = true;
                    break;
                }

                if (fightingStyleChoice.Equals("4") || fightingStyleChoice.Contains("great"))
                {
                    _characterdata.ClassArchetype = "Great Weapon Fighting ";
                    validFightingStyle = true;
                    break;
                }

                if (fightingStyleChoice.Equals("5") || fightingStyleChoice.Contains("protection"))
                {
                    _characterdata.ClassArchetype = "Protection ";
                    validFightingStyle = true;
                    break;
                }

                if (fightingStyleChoice.Equals("6") || fightingStyleChoice.Contains("two-weapon"))
                {
                    _characterdata.ClassArchetype = "Two-Weapon Fighting ";
                    validFightingStyle = true;
                    break;
                }

                else
                {
                    Console.WriteLine("Invalid fighting style. Try again.");
                }

            } while (!validFightingStyle);

            Console.WriteLine("Choose a martial archetype to follow at Fighter level 3:" +
                "\n1 - Champion" +
                "\n2 - Battle Master" +
                "\n3 - Eldritch Knight");

            bool validMartialType = false;

            do
            {
                string martialType = Console.ReadLine().ToLower();

                if (martialType.Equals("1") || martialType.Contains("champion"))
                {
                    _characterdata.ClassArchetype += "Champion";
                    validMartialType = true;
                    break;
                }

                if (martialType.Equals("2") || martialType.Contains("master"))
                {
                    _characterdata.ClassArchetype += "Battle Master";
                    validMartialType = true;
                    break;
                }

                if (martialType.Equals("3") || martialType.Contains("eldritch"))
                {
                    _characterdata.ClassArchetype += "Eldritch Knight";
                    validMartialType = true;
                    break;
                }

                else
                {
                    Console.WriteLine("Invalid martial type. Try again.");
                }

            } while (!validMartialType);

            return _characterdata;
        }

        public CharacterData CreateMonkClass(CharacterData characterdata)
        {
            CharacterData _characterdata = characterdata;

            _characterdata.HitDieValue = 8;
            _characterdata.CurrentHitDieTotal = 1;
            _characterdata.MaxHitDieTotal = 1;
            _characterdata.MaxHitPoints = 8;
            _characterdata.CurrentHitPoints = 8;
            _characterdata.CharClass = Constants.monkClass;

            Console.WriteLine("Choose a Monastic Tradition to follow at Monk level 3:" +
                "\n1 - Way of the Open Hand" +
                "\n2 - Way of Shadow" +
                "\n3 - Way of the Four Elements");

            bool validTraditionChoice = false;

            do
            {
                string traditionChoice = Console.ReadLine().ToLower();

                if (traditionChoice.Equals("1") || traditionChoice.Contains("hand"))
                {
                    _characterdata.ClassArchetype = "Open Hand";
                    validTraditionChoice = true;
                    break;
                }

                if (traditionChoice.Equals("2") || traditionChoice.Contains("shadow"))
                {
                    _characterdata.ClassArchetype = "Shadow";
                    validTraditionChoice = true;
                    break;
                }

                if (traditionChoice.Equals("3") || traditionChoice.Contains("elements"))
                {
                    _characterdata.ClassArchetype = "Four Elements";
                    validTraditionChoice = true;
                    break;
                }

                else
                {
                    Console.WriteLine("Invalid tradition choice. Try again.");
                }

            } while (!validTraditionChoice);

            return _characterdata;
        }

        public CharacterData CreatePaladinClass(CharacterData characterdata)
        {
            CharacterData _characterdata = characterdata;

            _characterdata.HitDieValue = 10;
            _characterdata.CurrentHitDieTotal = 1;
            _characterdata.MaxHitDieTotal = 1;
            _characterdata.MaxHitPoints = 10;
            _characterdata.CurrentHitPoints = 10;
            _characterdata.CharClass = Constants.paladinClass;

            Console.WriteLine("Choose a fighting style to specialize in at Paladin level 2: " +
                "\n1 - Defense" +
                "\n2 - Dueling" +
                "\n3 - Great Weapon Fighting" +
                "\n4 - Protection");

            bool validFightingStyle = false;

            do
            {
                string fightingStyleChoice = Console.ReadLine().ToLower();

                if (fightingStyleChoice.Equals("1") || fightingStyleChoice.Contains("defense"))
                {
                    _characterdata.ClassArchetype = "Defense ";
                    validFightingStyle = true;
                    break;
                }

                if (fightingStyleChoice.Equals("2") || fightingStyleChoice.Contains("dueling"))
                {
                    _characterdata.ClassArchetype = "Dueling ";
                    validFightingStyle = true;
                    break;
                }

                if (fightingStyleChoice.Equals("3") || fightingStyleChoice.Contains("great"))
                {
                    _characterdata.ClassArchetype = "Great Weapon Fighting ";
                    validFightingStyle = true;
                    break;
                }

                if (fightingStyleChoice.Equals("4") || fightingStyleChoice.Contains("protection"))
                {
                    _characterdata.ClassArchetype = "Protection ";
                    validFightingStyle = true;
                    break;
                }

                else
                {
                    Console.WriteLine("Invalid fighting style. Try again.");
                }

            } while (!validFightingStyle);

            Console.WriteLine("Choose a Sacred Oath to take at Paladin level 3:" +
                "\n1 - Oath of Devotion" +
                "\n2 - Oath of the Ancients" +
                "\n3 - Oath of Vengeance");

            bool validOathChoice = false;

            do
            {
                string oathChoice = Console.ReadLine().ToLower();

                if (oathChoice.Equals("1") || oathChoice.Contains("devotion")) 
                {
                    _characterdata.ClassArchetype += "Devotion Paladin";
                    validOathChoice = true;
                    break;
                }

                if (oathChoice.Equals("2") || oathChoice.Contains("ancients"))
                {
                    _characterdata.ClassArchetype += "Ancients Paladin";
                    validOathChoice = true;
                    break;
                }

                if (oathChoice.Equals("3") || oathChoice.Contains("vengeance"))
                {
                    _characterdata.ClassArchetype += "Vengeance Paladin";
                    validOathChoice = true;
                    break;
                }

                else
                {
                    Console.WriteLine("Invalid oath choice. Try again.");
                }

            } while (!validOathChoice);

            return _characterdata;
        }

        public CharacterData CreateRangerClass(CharacterData characterdata)
        {
            CharacterData _characterdata = characterdata;

            _characterdata.HitDieValue = 10;
            _characterdata.CurrentHitDieTotal = 1;
            _characterdata.MaxHitDieTotal = 1;
            _characterdata.MaxHitPoints = 10;
            _characterdata.CurrentHitPoints = 10;
            _characterdata.CharClass = Constants.rangerClass;

            Console.WriteLine("Choose a fighting style specialty: " +
                "\n1 - Archery" +
                "\n2 - Defense" +
                "\n3 - Dueling" +
                "\n4 - Great Weapon Fighting" +
                "\n5 - Protection" +
                "\n6 - Two-Weapon Fighting");

            bool validFightingStyle = false;

            do
            {
                string fightingStyleChoice = Console.ReadLine().ToLower();

                if (fightingStyleChoice.Equals("1") || fightingStyleChoice.Contains("archery"))
                {
                    _characterdata.ClassArchetype = "Archery ";
                    validFightingStyle = true;
                    break;
                }

                if (fightingStyleChoice.Equals("2") || fightingStyleChoice.Contains("defense"))
                {
                    _characterdata.ClassArchetype = "Defense ";
                    validFightingStyle = true;
                    break;
                }

                if (fightingStyleChoice.Equals("3") || fightingStyleChoice.Contains("dueling"))
                {
                    _characterdata.ClassArchetype = "Dueling ";
                    validFightingStyle = true;
                    break;
                }

                if (fightingStyleChoice.Equals("4") || fightingStyleChoice.Contains("two-weapon"))
                {
                    _characterdata.ClassArchetype = "Two-Weapon Fighting ";
                    validFightingStyle = true;
                    break;
                }

                else
                {
                    Console.WriteLine("Invalid fighting style. Try again.");
                }

            } while (!validFightingStyle);

            Console.WriteLine("Choose a Ranger Archetype:" +
                "\n1 - Hunter" +
                "\n2 - Beast Master");

            bool validRangerArchetype = false;

            do
            {
                string rangerArchetype = Console.ReadLine().ToLower();

                if (rangerArchetype.Equals("1") || rangerArchetype.Equals("hunter"))
                {
                    _characterdata.ClassArchetype += "Hunter";
                    validRangerArchetype = true;
                    break;
                }

                if (rangerArchetype.Equals("2") || rangerArchetype.Contains("beast"))
                {
                    _characterdata.ClassArchetype += "Beast Master";
                    validRangerArchetype = true;
                    break;
                }

                else
                {
                    Console.WriteLine("Invalid Ranger archetype. Try again.");
                }

            } while (!validRangerArchetype);

            return _characterdata;
        }

        public CharacterData CreateRogueClass(CharacterData characterdata)
        {
            CharacterData _characterdata = characterdata;

            _characterdata.HitDieValue = 8;
            _characterdata.CurrentHitDieTotal = 1;
            _characterdata.MaxHitDieTotal = 1;
            _characterdata.MaxHitPoints = 8;
            _characterdata.CurrentHitPoints = 8;
            _characterdata.CharClass = Constants.rogueClass;

            Console.WriteLine("Choose a Rogue Archetype:" +
                "\n1 - Thief" +
                "\n2 - Assassin" +
                "\n3 - Arcane Trickster");

            bool validRogueArchetype = false;

            do
            {
                string rogueArchetype = Console.ReadLine().ToLower();

                if (rogueArchetype.Equals("1") || rogueArchetype.Equals("thief"))
                {
                    _characterdata.ClassArchetype = "Thief";
                    validRogueArchetype = true;
                    break;
                }

                if (rogueArchetype.Equals("2") || rogueArchetype.Equals("assassin"))
                {
                    _characterdata.ClassArchetype = "Assassin";
                    validRogueArchetype = true;
                    break;
                }

                if (rogueArchetype.Equals("3") || rogueArchetype.Contains("arcane"))
                {
                    _characterdata.ClassArchetype = "Arcane Trickster";
                    validRogueArchetype = true;
                    break;
                }

                else
                {
                    Console.WriteLine("Invalid Rogue archetype. Try again.");
                }

            } while (!validRogueArchetype);

            return _characterdata;

            


        }

        public CharacterData CreateSorcererClass(CharacterData characterdata)
        {
            CharacterData _characterdata = characterdata;

            _characterdata.HitDieValue = 6;
            _characterdata.CurrentHitDieTotal = 1;
            _characterdata.MaxHitDieTotal = 1;
            _characterdata.MaxHitPoints = 6;
            _characterdata.CurrentHitPoints = 6;
            _characterdata.CharClass = Constants.sorcererClass;

            Console.WriteLine("Choose your sorcerous origin:" +
                "\n1 - Draconic Bloodline" +
                "\n2 - Wild Magic");

            bool validOrigin = false;

            do
            {
                string originChoice = Console.ReadLine().ToLower();

                if(originChoice.Equals("1") || originChoice.Contains("draconic"))
                {
                    _characterdata.ClassArchetype = "Draconic Sorceror";
                    validOrigin = true;
                    break;
                }

                if (originChoice.Equals("2") || originChoice.Contains("wild"))
                {
                    _characterdata.ClassArchetype = "Wild Sorceror";
                    validOrigin = true;
                    break;
                }

                else
                {
                    Console.WriteLine("Invalid Origin. Try again.");
                }

            } while (!validOrigin);

            return _characterdata;
        }

        public CharacterData CreateWarlockClass(CharacterData characterdata)
        {
            CharacterData _characterdata = characterdata;

            _characterdata.HitDieValue = 8;
            _characterdata.CurrentHitDieTotal = 1;
            _characterdata.MaxHitDieTotal = 1;
            _characterdata.MaxHitPoints = 8;
            _characterdata.CurrentHitPoints = 8;
            _characterdata.CharClass = Constants.warlockClass;

            Console.WriteLine("Choose your warlock patron:" +
                "\n1 - The Archfey" +
                "\n2 - The Fiend" +
                "\n3 - The Great Old One");

            bool validPatron = false;

            do
            {
                string patronChoice = Console.ReadLine().ToLower();

                if (patronChoice.Equals("1")|| patronChoice.Contains("archfey"))
                {
                    _characterdata.ClassArchetype = "Archfey ";
                    validPatron = true;
                    break;
                }

                if (patronChoice.Equals("2") || patronChoice.Contains("fiend"))
                {
                    _characterdata.ClassArchetype = "Fiend ";
                    validPatron = true;
                    break;
                }

                if (patronChoice.Equals("3") || patronChoice.Contains("great"))
                {
                    _characterdata.ClassArchetype = "Great Old One ";
                    validPatron = true;
                    break;
                }

                else
                {
                    Console.WriteLine("Invlaid Patron. Try again.");
                }
            } while (!validPatron);

            Console.WriteLine("Choose a pact to make with your patron at Warlock level 3:" +
                "\n1 - Pact of the Chain" +
                "\n2 - Pact of the Blade" +
                "\n3 - Pact of the Tome");

            bool validPact = false;

            do
            {
                string pactChoice = Console.ReadLine().ToLower();

                if (pactChoice.Equals("1") || pactChoice.Contains("chain"))
                {
                    _characterdata.ClassArchetype += "- Chain Pact";
                    validPact = true;
                    break;
                }

                if (pactChoice.Equals("2") || pactChoice.Contains("blade"))
                {
                    _characterdata.ClassArchetype += "- Blade Pact";
                    validPact = true;
                    break;
                }

                if (pactChoice.Equals("3") || pactChoice.Contains("tome"))
                {
                    _characterdata.ClassArchetype += "- Tome Pact";
                    validPact = true;
                    break;
                }

                else
                {
                    Console.WriteLine("Invalid Pact. Try again.");
                }

            } while (!validPact);

            return _characterdata;
        }

        public CharacterData CreateWizardClass(CharacterData characterdata)
        {
            CharacterData _characterdata = characterdata;

            _characterdata.HitDieValue = 6;
            _characterdata.CurrentHitDieTotal = 1;
            _characterdata.MaxHitDieTotal = 1;
            _characterdata.MaxHitPoints = 6;
            _characterdata.CurrentHitPoints = 6;
            _characterdata.CharClass = Constants.wizardClass;

            Console.WriteLine("Choose an Arcane Tradition to follow at Wizard level 2:" +
                "\n1 - School of Abjuration" +
                "\n2 - School of Conjuration" +
                "\n3 - School of Divination" +
                "\n4 - School of Enchantment" +
                "\n5 - School of Evocation" +
                "\n6 - School of Illusion" +
                "\n7 - School of Necromancy" +
                "\n8 - School of Transmutation");

            bool validSchool = false;

            do
            {
                string schoolChoice = Console.ReadLine().ToLower();

                if (schoolChoice.Equals("1") || schoolChoice.Contains("abjuration"))
                {
                    _characterdata.ClassArchetype = "Abjuration Wizard";
                    validSchool = true;
                    break;
                }

                if (schoolChoice.Equals("2") || schoolChoice.Contains("conjuration"))
                {
                    _characterdata.ClassArchetype = "Conjuration Wizard";
                    validSchool = true;
                    break;
                }

                if (schoolChoice.Equals("3") || schoolChoice.Contains("divination"))
                {
                    _characterdata.ClassArchetype = "Divination Wizard";
                    validSchool = true;
                    break;
                }

                if (schoolChoice.Equals("4") || schoolChoice.Contains("enchantment"))
                {
                    _characterdata.ClassArchetype = "Enchantment Wizard";
                    validSchool = true;
                    break;
                }

                if (schoolChoice.Equals("5") || schoolChoice.Contains("evocation"))
                {
                    _characterdata.ClassArchetype = "Evocation Wizard";
                    validSchool = true;
                    break;
                }

                if (schoolChoice.Equals("6") || schoolChoice.Contains("illusion"))
                {
                    _characterdata.ClassArchetype = "Illusion Wizard";
                    validSchool = true;
                    break;
                }

                if (schoolChoice.Equals("7") || schoolChoice.Contains("necromancy"))
                {
                    _characterdata.ClassArchetype = "Necromancy Wizard";
                    validSchool = true;
                    break;
                }

                if (schoolChoice.Equals("8") || schoolChoice.Contains("transmutation"))
                {
                    _characterdata.ClassArchetype = "Transmutation Wizard";
                    validSchool = true;
                    break;
                }

                else
                {
                    Console.WriteLine("Invalid School. Try again.");
                }

            } while (!validSchool);

            return _characterdata;
        }

        public int DetermineAbilityModifier(int abilityScore)
        {
            int abilityModifier = (abilityScore - 10);

            if (abilityModifier < 0)
            {
                if ((abilityModifier % 2) != 0)
                {
                    abilityModifier = (abilityModifier - 1) / 2;
                }

                else
                {
                    abilityModifier /= 2;
                }
            }

            if (abilityModifier >= 0)
            {
                abilityModifier /= 2;
            }

            return abilityModifier;
        }        

        public CharacterData AssignAbilityScores(int[] scoresToAssign, CharacterData _characterData, string abilityRecommendations)
        {
            for (int i = 0; i < 6; i++)
            {
                Console.Clear();
                _display.CharacterDisplay(_characterData);
                Console.WriteLine(abilityRecommendations);
                _display.SetAbilityScoreDisplay(scoresToAssign);
                bool validScoreToAssign = false;

                do
                {
                    bool intInput = false;
                    int scoreToCheck = 0;
                    switch (i)
                    {
                        case 0:
                            Console.WriteLine("Choose a score to assign to Strength.");
                            intInput = false;
                            intInput = Int32.TryParse(Console.ReadLine(), out scoreToCheck);

                            if (!intInput)
                            {
                                Console.WriteLine("Input wasn't a number. Try again.");
                            }

                            if (intInput)
                            {
                                int indexToRemove = Array.IndexOf(scoresToAssign, scoreToCheck);

                                if (indexToRemove < 0)
                                {
                                    Console.WriteLine("Invalid score. Try again.");
                                    break;
                                }

                                _characterData.Strength += scoreToCheck;

                                scoresToAssign = scoresToAssign.Where((source, index) => index != indexToRemove).ToArray();
                                _characterData.StrengthMod = DetermineAbilityModifier(_characterData.Strength);
                                validScoreToAssign = true;
                            }
                            break;
                        case 1:
                            Console.WriteLine("Choose a score to assign to Dexterity.");
                            intInput = false;
                            intInput = Int32.TryParse(Console.ReadLine(), out scoreToCheck);

                            if (!intInput)
                            {
                                Console.WriteLine("Input wasn't a number. Try again.");
                            }

                            if (intInput)
                            {
                                int indexToRemove = Array.IndexOf(scoresToAssign, scoreToCheck);

                                if (indexToRemove < 0)
                                {
                                    Console.WriteLine("Invalid score. Try again.");
                                    break;
                                }

                                _characterData.Dexterity += scoreToCheck;

                                scoresToAssign = scoresToAssign.Where((source, index) => index != indexToRemove).ToArray();
                                _characterData.DexterityMod = DetermineAbilityModifier(_characterData.Dexterity);
                                validScoreToAssign = true;
                            }
                            break;
                        case 2:
                            Console.WriteLine("Choose a score to assign to Constitution.");
                            intInput = false;
                            intInput = Int32.TryParse(Console.ReadLine(), out scoreToCheck);

                            if (!intInput)
                            {
                                Console.WriteLine("Input wasn't a number. Try again.");
                            }

                            if (intInput)
                            {
                                int indexToRemove = Array.IndexOf(scoresToAssign, scoreToCheck);

                                if (indexToRemove < 0)
                                {
                                    Console.WriteLine("Invalid score. Try again.");
                                    break;
                                }

                                _characterData.Constitution += scoreToCheck;

                                scoresToAssign = scoresToAssign.Where((source, index) => index != indexToRemove).ToArray();
                                _characterData.ConstitutionMod = DetermineAbilityModifier(_characterData.Constitution);
                                validScoreToAssign = true;
                            }
                            break;
                        case 3:
                            Console.WriteLine("Choose a score to assign to Intelligence.");
                            intInput = false;
                            intInput = Int32.TryParse(Console.ReadLine(), out scoreToCheck);

                            if (!intInput)
                            {
                                Console.WriteLine("Input wasn't a number. Try again.");
                            }

                            if (intInput)
                            {
                                int indexToRemove = Array.IndexOf(scoresToAssign, scoreToCheck);

                                if (indexToRemove < 0)
                                {
                                    Console.WriteLine("Invalid score. Try again.");
                                    break;
                                }

                                _characterData.Intelligence += scoreToCheck;

                                scoresToAssign = scoresToAssign.Where((source, index) => index != indexToRemove).ToArray();
                                _characterData.IntelligenceMod = DetermineAbilityModifier(_characterData.Intelligence);
                                validScoreToAssign = true;
                            }
                            break;
                        case 4:
                            Console.WriteLine("Choose a score to assign to Wisdom.");
                            intInput = false;
                            intInput = Int32.TryParse(Console.ReadLine(), out scoreToCheck);

                            if (!intInput)
                            {
                                Console.WriteLine("Input wasn't a number. Try again.");
                            }

                            if (intInput)
                            {
                                int indexToRemove = Array.IndexOf(scoresToAssign, scoreToCheck);

                                if (indexToRemove < 0)
                                {
                                    Console.WriteLine("Invalid score. Try again.");
                                    break;
                                }

                                _characterData.Wisdom += scoreToCheck;

                                scoresToAssign = scoresToAssign.Where((source, index) => index != indexToRemove).ToArray();
                                _characterData.WisdomMod = DetermineAbilityModifier(_characterData.Wisdom);
                                validScoreToAssign = true;
                            }
                            break;
                        case 5:
                            Console.WriteLine("Choose a score to assign to Charisma.");
                            intInput = false;
                            intInput = Int32.TryParse(Console.ReadLine(), out scoreToCheck);

                            if (!intInput)
                            {
                                Console.WriteLine("Input wasn't a number. Try again.");
                            }

                            if (intInput)
                            {
                                int indexToRemove = Array.IndexOf(scoresToAssign, scoreToCheck);

                                if (indexToRemove < 0)
                                {
                                    Console.WriteLine("Invalid score. Try again.");
                                    break;
                                }

                                _characterData.Charisma += scoreToCheck;

                                scoresToAssign = scoresToAssign.Where((source, index) => index != indexToRemove).ToArray();
                                _characterData.CharismaMod = DetermineAbilityModifier(_characterData.Charisma);
                                validScoreToAssign = true;
                            }
                            break;
                        default:
                            break;
                    }
                } while (!validScoreToAssign);

            }

            return _characterData;
        }

        private CharacterData ChooseHeightandWeight(CharacterData characterdata, string heightRange, string weightRange)
        {
            Console.WriteLine("Choose your character's height (in inches).");
            Console.WriteLine(heightRange);

            bool validHeightInput = false;

            do
            {
                validHeightInput = Int32.TryParse(Console.ReadLine(), out int heightInInches);

                if (!validHeightInput)
                {
                    Console.WriteLine(" Input wasn't a valid number. Try again.");
                    continue;

                }

                characterdata.Height = heightInInches;
                validHeightInput = true;

            } while (!validHeightInput);

            Console.WriteLine("Choose your character's weight (in pounds).");
            Console.WriteLine(weightRange);

            bool validWeightInput = false;

            do
            {
                validWeightInput = Int32.TryParse(Console.ReadLine(), out int weightInPounds);

                if (!validWeightInput)
                {
                    Console.WriteLine(" Input wasn't a valid number. Try again.");
                    continue;

                }

                characterdata.Weight = weightInPounds;
                validWeightInput = true;

            } while (!validWeightInput);

            return characterdata;
        }

        private CharacterData RandomHeightandWeight(CharacterData characterdata, int heightbase, int heightDie, int weightBase, int weightDie, int weightRolls)
        {
            int heightToAdd = 0;
            for (int i = 0; i < 2; i++)
            {
                heightToAdd += _random.Next(1, heightDie);
            }

            characterdata.Height = heightbase + heightToAdd;

            int weightToAdd = 0;
            for (int i = 0; i < weightRolls; i++)
            {
                weightToAdd += _random.Next(1, weightDie);
            }

            characterdata.Weight = weightBase + weightToAdd;

            return characterdata;
        }

    }
}
