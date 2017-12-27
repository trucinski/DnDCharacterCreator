using DnDCharacterCreator.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCharacterCreator.Workers
{
    class Display
    {
        public void CharacterDisplay(CharacterData characterData)
        {

            Console.WriteLine(Constants.characterDisplayOne, characterData.CharClass, characterData.Level, characterData.Background, characterData.Name);
            Console.WriteLine(Constants.characterDisplayTwo, characterData.SubRace, characterData.Alignment, characterData.Experience);
            Console.WriteLine(Constants.characterDisplayThree, characterData.Speed, characterData.Initiative, characterData.ArmorClass);
            Console.WriteLine(Constants.characterDisplayFour, characterData.Perception, characterData.ProficiencyBonus, characterData.Inspiration);
            Console.WriteLine(Constants.characterDisplayHP, characterData.CurrentHitPoints, characterData.MaxHitPoints, characterData.HitDieValue, characterData.CurrentHitDieTotal, characterData.MaxHitDieTotal);
            Console.WriteLine(Constants.characterDisplayAbility, characterData.Strength, characterData.Dexterity, characterData.Constitution,
                characterData.Intelligence, characterData.Wisdom, characterData.Charisma, characterData.StrengthMod, characterData.DexterityMod, 
                characterData.ConstitutionMod, characterData.IntelligenceMod, characterData.WisdomMod, characterData.CharismaMod);

        }

        public void SetAbilityScoreDisplay(int[] abilityScores)
        {
            foreach (var score in abilityScores)
            {
                Console.Write(score + " ");
            }
        }

        public void CharacterInfoDisplay(CharacterData characterData)
        {
            Console.WriteLine(Constants.characterInfoDisplayOne, characterData.Sex, characterData.Height, characterData.Weight, characterData.CarryWeight);
            Console.WriteLine(Constants.characterInfoDisplayTwo, characterData.EyeColor, characterData.SkinColor, characterData.HairColor);
        }
    }
}
