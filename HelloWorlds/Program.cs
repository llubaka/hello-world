using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HelloWorlds
{
    class Program
    {
        static void Main(string[] args)
        {
            var hw = "Hello world!";

            PrintHelloWorld(hw);

            Console.ReadLine();
        }

        private static void PrintHelloWorld(string hw)
        {
            foreach (var c in hw)
            {
                Console.Write(c);
                Thread.Sleep(60);
            }
            Console.Clear();

            for (int i = 0; i < hw.Length; i++)
            {
                Console.Clear();
                Console.WriteLine(hw.Remove(hw.Length - 1 - i));

                Thread.Sleep(100);
            }
        }
    }
}
