using System;
using System.Collections.Generic;

namespace ORLserveur.DTO
{
    public class DtoGamme 
    {
        public int Id { get; set; }
        public int FamilleId { get; set; }
        public string Nom { get; set; }

        public ICollection<Produit> Produit { get; set; }
    }
}
