using System;
using System.Collections.Generic;
using System.Threading;

namespace HackerRank
{
    class Program
    {
        static int jumpingOnClouds(int[] c)
        {
            int jumps = 0;
            int i = 0;

            while (i < c.Length - 1)
            {
                if (c[i] == 0)
                {
                    if (i < c.Length - 2)
                    {
                        if (c[i + 2] == 0)
                        {
                            jumps++;
                            i += 2;
                        }
                        else if (c[i + 1] == 0)
                        {
                            jumps++;
                            i++;
                        }
                    }
                    else if (c[i + 1] == 0)
                    {
                        jumps++;
                        i++;
                    }
                }
                else
                {
                    i++;
                }
            }
            return jumps;
        }


        static void Main(string[] args)
        {
            int[] a = { 0, 0, 1, 0, 0, 1, 0};
            Console.WriteLine(jumpingOnClouds(a));
        }
    }
}
