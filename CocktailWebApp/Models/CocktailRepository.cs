using CocktailsLibrary;

namespace CocktailWebApp.Models
{
    public class CocktailRepository : ICocktailRepository
    {
        private ICollection<Cocktail> Cocktails { get; set; }
        public IOutputInfo outputManager;

        public CocktailRepository(IOutputInfo output)
        {
            Cocktails = new List<Cocktail>();
            this.outputManager = output;
        }

        public IEnumerable<Cocktail> GetCocktails()
        {
            return Cocktails ?? new List<Cocktail>();
        }

        public void AddCocktail(Cocktail cocktail)
        {
            if (Cocktails == null)
            {
                throw new NullReferenceException();
            }
            Cocktails.Add(cocktail);
        }

        public void SaveCocktailsInfoToTxt(string filePath)
        {
            if (Cocktails == null)
            {
                throw new NullReferenceException();
            }

            foreach (Cocktail cocktail in Cocktails)
            {
                if (cocktail != null)
                {
                    cocktail.OutputShortFile(filePath);
                    cocktail.OutputFullFile(filePath);
                }
            }
        }

    }
}
