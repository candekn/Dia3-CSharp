using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ingrese dos nros por teclado
             Informe suma, resta, multiplicacion y division usando funciones*/
            string flag = "";
            double n1, n2;
            do
            {
                Console.WriteLine("Ingrese primer numero (puede contener decimales): ");
                n1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese segundo numero (puede contener decimales): ");
                n2 = double.Parse(Console.ReadLine());
                Suma(n1, n2); Resta(n1, n2); Multiplicacion(n1, n2); Division(n1, n2);
                Console.WriteLine("\n¿Desea seguir? Escriba NO para salir: ");
                flag = Console.ReadLine();
                Console.WriteLine("");
            } while (flag.ToLower() != "no");

            Console.ReadKey();
        }
        public static void Suma(double n1, double n2)
        {
            Console.WriteLine("La suma de {0} + {1} es igual a {2}", n1, n2, (n1 + n2));
        }
        public static void Resta(double n1, double n2)
        {
            Console.WriteLine("La resta de {0} - {1} es igual a {2}", n1, n2, (n1 - n2));
        }
        public static void Multiplicacion(double n1, double n2)
        {
            Console.WriteLine("La multiplicacion de {0} * {1} es igual a {2}", n1, n2, (n1 * n2));
        }
        public static void Division(double n1, double n2)
        {
            if (n2 == 0)
            {
                Console.WriteLine("ERROR! No se puede dividir por cero!");
            }
            else
            {
                Console.WriteLine("La division de {0} / {1} es igual a {2}", n1, n2, (n1 / n2));
            }
            
        }
    }
}
