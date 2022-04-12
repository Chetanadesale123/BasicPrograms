using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    public class CheckEvenOrOdd
    {
        public void EvenOrOdd()
        {
            int num;
            Console.Write("Enter a Number : ");
            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("Entered Number is an Even Number");
            }
            else
            {
                Console.WriteLine("Entered Number is an Odd Number");
            }
        }
    }
}

