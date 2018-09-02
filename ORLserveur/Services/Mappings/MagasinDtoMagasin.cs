using ORLserveur.DTO;
using ORLserveur.DTO.Interfaces;
using ORLserveur.Services.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ORLserveur.Services.Mappings
{
    /// <summary>
    /// Cette classe map la classe Magasin et DtoMagasin
    /// 
    ///  que l'exemple avec ces variables :
    ///  
    /// A gauche Les variables type DTO et A droite Les variables type Entities
    /// 
    ///Région Les données du Magasin
    ///     *IdMagasin = Id (Magasin)
    ///     *NomMag = Nom (Enseigne)
    ///     *Adresse1Mag = Adresse1 (Magasin)
    ///     *CodePostalMag = CodePostal (Magasin)
    ///     *VilleMag = Ville(Magasin)
    ///     *TypoMag = Typo (Magasin)
    ///     *IdEnseigneMag = EnseigneId (Magasin)
    ///     *NomEnseigneMag = Nom (Enseigne)
    ///Région Les données pour les statistiques
    ///     *DnMag = DnMag (PocoMagasin)
    ///     *NbrProduitRuptureMag = NbrProduitRuptureMag (PocoMagasin)
    ///     *ListPourcProduitMag = ListPourcProduitMag (PocoMagasin)
    ///     *ListNomProduitMag = ListNomProduitMag (PocoMagasin)
	///     * IdListNomProduitMag = IdListNomProduitMag (PocoMagasin)
    ///     *NbrVisiteMag = NbrVisiteMag (PocoMagasin)
    ///     *ListDnHistoMag // ListDnHistoMag (PocoMagasin)
    ///     *ListDateHistoMag  // ListDateHistoMag (PocoMagasin)
    /// 
    /// </summary>
    static class MagasinDtoMagasin
    {
        public static DtoMagasin Map(IDtoAfficheMagasin aMagasin, DtoEnseigne aEnseigne, PocoMagasin aPocomagasin)
        {
            DtoMagasin oDtoMagasin = new DtoMagasin();
            oDtoMagasin.IdMagasin = aMagasin.Id;
            oDtoMagasin.Adresse1Mag = aMagasin.Adresse1;
            oDtoMagasin.CodePostalMag = aMagasin.CodePostal;
            oDtoMagasin.VilleMag = aMagasin.Ville;
            oDtoMagasin.TypoMag = aMagasin.Typo;
            oDtoMagasin.IdEnseigneMag = aMagasin.IdEnseigneMag;

            oDtoMagasin.NomEnseigneMag = aEnseigne.Nom;

            oDtoMagasin.DnMag = aPocomagasin.DnMag;
            oDtoMagasin.NbrProduitRuptureMag = aPocomagasin.NbrProduitRuptureMag;
            oDtoMagasin.ListPourcProduitMag = aPocomagasin.ListPourcProduitMag;
            oDtoMagasin.ListNomProduitMag = aPocomagasin.ListNomProduitMag;
            oDtoMagasin.IdListNomProduitMag = aPocomagasin.IdListNomProduitMag;
            oDtoMagasin.NbrVisiteMag = aPocomagasin.NbrVisiteMag;
            oDtoMagasin.ListDnHistoMag = aPocomagasin.ListDnHistoMag;
            oDtoMagasin.ListDateHistoMag = aPocomagasin.ListDateHistoMag;

           

            return oDtoMagasin;
        }

        public static DtoMagasin Map(DtoMagasin oDtoMagasin, DtoEnseigne aEnseigne, PocoMagasin aPocomagasin)
        {
            DtoMagasin magasin = new DtoMagasin();
            magasin.Id = oDtoMagasin.IdMagasin;
            magasin.Adresse1 = oDtoMagasin.Adresse1Mag;
            magasin.CodePostal = oDtoMagasin.CodePostalMag;
            magasin.Ville = oDtoMagasin.VilleMag;
            magasin.Typo = oDtoMagasin.TypoMag;
            magasin.IdEnseigneMag = oDtoMagasin.IdEnseigneMag;

            aEnseigne.Nom = oDtoMagasin.NomEnseigneMag;

            aPocomagasin.DnMag = oDtoMagasin.DnMag;
            aPocomagasin.NbrProduitRuptureMag = oDtoMagasin.NbrProduitRuptureMag;
            aPocomagasin.ListPourcProduitMag = oDtoMagasin.ListPourcProduitMag;
            aPocomagasin.ListNomProduitMag = oDtoMagasin.ListNomProduitMag;
            aPocomagasin.IdListNomProduitMag = oDtoMagasin.IdListNomProduitMag;
            aPocomagasin.NbrVisiteMag = oDtoMagasin.NbrVisiteMag;
            aPocomagasin.ListDnHistoMag = oDtoMagasin.ListDnHistoMag;
            aPocomagasin.ListDateHistoMag = oDtoMagasin.ListDateHistoMag;
            return magasin;
        }

        public static void MapEnseigneMag(DtoMagasin aMagsasin,DtoMagasin aDtoMagasin, DtoEnseigne aEnseigne)
        {
            aEnseigne.IdEnseigneMag = aDtoMagasin.IdEnseigneMag;
            aEnseigne.Nom = aDtoMagasin.NomEnseigneMag;
        }

        public void Magasin MapPoccoDTO(DtoMagasin aMagsasin, DtoMagasin aDtoMagasin, PocoMagasin aPoccoMagasin)
        {
            aPocomagasin.DnMag = oDtoMagasin.DnMag;
            aPocomagasin.NbrProduitRuptureMag = oDtoMagasin.NbrProduitRuptureMag;
            aPocomagasin.ListPourcProduitMag = oDtoMagasin.ListPourcProduitMag;
            aPocomagasin.ListNomProduitMag = oDtoMagasin.ListNomProduitMag;
            aPocomagasin.IdListNomProduitMag = oDtoMagasin.IdListNomProduitMag;
            aPocomagasin.NbrVisiteMag = oDtoMagasin.NbrVisiteMag;
            aPocomagasin.ListDnHistoMag = oDtoMagasin.ListDnHistoMag;
            aPocomagasin.ListDateHistoMag = oDtoMagasin.ListDateHistoMag;

            return magasin;
        }

        public static ICollection<DtoMagasin> Map(IEnumerable<DtoMagasin> magasins, DtoEnseigne aEnseigne, PocoMagasin aPocomagasin)
        {
            ICollection<DtoMagasin> dtoMagasins = new List<DtoMagasin>();

            foreach (var magasin in magasins)
            {
                dtoMagasins.Add(Map(magasin));
            }

            return dtoMagasins;
        }


        public static ICollection<DtoMagasin> Map(IEnumerable<DtoMagasin> dtoMagasins, IEnumerable<DtoEnseigne> aEnseigne, IEnumerable<PocoMagasin> aPocomagasin)
        {
            ICollection<DtoMagasin> magasins = new List<DtoMagasin>();
            foreach (var dtoMagasin in dtoMagasins)
            {
                magasins.Add(Map(dtoMagasin));
            }
            return magasins;
        }
    }
}
