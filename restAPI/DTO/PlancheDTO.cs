using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFTest.DTO
{
    public class PlancheDTO
    {
        public int Id { get; set; }
        public string NumeroPlanche { get; set; }
        public sbyte? Rupture { get; set; }
        public List<ProduitDTO> ListProduitDTO { get; set; }
    }
}
