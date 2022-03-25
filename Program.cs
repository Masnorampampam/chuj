using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace SzyfrCezara
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("O ile przesunać?");
            int cezar;
            cezar = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Jaki Teskt zamienić?");
            foreach (var c in Console.ReadLine)
            {
                Console.WriteLine(Convert.ToChar((c - 'a' + cezar) % ('z' - 'a' + cezar) + 'a'));
            }
            Console.WriteLine();
            Console.ReadKey(true);
        }
    }
}