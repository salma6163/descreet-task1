// problem4
using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;

namespace problem
{
    public static class program
    {
        static void Main()
        {
            Console.WriteLine("please enter the first number");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter the second number");
            int n2 = int.Parse(Console.ReadLine());

            for (n1 = 5; n1 <= n2; n1 += 2)
            {
                do
                {

                    Console.WriteLine("prime number is "+n1);
                    n1 += 2;
                } while (n1 <= n2 && (n1 % 3 == 1));
            }
       
            
            
               
            
        
            
        }
       
    }
}
