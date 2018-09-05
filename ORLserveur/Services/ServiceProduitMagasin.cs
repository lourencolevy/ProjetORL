using AutoMapper;
using ORLserveur.DTO;
using ORLserveur.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ORLserveur.Services
{
    public class ServiceProduitMagasin
    {
        private readonly RepositoryProduitMagasin RepoProduitMagasin;
        public ServiceProduitMagasin()
        {
            RepoProduitMagasin = new RepositoryProduitMagasin();
        }

       
      
    }
}
