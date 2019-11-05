using System;

namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Array(4);
        }

        static int[] Array(int num1)
        {
            int[] yes = new int[num1];
            int i = 0;

            while (i < num1)
            {
                yes[i] = i + 1;
                Console.WriteLine(yes[i]);
                i++;
            }
            return yes;
        }
    }
}
