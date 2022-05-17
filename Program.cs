using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace divisibility_rule_of_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int rem;
            int sum = 0;
            Console.WriteLine("Enter a number");
            n = Convert.ToInt32(Console.ReadLine());

            if (n % 11 == 0)
            {
                Console.WriteLine("{0} is divisible by 11", n);
            }
            else
            {
                Console.WriteLine("{0} is not divisible by 11", n);
            }
            Console.ReadLine();
            
                



               
        }
    }
}
