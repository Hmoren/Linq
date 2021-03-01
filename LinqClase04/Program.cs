using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqClase04
{
    class Program
    {
        static void Main(string[] args)
        {
            List<CEstudiante> estudiantes = new List<CEstudiante>
            {
                new CEstudiante("Ana", "A100", "Mercadotecnia", 10.0),
                new CEstudiante("Luis", "A250", "Orientado a objetos", 9.0),
                new CEstudiante("Juan", "A875", "Programación básica", 5.0),
                new CEstudiante("Susana", "A432", "Mercadotecnia", 8.7),
                new CEstudiante("Pablo", "A156", "Mercadotecnia", 4.3),
                new CEstudiante("Alberto", "A456", "Orientado a objetos", 8.3),
            };

            var reprobados = from e in estudiantes
                             where e.Promedio <= 5.0
                             select e;

            Console.WriteLine("Reprobados");
            foreach (CEstudiante r in reprobados)
                Console.WriteLine(r);

            Console.WriteLine("Solo un atributo");
            foreach (CEstudiante r in reprobados)
                Console.WriteLine(r.Nombre);

            var mercadotecnia = from m in estudiantes
                                where m.Curso == "Mercadotecnia"
                                select m.Nombre;

            Console.WriteLine("Nombres de Mercadotecnia");
            foreach (string m in mercadotecnia)
                Console.WriteLine(m);

        }
    }
}
