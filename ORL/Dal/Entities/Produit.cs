using System;
using System.Collections.Generic;

namespace ORL.Dal.Entities
{
    public partial class Produit : EntityBase
    {
        public Produit()
        {
            PlancheProduit = new HashSet<PlancheProduit>();
        }

        public int Id { get; set; }
        public int GammeId { get; set; }
        public string CodeBarre { get; set; }
        public int MarqueId { get; set; }
        public string Debut { get; set; }
        public string Fin { get; set; }
        public sbyte? MonProduit { get; set; }

        public Gamme Gamme { get; set; }
        public Marque Marque { get; set; }
        public ICollection<PlancheProduit> PlancheProduit { get; set; }
    }
}
