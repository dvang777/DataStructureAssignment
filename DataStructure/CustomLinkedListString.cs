using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class CustomLinkedListString : ICustomString
    {
        public int data;
        public Node Head;
        public CustomLinkedListString(Node head)
        {
            Head = head;
        }

        public void Insert(int index, string stringToInsert)
        {
            char[] InsertArray = stringToInsert.ToCharArray();
            Node node = Head;
            if (index == 0)
            {
                for (int i = 0; i < InsertArray.Length; i++)
                {
                    node = new Node(InsertArray[InsertArray.Length - 1 - i], Head);
                    Head = node;
                }
            }
        }

        public int Length()
        {
            Node node = Head;
            int increment = 0;
            if (node == null)
            {
                return 0;
            }
            while(node.Next != null)
            {
                increment++;
                node = node.Next;
            }
            return increment;
        }

        public void Remove(int startIndex, int numCharsToRemove)
        {
            Node node = Head;
            Node next = Head;
            int index = 1;
            if (startIndex == 0)
            {
                for (int i = 0; i < numCharsToRemove; i++)
                {
                node = node.Next;
                }
            Head = node;
            }
            else
            {
                while (index < startIndex)
                {
                    node = node.Next;
                    next = next.Next;
                    index++;
                }
                for (int i =0; i<numCharsToRemove; i++)
                {
                    next = next.Next;
                    node.Next = next;
                }
            }

        }
    }
}
