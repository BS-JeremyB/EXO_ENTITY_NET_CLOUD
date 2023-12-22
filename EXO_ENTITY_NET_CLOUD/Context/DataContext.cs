using EXO_ENTITY_NET_CLOUD.Context.Config;
using EXO_ENTITY_NET_CLOUD.DataSet;
using EXO_ENTITY_NET_CLOUD.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXO_ENTITY_NET_CLOUD.Context
{
    public class DataContext : DbContext
    {

        public DbSet<Film> Films { get; set; }
        public DbSet<Personne> personnes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FilmConfig());
            modelBuilder.ApplyConfiguration(new PersonneConfig());
            modelBuilder.ApplyConfiguration(new FilmPersonneConfig());

            modelBuilder.ApplyConfiguration(new DataFilm());
            modelBuilder.ApplyConfiguration(new DataPersonne());
            modelBuilder.ApplyConfiguration(new DataFilmPersonne());
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(LocalDB)\BStormLocalDB;" +
                                         "Database=EXO_ENTITY_CLOUD_NET;" +
                                         "Trusted_Connection=True;");
        }

    }
}
