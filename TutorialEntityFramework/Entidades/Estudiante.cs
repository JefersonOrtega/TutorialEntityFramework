using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace TutorialEntityFramework.Entidades
{
    class Estudiante
    {
        public int EstudianteId { get; set; }
        public string PrimerNombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaCumpleano { get; set; }
        public byte[] Photo { get; set; }

        /*public int GradoId { get; set; }
        public Grado Grado { get; set; }
        */
       // public IList<EstudianteCurso> EstudianteCursos { get; set; }

    }
}
