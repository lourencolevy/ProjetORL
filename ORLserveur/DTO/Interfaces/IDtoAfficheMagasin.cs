using ORLserveur.DTO.Interfaces.InterfacesBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ORLserveur.DTO.Interfaces
{
    /// <summary>
    /// Une class DTO qui stocke des données concernant les magasins.
    /// On utilise cet class pour transferer les données 
    /// de la couche Metier vers les controleurs.
    ///     * DnMag // Pourcentage donc decimal // Dn= Distribution Numérique => Dn= (Nbr Magasin qui ont le produit / Nbr Magasin qui propose un produit de cette gamme)*100
    ///     *NbrProduitRuptureMag
    ///     *ListPourcProduitMag // List<decimal>
    ///     *ListNomProduitMag // List<string>
    ///     * IdListNomProduitMag// List<int>
    ///     *NbrVisiteMag
    ///     *ListDnHistoMag // Liste de Dn pour faire un diagramme historique
    ///     *ListDateHistoMag  // Liste de date pour le diagramme historique
    /// </summary>
    interface IDtoAfficheMagasin : IDtoEnseigne, IDtoMagasin, IDtoService
    {

    }
}
