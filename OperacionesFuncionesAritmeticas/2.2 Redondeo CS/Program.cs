using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2_Redondeo_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero;

            Console.Write("Ingrese un numero Real: ");

            numero = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Por exceso: " + Math.Ceiling(numero));
            Console.WriteLine("Por defecto: " + Math.Floor(numero));
            Console.WriteLine("Por redondeo: " + Math.Round(numero));
        }
    }
}
