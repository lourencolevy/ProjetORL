using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ORL.Bll.DTO
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
    public class DtoProduit
    {
        //Exemple
        public int Id { get; set; }
        public int GammeId { get; set; }
        public string CodeBarre { get; set; }
        public int MarqueId { get; set; }
        public string Debut { get; set; }
        public string Fin { get; set; }
        public sbyte? MonProduit { get; set; }
        public decimal DistributionNumerique { get; set; } 

        public DtoGamme Gamme { get; set; }
        public DtoMarque Marque { get; set; }
        public ICollection<DtoPlancheProduit> PlancheProduit { get; set; }
        public ICollection<DtoMagasin> MagasinsProduitPresent { get; set; }

    }
}
