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
            
            Console.WriteLine("enter first  number");
            int n1 =int.Parse(Console.ReadLine());
            Console.WriteLine("enter second number");
            int n2 =int.Parse(Console.ReadLine());
            
            Console.WriteLine("perfect numbers are");
            for(int x=n1;x<n2; x++)
            {
                int sum = 0;
                for (int z = 1; z < x; z++)
                {
                    if (x % z == 0)
                        sum = sum + z;
                }

                if (sum == x)
                {
                    Console.WriteLine(x);
                }
            }
      
        }
    }
}

