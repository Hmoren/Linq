using System;
using System.Collections.Generic;
using System.Text;

namespace _13LinqOperadores13
{
    class CEstudiante
    {
        private string nombre;
        private int id;

        public CEstudiante(string pNombre, int pID)
        {
            nombre = pNombre;
            id = pID;           
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Id { get => id; set => id = value; }
       

        

        public override string ToString()
        {
            return string.Format("Estudiante {0}, {1}", nombre, id);
        }
    }
}
