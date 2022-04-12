using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    public class FlipCoin
    {
        const double IS_TAIL = 0.5;
        int headCount = 0, tailCount = 0;
        public void Flip()
        {
            Console.WriteLine("Enter number of flips");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                while (num > 0)
                {
                    Random random = new Random();
                    double option = random.NextDouble();
                    if (option < IS_TAIL)
                    {
                        tailCount++;
                    }
                    else
                    {
                        headCount++;
                    }
                    num--;
                }
            }

            Console.WriteLine("tailCount : " + tailCount);
            Console.WriteLine("headCount : " + headCount);
            double HeadCountPercentage = headCount % 100;
            double tailCountPercentage = tailCount % 100;
            Console.WriteLine("Percentage of the HEAD :" + " " + HeadCountPercentage);
            Console.WriteLine("percentage of the TAIL :" + " " + tailCountPercentage);

        }
    }
}







