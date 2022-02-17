using System;
using System.Collections;

namespace ArraylistOperations
{
    class ArraylistMgr 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LinkedList.........");
            LinkedListProgram linkedList = new LinkedListProgram();
            Console.WriteLine("Var Keyword............");
            VarKeyword keyword = new VarKeyword();

            Console.WriteLine("List.........");
            ListProgram list1 = new ListProgram();

            Console.WriteLine("ArrayList................");
            ArrayList list = new ArrayList();
            bool acceptFlag = true;
            int i;
            char accept;
            while (acceptFlag)
            {
                Console.WriteLine("Enter Some Integer:");
                i = Convert.ToInt32(Console.ReadLine());
                list.Add(i);
                Console.WriteLine("Do you want to continue? Y/N:");
                accept = Convert.ToChar(Console.ReadLine());
                if (accept == 'y')
                    acceptFlag = true;
                else if (accept == 'n')
                    acceptFlag = false;

            }

            GetList(list);
        }

        private static void GetList(ArrayList list)
        {
            int midIndex = -1;
            Console.WriteLine("number of integers in arraylist= " + list.Count);

            if (list.Count % 2 == 0)
                midIndex = (list.Count / 2) + 1;
            else
                midIndex = list.Count / 2;
            int sum = 0;
            int[] myArray = (int[])list.ToArray(typeof(int));
            foreach (int a in list)
                sum = sum + a;

            int average = sum / list.Count;
            list.Insert(midIndex-1, average);
            Console.WriteLine("After average:");
            Display(list);

            list.RemoveAt(1);

            list.Remove(average);
            Console.WriteLine("After remove index 1 & average:");
            ArrayList.ReadOnly(list);
            Display(list);
            Console.ReadKey();
        }

        private static void Display(ArrayList list)
        {
            foreach (int a in list)
                Console.WriteLine(a);
            Console.WriteLine();
        }
    }
}
