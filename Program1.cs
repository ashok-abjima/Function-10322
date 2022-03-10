using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;

            
            num1 = Convert.ToInt32(Console.ReadLine());
           
            num2 = Convert.ToInt32(Console.ReadLine());
           
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.Write("The 1st Number is the greatest");
                }
                else
                {
                    Console.Write("The 3rd Number is the greatest");
                }
            }
            else
            if (num2 > num3)
                Console.Write("The 2nd Number is the greatest");
            else
                Console.Write("The 3rd Number is the greatest");


            Console.ReadKey();
        }
    

    }
}
