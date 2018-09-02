using ORLserveur.Entities;
using System;
using System.Collections.Generic;

namespace ORLserveur.DTO.Interfaces.InterfacesBase
{
    interface IDtoPlanche
    {
         int Id { get; set; }
         string NumPlanche { get; set; }
         int ElementGondoleId { get; set; }
         sbyte? Rupture { get; set; }
         DtoElementGondole ElementGondole { get; set; }
    }
}
