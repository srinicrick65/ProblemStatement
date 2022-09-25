namespace EulerProblem
{
    public class EulerProblem34
    {
        int ii = 1;
        public void FactorialAndCheckIfCuriusNmber(int[] jj)
        {
            int[] fact = new int[jj.Length];
            for (int i = 0; i < jj.Length; i++)
            {
                if (jj[i] == 1 || jj[i] == 0)
                {
                    fact[i] = 1;
                }
                else
                {
                    for (int j = 1; j <= jj[i]; j++)
                    {
                        ii = ii * j;
                    }

                }
                fact[i] = ii;
                ii = 1;
                Console.WriteLine($"Factorial is fact {fact[i]}");
            }

            int sumOfFactorialOutput = fact.Sum();
            int inputIntArrayToInteger = jj.Select((t, i) => t * Convert.ToInt32(Math.Pow(10, jj.Length - i - 1))).Sum();
            if (inputIntArrayToInteger.Equals(sumOfFactorialOutput))
            {
                Console.WriteLine("Its a Curious Number");
            }
            else
            {
                Console.WriteLine("Its not a Curious Number");
            }

        }

    }
}
