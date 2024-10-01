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
            modelBuilder.Entity<Aula>().HasMany(e => e.Alumnos).WithOne(e => e.Aula);
            modelBuilder.Entity<Tareas>().HasMany(e => e.Alumnos).WithMany(e => e.Tareas);
            
        }
    }
}