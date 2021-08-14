using System;
using System.Collections.Generic;

namespace RandomNumberGenerator
{
    class RandomNumberGenerator
    {
        static void Main(string[] args)
        {
            RandomNumberGenerator randomNumberGenerator = new RandomNumberGenerator();
            List<int> test1 = randomNumberGenerator.GenerateNumber(5);
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(test1[i]);
            }
        }

        public RandomNumberGenerator()
        {

        }

        public List<int> GenerateNumber(int n)
        {
            int[] array = new int[n];
            List<int> results = new List<int>();
            Random random = new Random();
            int maxValue = n-1;

            for (int i = 0; i < n; i++)
            {
                array[i] = i;
            }

            for(int i = 0; i < n; i++)
            {
                int next = random.Next(maxValue);
                results.Add(array[next]);
                array[next] = array[maxValue];
                maxValue--;
            }

            return results;
        }
    }
}
