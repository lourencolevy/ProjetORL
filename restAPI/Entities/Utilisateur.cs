﻿using EntityFTest.repositories;
using System;
using System.Collections.Generic;

namespace EntityFTest
{
    public partial class Utilisateur : EntityBase
    {
        public Utilisateur()
        {
            Visite = new HashSet<Visite>();
        }

        
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Login { get; set; }
        public string Mdp { get; set; }
        public int MarqueId { get; set; }

        public Marque Marque { get; set; }
        public ICollection<Visite> Visite { get; set; }
    }
}
