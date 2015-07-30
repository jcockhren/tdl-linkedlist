using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Stretch Goals: Using Generics, which would include implementing GetType() http://msdn.microsoft.com/en-us/library/system.object.gettype(v=vs.110).aspx
namespace SinglyLinkedLists
{
    public class SinglyLinkedListNode : IComparable
    {
        // Used by the visualizer.  Do not change.
        public static List<SinglyLinkedListNode> allNodes = new List<SinglyLinkedListNode>();

        // READ: http://msdn.microsoft.com/en-us/library/aa287786(v=vs.71).aspx
        private SinglyLinkedListNode next;
        public SinglyLinkedListNode Next
        {
            get { return next; }
            set {
                if (value.Equals(this)) {
                    throw new ArgumentException();
                }
                this.next = value;
            }
        }

        private string value; // same as this.value
        // Value is a property!! Fix the getter!
        public string Value 
        {
            get { return value; }
        }

        public static bool operator <(SinglyLinkedListNode node1, SinglyLinkedListNode node2)
        {
            // This implementation is provided for your convenience.
            return node1.CompareTo(node2) < 0;
        }

        public static bool operator >(SinglyLinkedListNode node1, SinglyLinkedListNode node2)
        {
            // This implementation is provided for your convenience.
            return node1.CompareTo(node2) > 0;
        }

        public static bool operator ==(SinglyLinkedListNode node1, SinglyLinkedListNode node2)
        {
            return node1.CompareTo(node2) == 0;
        }

        public static bool operator !=(SinglyLinkedListNode node1, SinglyLinkedListNode node2)
        {
            /* The long way
            return node1.CompareTo(node2) != 0;
            */
            return !(node1 == node2);
        }

        public SinglyLinkedListNode(string input)
        {
            this.value = input;

            // data members default to null, but...
            this.next = null;
            
            // Used by the visualizer:
            allNodes.Add(this);
        }

        // READ: http://msdn.microsoft.com/en-us/library/system.icomparable.compareto.aspx
        public int CompareTo(Object obj)
        {
            SinglyLinkedListNode other_node = obj as SinglyLinkedListNode;
            if (this.value == other_node.Value)
            {
                return 0;
            }
            return 1;
            /* Come back to this. What are other ways to compare instances? 
            else
            {
                throw new NotImplementedException();
            }
            */

            
        }

        public bool IsLast()
        {
            /* this makes the test pass
            if (this.next == null)
            {
                return true;
            } else
            {
                return false;
            }
            */
            /* Refactor 1: no else statement
            if (this.next == null)
            {
                return true;
            } 
            return false;
            */

            /* Refactor 2 */
            return this.next == null;

        }


        public override string ToString()
        {
            return this.value;
        }

    }
}
