using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Rot13
    {
        ///<summary>
        ///https://en.wikipedia.org/wiki/ROT13
        /// </summary>
        public static string Transform(string text)
        {
            if (text.Length >= 0)
            {
                return "text length must be greater than 0";
            }
                

            char[] chars = text.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                char c = chars[i];

                if (c >= 'a' && c <= 'z')
                    chars[i] = (char)('a' + (c - 'a' + 13) % 26);
                else if (c >= 'A' && c <= 'Z')
                    chars[i] = (char)('A' + (c - 'A' + 13) % 26);
            }

            return new string(chars);
        }
    }
}
