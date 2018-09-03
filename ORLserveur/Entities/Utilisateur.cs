using ORLserveur.Entities;
using System;
using System.Collections.Generic;

namespace ORLserveur
{
    public partial class Utilisateur : EntityBase
    {
        public Utilisateur()
        {
            Visite = new HashSet<Visite>();
        }

        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Login { get; set; }
        public string Mdp { get; set; }
        public int MarqueId { get; set; }

        public Marque Marque { get; set; }
        public ICollection<Visite> Visite { get; set; }
    }
}
