using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Program
    {

        private static bool IsPalindromwithTwoPointers(string s)
        {
            if (s == " ")
                return true;

            int Left = 0;
            int Right =s.Length - 1;
            while (Left < Right)
            {
                if (s[Left] != s[Right])
                    return false;


                Left++;
                Right--;

            }
            return true;
        }


        static public string FirstPalindrome(string[] words)
        {

            foreach (string Word in words)
            {
                if (IsPalindromwithTwoPointers(Word))
                {
                    return Word;
                }
            }
            return " ";

        }



        static void Main(string[] args)
        {

            string[] word = { "def", "ghi" };

            Console.WriteLine(FirstPalindrome(word));



            Console.ReadKey();

        }


    }
}

