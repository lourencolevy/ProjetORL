using ORLserveur.Entities;
using System;
using System.Collections.Generic;

namespace ORLserveur.DTO.Interfaces.InterfacesBase
{
    interface IDtoUtilisateur
    {
         int Id { get; set; }
         string Nom { get; set; }
         string Prenom { get; set; }
         string Login { get; set; }
         string Mdp { get; set; }
         int MarqueId { get; set; }

         DtoMarque Marque { get; set; }
         ICollection<DtoVisite> Visite { get; set; }
    }
}
