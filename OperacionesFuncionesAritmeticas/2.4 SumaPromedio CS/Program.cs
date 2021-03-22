using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._4_SumaPromedio_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort num1, num2, num3, num4;
            double media, suma;

            Console.WriteLine("Ingrese primer numero: ");
            num1 = Convert.ToUInt16(Console.ReadLine());

            Console.WriteLine("Ingrese segundo numero: ");
            num2 = Convert.ToUInt16(Console.ReadLine());

            Console.WriteLine("Ingrese tercer numero: ");
            num3 = Convert.ToUInt16(Console.ReadLine());

            Console.WriteLine("Ingrese cuarto numero: ");
            num4 = Convert.ToUInt16(Console.ReadLine());

            suma = Convert.ToUInt16(num1 + num2 + num3 + num4);
            media = suma / 4;

            Console.WriteLine("La sumatoria de los numeros ingresados es: " + suma);
            Console.WriteLine("La media de los numeros ingresados es: " + media);
        }
    }
}
