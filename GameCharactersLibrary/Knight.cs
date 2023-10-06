using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCharactersLibrary
{
    public class Knight : Character
    {
        public Knight(string name) : base(name, health: 120, attackPower: 25)
        {
        }

        public override string GetInfo()
        {
            return $"Knight - {base.GetInfo()}";
        }
    }
}
