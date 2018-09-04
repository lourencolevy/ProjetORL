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
        public ICollection<DtoProduit> GetProductByPlanche(DtoPlanche ePlanche)
        {
            Planche planche = AutoMapper.Mapper.Map<DtoPlanche, Planche>(ePlanche);
            ICollection<DtoProduit> listProd = new List<DtoProduit>();
            ICollection<PlancheProduit> listPlancheProd = PPRepo.GetProductsByPlanche(planche).ToList();
            foreach (var item in listPlancheProd)
            {
                DtoProduit b = AutoMapper.Mapper.Map<Produit, DtoProduit>
                    (ProduitRepo.FindById(item.PlancheId).ToList().FirstOrDefault());
            }
            return listProd;
        }
    }
}
