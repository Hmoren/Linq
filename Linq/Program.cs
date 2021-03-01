using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numeros = { 1, 5, 7, 3, 5, 9, 8 };

            IEnumerable<int> valores = from n in numeros
                                       where n > 3 && n < 8
                                       select n;

            foreach (int num in valores)
                Console.WriteLine(num);

            Console.WriteLine("------");

            string[] postres = { "pay de manzana", "pastel de chocolate", "manzana caramelizada", "fresas con crema" };

            IEnumerable<string> encontrados = from p in postres
                                              where p.Contains("manzana")
                                              orderby p
                                              select p;

            foreach (string postre in encontrados)
                Console.WriteLine(postre);
            
            Console.WriteLine("------");

            InformacionResultados(valores);
            Console.WriteLine("------");
            InformacionResultados(encontrados);
            
        }

        static void InformacionResultados(object pResultados)
        {
            Console.WriteLine("Tipo {0}",pResultados.GetType().Name);
            Console.WriteLine("Locacion {0}", pResultados.GetType().Assembly.GetName().Name);
        }
    }
}
