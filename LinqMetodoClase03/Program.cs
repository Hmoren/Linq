using System;
using System.Collections.Generic;

namespace LinqMetodoClase03
{
    class Program
    {
        
        static void Main(string[] args)
        {
            // Obtener resultados de query desde metodos

            //Invocamos el metodo
            IEnumerable<int> resultados = CClaseExplicita.ObtenerNumerosPares();

            //Mostramos resultados
            foreach (int num in resultados)
                Console.WriteLine(num);

            Console.WriteLine("------");

            IEnumerable<string> postres = CClaseExplicita.ObtenerPostres();

            foreach (string p in postres)
                Console.WriteLine(p);

            Console.WriteLine("------");

            int[] impares = CClaseExplicita.ObtenerNumerosImpares();

            foreach (int m in impares)
                Console.WriteLine(m);
        }
    }
}
