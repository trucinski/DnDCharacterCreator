using DnDCharacterCreator.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCharacterCreator.Builders
{
    public class CharacterDataBuilder
    {
        private string _charClass;
        private string _charClassArchetype;
        private int _charLevel;
        private string _charBackground;
        private string _charName;

        private string _charSex;
        private int _charHeight;
        private int _charWeight;
        private int _charCarryWeight;
        private string _charSize;

        private string _charEyeColor;
        private string _charSkinColor;
        private string _charHairColor;

        private string _charRace;
        private string _charSubRace;
        private string _charHumanEthnicity;
        private string _charAlignment;
        private int _charExperience;

        private int _charSpeed;
        private int _charInitiative;
        private int _charArmorClass;

        private int _charStrength;
        private int _charStrengthMod;
        private int _charDexterity;
        private int _charDexterityMod;
        private int _charConstitution;
        private int _charConstitutionMod;
        private int _charIntelligence;
        private int _charIntelligenceMod;
        private int _charWisdom;
        private int _charWisdomMod;
        private int _charCharisma;
        private int _charCharismaMod;

        private int _charMaxHitPoints;
        private int _charCurrentHitPoints;
        private int _charHitDieValue;
        private int _charMaxHitDieTotal;
        private int _charCurrentHitDieTotal;

        private int _charInspiration;
        private int _charProficiencyBonus;
        private int _charPerception;

        private int _charCreationStep;
        private bool _charCreationComplete;

        public CharacterDataBuilder()
        {
            SetDefaults();
        }

        public void SetDefaults()
        {
            _charClass = string.Empty;
            _charClassArchetype = string.Empty;
            _charLevel = 1;
            _charBackground = string.Empty;
            _charName = string.Empty;

            _charSex = string.Empty;
            _charHeight = 0;
            _charWeight = 0;
            _charCarryWeight = 0;
            _charSize = string.Empty;

            _charEyeColor = string.Empty;
            _charSkinColor = string.Empty;
            _charHairColor = string.Empty;

            _charRace = string.Empty;
            _charSubRace = string.Empty;
            _charHumanEthnicity = string.Empty;
            _charAlignment = string.Empty;
            _charExperience = 0;

            _charSpeed = 0;
            _charInitiative = 0;
            _charArmorClass = 10;

            _charStrength = 0;
            _charDexterity = 0;
            _charConstitution = 0;
            _charIntelligence = 0;
            _charWisdom = 0;
            _charCharisma = 0;

            _charStrengthMod = 0;
            _charDexterityMod = 0;
            _charConstitutionMod = 0;
            _charIntelligenceMod = 0;
            _charWisdomMod = 0;
            _charCharismaMod = 0;

            _charMaxHitPoints = 0;
            _charCurrentHitPoints = 0;
            _charHitDieValue = 0;
            _charMaxHitDieTotal = 0;
            _charCurrentHitDieTotal = 0;

            _charInspiration = 0;
            _charProficiencyBonus = 2;
            _charPerception = 0;

            _charCreationStep = 0;
            _charCreationComplete = false;

        }

        public CharacterDataBuilder WithClass(string charClass)
        {
            _charClass = charClass;
            return this;
        }

        public CharacterDataBuilder WithClassArchetype(string charClassArchetype)
        {
            _charClassArchetype = charClassArchetype;
            return this;
        }

        public CharacterDataBuilder WithLevel(int charLevel)
        {
            _charLevel = charLevel;
            return this;
        }

        public CharacterDataBuilder WithBackground(string charBackground)
        {
            _charBackground = charBackground;
            return this;
        }

        public CharacterDataBuilder WithName(string charName)
        {
            _charName = charName;
            return this;
        }

        public CharacterDataBuilder WithHeight(int charHeight)
        {
            _charHeight = charHeight;
            return this;
        }

        public CharacterDataBuilder WithWeight(int charWeight)
        {
            _charWeight = charWeight;
            return this;
        }

        public CharacterDataBuilder WithCarryWeight(int charCarryWeight)
        {
            _charCarryWeight = charCarryWeight;
            return this;
        }

        public CharacterDataBuilder WithEyeColor(string charEyeColor)
        {
            _charEyeColor = charEyeColor;
            return this;
        }

        public CharacterDataBuilder WithSkinColor(string charSkinColor)
        {
            _charSkinColor = charSkinColor;
            return this;
        }

        public CharacterDataBuilder WithHairColor(string charHairColor)
        {
            _charHairColor = charHairColor;
            return this;
        }

        public CharacterDataBuilder WithRace(string charRace)
        {
            _charRace = charRace;
            return this;
        }

        public CharacterDataBuilder WithSubRace(string charSubRace)
        {
            _charSubRace = charSubRace;
            return this;
        }

        public CharacterDataBuilder WithHumanEthnicity(string charHumanEthnicity)
        {
            _charHumanEthnicity = charHumanEthnicity;
            return this;
        }

        public CharacterDataBuilder WithAlignment(string charAlignment)
        {
            _charAlignment = charAlignment;
            return this;
        }

        public CharacterDataBuilder WithExperience(int charExperience)
        {
            _charExperience = charExperience;
            return this;
        }

        public CharacterDataBuilder WithStrength(int charStrength)
        {
            _charStrength = charStrength;
            return this;
        }

        public CharacterDataBuilder WithDexterity(int charDexterity)
        {
            _charDexterity = charDexterity;
            return this;
        }

        public CharacterDataBuilder WithConstitution(int charConstitution)
        {
            _charConstitution = charConstitution;
            return this;
        }

        public CharacterDataBuilder WithIntelligence(int charIntelligence)
        {
            _charIntelligence = charIntelligence;
            return this;
        }

        public CharacterDataBuilder WithWisdom(int charWisdom)
        {
            _charWisdom = charWisdom;
            return this;
        }

        public CharacterDataBuilder WithCharisma(int charCharisma)
        {
            _charCharisma = charCharisma;
            return this;
        }

        public CharacterDataBuilder WithStrengthMod(int charStrengthMod)
        {
            _charStrengthMod = charStrengthMod;
            return this;
        }

        public CharacterDataBuilder WithDexterityMod(int charDexterityMod)
        {
            _charDexterityMod = charDexterityMod;
            return this;
        }

        public CharacterDataBuilder WithConstitutionMod(int charConstitutionMod)
        {
            _charConstitutionMod = charConstitutionMod;
            return this;
        }

        public CharacterDataBuilder WithIntelligenceMod(int CharIntelligenceMod)
        {
            _charIntelligenceMod = CharIntelligenceMod;
            return this;
        }

        public CharacterDataBuilder WithWisdomMod(int charWisdomMod)
        {
            _charWisdomMod = charWisdomMod;
            return this;
        }

        public CharacterDataBuilder WithCharismaMod(int charCharismaMod)
        {
            _charCharismaMod = charCharismaMod;
            return this;
        }

        public CharacterDataBuilder WithSpeed(int charSpeed)
        {
            _charSpeed = charSpeed;
            return this;
        }

        public CharacterDataBuilder WithInitiative(int charInitiative)
        {
            _charInitiative = charInitiative;
            return this;
        }

        public CharacterDataBuilder WithArmorClass(int charArmorClass)
        {
            _charArmorClass = charArmorClass;
            return this;
        }

        public CharacterDataBuilder WithMaxHitPoints(int charMaxHitPoints)
        {
            _charMaxHitPoints = charMaxHitPoints;
            return this;
        }

        public CharacterDataBuilder WithCurrentHitPoints(int charCurrentHitPoints)
        {
            _charCurrentHitPoints = charCurrentHitPoints;
            return this;
        }

        public CharacterDataBuilder WithHitDieValue(int charHitDieValue)
        {
            _charHitDieValue = charHitDieValue;
            return this;
        }

        public CharacterDataBuilder WithMaxHitDieTotal(int charMaxHitDieTotal)
        {
            _charMaxHitDieTotal = charMaxHitDieTotal;
            return this;
        }

        public CharacterDataBuilder WithCurrentHitDieTotal(int charCurrentHitDieTotal)
        {
            _charCurrentHitDieTotal = charCurrentHitDieTotal;
            return this;
        }

        public CharacterDataBuilder WithInspiration(int charInspiration)
        {
            _charInspiration = charInspiration;
            return this;
        }

        public CharacterDataBuilder WithProficiencyBonus(int charProficiencyBonus)
        {
            _charProficiencyBonus = charProficiencyBonus;
            return this;
        }

        public CharacterDataBuilder WithPerception(int charPerception)
        {
            _charPerception = charPerception;
            return this;
        }

        public CharacterDataBuilder WithSex(string charSex)
        {
            _charSex = charSex;
            return this;
        }

        public CharacterDataBuilder WithSize(string charSize)
        {
            _charSize = charSize;
            return this;
        }

        public CharacterDataBuilder WithCreationStep(int charCreationStep)
        {
            _charCreationStep = charCreationStep;
            return this;
        }

        public CharacterDataBuilder WithCreationComplete(bool charCreationComplete)
        {
            _charCreationComplete = charCreationComplete;
            return this;
        }

        public CharacterData Build()
        {
            CharacterData characterData = new CharacterData
            {
                CharClass = _charClass,
                ClassArchetype = _charClassArchetype,
                Level = _charLevel,
                Background = _charBackground,
                Name = _charName,
                Height = _charHeight,
                Weight = _charWeight,
                CarryWeight = _charCarryWeight,
                EyeColor = _charEyeColor,
                SkinColor = _charSkinColor,
                HairColor = _charHairColor,
                Race = _charRace,
                SubRace = _charSubRace,
                HumanEthnicity = _charHumanEthnicity,
                Alignment = _charAlignment,
                Experience = _charExperience,
                Strength = _charStrength,
                Dexterity = _charDexterity,
                Constitution = _charConstitution,
                Intelligence = _charIntelligence,
                Wisdom = _charWisdom,
                Charisma = _charCharisma,
                StrengthMod = _charStrengthMod,
                DexterityMod = _charDexterityMod,
                ConstitutionMod = _charConstitutionMod,
                IntelligenceMod = _charIntelligenceMod,
                WisdomMod = _charWisdomMod,
                CharismaMod = _charCharismaMod,
                Speed = _charSpeed,
                Initiative = _charInitiative,
                ArmorClass = _charArmorClass,
                MaxHitPoints = _charMaxHitPoints,
                CurrentHitPoints = _charCurrentHitPoints,
                HitDieValue = _charHitDieValue,
                MaxHitDieTotal = _charMaxHitDieTotal,
                CurrentHitDieTotal = _charCurrentHitDieTotal,
                Inspiration = _charInspiration,
                ProficiencyBonus = _charProficiencyBonus,
                Perception = _charPerception,
                Sex = _charSex,
                Size = _charSize,
                CreationStep = _charCreationStep,
                CreationComplete = _charCreationComplete,
            };

            return characterData;
        }
    }
}
