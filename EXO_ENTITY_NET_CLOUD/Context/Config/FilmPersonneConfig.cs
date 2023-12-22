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
    public class FilmPersonneConfig : IEntityTypeConfiguration<FilmPersonne>
    {
        public void Configure(EntityTypeBuilder<FilmPersonne> builder)
        {
            builder.HasKey(x => new { x.PersonneId, x.FilmId }) ;

            builder.HasOne(pf => pf.Personne)
                   .WithMany(p => p.AEteActeur)
                   .HasForeignKey(pf => pf.PersonneId);

            builder.HasOne(fp => fp.Film)
                   .WithMany(f => f.AEmbaucheDesActeurs)
                   .HasForeignKey(fp => fp.FilmId);

        }
    }
}
