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


        private static bool IsPalindromwithCompareInLoop(string s)
        {
            if (s == " ")
                return true;

            string ReadyToCheck = RemoveAllnonalphanumericCharacters(s);

            for (int i = 0; i < ReadyToCheck.Length; i++)
            {
                if (ReadyToCheck[i] != ReadyToCheck[ReadyToCheck.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }

        public static string  LongestPalindromString(string[] ArrOrginalString)
        {
            string LengthLongPalindromString = "-1";

            foreach (string s in ArrOrginalString)
            {
               if ( IsPalindromwithCompareInLoop(s))
               {
                    if(s.Length > LengthLongPalindromString.Length)
                    LengthLongPalindromString = s;
               }

            }

            return LengthLongPalindromString;
        }




        #endregion

        static void Main(string[] args)
        {

            string[] Arrstring = { "eye", "california", "12321", "Level", "Was it a cat I saw" };

            string[] Arrstring2 = { "Dubai", "amman", "Cairo", "fes"};


            Console.Write(LongestPalindromString(Arrstring2));

            Console.ReadKey();


        }
    }
}
