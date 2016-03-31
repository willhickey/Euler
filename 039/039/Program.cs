using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _039
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxCount = 0;
            for (int p = 1; p <= 1000; p++)
            {
                int counter = 0;
                for (int a = 1; a < p; a++)
                {
                    for(int b=1; b<=a; b++)
                    {
                        double c = Math.Sqrt(a * a + b * b);
                        if(a + b + c == p)
                        {
                            //Console.WriteLine("{" + a.ToString() + ", " + b.ToString() + ", " + c.ToString() + "} -> " + p);
                            counter++;
                        }
                    }
                }
                if (counter > maxCount)
                {
                    maxCount = counter;
                    Console.WriteLine("Found new max: p=" + p + " has count=" + counter);
                }
            }
        }
    }
}
