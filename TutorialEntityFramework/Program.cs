using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
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
            string nombre = "Jeferosn";
            using (contexto)
            {
                var std = new Estudiante()
                {
                    PrimerNombre = "Raul"
                };

                contexto.Estudiantes.Add(std);
                contexto.SaveChanges();
                contexto.Dispose();
            }


            // var EstudiantesConMismoNombre = contexto.Estudiantes.Where(e => e.PrimerNombre == GetName()).ToList();

            using (contexto)
            {
                var std = contexto.Estudiantes.First<Estudiante>();
                std.PrimerNombre = "Jeferson";
                contexto.SaveChanges();
            }
            
            var std = contexto.Estudiantes.First<Estudiante>();
            contexto.Estudiantes.Remove(std);
            contexto.SaveChanges();

            var estudiantes = contexto.Estudiantes
                .FromSql($"Select * from Estudiantes where PPrimerNombre = '{0}'", nombre)
                .ToList();

            
        }

        public static string GetName()
        {
            return "Jeferson";
        }
    }
}
