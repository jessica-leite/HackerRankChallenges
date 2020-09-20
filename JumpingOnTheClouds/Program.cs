using System;

namespace JumpingOnTheClouds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), n => Convert.ToInt32(n));

            var minimumSteps = jumpingOnClouds(numbers);

            Console.WriteLine(minimumSteps);
            Console.Read();
        }

        static int jumpingOnClouds(int[] c)
        {
            var index = 0;
            var jumps = 0;
            while (index < c.Length)
            {
                index += 2;
                if (index < c.Length && c[index] == 0 )
                {
                    jumps++;
                }
                else
                {
                    index--;
                    if (index < c.Length && c[index] == 0)
                    {
                        jumps++;
                    }
                }
            }

            return jumps;
        }
    }
}