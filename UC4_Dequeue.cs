using System;
using System.Collections.Generic;
using System.Text;

namespace Day14StackNQueueAssg
{
    class UC4_Dequeue
    {
        Node head = null;
        internal void Enqueue(int data)
        {
            Node node = new Node(data);
            if (head == null)
                head = node;
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
            temp.next = node;
            }
            Console.WriteLine("{0} inserted into Queue",node.data);
        }
        internal void Dequeue()
        {
            if (head == null)
            {
                Console.WriteLine("\nQueue is Empty");
            }
            else
            {
                Console.Write("\n{0} Dequeued For Queue",head.data);
                head = head.next;
            }
        }
        internal void Display()
        {
            Node temp = head;
            if(temp==null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }    
            while(temp!=null)
            {
                Console.Write(temp.data+" ");
                temp = temp.next;
            }
        }
    }
}
