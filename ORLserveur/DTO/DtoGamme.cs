using System;
using System.Collections.Generic;

namespace ORLserveur.DTO
{
    /// <summary>
    /// Une class DTO qui stocke des données concernant le produit.
    /// On utilise cet class pour transferer les données 
    /// de la couche Metier vers les controleurs.
    /// 
    /// Ici il faut donc faire la même chose
    /// que l'exemple avec ces variables :
    ///     
    ///     * 
    /// </summary>
    public class DtoGamme 
    {
        public int Id { get; set; }
        public int FamilleId { get; set; }
        public string Nom { get; set; }

        public ICollection<Produit> Produit { get; set; }
    }
}
