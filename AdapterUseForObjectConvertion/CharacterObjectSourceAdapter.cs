using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterUseForObjectConversion
{
    public class CharacterObjectSourceAdapter : ICharacterSourceAdapter
    {
        private IEnumerable<Character> characters;
        public CharacterObjectSourceAdapter(IEnumerable<Character> characters)
        {
            this.characters = characters;
        }

        public IEnumerable<Person> GetCharacters() =>
            characters.Select(character => new CharacterToPersonAdapter(character));
    }
}
