using System;
using System.Collections.Generic;
using System.Text;

namespace ArraylistOperations
{
    public class LinkedListProgram
    {

         public LinkedListProgram()
        {
            LinkedList<String> my_list = new LinkedList<String>();

            my_list.AddLast("Anshpreet");
            my_list.AddLast("Anusha");
            my_list.AddLast("Ramya");
            my_list.AddLast("Arpita");
            my_list.AddLast("Nishitha");
            my_list.AddLast("Aayushi");

            // Inital number of elements 
            Console.WriteLine("Best students of XYZ " +
                             "university initially:");

            // Accessing the elements of Linkedlist Using foreach loop 
            foreach (string str in my_list)
            {
                Console.WriteLine(str);
            }

            // After using Remove(LinkedListNode) method 
            Console.WriteLine("Best students of XYZ" +
                             " university in 2000:");

            my_list.Remove(my_list.First);

            foreach (string str in my_list)
            {
                Console.WriteLine(str);
            }

            // After using Remove(T) method 
            Console.WriteLine("Best students of XYZ" +
                             " university in 2001:");

            my_list.Remove("Anusha");

            foreach (string str in my_list)
            {
                Console.WriteLine(str);
            }

            // After using RemoveFirst() method 
            Console.WriteLine("Best students of XYZ" +
                             " university in 2002:");

            my_list.RemoveFirst();

            foreach (string str in my_list)
            {
                Console.WriteLine(str);
            }

            // After using RemoveLast() method 
            Console.WriteLine("Best students of XYZ" +
                             " university in 2003:");

            my_list.RemoveLast();

            foreach (string str in my_list)
            {
                Console.WriteLine(str);
            }

            // After using Clear() method 
            my_list.Clear();
            Console.WriteLine("Number of students: {0}",
                                         my_list.Count);

            Console.ReadLine();
        }
    }
}
