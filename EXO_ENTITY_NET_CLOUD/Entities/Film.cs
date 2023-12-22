using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXO_ENTITY_NET_CLOUD.Entities
{
    public class Film
    {
        public int FilmId { get; set; }
        [Required]
        [MaxLength(100)]
        public string Titre { get; set; }
        [Required]
        [MaxLength(100)]
        public string Genre { get; set; }
        public int AnneeDeSortie { get; set; }
        public int RealisateurId {  get; set; }
        public Personne Realisateur { get; set; }

        public List<FilmPersonne> AEmbaucheDesActeurs { get; set; }

       
    }
}
