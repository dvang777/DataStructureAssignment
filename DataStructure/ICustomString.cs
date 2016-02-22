using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    interface ICustomString
    {
        String ToString();
        void Insert(int index, string stringToInsert);
        void Remove(int startIndex, int numCharsToRemove);
        int Length();
    }
}
