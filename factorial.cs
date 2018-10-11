using System;

namespace factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] result = Fact(100);
            int i = result.Length - 1;
            while (i > 0 && result[i] == 0)
            {
                i--;
            }
            while (i >= 0)
            {
                Console.Write(result[i--]);
            }
            
            Console.ReadKey();
        }

        static int[] Fact(int n)
        {
            int[] arr = new int[160];
            arr[0] = 1;
            for (int i = 1; i <= n; i++)
            {
                int transfer = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    int x = arr[j] * i + transfer;
                    arr[j] = x % 10;
                    transfer = x / 10;
                }
            }
            return arr;
        }
    }
}
