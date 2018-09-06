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
        public ICollection<DtoProduit> ProduitsClient { get; set; }
        public ICollection<DtoProduit> ProduitsConcurrent { get; set; }
        public ICollection<DtoVisite> VisitesProduitMagasin { get; set; }
    }
}
