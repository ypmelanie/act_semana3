using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Precios unitarios
            double precioHabitacion = 30.0;
            double precioBano = 10.0;
            double precioPatio = 15.0;

            // Entrada
            Console.WriteLine("PAGO POR ALQUILER");

            Console.Write("Cantidad de habitaciones: ");
            int numHabitaciones = int.Parse(Console.ReadLine());

            Console.Write("Cantidad de baños: ");
            int numBanos = int.Parse(Console.ReadLine());

            Console.Write("Cantidad de patios: ");
            int numPatios = int.Parse(Console.ReadLine());

            // Proceso
            double total = (numHabitaciones * precioHabitacion) + (numBanos * precioBano) + (numPatios * precioPatio);

            // Salida
            Console.WriteLine($"El pago total por el alquiler es: S/ {total:F2}");
        }
    }
}
