using ORLserveur.DTO;
using ORLserveur.Repositories;
using ORLserveur.Services.Interfaces;
using ORLserveur.Services.Mappings;
using ORLserveur.Services.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ORLserveur.Services
{
    /// <summary>
    /// ServiceProduit va Contenir les actions du service.
    /// Il utilise 2 objets :
    ///     *PoccoMagasin
    ///     *RepositoryMagasin
    ///     
    /// 
    /// 
    /// </summary>
    public class ServiceAfficheMagasin : IService
    {
        private PocoMagasin pm;
        private RepositoryMagasin rm;

        public ServiceAfficheMagasin()
        {
            pm = new PocoMagasin();
            rm = new RepositoryMagasin();
        }

        //public IEnumerable<DtoMagasin> findAll()
        //{
        //    // récupération des Magasin depuis la BDD
        //    ICollection<DtoMagasin> Magasins = rm.FindAll().ToList();
        //    // transformation en DTO
        //    ICollection<DtoMagasin> DtoMagasins = MagasinDtoMagasin.Map(Magasins);
        //    return DtoMagasins;
        //}
    }
}
