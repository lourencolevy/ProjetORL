using System;
using System.Collections.Generic;

namespace ORLserveur.DTO.Interfaces.InterfacesBase
{
    interface IDtoGamme
    {
         int Id { get; set; }
         int FamilleId { get; set; }
         string Nom { get; set; }

        public ICollection<Produit> Produit { get; set; }
    }
}
