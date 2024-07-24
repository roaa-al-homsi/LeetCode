using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Program
    {

        static bool isAnagram(string s, string t)
        {
            if (s.Length != t.Length)
                return false;

            List<char> Search = new List<char>(s);
            foreach(char i in t)
            {
                if (Search.Contains(i))
                {
                    Search.Remove(i);
                }
                else
                    return false;
            }
       
            return true;
        }

        static void Main(string[] args)
        {
            Console.Write(isAnagram("anagram", "nagaram"));

            Console.ReadKey();


        }
    }
}
