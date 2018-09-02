using ORLserveur.DTO.Interfaces.InterfacesBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ORLserveur.DTO.Interfaces
{
    /// <summary>
    /// Une interface DTO qui stocke des données concernant le produit.
    /// On utilise cet class pour transferer les données 
    /// de la couche Metier vers les controleurs.
    /// 
    /// Ici il faut donc faire la même chose
    /// que l'exemple avec ces variables :
    ///     
    ///     *
    ///     *
    ///     *
    ///     *NomGammeProduit
    ///     *IdRayonProduit
    ///     *NomRayonProduit
    ///     *CodeBarProduit // string
    ///     *DateDebutProduitSaison
    ///     *DateFinProduitSaison
    ///     *DernierVisitMagDate // Date de la dernière visite où le produit à été controlé
    ///     *DernierVisitMagNom  // Nom du dernier Magasin où le produit à été controlé
    ///     *IdDernierVisitMagNom
    ///     *NumElementGondol
    ///     *IdNumElementGondol
    ///     *NumPlancheProduit
    ///     *IdNumPlancheProduit
    ///     *PourcRuptureProduit // Pourcentage de Rupture du produit // decimal
    ///     *PourcFacingProduit // Pourcentage de Facing du produit // decimal
    /// </summary>
    interface IDtoAfficheProduit : IDtoProduit, IDtoGamme, IDtoRayon, IDtoVisite, IDtoElementGondole, IDtoPlanche
    {

    }
}
