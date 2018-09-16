using System;
using System.Collections.Generic;

namespace ORL.Dal.Entities
{
    public partial class Magasin : EntityBase
    {
        public Magasin()
        {
            Rayon = new HashSet<Rayon>();
        }

        public int Id { get; set; }
        public string Adresse1 { get; set; }
        public string Adresse2 { get; set; }
        public string Adresse3 { get; set; }
        public string CodePostal { get; set; }
        public string Ville { get; set; }
        public string Typo { get; set; }
        public int EnseigneId { get; set; }
        public sbyte? ProduitPresent { get; set; }

        public Enseigne Enseigne { get; set; }
        public ICollection<Rayon> Rayon { get; set; }
    }
}
