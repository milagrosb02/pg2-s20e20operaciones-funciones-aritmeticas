using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1_Aritméticas_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort numero;

            Console.WriteLine("Ingresar un numero: ");
            numero = Convert.ToUInt16(Console.ReadLine());

            Console.WriteLine("Resto del numero: " + numero % 2);
            Console.WriteLine("Valor absoluto: " + Math.Abs(numero));
            Console.WriteLine("Elevado a la decima potencia: " + Math.Pow(numero, 10));
            Console.WriteLine("Raiz cuadrada: " + Math.Sqrt(numero));
        }
    }
}
