using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3_Mayor_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor1, valor2, valor3;

            Console.WriteLine("Ingresar primer valor: ");
            valor1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingresar segundo valor: ");
            valor2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingresar tercer valor: ");
            valor3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("El mayor numero es: " + Math.Max(valor1, Math.Max(valor2, valor3)));
        }
    }
}
