using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Program
    {

        static private void Swap(ref char a, ref char b)
        {
            char temp = a;
            a = b;
            b = temp;
        }

        static private void ReverseString(char[] s)
        {
           //using two pointers
            int Left = 0;
            int Right = s.Length - 1;
            while(Left <= Right)
            {
                Swap (ref s[Left] ,ref s[Right]);
                Left++;
                Right--;
            }


        }

        static void Main(string[] args)
        {
            char[] schar = { 'h','e', 'l', 'l', 'o' };
            Console.WriteLine(schar);
            ReverseString(schar);

            Console.WriteLine(schar);
            Console.ReadKey();

        }


    }
    }

