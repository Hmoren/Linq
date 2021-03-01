using System;
using System.Collections;
using System.Linq;

namespace LinqArrayListTip05
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tips para el uso de ArrayList con LINQ por medio de OfType<
            // Seleccionamos objetos de un tipo particular que esten en un ArrayList

            ArrayList lista = new ArrayList();
            lista.AddRange(new object[] { "hola", 5, 6.7, false, 4, 2, "saludos", 3.5, 3 });

            //obtenemos solo los enteros
            var enteros = lista.OfType<int>();

            foreach(int n in enteros)
                    Console.WriteLine(n);

            Console.WriteLine("------");

            // Creamos un ArrayList
            ArrayList estudiantes = new ArrayList()
            {
                new CEstudiante("Ana", "A100", "Mercadotecnia", 10.0),
                new CEstudiante("Luis", "S250", "Orientado a objetos", 9.0),
                new CEstudiante("Juan", "S875", "Programacion basica", 5.0),
                new CEstudiante("Susana", "A432", "Mercadotecnia", 8.7),
                new CEstudiante("Pablo", "A156", "Mercadotecnia", 4.3),
                new CEstudiante("Alberto", "S456", "Orientado a objetos", 8.3),
            };

            //Tenemos que transformar el ArrayList a un tipo que implemente a 
            //IEnumerable<T> para poder ser usado con LinQ
            var estL = estudiantes.OfType<CEstudiante>();

            // Ahora si usamos Linq
            // Encontramos a los reprobados
            var reprobados = from e in estL
                             where e.Promedio >= 5.0 // Aqui trabajamos con una propiedad
                             select e;

            // Mostramos
            Console.WriteLine("Reprobados");
            foreach (CEstudiante r in reprobados)
                Console.WriteLine(r);

        }
    }
}
