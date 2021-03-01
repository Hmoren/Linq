using System;
using System.Collections.Generic;
using System.Text;

namespace LinqProjeccion06
{
    class CEstudiante
    {
        private string nombre;
        private string id;
        private string curso;
        private double promedio;

        public string Nombre { get { return nombre; } }
        public string ID { get { return id; } }
        public string Curso { get { return curso; } }
        public double Promedio { get { return promedio; } }

        public CEstudiante(string pNombre, string pId, string pCurso, double pPromedio) 
        {
            nombre = pNombre;
            id = pId;
            curso = pCurso;
            promedio = pPromedio;
        }

        public override string ToString()
        {
            return string.Format("Nombre: {0}, {1}, curso: {2}, promedio: {3}", nombre, id, curso, promedio);
        }
    }
}
