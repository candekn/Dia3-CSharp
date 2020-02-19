using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Calculadora
             suma todo void
             resta no recibe pero retorna
             multiplicacion reciba parametro pero no retorne
             division recibe y retorna*/
            int flag = 0;
            double n1, n2;
            do
            {
                Console.WriteLine("Bienvenido. Seleccione el calculo a realizar: " +
                    "\n1.Suma\n2.Resta\n3.Multiplicacion\n4.Division\n5.Salir");
                flag = int.Parse(Console.ReadLine());
                switch (flag)
                {
                    case 1: Suma();
                        break;
                    case 2: double resta = Resta();
                        Console.WriteLine("El resultado de la resta es: " + resta);
                        break;
                    case 3:
                        Console.WriteLine("Ingrese primer numero (puede contener decimales): ");
                        n1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese segundo numero (puede contener decimales): ");
                        n2 = double.Parse(Console.ReadLine());
                        Multiplicacion(n1, n2);
                        break;
                    case 4:
                        Console.WriteLine("Ingrese primer numero (puede contener decimales): ");
                        n1 = double.Parse(Console.ReadLine());
                        eti1:
                        Console.WriteLine("Ingrese segundo numero (puede contener decimales): ");
                        n2 = double.Parse(Console.ReadLine());
                        double div = Division(n1, n2);
                        if (div == 0.0)
                        {
                            Console.WriteLine("Error! No se puede dividir por cero.");
                            Console.WriteLine("Ingrese un numero valido");
                            goto eti1;
                        }
                        else
                        {
                            Console.WriteLine("El resultado de la division es: " + div);
                        }
                        break;
                    case 5: Console.WriteLine("\nGracias por usar mi calculadora. Que tengas un buen dia :)\n");
                        break;
                    default: Console.WriteLine("Opcion incorrecta. Seleccione entre el 1 y 5.\n");
                        break;
                }

            } while (flag != 5);
        }
        public static void Suma()
        {
            Console.WriteLine("Ingrese primer numero (puede contener decimales): ");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese segundo numero (puede contener decimales): ");
            double n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("La suma de {0} + {1} es igual a {2}", n1, n2, (n1 + n2));
        } 
        public static double Resta()
        {
            Console.WriteLine("Ingrese primer numero (puede contener decimales): ");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese segundo numero (puede contener decimales): ");
            double n2 = double.Parse(Console.ReadLine());
            return n1 + n2;
        }
        public static void Multiplicacion(double n1, double n2)
        {
            Console.WriteLine("La multiplicacion de {0} * {1} es igual a {2}", n1, n2, (n1 * n2));
        }
        public static double Division(double n1, double n2)
        {
            if (n2 == 0)
            {
                return 0.0;
            }
            else
            {
                return n1 / n2;
            }
        }
    }
}
