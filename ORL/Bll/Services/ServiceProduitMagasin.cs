using AutoMapper;
using ORL.Bll.DTO;
using ORL.Dal.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ORL.Bll.Services
{
    public class ServiceProduitMagasin
    {
        private readonly ServiceMagasin serviceMagasin;
        private readonly ServiceProduit serviceProduit;
        private readonly RepositoryProduitMagasin repoProduitMagasin;
        private readonly DtoProduitMagasin dtoProduitMagasin;
        public ServiceProduitMagasin()
        {
            repoProduitMagasin = new RepositoryProduitMagasin();
            serviceProduit = new ServiceProduit();
            serviceMagasin = new ServiceMagasin();
        }

        public DtoProduit TrouverProduitMAvecId(int aId)
        {
            dtoProduitMagasin.oProduit = serviceProduit.TrouverProduitAvecId(aId);
            return dtoProduitMagasin.oProduit;
        }

        public DtoMagasin TrouverMagasinPAvecId(int aId)
        {
            dtoProduitMagasin.oMagasin = serviceMagasin.TrouverMagasinAvecId(aId);
            return dtoProduitMagasin.oMagasin;
        }

        public int Facing()
        {
            int facing = serviceProduit.ListerProduits()
                .Where(o => o.MonProduit == 1)
                .Count();
            return facing;
        }
        public decimal PresenceProduit(List<DtoProduit> ProduitsClient, List<DtoProduit> ProduitsConcurrent)
        {
            decimal PresenceProduit = (ListerProduitsClient().Count() / (ListerProduitsConcurrent().Count() + ListerProduitsClient().Count())) * 100;
            return PresenceProduit;
        }

        public ICollection<DtoProduit> ListerProduitsClient()
        {
            ICollection<DtoProduit> ProduitsClient = serviceProduit.ListerProduits()
                .Where(o => o.MonProduit == 1)
                .ToList();
            dtoProduitMagasin.ProduitsClient = ProduitsClient;
            return ProduitsClient;
        }

        public ICollection<DtoProduit> ListerProduitsConcurrent()
        {
            ICollection<DtoProduit> ProduitsConcurrent = serviceProduit.ListerProduits()
                .Where(o => o.MonProduit == 0)
                .ToList();
            dtoProduitMagasin.ProduitsClient = ProduitsConcurrent;
            return ProduitsConcurrent;
        }
    }
}
