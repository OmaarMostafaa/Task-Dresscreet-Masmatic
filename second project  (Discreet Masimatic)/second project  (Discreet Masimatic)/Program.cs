using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace second_project___Discreet_Masimatic_
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n1 , n2 , num, i;
            Console.WriteLine("Min");
            n1=int.Parse(Console.ReadLine());
            Console.WriteLine("Max");
            n2 = int.Parse(Console.ReadLine());
            for (num = n1; num <= n2; num++)
            {
                decimal sum = 0;
                for (i = 1; i < num; i++)
                {
                    if (num % i == 0)
                        sum = sum + 1;
                }
                if (sum == num)
                { Console.WriteLine(num);
                }
            }
        }
    }
}
