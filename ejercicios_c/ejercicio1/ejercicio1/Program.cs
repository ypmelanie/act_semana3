using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ingrese la nota1 :");
            int notal = int.Parse(Console.ReadLine());
            Console.Write("ingrese la nota2 :");
            int nota2 = int.Parse(Console.ReadLine());
            Console.Write("ingrese la nota3 :");
            int nota3 = int.Parse(Console.ReadLine());
            Console.Write("ingrese la nota4 :");
            int nota4 = int.Parse(Console.ReadLine());


            int suma = notal + nota2 + nota3 + nota4;
            double promedio = suma / 4.0;
            Console.WriteLine("-------------------");
            Console.WriteLine("Suma de notas: " + suma);
            Console.WriteLine($"Promedio final: {promedio}");
            Console.WriteLine("-------------------");
        }
    }
}
