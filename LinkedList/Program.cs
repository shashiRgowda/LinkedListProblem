using System;

namespace LinkedList
{
    class Program
    {
        class Program
        {
            //
            static void Main(string[] args)
            {
                LinkedList linkedlist = new LinkedList();
                linkedlist.Add(56);
                linkedlist.Add(70);
                Console.WriteLine("The list before inserting 30 is : ");
                linkedlist.Display();
                linkedlist.InsertAtParticularPosition(3, 30);
                Console.WriteLine("The list after inserting 30 is :  ");
                linkedlist.Display();
                linkedlist.RemoveLastNode();
                Console.WriteLine("The list after removing last node is : ");
                linkedlist.Display();
            }
        }
    }