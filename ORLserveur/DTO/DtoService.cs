//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace ORLserveur.DTO
//{
//    /// <summary>
//    /// DTO Service ce que renvoi service 
//    /// 
//    /// Methodes pour IDtoAfficheProduit: 
//    ///     *ListNomProduit
//    ///     *ListIdProduit
//    ///     *ListNomGamme
//    ///     *ListIdGamme
//    ///     
//    ///     *DernierVisitMagDate // Date de la dernière visite où le produit à été controlé
//    ///     *DernierVisitMagNom // Nom du dernier Magasin où le produit à été controlé
//    ///     *DernierVisitMagId
//    ///     *PourcRuptureProduit
//    ///     PourcFacingProduit
//    ///
//    /// Methodes pour IDtoAfficheMagasin:
//    ///     * DnMag // Pourcentage donc decimal // Dn= Distribution Numérique => Dn= (Nbr Magasin qui ont le produit / Nbr Magasin qui propose un produit de cette gamme)*100
//    ///     *NbrProduitRuptureMag
//    ///     *ListPourcProduitMag // List<decimal>
//    ///     *ListNomProduitMag // List<string>
//    ///     * IdListNomProduitMag// List<int>
//    ///     *NbrVisiteMag
//    ///     *ListDnHistoMag // Liste de Dn pour faire un diagramme historique
//    ///     *ListDateHistoMag  // Liste de date pour le diagramme historique
//    ///     *
//    /// </summary>
//    public class DtoService
//    {
//        //Attributs pour IDtoAfficheProduit
        
        
//        public ICollection<DtoPlancheProduit> ListePlancheProduit { get; set; }

//        public decimal PourcRuptureProduit { get; set; }
//        public decimal PourcFacingProduit { get; set; }

//        //Attributs pour IDtoAfficheMagasin
//        public decimal  DnMagasin { get; set; }
//        public int NbrProduitRuptureMag { get; set; }
//        public ICollection<DtoProduit> ListProduitMag { get; set; }
//        public int NbrVisiteMag { get; set; }
//        public List<decimal> ListDnHistoMag { get; set; }
//        public List<DateTime> ListDateHistoMag { get; set; }
//    }
//}
