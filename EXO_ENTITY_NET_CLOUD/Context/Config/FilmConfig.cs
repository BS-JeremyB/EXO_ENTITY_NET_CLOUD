using EXO_ENTITY_NET_CLOUD.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXO_ENTITY_NET_CLOUD.Context.Config
{
    public class FilmConfig : IEntityTypeConfiguration<Film>
    {
        public void Configure(EntityTypeBuilder<Film> builder)
        {
            //ID
            builder.HasKey(x => x.FilmId);
            builder.Property(x => x.FilmId).ValueGeneratedOnAdd();

            //Contraintes
            builder.Property(x => x.Genre).IsRequired().HasMaxLength(100);
            builder.Property(x => x.AnneeDeSortie).IsRequired();
            builder.HasCheckConstraint("CK_Annee", "AnneeDeSortie > 1975");
            builder.HasIndex(x => x.Titre).IsUnique();

            builder.HasOne(f => f.Realisateur)
                   .WithMany(p => p.AEteRealisateur)
                   .HasForeignKey(f => f.RealisateurId);

        }
    }
}
