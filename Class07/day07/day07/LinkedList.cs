using System;
using System.Collections.Generic;
using System.Text;

namespace day07
{
    class LinkedList
    {
        public Node Head { get; set; }
        //public Node Tail { get; set; }

        public LinkedList()
        {
            Head = null;
        }

        public void InsertAtHead(int value)
        {
            Node newNode = new Node(value);
            if(Head == null) 
            {
                Head = newNode;
            }
            else 
            {
                newNode.Next = Head;
                Head = newNode;
            }
        }

        public void Append(int value)
        {
            Node newNode = new Node(value);
            
            if(Head == null)
            {
                // Invariant - The LL is empty
                Head = newNode;

            }
            else
            {
                // Invariant - The LL is not empty - Head is not null
                Node current = Head;
                while(current.Next != null)
                {
                    current = current.Next;
                }
                // Invariant - You reached the end of the linked list. current is the last node
                current.Next = newNode;
            }
        }
    }
}
