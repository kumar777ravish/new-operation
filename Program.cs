using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
  
namespace divisiblity_testing
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int sum = 0;
            int rem;
            int res;

            Console.WriteLine("Enter a number");
            n = Convert.ToInt32(Console.ReadLine());
            res = n;
            while (res > 0)
            {
                rem = res % 10;
                sum = sum * 10 + rem;
                res = res / 10;
            }
            Console.WriteLine(res);
            if (res = sum)
            {
                Console.WriteLine("{0} is divisible by 8", n);
            }
            else
            {
                Console.WriteLine("{0} is not divisible by8", n);
            }
            Console.ReadLine();
        }
    }
}
