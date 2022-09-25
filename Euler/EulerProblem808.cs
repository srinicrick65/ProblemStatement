using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblem
{
    public class EulerProblem808
    {
        public Dictionary<int, int> GetPrimeSquareDictionary(int startNumber, int endNumber)
        {
            Dictionary<int, int> primeNumberSquaresDictionary = new Dictionary<int, int>() { };
            bool isNotPrime;
            for (int i = startNumber; i <= endNumber; i++)
            {
                isNotPrime = false;
                for (int j = 2; j <= i - 1; j++)
                {
                    if (i % j == 0)
                    {
                        isNotPrime = true;
                        break;
                    }
                }
                if (!isNotPrime)
                {
                    primeNumberSquaresDictionary.Add(i ,i*i);
                }
            }

            return primeNumberSquaresDictionary;

        }   
        
        public int ReverseNumber(int num)
        {
            int reverse = 0;
            while (num > 0)
            {
                int remainder = num % 10;
                reverse = (reverse * 10) + remainder;
                num = num / 10;
            }
            return reverse;
        }


            public Dictionary<int,int> GetReversePrimeSquare(int startNum, int endNum)
        {
            Dictionary<int,int> primeSquares = GetPrimeSquareDictionary(startNum, endNum);
            Dictionary<int,int> reversablePrimeSquare = new Dictionary<int, int>() { };


            foreach (var i in primeSquares)
            {
                if (primeSquares.ContainsValue(ReverseNumber(i.Value)) && !reversablePrimeSquare.ContainsValue(i.Value))
                {
                    reversablePrimeSquare.Add(i.Value, ReverseNumber(i.Value));
                    Console.WriteLine($"Key: {i.Key}");
                }
            }

            foreach (KeyValuePair<int, int> kvp in reversablePrimeSquare)
            {
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }

            return reversablePrimeSquare;

            }



    }
}
