using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(); //stworzylismy obiekt klasy Point, ktora zawiera w sobie 3 zmienne x, y i sym
            p1.x = 1; //tutaj przypisujemy wartosci zmiennym
            p1.y = 3;
            p1.sym = '*';
           p1.Draw();

            Point p2 = new Point(); //stworzylismy drugi obiekt klasy Point, ktora zawiera w sobie 3 zmienne x, y i sym
            p2.x = 4;
            p2.y = 5;
            p2.sym = '#';
            p2.Draw();

            Console.ReadLine();
        }
    }
}
