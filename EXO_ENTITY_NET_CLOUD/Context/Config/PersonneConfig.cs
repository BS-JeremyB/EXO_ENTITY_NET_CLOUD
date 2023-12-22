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
    public class PersonneConfig : IEntityTypeConfiguration<Personne>
    {

        public void Configure(EntityTypeBuilder<Personne> builder)
        {
            //ID
            builder.HasKey(x => x.PersonneId);
            builder.Property(x => x.PersonneId).ValueGeneratedOnAdd();

            // Contrainte

            builder.Property(x => x.Prenom).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Nom).IsRequired().HasMaxLength(100);

        }
    }
}
