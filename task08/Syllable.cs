using System.Text;

namespace Syllable
{
    class Syllable
    {
        public static string[] GetWords(string verse)
        {
            return verse.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        }

        public static string GetSyllable(string word)
        {
            StringBuilder strbldword = new StringBuilder();
            strbldword.Append(word);
            char[] glas = { 'у', 'е', 'а', 'о', 'э', 'я', 'и', 'ё', 'ю','ы'};
            char[] soglarray = "БВГДЖЗЙКЛМНПРСТФХЦЧШЩ".ToLower().ToCharArray();

            for (int i = 0; i < strbldword.Length - 2; i++)
            {
                        if (glas.Contains(strbldword[i]) && soglarray.Contains(strbldword[i+1]) && soglarray.Contains(strbldword[i + 2]) )
                        {
                            strbldword.Insert((i + 2), '-');
                        }
                        else if (glas.Contains(strbldword[i]) && glas.Contains(strbldword[i+1]))
                        {
                            strbldword.Insert((i + 1), '-');
                        }
                        else if (glas.Contains(strbldword[i]) && soglarray.Contains(strbldword[i + 1]) && glas.Contains(strbldword[i + 2]))
                        {
                            strbldword.Insert((i + 1), '-');
                        }
            }
            return strbldword.ToString();
        }
        
    }
}
