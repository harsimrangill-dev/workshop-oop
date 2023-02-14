using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903MWorkshopCode
{
    class Atbash
    {
        public string encode(string text)
        {
            string encoded = "";
            int len = text.Length;
            for (int i = 1; i <= len; i++)
            {
                encoded = encoded + Convert.ToString(text[len - i]);
            }
            return encoded;
        }

        public string decode(string text)
        {
            string decoded = "";
            int len = text.Length;
            for (int i = 1; i <= len; i++)
            {
                decoded = decoded + Convert.ToString(text[len - i]);
            }
            return decoded;
        }
        
    }
}
