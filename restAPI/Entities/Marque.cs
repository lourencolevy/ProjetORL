using EntityFTest.repositories;
using System;
using System.Collections.Generic;

namespace EntityFTest
{
    public partial class Marque : EntityBase
    {
        public Marque()
        {
            Produit = new HashSet<Produit>();
            Utilisateur = new HashSet<Utilisateur>();
        }

        
        public string Nom { get; set; }
        public string Addresse1 { get; set; }
        public string Adresse2 { get; set; }
        public string Addresse3 { get; set; }
        public string CodePostal { get; set; }
        public string Ville { get; set; }

        public ICollection<Produit> Produit { get; set; }
        public ICollection<Utilisateur> Utilisateur { get; set; }
    }
}
