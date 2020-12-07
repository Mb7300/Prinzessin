using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] raster = new char[3,3];
            for(int zeile = 0; zeile < raster.Length; zeile++)
            {
                string input = Console.ReadLine();
                Console.WriteLine(input);
            }
        }
    }
}
