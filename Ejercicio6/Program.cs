using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ejercicio 5
            Generar en c Sharp, un programa que ingrese 10 elementos en un Vector. 

            Se pide:

            1)	Cantidad de Pares.
            2)	Cantidad de Impares.
            3)	Promedio.                    
            4)	Porcentaje de Pares     
            5)	Porcentaje de Impares */

            int flag = 0;
            int[] v = new int[10];
            Console.WriteLine("Bienvenido, ingrese 10 numeros: ");
            for (int i = 0; i < v.Length; i++)
            {
                Console.WriteLine("Numero {0}: ", i + 1);
                v[i] = int.Parse(Console.ReadLine());
            }
            do
            {
                eti1:
                Console.WriteLine("\nSeleccione lo que desea hacer: \n1.Cantidad de pares\n2.Cantidad de impares\n" +
                    "3.Promedio\n4.Porcentaje de pares\n5.Porcentaje de impares\n0.Salir");
                flag = int.Parse(Console.ReadLine());
                switch (flag)
                {
                    case 0: Console.WriteLine("Adios. Que tenga un buen dia");
                        break;
                    case 1: int par = CantidadPares(v);
                        Console.WriteLine("La cantidad de numeros pares de " + par);
                        break;
                    case 2: int impar = CantidadImpares(v);
                        Console.WriteLine("La cantidad de numeros impares de " + impar);
                        break;
                    case 3: Promedio(v);
                        break;
                    case 4: PorcentajePares(v);
                        break;
                    case 5: PorcentajeImpares(v);
                        break;
                    default: Console.WriteLine("Opcion incorrecta. Ingrese nuevamente.");
                        goto eti1;

                }
            } while (flag != 0);
        }
        public static int CantidadPares(int[] v)
        {
            int cont = 0;
            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] % 2 == 0)
                {
                    cont++;
                }
            }
            return cont;
        }
        public static int CantidadImpares(int[] v)
        {
            int cont = 0;
            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] % 2 != 0)
                {
                    cont++;
                }
            }
            return cont;
        }
        public static void Promedio(int[] v)
        {
            int tot = 0;
            for (int i = 0; i < v.Length; i++)
            {
                tot = tot + v[i];
            }
            Console.WriteLine("El promedio es de: " + (tot / v.Length));
        }
        public static void PorcentajePares(int[] v)
        {
            int par = 0;
            par = CantidadPares(v);
            Console.WriteLine("El porcentaje de numeros pares es: " +((par * 100) / v.Length));
        }
        public static void PorcentajeImpares(int[] v)
        {
            int impar = 0;
            impar = CantidadImpares(v);
            Console.WriteLine("El porcentaje de numeros impares es: " +((impar * 100) / v.Length));
        }
    }
}
