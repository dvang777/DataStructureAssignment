using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DataStructure
{
    public class SystemLinkedListString : ICustomString
    {
        public int data;
        public SystemLinkedListString next;
        SystemLinkedListString node1;
        SystemLinkedListString node2;
        LinkedList<char> linkedList;

        public SystemLinkedListString(LinkedList<char> linkedList)
        {
            this.linkedList = linkedList;

        }

        public void Insert(int index, string insert)
        {

            char[] addString = insert.ToCharArray();
            LinkedListNode<char> node = linkedList.First;
            int Index = 0;

            while (Index < index)
            {
                node = node.Next;
                Index++;
            }
            node = node.Previous;
            if (linkedList == null || addString == null)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                for (int i = 0; i < insert.Length; i++)
                {
                    linkedList.AddAfter(node, insert[i]);
                    node = node.Next;
                }
            }
        }

        public int Length()
        {
            return linkedList.Count;
        }

        public void Remove(int startIndex, int numCharsToRemove)
        {
            LinkedListNode<char> node = linkedList.First;
            int index = 0;
            int i = 0;

            if(startIndex == 0)
            {
                for(i = 0; i < numCharsToRemove; i++)
                {
                    linkedList.RemoveFirst();
                }
            }
            else
            {
                while(index < startIndex)
                {
                    node = node.Next;
                    index++;
                }
                node = node.Previous;
                for (i =0; i < numCharsToRemove; i++)
                {
                    if(node != null)
                    {
                        linkedList.Remove(node.Next);
                    }
                }
            }
        }
    }
}
