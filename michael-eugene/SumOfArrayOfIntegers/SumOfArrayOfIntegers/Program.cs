using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfArrayOfIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int totalSum = 0;
            foreach (int number in numbers)
            {
                totalSum += number;
            }
            Console.WriteLine(totalSum);
        }
    }
}
