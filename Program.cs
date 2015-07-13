using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            double ans = 1;
            Console.WriteLine("Enter a number: ");
            number = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                ans *= i+1;
            }
            Console.WriteLine("{0}! = {1}", number, ans);
            Console.ReadKey();
            

        }
    }
}
