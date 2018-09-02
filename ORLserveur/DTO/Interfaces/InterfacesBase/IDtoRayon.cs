using ORLserveur.Entities;
using System;
using System.Collections.Generic;

namespace ORLserveur.DTO.Interfaces.InterfacesBase
{
    interface IDtoRayon
    {
         int Id { get; set; }
         int MagasinId { get; set; }
         string NumRayon { get; set; }

         DtoMagasin Magasin { get; set; }
         ICollection<DtoElementGondole> ElementGondole { get; set; }
    }
}
