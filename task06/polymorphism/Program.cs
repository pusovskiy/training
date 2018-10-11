using System;

namespace task06_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rose rose = new Rose();
            Tulips tulips = new Tulips();
            GoldenFlower goldenFlower = new GoldenFlower();

            rose.Count = 2;
            rose.Cost = 300;
            rose.Discount = 15;
            tulips.Count = 1;
            tulips.Cost = 200;
            tulips.Discount = 5;
            tulips.Discount = 15;
            goldenFlower.Cost = 1000;
            goldenFlower.Count = 1;

            Flowers[] bouquet = { rose, tulips, goldenFlower };
            int sum = 0;
            foreach(Flowers flower in bouquet)
            {  
               sum += flower.GetCost();
            }

            Console.WriteLine($"Total bill for flowers:{sum}");
            Console.ReadKey();
        }
    }
}
