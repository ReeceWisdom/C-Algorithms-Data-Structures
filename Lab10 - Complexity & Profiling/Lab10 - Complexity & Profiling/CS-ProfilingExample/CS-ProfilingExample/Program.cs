using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace CS_ProfilingExample
{
    class Program
    {
        static public long MethodA(int n)
        {
            long  sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum = sum + i;
            }
            return sum;
        }

        static public long  MethodB(int n)
        {
            long sum = 0;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    sum = sum + 1;
                }
            }
            return sum;
        }

        static public long MethodC(int  n)
        {
            return  (long) n * (n + 1) / 2; 
        }


        static void Main(string[] args)
        {
           
            int x = 5000;
            
            Console.WriteLine("Method A sum to {0} is {1}", x, MethodA(x));
            Console.WriteLine("Method B sum to {0} is {1}", x, MethodB(x));
            Console.WriteLine("Method C sum to {0} is {1}", x, MethodC(x));
            
            Console.ReadKey();
        }
    }
}
