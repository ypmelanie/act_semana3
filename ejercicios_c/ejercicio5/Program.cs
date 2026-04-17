using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Entrada
            Console.Write("Ingrese el monto en soles: ");
            double monto = double.Parse(Console.ReadLine());

            // Proceso
            double ceiling = Math.Ceiling(monto);
            double floor = Math.Floor(monto);
            double truncado = Math.Truncate(monto);

            // Salida
            Console.WriteLine($"Precio original: {monto}");
            Console.WriteLine($"Ceiling (hacia arriba): {ceiling}");
            Console.WriteLine($"Floor (hacia abajo): {floor}");
            Console.WriteLine($"Truncado: {truncado}");
        }
    }
}
