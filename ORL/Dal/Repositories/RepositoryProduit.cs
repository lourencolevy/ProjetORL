using ORL.Dal.Entities;
using ORL.Dal.Entities.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ORL.Dal.Repositories
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
