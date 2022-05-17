
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PALLENDROME
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, sum = 0, t,r ;
            Console.WriteLine("Enter the number");
            n = Convert.ToInt32(Console.ReadLine());
            t = n;
            while (n > 0)
            {
                r = n % 10;
                sum = sum * 10 + r;
                n = n / 10;
            }
            if (t == sum)
            {
                Console.WriteLine("{0} is a pallindrome", sum);
            }
            else
            {
                Console.WriteLine("{0} is not a pallindrome", sum);
            }
            Console.ReadLine();

               





                ;
                





        }
    }
}
