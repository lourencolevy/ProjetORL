using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFTest.DTO
{
    public class VisiteDTO
    {
        public int Id { get; set; }
        public string NomMagasinDTO { get; set; }
        public string NomCommercialDTO { get; set; }
        public List<MagasinDTO> LsitMagasinDTOVisite { get; set; }
        public List<RayonDTO> ListRayonDTO { get; set; }
    }
}
