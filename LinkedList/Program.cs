﻿using System;

namespace LinkedList
{
    class Program
    {
        //
        static void Main(string[] args)
        {
            var linkedlist = new LinkedList();
            linkedlist.Add(56);
            linkedlist.Add(30);
            linkedlist.Add(70);
            linkedlist.Display();
            linkedlist.RemoveLastNode();

            Console.ReadKey();
        }
    }
}