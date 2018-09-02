using System;
using System.Collections.Generic;

namespace ORLserveur.DTO.Interfaces.InterfacesBase
{
    interface IDtoMagasin
    {

         int IdMagasin { get; set; }
         string Adresse1Magasin { get; set; }
         string Adresse2Magasin { get; set; }
         string Adresse3Magasin { get; set; }
         string CodePostalMagasin { get; set; }
         string VilleMagasin { get; set; }
         string TypoMagasin { get; set; }
         int EnseigneIdMagasin { get; set; }

         ICollection<IDtoRayon> ListIDtoRayon { get; set; }
    }
}
