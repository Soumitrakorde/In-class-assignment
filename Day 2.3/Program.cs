using System;

namespace Day_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            //max heart rate is equal to 220-age
            int m;

            x = 23;
            y = 186;
            m = 220 - x;

            Console.WriteLine(" I am " + x + " years old, my heart rate is " + m + " and I am " + y +  " centimeter tall. ");
            Console.ReadLine();
        }
    }
}