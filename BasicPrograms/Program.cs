using System;
namespace BasicPrograms;

class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine("Welcome to Basic Programs");
        bool end = true;
        Console.WriteLine("1. FlipCoin\n  2. Leap year \n 3.Power Of Two \n 4.Harmonic no \n 5. End the Program");
        while (end == true)
        {
            Console.WriteLine("Take an option to execute");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    FlipCoin flipCoin = new FlipCoin();
                    flipCoin.Flip();
                    break;
                case 2:
                    LeapYear leapyear = new LeapYear();
                    leapyear.Year();
                    break;
                case 3:
                    PowerOfTwo power = new PowerOfTwo();
                    power.Power();
                    break;
                case 4:
                    HarmonicNo harmonicNo = new HarmonicNo();
                    harmonicNo.harmonicNumber();
                    break;
                case 5:
                    end = false;
                    break;
                default:
                    Console.WriteLine("Enter Proper Option To Execute");
                    break;
            }
        }
    }
}
