using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Syllable
{
    class Syllable
    {
        public static string[] GetWords(string verse)
        {
            return verse.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        }
        public string CompileText(string[] words)
        {
            return string.Join(" ", words);
        }

        public static string GetSyllable(string word)
        {
            StringBuilder result = new StringBuilder();
            result.Append(word);
            char[] glas = { 'у', 'е', 'а', 'о', 'э', 'я', 'и', 'ё', 'ю','ы'};
            char[] soglarray = "БВГДЖЗЙКЛМНПРСТФХЦЧШЩ".ToLower().ToCharArray();

            for (int i = 0; i < result.Length - 2; i++)
            {
                        if (glas.Contains(result[i]) && soglarray.Contains(result[i+1]) && soglarray.Contains(result[i + 2]) )
                        {
                            result.Insert((i + 2), '-');
                        }
                        else if (glas.Contains(result[i]) && glas.Contains(result[i+1]))
                        {
                            result.Insert((i + 1), '-');
                        }
                        else if (glas.Contains(result[i]) && soglarray.Contains(result[i + 1]) && glas.Contains(result[i + 2]))
                        {
                            result.Insert((i + 1), '-');
                        }
            }
            return result.ToString();
        }
        
    }
}