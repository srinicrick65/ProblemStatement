using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblem
{
    public class EulerProblem49
    {
        public IList<int> PrimeNumbersList(int startNumber, int endNumber)
        {
            IList<int> primeNumberList = new List<int> { };
            bool isNotPrime;
            for (int i = startNumber; i <= endNumber; i++)
            {
                isNotPrime = false;
                for (int j = 2; j <= i-1 ; j++)
                {
                    if (i % j == 0)
                    {
                        isNotPrime = true;
                        break;
                    }
                }
                if (!isNotPrime)
                {
                    primeNumberList.Add(i);
                }
            }

            return primeNumberList;

        }

        public IList<string> PrimeSequenceAndPermutation()
        {
            IList<int> primeNumberList = PrimeNumbersList(1000, 9999);
            int primeSecond;
            int primeThird;
            IList<string> primeSequence = new List<string> { };
            int primeDiff = 3330;
            foreach (int i in primeNumberList)
            {
                primeSecond = i + primeDiff;
                primeThird = primeSecond + primeDiff;
                if (primeNumberList.Contains(primeSecond) && primeNumberList.Contains(primeThird))
                {
                    string primeFirstString = string.Concat(i.ToString().OrderBy(c => c));
                    string primeSecondString = string.Concat(primeSecond.ToString().OrderBy(c => c));
                    string primeThirdString = string.Concat(primeThird.ToString().OrderBy(c => c));

                    if (primeFirstString.Equals(primeSecondString) && primeFirstString.Equals(primeThirdString))
                    {
                        primeSequence.Add(i.ToString() + primeSecond.ToString() + primeThird.ToString());
                    }
                }
            }
            foreach (var j in primeSequence)
            {
                Console.WriteLine(j);
            }
            return primeSequence;
        }







    }
}
