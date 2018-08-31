using EntityFTest.repositories;
using System;
using System.Collections.Generic;

namespace EntityFTest
{
    public partial class Magasin : EntityBase
    {
        public Magasin()
        {
            Rayon = new HashSet<Rayon>();
        }

        
        public string Adresse1 { get; set; }
        public string Adresse2 { get; set; }
        public string Adresse3 { get; set; }
        public string CodePostal { get; set; }
        public string Ville { get; set; }
        public string Typo { get; set; }
        public int EnseigneId { get; set; }

        public Enseigne Enseigne { get; set; }
        public ICollection<Rayon> Rayon { get; set; }
    }
}
