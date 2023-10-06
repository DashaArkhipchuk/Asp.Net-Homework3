using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailsLibrary
{
    public interface IOutputInfo
    {
        void OutputShortFile(string path, in string shortInfo);
        void OutputFullFile(string path, in string fullInfo);

        string OutputShort(in string shortInfo);
        string OutputFull(in string fullInfo);
    }
}
