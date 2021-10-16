using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            Krug.Length(10);
            Krug.Square(10);
            Krug.Inside(3,3,5,0,0);

            Console.ReadKey();
        }
    }

    static class Krug
    {

        public static void Length(double radius)
        {
            double l = 2 * radius * (Math.PI);
            Console.WriteLine("Длина круга с радиусом {0:f2} = {1:f2}", radius, l);
        }

        public static void Square(double radius)
        {
            double s = Math.Pow(radius, 2) * Math.PI;
            Console.WriteLine("Площадь круга с радиусом {0:f2} = {1:f2}", radius, s);
        }

        public static void Inside(double x, double y, double radius, double x0, double y0)
        {

            double l = Math.Sqrt(Math.Pow((Math.Abs(x - x0)), 2) + Math.Pow((Math.Abs(y - y0)), 2));
            if (radius >= l)
                Console.WriteLine($"Точка с координатами ({x:f2},{y:f2}) принадлежит кругу с радиусом {radius:f2} и центром ({x0},{y0})");
            else
            {
                Console.WriteLine($"Точка с координатами ({x:f2},{y:f2}) не принадлежит кругу с радиусом {radius:f2} и центром ({x0},{y0})");
            }
        }
    }
}
