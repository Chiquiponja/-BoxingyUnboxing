using System;
using System.Collections.Generic;
using System.Threading;

namespace boxingunboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Diagnostics.Stopwatch timer = new System.Diagnostics.Stopwatch();
            System.Diagnostics.Stopwatch timer1 = new System.Diagnostics.Stopwatch();
            Console.WriteLine(" ");
            int num = 1000000;
            timer.Start();
            Stack<object> PILA = new Stack<object>();
            for (int i = 0; i < num; i++)
            {
                PILA.Push(i);
            }
            while (PILA.Count > 0)
            {
                Console.WriteLine(PILA.Pop());
            }
            timer.Stop();
           
            Console.WriteLine("TOTAL : "+timer.Elapsed.TotalSeconds);
            //timer.Reset();
            Console.ReadKey();
            timer1.Start();
            Console.WriteLine(" ");
            Stack<int> pilam = new Stack<int>();
            for (int i = 0; i <= num; i++)
            {
                pilam.Push(i);
            }
            while (pilam.Count > 0)
            {
                Console.WriteLine(pilam.Pop());
            }
            timer1.Stop();
            Console.WriteLine("TOTAL : "+timer1.Elapsed.TotalSeconds);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Con Boxing y Unboxing: " + timer.Elapsed.TotalSeconds);
            Console.WriteLine("Con Generic : " + timer1.Elapsed.TotalSeconds);
            Console.ReadKey();
        }
    }
}
