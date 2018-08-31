using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFTest.DTO
{
    public class RayonDTO
    {
        public int Id { get; set; }
        public String Nom { get; set; }
        public List<GondoleDTO> ListGondoleDTO { get; set; }
    }
}
