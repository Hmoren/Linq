using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqOperaciones07
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creamos una lista
            List<CEstudiante> estudiantes = new List<CEstudiante>
            {
                new CEstudiante("Ana", "A100", "Mercadotecnia", 10.0),
                new CEstudiante("Luis", "S250", "Orientado a objetos", 9.0),
                new CEstudiante("Juan", "S875", "Programacion basica", 5.0),
                new CEstudiante("Susana", "A432", "Mercadotecnia", 8.7),
                new CEstudiante("Pablo", "A156", "Mercadotecnia", 4.3),
                new CEstudiante("Alberto", "S456", "Orientado a objetos", 8.3),
            };

            int cantidad = (from e in estudiantes
                            where e.Promedio > 5
                            select e).Count();
            Console.WriteLine("La cantidad de aprobados es {0}", cantidad);

            Console.WriteLine("------");


            /// Reversa
            /// 
            var aprobados = from e in estudiantes
                            where e.Promedio > 5
                            select e;

            foreach (CEstudiante est in aprobados)
                Console.WriteLine(est);

            Console.WriteLine("------");
            Console.WriteLine("Orden inversio");

            foreach (CEstudiante est in aprobados.Reverse())
                Console.WriteLine(est);

            // Ordenamiento
            Console.WriteLine("------");
            Console.WriteLine("Ordenados");

            var ordenados = from e in estudiantes
                            orderby e.Promedio descending
                            select e;

            foreach (CEstudiante est in ordenados)
                Console.WriteLine(est);

            Console.WriteLine("------");
            Console.WriteLine("Ascendente");

            var ordenadosA = from e in estudiantes
                            orderby e.Promedio ascending
                            select e;

            foreach (CEstudiante est in ordenadosA)
                Console.WriteLine(est);

            Console.WriteLine("------");
            int[] numeros = { 2, 5, 3, 9, 1, 6, 4, 7, 8 };

            // Encontramos el maximo
            int maximo = (from n in numeros select n).Max();
            Console.WriteLine("El maximo es {0}", maximo);

            // Encontramos el minimo
            int minimo = (from n in numeros select n).Min();
            Console.WriteLine("El minimo es {0}", minimo);

            // Encontramos el promedio
            double promedio = (from n in numeros select n).Average();
            Console.WriteLine("El promedio es {0}", promedio);

            // Sumatoria
            int sumatoria = (from n in numeros select n).Sum();
            Console.WriteLine("La sumatoria es {0}", sumatoria);


        }
    }
}
