using ORLserveur.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ORLserveur.Repositories
{
    /// <summary>
    /// RepositoryMagasin contient les requetes vers la bdbd pour le serviceMagasin
    /// </summary>
    public class RepositoryMagasin : CrudRepository<orlContext, DtoMagasin>
    {
        private orlContext _context = new orlContext();
        public RepositoryMagasin(): base()
        {

        }

        public override IQueryable<DtoMagasin> FindAll()
        {
            IQueryable<DtoMagasin> query = _context.Set<DtoMagasin>();
            return query;
        }
    }
}
