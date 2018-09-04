using ORLserveur.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ORLserveur.DTO
{
    public class DtoPlancheProduit
    {
        public int Id { get; set; }
        public int PlancheId { get; set; }
        public int ProduitId { get; set; }
        public int VisiteId { get; set; }
        public string NombreProduit { get; set; }

        public Planche Planche { get; set; }
        public Produit Produit { get; set; }
        public Visite Visite { get; set; }
    }
}
