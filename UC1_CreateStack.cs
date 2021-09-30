using System;
using System.Collections.Generic;
using System.Text;

namespace Day14StackNQueueAssg
{
    class UC1_CreateStack
    {
        private Node top;
        public UC1_CreateStack()
        {
            this.top = null;
        }
        internal void Push(int Value)
        {
            Node node = new Node(Value);
            if (this.top == null)
                node.next = null;
            else
                node.next = this.top;
            this.top = node;
            Console.WriteLine("{0} inserted into Stack",Value);
        }
        internal void Display()
        {
            Node temp = this.top;
            while(temp!=null)
            {
                Console.Write(temp.data+" ");
                temp = temp.next;
            }
        }
    }
}
