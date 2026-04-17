using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Entrada
            Console.WriteLine("RADIO DE UN CIRCULO: ");
            double r = double.Parse(Console.ReadLine());

            // Proceso
            double area = Math.PI * Math.Pow(r, 2);
            double perimetro = 2 * Math.PI * r;

            // Salida
            Console.WriteLine($"AREA DEL CIRCULO: {area:F2}");
            Console.WriteLine($"PERIMETRO DEL CIRCULO: {perimetro:F2}");
        }
    }
}
