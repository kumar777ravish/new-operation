using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace divisible_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int sum = 0;
            int rem = 0;
            int res = 0;
            Console.WriteLine("Enter a number");
            n = Convert.ToInt32(Console.ReadLine());
            res = n;
            while (res > 0)
            {
                rem = res % 10;
                sum = sum + rem;
                res = res / 10;
            }
            Console.WriteLine(sum);
            if (n % 3 == 0)
            {
                Console.WriteLine("{0} is divisible by 9", n);
            }
            else
            {
                Console.WriteLine("{0} is not divisible by 9", n);
            }

            Console.ReadLine();
        }
    }
}


