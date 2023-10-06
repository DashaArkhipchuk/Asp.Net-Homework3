using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCharactersLibrary
{
    public interface IOutputInfo
    {
        void OutputFile(string path, in string shortInfo);
        string Output(in string shortInfo);
    }
}
