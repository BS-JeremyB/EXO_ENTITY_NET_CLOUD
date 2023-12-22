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
    public class DataPersonne : IEntityTypeConfiguration<Personne>
    {
        public void Configure(EntityTypeBuilder<Personne> builder)
        {
            builder.HasData
            (
                new Personne
                {
                    PersonneId = 1,
                    Prenom = "Elijah",
                    Nom = "Wood"
                },
                new Personne
                {
                    PersonneId = 2,
                    Prenom = "Charlie",
                    Nom = "Hunnam"
                },
                new Personne
                {
                    PersonneId = 3,
                    Prenom = "Harisson",
                    Nom = "Ford"
                },
                new Personne
                {
                    PersonneId = 4,
                    Prenom = "Mark",
                    Nom = "Hammil"
                },
                new Personne
                {
                    PersonneId = 5,
                    Prenom = "Carrie",
                    Nom = "Fisher"
                },
                new Personne
                {
                    PersonneId = 6,
                    Prenom = "Vigo",
                    Nom = "Mortensen"
                },
                new Personne
                {
                    PersonneId = 7,
                    Prenom = "Orlando",
                    Nom = "Bloom"
                },
                new Personne
                {
                    PersonneId = 8,
                    Prenom = "Lexi",
                    Nom = "Alexander"
                },
                new Personne
                {
                    PersonneId = 9,
                    Prenom = "Peter",
                    Nom = "Jackson"
                },
                new Personne
                {
                    PersonneId = 10,
                    Prenom = "Georges",
                    Nom = "Lucas"
                }
            );
        }
    }
}
