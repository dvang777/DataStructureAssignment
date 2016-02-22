using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            
            SystemString sys = new SystemString("String");
            sys.Insert(6, "insert");
            sys.Remove(2, 3);

            LinkedList<char> charList = new LinkedList<char>();
            SystemLinkedListString SLL = new SystemLinkedListString(charList);
            charList.AddFirst('A');
            charList.AddLast('L');
            SLL.Insert(2, "P");
            SLL.Insert(3, "H");
            SLL.Insert(4, "A");

            


        }
    }
}
