using ORL.Dal.Entities;
using ORL.Dal.Entities.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ORL.Dal.Repositories
{
    /// <summary>
    /// RepositoryMagasin contient les requetes vers la bdbd pour le serviceMagasin
    /// </summary>
    public class RepositoryMagasin : CrudRepository<orlContext, Magasin>
    {
        private orlContext _context = new orlContext();
        public RepositoryMagasin() : base()
        {

        }
    }
}
