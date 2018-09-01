using System;
using System.Collections.Generic;

namespace ORLserveur
{
    public partial class Gamme
    {
        public Gamme()
        {
            Produit = new HashSet<Produit>();
        }

        public int Id { get; set; }
        public int FamilleId { get; set; }
        public string Nom { get; set; }

        public ICollection<Produit> Produit { get; set; }
    }
}
