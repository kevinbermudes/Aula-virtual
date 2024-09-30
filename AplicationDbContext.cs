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
    }
}