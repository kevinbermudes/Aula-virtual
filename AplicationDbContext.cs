using Microsoft.EntityFrameworkCore;
using Webvs2.Models;

namespace Webvs2
{
    public class AplicationDbContext : DbContext
    {
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(
                "Host=localhost;Username=kevin;Password=1234;Database=mydatabase");
            base.OnConfiguring(optionsBuilder);
        }



        public DbSet<Tareas> Tareas { get; set; }
        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Aula> Aulas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aula>()
                .HasMany(a => a.Alumnos)
                .WithOne(a => a.Aula)
                .HasForeignKey(a => a.AulaId);

            modelBuilder.Entity<AlumnoTarea>()
                .HasKey(at => new { at.AlumnoId, at.TareaId });

            modelBuilder.Entity<AlumnoTarea>()
                .HasOne(at => at.Alumno)
                .WithMany(a => a.AlumnoTareas)
                .HasForeignKey(at => at.AlumnoId);

            modelBuilder.Entity<AlumnoTarea>()
                .HasOne(at => at.Tarea)
                .WithMany(t => t.AlumnoTareas)
                .HasForeignKey(at => at.TareaId);
        }
    }
}