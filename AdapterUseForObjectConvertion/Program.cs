using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterUseForObjectConversion
{
    class Program
    {
        static IEnumerable<Character> characters = new List<Character>()
        {
            new Character()
            {
                FirstName = "Luke",
                LastName = "Skywalker",
                Gender = "Male",
                Hair = "Blonde"
            },
            new Character()
            {
               LastName = "C-3PO",
                Gender = "n/a",
                Hair = "n/a"
            },
            new Character()
            {
                FirstName = "R2-D2",
                Gender = "n/a",
                Hair = "n/a"
            },
            new Character()
            {
                FirstName = "Darth",
                LastName = "Vader",
                Gender = "male",
                Hair = "none"
            },
            new Character()
            {
                FirstName = "Leia",
                LastName = "Organa",
                Gender = "female",
                Hair = "brown"
            }
        };

        static ICharacterSourceAdapter characterSourceAdapter = new CharacterObjectSourceAdapter(characters);

        static void Main(string[] args)
        {
            var people = characterSourceAdapter.GetCharacters();
            var sb = new StringBuilder();
            int nameWidth = 30;
            sb.AppendLine($"{"NAME".PadRight(nameWidth)}   {"HAIR"}");
            foreach (Person person in people)
            {
                sb.AppendLine($"{person.Name.PadRight(nameWidth)}   {person.HairColor}");
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
