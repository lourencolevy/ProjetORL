using ORLserveur.Entities;
using System;
using System.Collections.Generic;

namespace ORLserveur.DTO.Interfaces.InterfacesBase
{
    interface IDtoVisite
    {
         int Id { get; set; }
         int UserId { get; set; }
         string Date { get; set; }

         DtoUtilisateur User { get; set; }
    }
}
