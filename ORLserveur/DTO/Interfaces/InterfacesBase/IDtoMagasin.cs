using System;
using System.Collections.Generic;

namespace ORLserveur.DTO.Interfaces.InterfacesBase
{
    interface IDtoMagasin
    {

         int Id { get; set; }
         string Adresse1 { get; set; }
         string Adresse2 { get; set; }
         string Adresse3 { get; set; }
         string CodePostal { get; set; }
         string Ville { get; set; }
         string Typo { get; set; }
         int EnseigneId { get; set; }

         ICollection<IDtoRayon> ListIDtoRayon { get; set; }
    }
}
