using ORLserveur.Entities;
using System;
using System.Collections.Generic;

namespace ORLserveur.DTO.Interfaces.InterfacesBase
{
    interface IDtoMarque
    {
         int Id { get; set; }
         string Nom { get; set; }
         string Addresse1 { get; set; }
         string Adresse2 { get; set; }
         string Addresse3 { get; set; }
         string CodePostal { get; set; }
         string Ville { get; set; }

        public ICollection<Produit> Produit { get; set; }
        public ICollection<DtoUtilisateur> Utilisateur { get; set; }
    }
}
