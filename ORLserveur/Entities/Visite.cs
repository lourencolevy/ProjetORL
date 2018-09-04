using ORLserveur.Entities;
using System;
using System.Collections.Generic;

namespace ORLserveur.Entities
{
    public partial class Visite : EntityBase
    {
        public Visite()
        {
            PlancheProduit = new HashSet<PlancheProduit>();
        }

        public int Id { get; set; }
        public int UserId { get; set; }
        public string Date { get; set; }

        public Utilisateur User { get; set; }
        public ICollection<PlancheProduit> PlancheProduit { get; set; }
    }
}
