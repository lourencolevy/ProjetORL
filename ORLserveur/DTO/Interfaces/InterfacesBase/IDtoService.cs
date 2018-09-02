using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ORLserveur.DTO.Interfaces.InterfacesBase
{
    interface IDtoService
    {
        //Attributs pour IDtoAfficheProduit
        ICollection<DtoProduit> ListProduit { get; set; }
        ICollection<DtoGamme> ListGamme { get; set; }

        // Faut ajouter la classe PlancheProduit? 
        //ICollection<IDtoPlancheProduit> ListePlancheProduit { get; set; }

        decimal PourcRuptureProduit { get; set; }
        decimal PourcFacingProduit { get; set; }

        //Attributs pour IDtoAfficheMagasin
        decimal DnMagasin { get; set; }
        int NbrProduitRuptureMag { get; set; }
        ICollection<DtoProduit> ListProduitMag { get; set; }
        int NbrVisiteMag { get; set; }
        List<decimal> ListDnHistoMag { get; set; }
        List<DateTime> ListDateHistoMag { get; set; }
    }
}
