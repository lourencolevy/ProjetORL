﻿using ORLserveur.Entities;
using System;
using System.Collections.Generic;

namespace ORLserveur.Entities
{
    public partial class Gamme : EntityBase
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
