using ORLserveur.Entities;
using System;
using System.Collections.Generic;

namespace ORLserveur.DTO
{
    public partial class DtoUtilisateur
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Login { get; set; }
        public string Mdp { get; set; }
        public int MarqueId { get; set; }

        public DtoMarque Marque { get; set; }
        public ICollection<DtoVisite> Visites { get; set; }
        public ICollection<DtoGamme> Gammes { get; set; }
    }
}
