using ORLserveur.Entities;
using System;
using System.Collections.Generic;

namespace ORLserveur.DTO
{
    public  class DtoPlanche
    {
        public int Id { get; set; }
        public string NumPlanche { get; set; }
        public int ElementGondoleId { get; set; }
        public sbyte? Rupture { get; set; }

        public DtoElementGondole ElementGondole { get; set; }
        public ICollection<DtoProduit> Produits { get; set; }
    }
}
