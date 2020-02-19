using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Generar una funcion que se llame FuncionCubo*/
            string flag = "";
            do
            {
                Console.WriteLine("Ingrese un numero (puede contener decimales): ");
                double n = double.Parse(Console.ReadLine());
                Console.WriteLine("El cubo de {0} es {1}.", n, FuncionCubo(n));
                Console.WriteLine("\n¿Desea seguir? Escriba NO para salir: ");
                flag = Console.ReadLine();
                Console.WriteLine("");
            } while (flag.ToLower() != "no");

            Console.ReadKey();
        }

        public static double FuncionCubo(double v)
        {
            return v * v * v;
        }
    }
}
