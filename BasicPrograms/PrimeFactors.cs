using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    public class PrimeFactors
    {
        public void PrimeFactor()
        {
            Console.WriteLine("Enter the number");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= n; i++)
            {
                if (n % i == 0)
                {
                    int Count = 0;
                    while (n % i == 0)
                    {
                        n = n / i;
                        Count++;
                    }
                    Console.WriteLine(i + " " + "^" + Count);
                }
            }


        }
    }
}


