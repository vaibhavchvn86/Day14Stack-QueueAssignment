﻿using System;

namespace Day14StackNQueueAssg
{
    class Program
    {
        static void Main(string[] args)
        {
            //#region UC1
            //UC1_CreateStack list = new UC1_CreateStack();
            //list.Push(70);
            //list.Push(30);
            //list.Push(56);
            //Console.WriteLine("\nFinal Sequence");
            //list.Display();
            //#endregion

            //#region
            //UC2_PeekNPopStack stack = new UC2_PeekNPopStack();
            //stack.Push(70);
            //stack.Push(30);
            //stack.Push(56);
            //Console.WriteLine("\nStack Linked List");
            //stack.Display();
            //stack.Peek();
            //stack.Pop();
            //stack.IsEmpty();
            //stack.Display();
            //#endregion

            //#region UC3
            //UC3_CreateQueue queue = new UC3_CreateQueue();
            //queue.Enqueue(56);
            //queue.Enqueue(30);
            //queue.Enqueue(70);
            //Console.WriteLine("\nQueue Sequence");
            //queue.Display();
            //#endregion

            #region UC4
            UC4_Dequeue queuelist = new UC4_Dequeue();
            queuelist.Enqueue(56);
            queuelist.Enqueue(30);
            queuelist.Enqueue(70);
            Console.WriteLine("\nQueue Sequence");
            queuelist.Dequeue();
            queuelist.Dequeue();
            queuelist.Dequeue();
            queuelist.Display();
            #endregion
        }
    }
}
