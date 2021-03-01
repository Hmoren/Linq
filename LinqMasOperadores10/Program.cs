using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqMasOperadores10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ordenamientos y otros operadores

            // Creamos un arreglo sobre el cual trabajar
            int[] numeros = { 1, 5, 4, 7, 6, 3, 5, 9, 8, 11 };

            IEnumerable<int> desdeInicio = numeros.Take(5);

            Console.WriteLine("int[] numeros = { 1, 5, 4, 7, 6, 3, 5, 9, 8, 11 };");
            Console.WriteLine("Take - toma los numeros indicados en el metodo Take(5)");
            // Mostramos los resultados
            foreach (int num in desdeInicio)
                Console.WriteLine(num);

            Console.WriteLine("------");

            IEnumerable<int> brinco = numeros.Skip(5);

            // Mostramos los resultados
            Console.WriteLine("Skip - salta los numeros indicados en el metodo Skip(5)");
            foreach (int num in brinco)
                Console.WriteLine(num);

            Console.WriteLine("------");

            IEnumerable<int> reversa = numeros.Reverse();

            // Mostramos los resultados
            Console.WriteLine("Reverse - muestra los numeros de atras hacia adelante Reverse()");
            foreach (int num in reversa)
                Console.WriteLine(num);

            Console.WriteLine("------");

            // Encontramos el primero
            Console.WriteLine("El primero es {0}", numeros.First());

            // Encontramos el primero
            Console.WriteLine("El ultimo es {0}", numeros.Last());

            // Encontramos el elemento en el indice 3
            Console.WriteLine("En el indice 3 esta {0}", numeros.ElementAt(3));

            // Vemos si contiene a determinado elemento
            Console.WriteLine("Contiene al 15 - {0}", numeros.Contains(15));

            // Vemos su hay elementos
            Console.WriteLine("Tiene elementos - {0}", numeros.Any());

            // Vemos si hay multiplos de 5
            Console.WriteLine("Hay multiplos de 5 - {0}", numeros.Any(n => n % 5 == 0));
            Console.WriteLine("------");


            // Cuidado con los cambios de valor entre la ejecucion de los query

            int valor = 2;
            IEnumerable<int> resultados = numeros.Where(n => n % valor == 0);

            valor = 3;

            foreach (int n in resultados)
                Console.WriteLine(n);

        }
    }
}
