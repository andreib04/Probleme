using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Threading;
namespace binaryclock
{
    internal class Program
    {
        static void Main()
        {
            for(; ; )
            {
                DateTime now = DateTime.Now;
                string hour = now.ToString("HH");
                string min = now.ToString("mm");
                string sec = now.ToString("ss");
                

                int h = int.Parse(hour);
                int h1 = h / 10;
                int h2 = h % 10;

                int m = int.Parse(min);
                int m1 = m / 10;
                int m2 = m % 10;

                int s = int.Parse(sec);
                int s1 = s / 10;
                int s2 = s % 10;
                //ora
                string binH1 = Convert.ToString(h1, 2);
               
                string binH2 = Convert.ToString(h2, 2);
                //minut
                string binM1 = Convert.ToString(m1, 2);
                string binM2 = Convert.ToString(m2, 2);
                //secunda
                string binS1 = Convert.ToString(s1, 2);
                string binS2 = Convert.ToString(s2, 2);

                int bh1 = int.Parse(binH1);
                int bh2 = int.Parse(binH2);
                int bm1 = int.Parse(binM1);
                int bm2 = int.Parse(binM2);
                int bs1 = int.Parse(binS1);
                int bs2 = int.Parse(binS2);


                //Console.WriteLine($"{hour}: {min}: {sec}");
                //Console.WriteLine($"{binH1} {binH2}:{binM1} {binM2}:{binS1} {binS2}");

                Console.WriteLine("  " + bh1 / 1000 + " | " + "  " + bm2 / 1000 + " | " + "  " + bh2 / 1000);
                Console.WriteLine("  " + (bh2 / 100) % 10 + " | " + (bm1 / 100) % 10 + " " + (bm2 / 100) % 10 + " | " + (bs1 / 100) % 10 + " " + (bs2 / 100) % 10);
                Console.WriteLine((bh1 / 10) % 10 + " " + (bh2 / 10) % 10 + " | " + (bm1 / 10) % 10 + " " + (bm2 / 10) % 10 + " | " + (bs1 / 10) % 10 + " " + (bs2 / 10) % 10);
                Console.WriteLine(bh1 % 10 + " " + bh2 % 10 + " | " + bm1 % 10 + " " + bm2 % 10 + " | " + bs1 % 10 + " " + bs2 % 10);
                Console.WriteLine();
                Console.WriteLine($"{hour}  : {min}  : {sec}");
                Thread.Sleep(1000);
                Console.Clear();
                

            }
        }
    }
}
