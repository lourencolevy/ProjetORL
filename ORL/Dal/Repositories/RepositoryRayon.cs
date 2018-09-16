using ORL.Dal.Entities;
using ORL.Dal.Entities.Contexts;
using System;
using System.Collections.Generic;

namespace ORL.Dal.Repositories
{
    public class RepositoryRayon : CrudRepository<orlContext, Rayon>
    {
        private orlContext _context = new orlContext();
        public RepositoryRayon() : base()
        {

        }
    }
}
