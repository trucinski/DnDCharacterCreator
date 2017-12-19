using DnDCharacterCreator.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DnDCharacterCreator.Workers
{
    class SaveCharacter
    {
        public void SaveCharacterData(string fileName, CharacterData characterData)
        {

            TextWriter tw = new StreamWriter(fileName, false);
            foreach (PropertyInfo prop in typeof(CharacterData).GetProperties())
            {
                tw.WriteLine("{0} = {1}", prop.Name, prop.GetValue(characterData, null));

            }
            tw.Close();
        }
    }
}
