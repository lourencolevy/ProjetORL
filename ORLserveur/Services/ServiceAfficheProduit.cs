using ORLserveur.Repositories;
using ORLserveur.Services.Interfaces;
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
    ///     
    /// Méthodes pour renvoyer aux DTOs:
    ///     * Faire les listes en fonction d'iD 
    ///     * Faire les listes
    /// </summary>
    public class ServiceAfficheProduit : IService
    {
        private PocoProduit pm;
        private RepositoryProduit rm;

        public ServiceAfficheProduit()
        {
            pm = new PocoProduit();
            rm = new RepositoryProduit();
        }
    }
}
