using System;
using System.Collections.Generic;

namespace ORLserveur.DTO
{
    public class DtoElementGondole
    {
        public int Id { get; set; }
        public int RayonId { get; set; }
        public string Numero { get; set; }

        public DtoRayon Rayon { get; set; }
        public ICollection<DtoPlanche> Planche { get; set; }
    }
}
