using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace TutorialEntityFramework.Entidades
{
    class EstudianteCurso
    {
        public int EstudianteID { get; set; }
        public Estudiante Estudiante { get; set; }

        public int CursoId { get; set; }
        public Curso Curso { get; set; }
    }
}
