using System;


namespace Syllable
{
    class Program
    {
        static void Main(string[] args)
        {
            string verse = "Я сразу смазал карту будня,\n " +
                "плеснувши краску из стакана;\n " +
                "я показал на блюде студня\n" +
                " косые скулы океана.\n" +
                " На чешуе жестяной рыбы\n" +
                " прочёл я зовы новых губ.\n" +
                " А вы\n" +
                " ноктюрн сыграть\n" +
                " могли бы\n" +
                " на флейте водосточных труб?";

            Console.WriteLine($"{verse} \n");
            string[] words = Syllable.GetWords(verse);
            foreach (string word in words)
            {
                Console.Write(Syllable.GetSyllable(word)+ " ");
            }

            Console.ReadKey();
        }
    }
}
