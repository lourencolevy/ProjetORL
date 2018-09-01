using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ORLserveur.DTO
{
    /// <summary>
    /// Une class DTO qui stocke des données concernant les magasins.
    /// On utilise cet class pour transferer les données 
    /// de la couche Metier vers les controleurs.
    /// 
    /// Ici il faut donc faire la même chose
    /// que l'exemple avec ces variables :
    ///     *IdMag
    ///     *NomMag
    ///     *Adresse1Mag
    ///     *CodePostalMag
    ///     *VilleMag
    ///     *TypoMag
    ///     *IdEnseigneMag
    ///     *NomEnseigneMag
    ///     *DnMag // Pourcentage donc decimal // Dn= Distribution Numérique => Dn= (Nbr Magasin qui ont le produit / Nbr Magasin qui propose un produit de cette gamme)*100
    ///     *NbrProduitRuptureMag
    ///     *ListPourcProduitMag // List<String> 
    ///     *ListNomProduitMag // List<string>
    ///     *IdListNomProduitMag// List<int>
    ///     *NbrVisiteMag
    ///     *ListDnHistoMag // Liste de Dn pour faire un diagramme historique
    ///     *ListDateHistoMag  // Liste de date pour le diagramme historique
    /// </summary>
    public class DtoMagasin
    {
        //Exemple

        public int IdMag {get;set;}
    }
}
