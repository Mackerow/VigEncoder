using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace VigEncoder
{
    public class VigenerCode:  CodeMethods
    {
        public static string Encode(string input, string keyword)
        {
            string result = "";
            int j = 0;
            int index = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (Alf.Contains(input[i]))
                {
                    if (StringToInt(input[i]) <= 33)
                    {
                        index = EnRotate(input[i], keyword[j]);
                        result += IntToString(index);
                    }
                    else
                    {
                        index = EnRotate(input[i], keyword[j]);
                        index += 33;
                        result += IntToString(index);
                    }
                    j++;
                }
                else
                {
                    result += input[i];
                }
                if (j==keyword.Length)
                {
                    j = 0;
                }
            }
            return result;
        }
        public static string Decode(string input, string keyword)
        {
            string result = "";
            int j = 0;
            int index = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (Alf.Contains(input[i]))
                {
                    if (StringToInt(input[i]) <= 33)
                    {
                        index = DeRotate(input[i], keyword[j]);
                        result += IntToString(index);
                    }
                    else
                    {
                        index = DeRotate(input[i], keyword[j]);
                        index += 33;
                        result += IntToString(index);
                    }
                    j++;
                }
                else
                {
                    result += input[i];
                }
                if (j == keyword.Length)
                {
                    j = 0;
                }
            }
            return result;
        }
    }
}