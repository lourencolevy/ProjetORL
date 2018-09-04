using ORLserveur.Entities;
using System;
using System.Collections.Generic;

namespace ORLserveur.Entities
{
    public partial class Enseigne : EntityBase
    {
        public Enseigne()
        {
            Magasin = new HashSet<Magasin>();
        }

        public int Id { get; set; }
        public string Nom { get; set; }

        public ICollection<Magasin> Magasin { get; set; }
    }
}
