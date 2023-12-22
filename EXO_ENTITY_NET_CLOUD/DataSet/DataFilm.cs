using EXO_ENTITY_NET_CLOUD.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXO_ENTITY_NET_CLOUD.DataSet
{
    public class DataFilm : IEntityTypeConfiguration<Film>
    {
        public void Configure(EntityTypeBuilder<Film> builder)
        {
            builder.HasData(
                 new Film
                 {
                     FilmId = 1,
                     Titre = "Star Wars : Un nouvel espoir",
                     AnneeDeSortie = 1977,
                     Genre = "Science-Fiction",
                     RealisateurId = 10
                 },
                 new Film
                 {
                     FilmId = 2,
                     Titre = "Star Wars : L'empire contre-attaque",
                     AnneeDeSortie = 1980,
                     Genre = "Science-Fiction",
                     RealisateurId = 10
                 },
                 new Film
                 {
                     FilmId = 3,
                     Titre = "Star Wars : Le retour du Jedi",
                     AnneeDeSortie = 1983,
                     Genre = "Science-Fiction",
                     RealisateurId = 10
                 },
                 new Film
                 {
                     FilmId = 4,
                     Titre = "Hooligans",
                     AnneeDeSortie = 2005,
                     Genre = "Société",
                     RealisateurId = 8
                 },
                 new Film
                 {
                     FilmId = 5,
                     Titre = "LOTR - La communauté de l'anneau",
                     AnneeDeSortie = 2001,
                     Genre = "Heroic-Fantasy",
                     RealisateurId = 9
                 },
                 new Film
                 {
                     FilmId = 6,
                     Titre = "LOTR - Les deux tours",
                     AnneeDeSortie = 2002,
                     Genre = "Heroic-Fantasy",
                     RealisateurId = 9
                 },
                 new Film
                 {
                     FilmId = 7,
                     Titre = "LOTR - Le retour du roi",
                     AnneeDeSortie = 2003,
                     Genre = "Heroic-Fantasy",
                     RealisateurId = 9
                 });
        }
    }
}
