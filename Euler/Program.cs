using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EulerProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            EulerProblem34 problem34 = new EulerProblem34();
            Console.WriteLine("****Eulers Problem 34 executing****");
            problem34.FactorialAndCheckIfCuriusNmber(new int[] { 4, 0, 5, 8, 5 });
            Console.WriteLine("****Eulers Problem 34 executed****");

            EulerProblem49 problem49 = new EulerProblem49();
            Console.WriteLine("****Eulers Problem 49 executing****");
            var sol49 = problem49.PrimeSequenceAndPermutation();
            Console.WriteLine($"****Eulers Problem 49 executed****");

            EulerProblem808 problem808 = new EulerProblem808();
            Console.WriteLine("****Eulers Problem 808 executing****");
            problem808.GetReversePrimeSquare(11,20000);
            Console.WriteLine($"****Eulers Problem 808 executed****");


            HackerRankSalesByMatchProblem problemstatement = new HackerRankSalesByMatchProblem();
            Console.WriteLine("**** HackerRankSalesByMatchProblem executing****");
            List<int> ar = new List<int>() { 10, 20, 20, 10, 10, 30, 50, 10, 20 }; //= Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();
            int n = 9;
            int result = problemstatement.sockMerchant(n, ar);
            Console.WriteLine(result);
            Console.WriteLine($"****HackerRankSalesByMatchProblem executed****");

        }

    }
}


