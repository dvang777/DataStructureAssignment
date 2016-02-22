using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class SystemArrayString : ICustomString
    {
        static string[] stringArray;
        string[] newStringArray = new string[stringArray.Length + 1];
        string[] removeStringArray = new string[stringArray.Length - 1];
        public SystemArrayString()
        {

        }

        public void Insert(int index, string stringToInsert)
        {

            stringArray.CopyTo(newStringArray, index);
            newStringArray.SetValue(stringToInsert, stringArray.Length);
            stringArray = newStringArray;
            
        }

        public int Length()
        {
            int length;
            length = stringArray.Length;
            return length;
        }

        public void Remove(int startIndex, int numCharsToRemove)
        {
            throw new NotImplementedException();
        }
    }
}
