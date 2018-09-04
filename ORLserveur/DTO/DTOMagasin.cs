using System;
using System.Collections.Generic;

namespace ORLserveur.DTO
{
    public class DtoMagasin 
    {
        public int Id { get; set; }
        public string Adresse1 { get; set; }
        public string Adresse2 { get; set; }
        public string Adresse3 { get; set; }
        public string CodePostal { get; set; }
        public string Ville { get; set; }
        public string Typo { get; set; }
        public int EnseigneId { get; set; }

        public ICollection<DtoRayon> ListDtoRayon { get; set; }
    }
}
