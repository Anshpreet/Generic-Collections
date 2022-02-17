using System;
using System.Collections.Generic;
using System.Text;

namespace ArraylistOperations
{
   public class ListProgram
    {
        public ListProgram()
        {
            List<int> primeNumbers = new List<int>();
            primeNumbers.Add(1); 
            primeNumbers.Add(3);
            primeNumbers.Add(5);
            primeNumbers.Add(7);

            foreach(int p in primeNumbers)
            {
                Console.WriteLine(p);
            }
            primeNumbers.RemoveRange(0, 2);
            Console.WriteLine("After removing elements from list");
            foreach (int p in primeNumbers)
            {
                Console.WriteLine(p);
            }
            Console.ReadLine();
        }
    }
}
