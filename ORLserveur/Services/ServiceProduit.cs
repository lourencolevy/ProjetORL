using ORLserveur.Repositories;
using ORLserveur.Services.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ORLserveur.Services
{
    /// <summary>
    /// ServiceProduit va Contenir les actions du service
    /// 
    /// Il utilise 2 objets :
    ///     *PoccoProduit
    ///     *RepositoryProduit
    /// </summary>
    public class ServiceProduit
    {
        private PocoProduit pm;
        private RepositoryProduit rm;

        public ServiceProduit()
        {
            pm = new PocoProduit();
            rm = new RepositoryProduit();
        }
    }
}
