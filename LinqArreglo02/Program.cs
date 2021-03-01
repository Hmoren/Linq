using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqArreglo02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 1, 5, 4, 7, 6, 3, 5, 9, 8, 11 };
            var valores = from n in numeros
                          where n % 2 == 0
                          select n;

            foreach(int num in valores)
                Console.WriteLine(num);

            Console.WriteLine("------");

            InformacionResultados(valores);

            Console.WriteLine("------Ejecución diferida");

            numeros[1] = 12;

            foreach (int num in valores)
                Console.WriteLine(num);

            Console.WriteLine("------Ejecución inmediata");

            //Guarda los resultados como arreglo
            int[] arrayValores = (from n in numeros where n % 2 == 0 select n).ToArray<int>();

            //Guarda los resultados como un list
            List<int> listadoValores = (from n in numeros where n % 2 == 0 select n).ToList<int>();

            Console.WriteLine("El arreglo");

            foreach (int num in arrayValores)
                Console.WriteLine(num);

            numeros[0] = 28;
            Console.WriteLine("------ se actualiza despues de la modificacion?");

            foreach (int num in arrayValores)
                Console.WriteLine(num);

            Console.WriteLine("La Lista");
            Console.WriteLine("------");

            foreach (int num in listadoValores)
                Console.WriteLine(num);

        }



        static void InformacionResultados(object pResultados)
        {
            Console.WriteLine("Tipo {0}", pResultados.GetType().Name);
            Console.WriteLine("Locacion {0}", pResultados.GetType().Assembly.GetName().Name);
        }
    }
}
