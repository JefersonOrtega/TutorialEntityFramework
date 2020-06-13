using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace TutorialEntityFramework.Entidades
{
    class Curso
    {
        public int CursoId { get; set; }
        public string NombreCurso { get; set; }
        public string Descripcion { get; set; }

        public IList<EstudianteCurso> EstudianteCursos { get; set; }

    }
}
