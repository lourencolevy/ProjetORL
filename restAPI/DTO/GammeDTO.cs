using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFTest.DTO
{
    public class GammeDTO
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public List<ProduitDTO> ListProduitDTO { get; set; }
    }
}
