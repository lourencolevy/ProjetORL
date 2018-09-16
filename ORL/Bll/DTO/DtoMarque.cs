using System;
using System.Collections.Generic;

namespace ORL.Bll.DTO
{
    public class DtoMarque
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Addresse1 { get; set; }
        public string Adresse2 { get; set; }
        public string Addresse3 { get; set; }
        public string CodePostal { get; set; }
        public string Ville { get; set; }

        public ICollection<DtoProduit> Produit { get; set; }
        public ICollection<DtoUtilisateur> Utilisateur { get; set; }
    }
}
