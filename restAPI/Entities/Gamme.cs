using EntityFTest.repositories;
using System;
using System.Collections.Generic;

namespace EntityFTest
{
    public partial class Gamme : EntityBase
    {
        public Gamme()
        {
            Produit = new HashSet<Produit>();
        }

        
        public int FamilleId { get; set; }
        public string Nom { get; set; }

        public ICollection<Produit> Produit { get; set; }
    }
}
