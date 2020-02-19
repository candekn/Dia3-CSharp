using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ingrese 3 notas por teclado
             Informe su total y su promedio llamando a una funcion que se llame CalcularPromedio*/
            /*Generar una funcion que se llame FuncionCubo*/
            string flag = "";
            do
            {
                Console.WriteLine("Ingrese nota numero 1 (puede contener decimales): ");
                double n1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese nota numero 2 (puede contener decimales): ");
                double n2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese nota numero 3 (puede contener decimales): ");
                double n3 = double.Parse(Console.ReadLine());


                Console.WriteLine("El promedio de las 3 notas es de {0}.", CalcularPromedio(n1,n2,n3));
                Console.WriteLine("\n¿Desea seguir? Escriba NO para salir: ");
                flag = Console.ReadLine();
                Console.WriteLine("");
            } while (flag.ToLower() != "no");

            Console.ReadKey();
        }
        public static double CalcularPromedio(double n1, double n2, double n3)
        {
            return ((n1 + n2 + n3) / 3);
        }
    }
}
