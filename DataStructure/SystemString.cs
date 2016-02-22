using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class SystemString : ICustomString
    {
        string StringInput;
        int length;
        public SystemString(string stringInput)
        {
            StringInput = stringInput;
        }

        public void Insert(int index, string stringToInsert)
        {
            StringInput.Insert(index, stringToInsert);
        }

        public int Length()
        {
            
            length = StringInput.Length;
            return length;
        }

        public void Remove(int startIndex, int numCharsToRemove)
        {
            StringInput.Remove(startIndex, numCharsToRemove);
        }
    }
}
