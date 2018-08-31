using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFTest.DTO
{
    public class MarqueDTO
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Descriptif { get; set; }
        public List<GammeDTO> ListGammeDTO { get; set; }
    }
}
