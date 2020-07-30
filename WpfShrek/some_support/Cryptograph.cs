using DocumentFormat.OpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfShrek.some_support
{
    public class Cryptograph
    {
        static string alph = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        static string alph2 = alph.ToUpper();
        public static string Encrypt(string input, string key)
        {
            string result="";
            int key_index = 0;
            key = key.ToLower();

            foreach(var symbol in input)
            {
                if (alph.IndexOf(symbol) != -1)
                {
                    int c = (alph.IndexOf(symbol) + alph.IndexOf(key[key_index])) % alph.Length;
                    result += alph[c];
                    key_index++;
                    if (key_index == key.Length) key_index = 0;
                }
                else if (alph2.IndexOf(symbol) != -1)
                {
                    int c = (alph2.IndexOf(symbol) + alph2.IndexOf(key[key_index])) % alph2.Length;
                    result += alph2[c];
                    key_index++;
                    if (key_index == key.Length) key_index = 0;
                }
                else
                {  
                    result += symbol;
                }
            }
            return result;
        }

        public static string Decrypt(string input, string key)
        {
            string result = "";
            int key_index = 0;
            key = key.ToLower();

            foreach (var symbol in input)
            {
                if (alph.IndexOf(symbol) != -1)
                {
                    int p = (alph.IndexOf(symbol) + alph.Length - alph.IndexOf(key[key_index])) % alph.Length;

                    result += alph[p];

                    key_index++;

                    if (key_index == key.Length) key_index = 0;
                }
                else if (alph2.IndexOf(symbol) != -1)
                {
                    int p = (alph2.IndexOf(symbol) + alph2.Length - alph2.IndexOf(key[key_index])) % alph2.Length;
                    result += alph2[p];
                    key_index++;
                    if (key_index == key.Length) key_index = 0;
                }
                else
                {
                    result += symbol;
                }
            }
            return result;
        }


    }
}
