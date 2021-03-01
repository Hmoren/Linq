using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqConjuntos08
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> conjunto1 = new List<int> { 2, 4, 6, 8, 9 };
            List<int> conjunto2 = new List<int> { 2, 5, 6, 7, 9 };

            // Except nos da la diferenia entre dos contenedores
            var expt = (from n1 in conjunto1 select n1)
                .Except(from n2 in conjunto2 select n2);

            Console.WriteLine("Except");
            foreach (int num in expt)
                Console.WriteLine(num);

            Console.WriteLine("------");

            // Interset nos da lo comun entre los dos contenedores
            var ints = (from n1 in conjunto1 select n1)
                .Intersect(from n2 in conjunto2 select n2);

            Console.WriteLine("Interset");
            foreach (int num in ints)
                Console.WriteLine(num);

            Console.WriteLine("------");

            // Union nos da la union entre los dos contenedores sin repeticiones
            var un = (from n1 in conjunto1 select n1)
                .Union(from n2 in conjunto2 select n2);

            Console.WriteLine("Union");
            foreach (int num in un)
                Console.WriteLine(num);

            Console.WriteLine("------");

            // Concat, concatena directamente los contenedores
            var cnt = (from n1 in conjunto1 select n1)
                .Concat(from n2 in conjunto2 select n2);

            Console.WriteLine("Concat");
            foreach (int num in cnt)
                Console.WriteLine(num);

            Console.WriteLine("------");

            // Distinct, remueve los duplicados

            Console.WriteLine("Distinct");
            foreach (int num in cnt.Distinct())
                Console.WriteLine(num);

            Console.WriteLine("------");
            Console.WriteLine("Concat nuevamente -- se imprime nuevamente para demostrar que con distinct no se modificó cnt");
            foreach (int num in cnt)
                Console.WriteLine(num);

        }
    }
}
