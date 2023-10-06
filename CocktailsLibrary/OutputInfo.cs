using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CocktailsLibrary.OutputInfo;

namespace CocktailsLibrary
{
    public class OutputInfo : IOutputInfo
    {
        public void OutputShortFile(string path, in string shortInfo)
        {
            if (string.IsNullOrEmpty(path))
            {
                throw new ArgumentNullException();
            }

            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }

            File.AppendAllText(path, shortInfo);
        }

        public void OutputFullFile(string path, in string fullInfo)
        {
            if (string.IsNullOrEmpty(path))
            {
                throw new ArgumentNullException();
            }

            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }

            File.AppendAllText(path, fullInfo);
        }

        public string OutputShort(in string shortInfo)
        {
            return $"<p>{shortInfo}</p>";
        }

        public string OutputFull(in string fullInfo)
        {
            return $"<p>{fullInfo}</p>";
        }
    }
}