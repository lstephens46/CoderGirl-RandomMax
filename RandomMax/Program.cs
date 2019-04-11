using System;
using System.Linq;

namespace RandomMax
{
    public static class Program
    {
        public static void Main()
        {
           

            int  Min = 0;
            int Max = 1000;
            System.Random randNum = new Random();
            int[] myArray = Enumerable
                .Repeat(0, 1000)
                .Select(i => randNum.Next(Min, Max))
                .ToArray();
            int largestNumber = myArray.Max();
            Console.WriteLine(largestNumber);
            Console.ReadLine();

          

        }
    }
}
