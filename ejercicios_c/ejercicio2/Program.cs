using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Entrada
            Console.WriteLine("Precio unitario (S/): ");
            double precio = double.Parse(Console.ReadLine());

            Console.WriteLine("Cantidad de productos: ");
            int cantidad = int.Parse(Console.ReadLine());

            // Proceso
            double subtotal = precio * cantidad;
            double igv = subtotal * 0.18;
            double total = subtotal + igv;

            // Salida
            Console.WriteLine("Subtotal (sin IGV): S/ " + subtotal);
            Console.WriteLine("IGV (18%): S/ " + igv);
            Console.WriteLine("Total a pagar: S/ " + total);
        }
    }
}
