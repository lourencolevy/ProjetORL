using ORL.Dal.Entities;
using ORL.Dal.Entities.Contexts;
using System;
using System.Collections.Generic;

namespace ORL.Dal.Repositories
{
    public partial class RepositoryEnseigne : CrudRepository<orlContext, Enseigne>
    {
        private orlContext _context = new orlContext();
        public RepositoryEnseigne() : base()
        {

        }


    }
}

