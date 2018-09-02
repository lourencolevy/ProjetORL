using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ORLserveur.DTO.Interfaces.InterfacesBase
{
    /// <summary>
    /// Une class DTO qui stocke des données concernant le produit.
    /// On utilise cet class pour transferer les données 
    /// de la couche Metier vers les controleurs.
    /// 
    /// Ici il faut donc faire la même chose
    /// que l'exemple avec ces variables :
    ///     * IdProduit
    ///     * IdGammeProduit
    ///     * CodeBarreProduit
    ///     * IdMarqueProduit
    ///     * DateDebutProduitSaison
    ///     * DateFinProduitSaison
    ///     * 
    ///     * 
    /// </summary>
    interface IDtoProduit
    {
        //Exemple
         int Id { get; set; }
         int GammeId { get; set; }
         string CodeBarre { get; set; }
         int MarqueId { get; set; }
         string Debut { get; set; }
         string Fin { get; set; }

         DtoGamme Gamme { get; set; }
         DtoMarque Marque { get; set; }
    }
}
