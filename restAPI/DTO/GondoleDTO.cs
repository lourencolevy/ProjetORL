using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFTest.DTO
{
    public class GondoleDTO
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public List<PlancheDTO> ListPlancheDTO { get; set; }
    }
}
