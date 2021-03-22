using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._5_Interes_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal monto, interes_anual, Interes, tiempo, capAcumulado;

            Console.WriteLine("Ingresar un monto: ");
            monto = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Ingresar interes: ");
            interes_anual = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Ingresar cantidad de dias: ");
            tiempo = Convert.ToDecimal(Console.ReadLine());

            Interes = (monto * interes_anual * tiempo) / (360 * 100);

            capAcumulado = Interes + monto;

            Console.WriteLine("El total es de: " + Interes);
            Console.WriteLine("El capital acumulado es de: " + capAcumulado);
        }
    }
}
