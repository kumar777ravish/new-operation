using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ravish.test2nd
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B;
            Console.WriteLine("Enter the number");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number");
            B = Convert.ToInt32(Console.ReadLine());
            int rem = A % B;

            if (rem > 5)
            {
                Console.WriteLine("rem is greater than 5");
            }
            else if (rem > 5)
            {
                Console.WriteLine("rem is less than 5");
            }

            Console.ReadLine();



        }

    }
}




