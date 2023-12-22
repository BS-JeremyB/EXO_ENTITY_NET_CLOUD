using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXO_ENTITY_NET_CLOUD.Entities
{
    public class Personne
    {
        public int PersonneId { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public List<Film> AEteRealisateur { get; set; }

        public List<FilmPersonne> AEteActeur {  get; set; }
    }
}
