using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ORLserveur.DTO
{
    public class DtoProduitMagasin
    {
        public DtoProduit oProduit { get; set; }
        public DtoMagasin oMagasin { get; set; }
        public int Facing { get; set; }
        public decimal PresenceProduit {get;set;}
        public List<DtoProduit> ProduitsClient { get; set; }
        public List<DtoProduit> ProduitsConcurrent { get; set; }
        public List<DtoVisite> Visites { get; set; }
    }
}
