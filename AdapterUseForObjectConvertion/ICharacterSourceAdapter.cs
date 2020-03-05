using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AdapterUseForObjectConversion
{
    public interface ICharacterSourceAdapter
    {
        IEnumerable<Person> GetCharacters();
    }
}
