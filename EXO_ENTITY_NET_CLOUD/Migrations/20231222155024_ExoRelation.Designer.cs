﻿// <auto-generated />
using EXO_ENTITY_NET_CLOUD.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EXO_ENTITY_NET_CLOUD.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20231222155024_ExoRelation")]
    partial class ExoRelation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EXO_ENTITY_NET_CLOUD.Entities.Film", b =>
                {
                    b.Property<int>("FilmId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FilmId"), 1L, 1);

                    b.Property<int>("AnneeDeSortie")
                        .HasColumnType("int");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("RealisateurId")
                        .HasColumnType("int");

                    b.Property<string>("Titre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("FilmId");

                    b.HasIndex("RealisateurId");

                    b.HasIndex("Titre")
                        .IsUnique();

                    b.ToTable("Films");

                    b.HasCheckConstraint("CK_Annee", "AnneeDeSortie > 1975");

                    b.HasData(
                        new
                        {
                            FilmId = 1,
                            AnneeDeSortie = 1977,
                            Genre = "Science-Fiction",
                            RealisateurId = 10,
                            Titre = "Star Wars : Un nouvel espoir"
                        },
                        new
                        {
                            FilmId = 2,
                            AnneeDeSortie = 1980,
                            Genre = "Science-Fiction",
                            RealisateurId = 10,
                            Titre = "Star Wars : L'empire contre-attaque"
                        },
                        new
                        {
                            FilmId = 3,
                            AnneeDeSortie = 1983,
                            Genre = "Science-Fiction",
                            RealisateurId = 10,
                            Titre = "Star Wars : Le retour du Jedi"
                        },
                        new
                        {
                            FilmId = 4,
                            AnneeDeSortie = 2005,
                            Genre = "Société",
                            RealisateurId = 8,
                            Titre = "Hooligans"
                        },
                        new
                        {
                            FilmId = 5,
                            AnneeDeSortie = 2001,
                            Genre = "Heroic-Fantasy",
                            RealisateurId = 9,
                            Titre = "LOTR - La communauté de l'anneau"
                        },
                        new
                        {
                            FilmId = 6,
                            AnneeDeSortie = 2002,
                            Genre = "Heroic-Fantasy",
                            RealisateurId = 9,
                            Titre = "LOTR - Les deux tours"
                        },
                        new
                        {
                            FilmId = 7,
                            AnneeDeSortie = 2003,
                            Genre = "Heroic-Fantasy",
                            RealisateurId = 9,
                            Titre = "LOTR - Le retour du roi"
                        });
                });

            modelBuilder.Entity("EXO_ENTITY_NET_CLOUD.Entities.FilmPersonne", b =>
                {
                    b.Property<int>("PersonneId")
                        .HasColumnType("int");

                    b.Property<int>("FilmId")
                        .HasColumnType("int");

                    b.HasKey("PersonneId", "FilmId");

                    b.HasIndex("FilmId");

                    b.ToTable("FilmPersonne");

                    b.HasData(
                        new
                        {
                            PersonneId = 3,
                            FilmId = 1
                        },
                        new
                        {
                            PersonneId = 4,
                            FilmId = 1
                        },
                        new
                        {
                            PersonneId = 5,
                            FilmId = 1
                        },
                        new
                        {
                            PersonneId = 3,
                            FilmId = 2
                        },
                        new
                        {
                            PersonneId = 4,
                            FilmId = 2
                        },
                        new
                        {
                            PersonneId = 5,
                            FilmId = 2
                        },
                        new
                        {
                            PersonneId = 3,
                            FilmId = 3
                        },
                        new
                        {
                            PersonneId = 4,
                            FilmId = 3
                        },
                        new
                        {
                            PersonneId = 5,
                            FilmId = 3
                        },
                        new
                        {
                            PersonneId = 1,
                            FilmId = 4
                        },
                        new
                        {
                            PersonneId = 2,
                            FilmId = 4
                        },
                        new
                        {
                            PersonneId = 1,
                            FilmId = 5
                        },
                        new
                        {
                            PersonneId = 6,
                            FilmId = 5
                        },
                        new
                        {
                            PersonneId = 7,
                            FilmId = 5
                        },
                        new
                        {
                            PersonneId = 1,
                            FilmId = 6
                        },
                        new
                        {
                            PersonneId = 6,
                            FilmId = 6
                        },
                        new
                        {
                            PersonneId = 7,
                            FilmId = 6
                        },
                        new
                        {
                            PersonneId = 1,
                            FilmId = 7
                        },
                        new
                        {
                            PersonneId = 6,
                            FilmId = 7
                        },
                        new
                        {
                            PersonneId = 7,
                            FilmId = 7
                        });
                });

            modelBuilder.Entity("EXO_ENTITY_NET_CLOUD.Entities.Personne", b =>
                {
                    b.Property<int>("PersonneId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersonneId"), 1L, 1);

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("PersonneId");

                    b.ToTable("personnes");

                    b.HasData(
                        new
                        {
                            PersonneId = 1,
                            Nom = "Wood",
                            Prenom = "Elijah"
                        },
                        new
                        {
                            PersonneId = 2,
                            Nom = "Hunnam",
                            Prenom = "Charlie"
                        },
                        new
                        {
                            PersonneId = 3,
                            Nom = "Ford",
                            Prenom = "Harisson"
                        },
                        new
                        {
                            PersonneId = 4,
                            Nom = "Hammil",
                            Prenom = "Mark"
                        },
                        new
                        {
                            PersonneId = 5,
                            Nom = "Fisher",
                            Prenom = "Carrie"
                        },
                        new
                        {
                            PersonneId = 6,
                            Nom = "Mortensen",
                            Prenom = "Vigo"
                        },
                        new
                        {
                            PersonneId = 7,
                            Nom = "Bloom",
                            Prenom = "Orlando"
                        },
                        new
                        {
                            PersonneId = 8,
                            Nom = "Alexander",
                            Prenom = "Lexi"
                        },
                        new
                        {
                            PersonneId = 9,
                            Nom = "Jackson",
                            Prenom = "Peter"
                        },
                        new
                        {
                            PersonneId = 10,
                            Nom = "Lucas",
                            Prenom = "Georges"
                        });
                });

            modelBuilder.Entity("EXO_ENTITY_NET_CLOUD.Entities.Film", b =>
                {
                    b.HasOne("EXO_ENTITY_NET_CLOUD.Entities.Personne", "Realisateur")
                        .WithMany("AEteRealisateur")
                        .HasForeignKey("RealisateurId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Realisateur");
                });

            modelBuilder.Entity("EXO_ENTITY_NET_CLOUD.Entities.FilmPersonne", b =>
                {
                    b.HasOne("EXO_ENTITY_NET_CLOUD.Entities.Film", "Film")
                        .WithMany("AEmbaucheDesActeurs")
                        .HasForeignKey("FilmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EXO_ENTITY_NET_CLOUD.Entities.Personne", "Personne")
                        .WithMany("AEteActeur")
                        .HasForeignKey("PersonneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Film");

                    b.Navigation("Personne");
                });

            modelBuilder.Entity("EXO_ENTITY_NET_CLOUD.Entities.Film", b =>
                {
                    b.Navigation("AEmbaucheDesActeurs");
                });

            modelBuilder.Entity("EXO_ENTITY_NET_CLOUD.Entities.Personne", b =>
                {
                    b.Navigation("AEteActeur");

                    b.Navigation("AEteRealisateur");
                });
#pragma warning restore 612, 618
        }
    }
}