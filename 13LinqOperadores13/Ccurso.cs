using System;
using System.Collections.Generic;
using System.Text;

namespace _13LinqOperadores13
{
    class Ccurso
    {
        private string curso;
        private int id;

        public Ccurso(string pCurso, int pID)
        {
            curso = pCurso;
            id = pID;
        }

        public string Curso { get => curso; set => curso = value; }
        public int Id { get => id; set => id = value; }




        public override string ToString()
        {
            return string.Format("Curso => {0}", curso);
        }
    }
}
