using System;
using System.Linq;
using TutorialEntityFramework.DAL;
using TutorialEntityFramework.Entidades;

namespace TutorialEntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            var contexto = new ContextoEscuela();
            using (contexto)
            {
                var std = new Estudiante()
                {
                    PrimerNombre = "Raul"
                };

                contexto.Estudiantes.Add(std);
                contexto.SaveChanges();

            }


             var EstudiantesConMismoNombre = contexto.Estudiantes.Where(e => e.PrimerNombre == GetName()).ToList();

            using (contexto)
            {
                var std = contexto.Estudiantes.First<Estudiante>();
                std.PrimerNombre = "Jeferson";
                contexto.SaveChanges();
            }

            /*var std = contexto.Estudiantes.First<Estudiante>();
            contexto.Estudiantes.Remove(std);
            contexto.SaveChanges();*/
        }

        public static string GetName()
        {
            return "Jeferson";
        }
    }
}
