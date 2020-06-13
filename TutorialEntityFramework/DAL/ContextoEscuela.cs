using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using TutorialEntityFramework.Entidades;

namespace TutorialEntityFramework.DAL
{
    class ContextoEscuela : DbContext
    {
        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Grado> Grados { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=EscuelaDB; Trusted_Connection=True;");
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Estudiante>()
                .Property(e => e.EstudianteId)
                .HasColumnName("id")
                .HasDefaultValue(0)
                .IsRequired();

            //Relacion de uno a Varios
            modelBuilder.Entity<Estudiante>()
                .HasOne<Grado>(e => e.Grado)
                .WithMany(g => g.Estudiantes) //WithOne si se quiere relacion de 1 a 1
                .HasForeignKey(e => e.GradoId);

            //Para eliminar en Cascada
            modelBuilder.Entity<Grado>()
                .HasMany<Estudiante>(g => g.Estudiantes)
                .WithOne(e => e.Grado)
                .HasForeignKey(e => e.GradoId)
                .OnDelete(DeleteBehavior.Cascade);//ClientNull si lo que se quiere es que en la otra tabla se ponga valor nulo

            //Para Relacion varios a varios
            modelBuilder.Entity<EstudianteCurso>().HasKey(ec => new { ec.EstudianteID, ec.CursoId });
        }

       
       
    }
}
