using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericite
{
    public class LinkedList<T> : IEnumerable
    {
        public LinkedListNode<T> First { get; private set; }
        public LinkedListNode<T> Last { get; private set; }
        public LinkedListNode<T> AddLast(T value)
        {
            LinkedListNode<T> newNode = new LinkedListNode<T>(value);
            if (First == null)
            {
                First = newNode;
                Last = First;
                First.Prev = null;
            }
            else
            {
                Last.Next = newNode;
                newNode.Prev = Last;
                Last = newNode;
            }

            Last.Next = null;
            return newNode;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            LinkedListNode<T> current = First;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            LinkedListNode<T> node = First;

            while (node != null)
            {
                sb.Append(node.ToString()).Append("  ");
                node = node.Next;
            }
            

            return sb.ToString();
        }
    }
}
