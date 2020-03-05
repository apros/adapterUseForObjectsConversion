using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterUseForObjectConversion
{
    public class CharacterToPersonAdapter : Person
    {
        private readonly Character _character;

        public CharacterToPersonAdapter(Character character)
        {
            _character = character ?? throw new ArgumentNullException(nameof(character));
        }

        public override string Name
        {
            get => string.IsNullOrEmpty(_character.FirstName)? _character.LastName : _character.FirstName + " " + _character.LastName;
            set
            {
                if (value.Split(" ").Length > 1)
                {
                    _character.FirstName = value.Split(" ")[0];
                    _character.LastName = value.Split(" ")[1];
                }
                else
                {
                    _character.LastName = value;
                }
            }
        }

        public override string HairColor
        {
            get => _character.Hair;
            set => _character.Hair = value;
        }
    }
}
