using ORL.Dal.Entities;
using ORL.Dal.Entities.Contexts;
using System;
using System.Collections.Generic;

namespace ORL.Dal.Repositories
{
    public class RepositoryMarque : CrudRepository<orlContext, Marque>
    {
        private orlContext _context = new orlContext();
        public RepositoryMarque() : base()
        {

        }
    }
}
