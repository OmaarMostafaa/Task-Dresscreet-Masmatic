using System;

    namespace HelloWorld
   {
       class Program
       {
           static void Main(string[] args)          
        {
int y;
int x;
int z;
Console.WriteLine("Max Num");
x = int.Parse(Console.ReadLine());
z = int.Parse(Console.ReadLine());
Console.WriteLine("Min Num");
for (y = int.Parse(Console.ReadLine()); z <= x; y++) ;
            {
                for (z = 2; z <= y; z++)
                    if (y%z==0)
                    {

                        break;
                    }
       if (y == z)
                {
                    Console.WriteLine(y);
                }
            }
        }
     }
 }
