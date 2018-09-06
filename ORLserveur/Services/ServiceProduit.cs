using AutoMapper;
using ORLserveur;
using ORLserveur.DTO;
using ORLserveur.Entities;
using ORLserveur.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ORLserveur.Repositories
{
    /// <summary>
    /// RepositoryProduit Contient les requetes vers la bdbd pour le serviceProduit 
    /// 
    /// </summary>
    public class ServiceProduit
    {
        private readonly DtoProduit oDtoProduit;
        private readonly ServicePlancheProduit oServicePlancheProduit;
        private readonly ServicePlanche oServicePlanche;
        private readonly ServiceElementGondole oServiceElementGondole;
        private readonly ServiceRayon oServiceRayon;
        private readonly ServiceMagasin oServiceMagasin;
        private readonly RepositoryPlancheProduit PPRepo;
        private readonly RepositoryProduit ProduitRepo;
        public ServiceProduit()
        {
            PPRepo = new RepositoryPlancheProduit();
            ProduitRepo = new RepositoryProduit();
            oServiceMagasin = new ServiceMagasin();
            oServiceRayon = new ServiceRayon();
            oServiceElementGondole = new ServiceElementGondole();
            oServicePlanche = new ServicePlanche();
            oServicePlancheProduit = new ServicePlancheProduit();
        }
        public ICollection<DtoProduit> GetProductByPlanche(DtoPlanche aPlanche)
        {
            Planche planche = Mapper.Map<DtoPlanche, Planche>(aPlanche);
            ICollection<DtoProduit> listProd = new List<DtoProduit>();
            ICollection<PlancheProduit> listPlancheProd = PPRepo.GetProductsByPlanche(planche).ToList();
            foreach (var item in listPlancheProd)
            {
                DtoProduit b = Mapper.Map<Produit, DtoProduit>
                    (ProduitRepo.FindById(item.PlancheId).ToList().FirstOrDefault());
            }
            return listProd;
        }
        public void AjouterProduit(DtoProduit aDtoProduit)
        {
            Produit oProduit = Mapper.Map<DtoProduit, Produit>(aDtoProduit);
            ProduitRepo.Add(oProduit);
            ProduitRepo.Save();
        }
        public void ModifierProduit(DtoProduit aDtoUtilisateur)
        {
            Produit oProduit = Mapper.Map<DtoProduit, Produit>(aDtoUtilisateur);
            ProduitRepo.Edit(oProduit);
            ProduitRepo.Save();
        }
        public void SupprimerProduit(DtoProduit aDtoUtilisateur)
        {
            Produit oProduit = Mapper.Map<DtoProduit, Produit>(aDtoUtilisateur);
            ProduitRepo.Delete(oProduit);
            ProduitRepo.Save();
        }
        public DtoProduit TrouverProduitAvecId(int aId)
        {
            return Mapper.Map<Produit, DtoProduit>
                (ProduitRepo.FindById(aId).FirstOrDefault());
        }
        public ICollection<DtoProduit> ListerProduits()
        {
            return Mapper.Map<ICollection<Produit>, ICollection<DtoProduit>>(ProduitRepo.FindAll().ToList());
        }
        public int NbrMagasinProduitPresent(DtoProduit adtoProduit)
        {
            var req = from dtoMagasin in oServiceMagasin.ListerMagasins()
                            join dtoRayon in oServiceRayon.ListerRayons() on dtoMagasin.Id equals dtoRayon.MagasinId
                            join dtoElementGondole in oServiceElementGondole.ListerElementGondoles() on dtoRayon.Id equals dtoElementGondole.RayonId
                            join dtoPlanche in oServicePlanche.ListerPlanches() on dtoElementGondole.Id equals dtoPlanche.ElementGondoleId
                            join dtoPlancheProduit in oServicePlancheProduit.ListerPlancheProduits() on dtoPlanche.Id equals dtoPlancheProduit.PlancheId
                            join dtoProduit in ListerProduits() on dtoPlancheProduit.ProduitId equals dtoProduit.Id
                            where adtoProduit.MonProduit == 1
                            select dtoMagasin;

            int result = req.Count();
            return result;
        }
        public int NbrMagasin()
        {
            return oServiceMagasin.ListerMagasins().Count;
        }
        public decimal DistributionNumerique(DtoProduit adtoProduit)
        {
            decimal Dn = (NbrMagasinProduitPresent(adtoProduit) / NbrMagasin()) * 100;
            oDtoProduit.DistributionNumerique = Dn;
            return Dn;
        }
    }
}
