using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqMetodoClase03
{
    class CClaseExplicita
    {
        private static string[] postres = { "pay de manzana", "pastel de chocolate", "manzana caramelizada", "fresas con crema" };

        private static IEnumerable<string> encontrados = from p in postres
                                                         where p.Contains("manzana")
                                                         orderby p
                                                         select p;

        public static IEnumerable<int> ObtenerNumerosPares()
        {
            int[] numeros = { 1, 5, 4, 7, 6, 3, 5, 9, 8, 11 };
            IEnumerable<int> pares = from n in numeros
                          where n % 2 == 0
                          select n;
            return pares;
        }

        public static IEnumerable<string> ObtenerPostres()
        {
            return encontrados;
        }

        public static int[] ObtenerNumerosImpares()
        {
            int[] numeros = { 1, 5, 4, 7, 6, 3, 5, 9, 8, 11 };
            var resultados = from n in numeros
                                     where n % 2 != 0
                                     select n;
            return resultados.ToArray();
        }
    }
}
