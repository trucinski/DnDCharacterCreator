using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DnDCharacterCreator.Data;
using DnDCharacterCreator.Builders;
using System.Reflection;

namespace TestProject
{
    class Program
    {
        private static readonly Random _random = new Random();
        private static readonly CharacterData _characterData = new CharacterData();
        private static readonly CharacterDataBuilder _characterDataBuilder = new CharacterDataBuilder();

        static void Main(string[] args)
        {

            int heightOverall = 56;
            int weightOverall = 110;

            int heightFeet = heightOverall / 12;
            int heightInches = heightOverall % 12;
            Console.WriteLine("{0}'{1}\"", heightFeet, heightInches);

            int heightToAdd = 0;

            for (int i = 0; i < 2; i++)
            {
                heightToAdd += _random.Next(1, 11);
            }

            heightOverall += heightToAdd;

            heightFeet = heightOverall / 12;
            heightInches = heightOverall % 12;
            Console.WriteLine("{0}'{1}\"", heightFeet, heightInches);

            int weightMod = 0;

            for (int i = 0; i < 2; i++)
            {
                weightMod += _random.Next(1, 5);
            }

            weightMod *= heightToAdd;

            weightOverall += weightMod;

            Console.WriteLine("{0} lbs.", weightOverall);

            Console.ReadLine();
          

        }
    }
}
