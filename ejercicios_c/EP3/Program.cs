using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Entrada
            Console.Write("Ingrese la temperatura en °C: ");
            double celsius = double.Parse(Console.ReadLine());

            // Proceso
            double fahrenheit = celsius * (9.0 / 5) + 32;
            double kelvin = celsius + 273.15;

            // Salida
            Console.WriteLine($"Temperatura en Celsius: {celsius:F2} °C");
            Console.WriteLine($"Temperatura en Fahrenheit: {fahrenheit:F2} °F");
            Console.WriteLine($"Temperatura en Kelvin: {kelvin:F2} K");
        }
    }
}
