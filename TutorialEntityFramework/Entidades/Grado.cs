using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace TutorialEntityFramework.Entidades
{
    class Grado
    {
        public int GradoId { get; set; }
        public string NombreGrado { get; set; }
        public string seleccion { get; set; }
       // public IList<Estudiante> Estudiantes { get; set; }
    }
}
