using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Program
    {
        #region 
        private static string RemoveAllnonalphanumericCharacters(string s)
        {
            string ReadyToCheck = "";
            foreach (char c in s)
            {
                if (char.IsLetterOrDigit(c))
                {
                    ReadyToCheck += char.ToLower(c);
                }
            }

            return ReadyToCheck;
        }
        static public bool IsPalindromeWithReverse(string s)
        {
            if (s == " ")
                return true;

            string ReadyToCheck = "";
            ReadyToCheck = RemoveAllnonalphanumericCharacters(s);

            char[] charArray = ReadyToCheck.ToCharArray();

            Array.Reverse(charArray);
            string reversedString = new string(charArray);

            return ReadyToCheck.Equals(reversedString);



        }

        private static bool IsPalindromwithCompareInLoop(string s)
        {
            if (s == " ")
                return true;

            s = RemoveAllnonalphanumericCharacters(s);

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != s[s.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }

        private static bool IsPalindromwithTwoPointers(string s)
        {
            if (s == " ")
                return true;

          
            int Left = 0;
            int Right = ReadyToCheck.Length - 1;

            while (Left < Right)
            {


                if (!char.IsLetterOrDigit(s[Left]))
                {
                    Left++;
                    continue;
                }

                if (!char.IsLetterOrDigit(s[Right]))
                {
                    Right--;
                    continue;
                }

                if (ReadyToCheck[Left] != ReadyToCheck[Right])
                    return false;


                Left++;
                Right--;

            }
            return true;
        }
        #endregion 



        static void Main(string[] args)
        {
            Console.Write(IsPalindromwithCompareInLoop("A man, a plan, a canal: Panama"));

            Console.ReadKey();


        }
    }
}
