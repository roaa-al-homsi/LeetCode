using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Program
    {

        static public bool IsPowerofTwo(int n)
        {
            if (n <= 0)
                return false;
         

            int Result = (int)Math.Log(n,2 );
            return (Math.Pow( 2,Result) == n);
            /*
             
             n*(n-1)==0
             
             */
           
        }

        static void Main(string[] args)
        {
            Console.WriteLine(IsPowerofTwo(1));
            Console.ReadKey();

        }
    }
}
