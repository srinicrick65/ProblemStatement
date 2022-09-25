using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * https://www.hackerrank.com/challenges/sock-merchant/problem
 There is a large pile of socks that must be paired by color. Given an array of integers representing the color of each sock, determine how many pairs of socks with matching colors there are.

Example
n=7
ar = [1,2,1,2,1,3,2]

There is one pair of color  1 and one of color 2. There are three odd socks left, one of each color. The number of pairs is 2.

Function Description
Complete the sockMerchant function in the editor below.

sockMerchant has the following parameter(s):

int n: the number of socks in the pile
int ar[n]: the colors of each sock


Returns
int: the number of pairs


Input Format
The first line contains an integer , the number of socks represented in ar.
The second line contains  space-separated integers,ar[i] , the colors of the socks in the pile.

Constraints
1<=n<=100

Sample Input

STDIN                       Function
-----                       --------
9                           n = 9
10 20 20 10 10 30 50 10 20  ar = [10, 20, 20, 10, 10, 30, 50, 10, 20]

Sample Output 
3
*/
namespace EulerProblem
{
    public class HackerRankSalesByMatchProblem
    {
        public int sockMerchant(int n, List<int> ar)
        {
            int sockPair = 0;
            int colorValue = 1;
            Dictionary<int, int> colorSet = new Dictionary<int, int>();
            if (n >= 1 && n <= 100)
            {
                for (int i = 0; i < ar.Count; i++)
                {
                    if (!colorSet.ContainsKey(ar[i]))
                    {
                        for (int j = i + 1; j < ar.Count; j++)
                        {
                            if (ar[i] == ar[j])
                            {
                                colorValue = colorValue + 1;
                            }
                        }
                        colorSet.Add(ar[i], colorValue);
                    }
                    colorValue = 1;
                }

                foreach (var pair in colorSet)
                {
                    sockPair = sockPair + pair.Value / 2;
                }
            }
            return sockPair;
        }

    }
}
