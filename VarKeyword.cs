using System;
using System.Collections.Generic;
using System.Text;

namespace ArraylistOperations
{
   public class VarKeyword
    {

        public VarKeyword()
        {
            var varInt = 1;
            var varChar = 'a';
            var varString = "abcdef";
            Console.WriteLine("{0}\n{1}\n{2}", varInt, varChar, varString);

            //array
            var aInt = new int[] { 1, 2, 3, 4, 5, 6 };
            foreach (var item in aInt)
            {
                Console.Write(item);
            }

            Console.ReadLine();
        }
    }
}
