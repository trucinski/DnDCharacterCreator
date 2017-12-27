using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCharacterCreator.Data
{
    public class CharacterData 
    {     
        public string CharClass { get; set; }
        public string ClassArchetype { get; set; }
        public int Level { get; set; }
        public string Background { get; set; }
        public string Name { get; set; }

        public string Sex { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public int CarryWeight { get; set; }
        public string Size { get; set; }

        public string EyeColor { get; set; }
        public string SkinColor { get; set; }
        public string HairColor { get; set; }

        public string Race { get; set; }
        public string SubRace { get; set; }
        public string HumanEthnicity { get; set; }
        public string Alignment { get; set; }
        public int Experience { get; set; }

        public int Speed { get; set; }
        public int Initiative { get; set; }
        public int ArmorClass { get; set; }

        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }

        public int StrengthMod { get; set; }
        public int DexterityMod { get; set; }
        public int ConstitutionMod { get; set; }
        public int IntelligenceMod { get; set; }
        public int WisdomMod { get; set; }
        public int CharismaMod { get; set; }

        public int MaxHitPoints { get; set; }
        public int CurrentHitPoints { get; set; }
        public int HitDieValue { get; set; }
        public int MaxHitDieTotal { get; set; }
        public int CurrentHitDieTotal { get; set; }

        public int Inspiration { get; set; }
        public int ProficiencyBonus { get; set; }
        public int Perception { get; set; }

        public int CreationStep { get; set; }
        public bool CreationComplete { get; set; }
    }
}
