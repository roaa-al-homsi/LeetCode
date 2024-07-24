using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Program
    {

        static public int Reverse(int x)
        {
            int Remainder = 0;
            int NewNum = 0;

            while (x != 0)
            {
                Remainder = x % 10;
                if (NewNum > int.MaxValue / 10 || (NewNum == int.MaxValue / 10 && Remainder > 7)) return 0;
                if (NewNum < int.MinValue / 10 || (NewNum == int.MinValue / 10 && Remainder < -8)) return 0;
                x = x / 10;
                NewNum = NewNum * 10 + Remainder;
            }

            return NewNum;
        }
        static public bool IsPalindrome(int x)
        {
            if (x < 0) return false;


            int NumReverse = Reverse(x);

            return (NumReverse == x);


        }

        static void Main(string[] args)
        {
         
            Console.WriteLine(IsPalindrome(-121));
            Console.ReadKey();

        }


    }
    }

