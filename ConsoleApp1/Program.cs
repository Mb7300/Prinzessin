using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Point m = new Point();
            Point p = new Point();

            for (int y = 0; y < 3; y++) 
            {
                string zeile = Console.ReadLine();
                for (int x = 0; x < 3; x++)
                {
                    char zeichen = zeile[x];
                    if (zeichen  == 'm')
                    {
                        m = new Point(x, y);
                        //Ort von m gefunden 

                    } 
                    else if (zeichen == 'p')
                    {
                        p = new Point(x, y);
                        // Ort von p gefunden

                    }
                    else if (zeichen != '-')
                    {
                        Console.WriteLine("Ungültige Zeichen vorhanden, bitte Zeile erneut eingeben!");
                        y--;
                        break;
                    }
                }
            }
            Console.WriteLine("M ist an der Stelle: " + m.ToString());
            Console.WriteLine("P ist an der Stelle: " + p.ToString());
            Point weg = new Point(p.X - m.X, p.Y - m.Y);
            Console.WriteLine("Der Weg ist: " + weg.ToString());

            if (weg.X<0)
            {
                for (int x = 0; x < -weg.X; x++)
                {
                    Console.WriteLine("L");
                }
            } 
            else if (weg.X>0)
            {
                for (int x = 0; x < weg.X; x++)
                {
                    Console.WriteLine("R");
                }
            }
            if (weg.Y < 0)
            {
                for (int y = 0; y < -weg.Y; y++)
                {
                    Console.WriteLine("U");
                }
            }
            else if (weg.Y > 0)
            {
                for (int y = 0; y < weg.Y; y++)
                {
                    Console.WriteLine("D");
                }
            }
            Console.ReadKey();
           
        }
    }
}
