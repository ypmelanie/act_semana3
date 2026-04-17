using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Entrada
            Console.Write("x1: ");
            double x1 = double.Parse(Console.ReadLine());

            Console.Write("y1: ");
            double y1 = double.Parse(Console.ReadLine());

            Console.Write("x2: ");
            double x2 = double.Parse(Console.ReadLine());

            Console.Write("y2: ");
            double y2 = double.Parse(Console.ReadLine());

            // Proceso
            double dx = x2 - x1;
            double dy = y2 - y1;
            double distancia = Math.Sqrt(dx * dx + dy * dy);

            // Salida
            Console.WriteLine($"DISTANCIA ENTRE LOS PUNTOS: {distancia:F2}");
        }
    }
}
