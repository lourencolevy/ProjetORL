using ORLserveur.Entities;
using System;
using System.Collections.Generic;

namespace ORLserveur.Entities
{
    public partial class PlancheProduit : EntityBase
    {
        public int Id { get; set; }
        public int PlancheId { get; set; }
        public int ProduitId { get; set; }
        public int VisiteId { get; set; }
        public int? NombreProduit { get; set; }

        public Planche Planche { get; set; }
        public Produit Produit { get; set; }
        public Visite Visite { get; set; }
    }
}
