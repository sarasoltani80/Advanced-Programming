using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalproject
{
    interface ISaveLoadManagedoctors
    {
        void SaveListToFile(string filePath, List<doctor> assistantlist);
        List<doctor> ReadListFromFile(string filePath);
    }
}
