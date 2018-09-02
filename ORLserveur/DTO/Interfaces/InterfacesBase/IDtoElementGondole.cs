using System;
using System.Collections.Generic;

namespace ORLserveur.DTO.Interfaces.InterfacesBase
{
    interface IDtoElementGondole
    {
        int Id { get; set; }
        int RayonId { get; set; }
        string Numero { get; set; }

        DtoRayon Rayon { get; set; }
        ICollection<DtoPlanche> Planche { get; set; }
    }
}
