using ORLserveur.Contexts.Entities;
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
    public class RepositoryProduit : CrudRepository<orlContext, Produit>
    {
        private orlContext _context = new orlContext();
        public RepositoryProduit() : base()
        {

        }
    }
}
