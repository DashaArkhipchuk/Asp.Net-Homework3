using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailsLibrary
{
    public class Cocktail2:Cocktail
    {
        public override string Name => "Cocktail2";

        public override string Descrition => "Cocktail2 Description";

        public Cocktail2(IOutputInfo output) : base(output)
        {
        }

        public override string FullInfo => base.FullInfo + "How to prepare: call a barman";
    }
}
