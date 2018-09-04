using AutoMapper;
using ORLserveur;
using ORLserveur.DTO;
using ORLserveur.Entities;
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
        private readonly RepositoryPlancheProduit PPRepo;
        private readonly RepositoryProduit ProduitRepo;
        public ServiceProduit()
        {
            PPRepo = new RepositoryPlancheProduit();
            ProduitRepo = new RepositoryProduit();
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
        }
        public void ModifierProduit(DtoProduit aDtoUtilisateur)
        {
            Produit oProduit = Mapper.Map<DtoProduit, Produit>(aDtoUtilisateur);
            ProduitRepo.Edit(oProduit);
        }
        public void SupprimerProduit(DtoProduit aDtoUtilisateur)
        {
            Produit oProduit = Mapper.Map<DtoProduit, Produit>(aDtoUtilisateur);
            ProduitRepo.Delete(oProduit);
        }
        public DtoProduit TrouverProduitAvecId(int aId)
        {
            return Mapper.Map<Produit, DtoProduit>
                (ProduitRepo.FindById(aId).FirstOrDefault());
        }
        public ICollection<DtoProduit> TrouverProduits()
        {
            return Mapper.Map<ICollection<Produit>, ICollection<DtoProduit>>(ProduitRepo.FindAll().ToList());
        }
    }
}
