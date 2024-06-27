using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalproject
{
    interface ISaveLoadManagebimar
    {
        void SaveListToFile(string filePath, List<bimar> bimarList);
        List<bimar> ReadListFromFile(string filePath);
    }
}
