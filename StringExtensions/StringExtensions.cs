using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethods
{
    public static class StringExtensions
    {
        public static string Capitalize(this String str)
        {
            string first =  str[0].ToString().ToUpper();
            return first + str.Substring(1);
        }
        public static string ToCamelCase(this String str)
        {
            StringBuilder sb = new StringBuilder();
            string[] parts = str.Split(" ");
            foreach( string part in parts)
            {
                sb.Append(part.ToLower().Capitalize());
            }
            return sb.ToString();
        }

        public static int WordCount(this String str)
        {
            string[] parts = str.Split(new char[] {' ', '\n', ',', '\t'  }, StringSplitOptions.RemoveEmptyEntries);
            return parts.Length;
        }

        public static string Smurf(this string s, string toReplace)
        {
            return s.Replace(toReplace, "Smurf");
        }
    }
}
