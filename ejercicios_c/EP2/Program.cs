using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Entrada
            Console.Write("Ingrese los kWh consumidos: ");
            double kwh = double.Parse(Console.ReadLine());

            // Proceso
            double subtotal = 5.00 + (kwh * 0.55);
            double igv = subtotal * 0.18;
            double total = subtotal + igv;

            // Salida
            Console.WriteLine($"Subtotal: S/ {subtotal:F2}");
            Console.WriteLine($"IGV (18%): S/ {igv:F2}");
            Console.WriteLine($"Total a pagar: S/ {total:F2}");
        }
    }
}
