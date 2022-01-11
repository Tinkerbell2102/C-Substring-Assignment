using System;

namespace PRGLaikinFA1
{
    class TestSearchReplace
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter a string: ");
            string str = Console.ReadLine();

            Console.Write("Please enter a substring you wish to find: ");
            string substr = Console.ReadLine();

            Console.Write("Please enter a string to replace the given stubstring:  ");
            string charRep = Console.ReadLine();


            ReplaceSubString.SearchSubstring(str, substr, charRep);
            ReplaceSubString.ReplaceSubStr(str, substr, charRep);
        }
    }

    public class ReplaceSubString
    {
        public static void ReplaceSubStr(string str, string substr, string charRep)
        {
            //display find string
            Console.Write("Your new string is : " + str.Replace(substr, charRep));
        }
        public static Boolean SearchSubstring(string str, string substr, string charRep)
        {
            return str.Contains(substr);

        }
    }
}

