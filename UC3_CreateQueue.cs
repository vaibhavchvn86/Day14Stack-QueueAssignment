﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Day14StackNQueueAssg
{
    class UC3_CreateQueue
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
                while(temp.next!=null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} Inserted in Queue Linked list",node.data);
        }
        internal void Display()
        {
            Node temp = head;
            if(temp==null)
            {
                Console.WriteLine("Queue is Empty");
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
