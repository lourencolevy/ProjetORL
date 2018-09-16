using ORL.Dal.Entities;
using ORL.Dal.Entities.Contexts;
using System;
using System.Collections.Generic;

namespace ORL.Dal.Repositories
{
    public class RepositoryVisite : CrudRepository<orlContext, Visite>
    {
        private orlContext _context = new orlContext();
        public RepositoryVisite() : base()
        {

        }
    }
}
