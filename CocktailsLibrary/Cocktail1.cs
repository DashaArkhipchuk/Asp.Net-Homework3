using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailsLibrary
{
    public class Cocktail1 : Cocktail
    {
        public override string Name => "Cocktail1";

        public override string Descrition => "Cocktail1 Description";

        public Cocktail1(IOutputInfo output) : base(output)
        {
        }

        public override string FullInfo => base.FullInfo + "How to prepare: call a barman";

    }
}
