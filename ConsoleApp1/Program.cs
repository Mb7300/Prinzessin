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
            for (int y = 0; y < 3; y++) 
            {
                string zeile = Console.ReadLine();
                for (int x = 0; x < 3; x++)
                {
                    char zeichen = zeile[x];
                    if (zeichen  == 'm')
                    {
                        //Ort von m gefunden 

                    } 
                    else if (zeichen == 'p')
                    {

                        // Ort von p gefunden

                    }
                    else if (zeichen!= '-')
                    {
                        Console.WriteLine("Ungültige Zeichen vorhanden, bitte Zeile erneut eingeben!");
                        y--;
                        break;
                    }
                }
            }
        }
    }
}
