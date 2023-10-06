namespace CocktailsLibrary
{
    public abstract class Cocktail
    {
        public abstract string Name { get; }
        public abstract string Descrition { get; }

        public virtual string ShortInfo => $"Cocktail name: {Name}";
        public virtual string FullInfo => $"Name: {Name}, Description: {Descrition}%";

        public IOutputInfo OutputManager { get; protected set; }

        public Cocktail(IOutputInfo output)
        {
            OutputManager = output;
        }

        public void OutputShortFile(string filePath)
        {
            if (OutputManager == null)
            {
                throw new NullReferenceException();
            }

            OutputManager.OutputShortFile(filePath, ShortInfo);
        }

        public void OutputFullFile(string filePath)
        {
            if (OutputManager == null)
            {
                throw new NullReferenceException();
            }

            OutputManager.OutputFullFile(filePath, FullInfo);
        }
    }
}