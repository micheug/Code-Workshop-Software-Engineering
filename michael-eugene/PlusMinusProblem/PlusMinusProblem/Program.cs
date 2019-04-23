using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlusMinusProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] integers = { -4, -3, -2, -1, 0, 1, 2, 3, 4 };
            double pos = 0;
            double neg = 0;
            double zero = 0;

            foreach (double integer in integers)
            {
                if (integer < 0)
                {
                    neg++;
                }
                else if (integer > 0)
                {
                    pos++;
                }
                else
                {
                    zero++;
                }
            }

            Console.WriteLine($"The Fraction of Positive Numbers is {pos / integers.Length}");
            Console.WriteLine($"The Fraction of Zero Numbers is {zero / integers.Length}");
            Console.WriteLine($"The Fraction of Negative Numbers is {neg / integers.Length}");
        }
    }
}
