using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Final_DIARS.DB.Configuraciones;
using Final_DIARS.Models;



namespace Final_DIARS.Models
{
    public class AppPruebaContext : DbContext
    {
        //public DbSet<Pokemons> Pokemones { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Etiqueta> Etiquetas { get; set; }
        public DbSet<EtiquetaNota> EtiquetaNotas { get; set; }
        public DbSet<Nota> Notas { get; set; }


        public AppPruebaContext(DbContextOptions<AppPruebaContext> options)
            : base(options)
        {
        
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new UserConfigurations());
            modelBuilder.ApplyConfiguration(new EtiquetaConfigurations());
            modelBuilder.ApplyConfiguration(new EtiquetaNotaConfigurations());
            modelBuilder.ApplyConfiguration(new NotaConfigurations());




        }
    }
}