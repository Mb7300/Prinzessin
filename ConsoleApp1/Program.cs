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
            
            Console.WriteLine("h steht für die Position des Heldens der die Prinzessin retten will. p steht für die Position der Prinzessin.");
            Console.WriteLine("Insgesamt darf man je einmal den Buchstaben h und einmal den Buchstaben p verwenden.");
            Console.WriteLine("Die Buchstaben müssen klein geschrieben sein!");
            Console.WriteLine("Geben sie nun ein wie breit ihre Zeile sein soll(3-10)");
                       
            int breite = 0;
            while (breite == 0)
            {                               
                string breiteAlsText = Console.ReadLine();
                try
                {
                    breite = int.Parse(breiteAlsText);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ungültige Eingabe");
                }
            }
            Point h = new Point();
            Point p = new Point();

            for (int y = 0; y < 3; y++) 
            {
                string zeile = Console.ReadLine();
                for (int x = 0; x < 3; x++)
                {
                    char zeichen = zeile[x];
                    if (zeichen  == 'h')
                    {
                        h = new Point(x, y);
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
            Console.WriteLine("H ist an der Stelle: " + h.ToString());
            Console.WriteLine("P ist an der Stelle: " + p.ToString());
            Point weg = new Point(p.X - h.X, p.Y - h.Y);
            Console.WriteLine("Der Weg ist: " + weg.ToString());

            if (weg.X<0)
            {
                for (int x = 0; x < -weg.X; x++)
                {
                    Console.WriteLine("Einmal nach Links");
                }
            } 
            else if (weg.X>0)
            {
                for (int x = 0; x < weg.X; x++)
                {
                    Console.WriteLine("Einmal nach Rechts");
                }
            }
            if (weg.Y < 0)
            {
                for (int y = 0; y < -weg.Y; y++)
                {
                    Console.WriteLine("Einmal nach Oben");
                }
            }
            else if (weg.Y > 0)
            {
                for (int y = 0; y < weg.Y; y++)
                {
                    Console.WriteLine("Einmal nach Unten");
                }
            }
            Console.ReadKey();
           
        }

        private static void ToChar(string breite)
        {
            throw new NotImplementedException();
        }
    }
}
