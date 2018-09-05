using ORLserveur.Entities;
using ORLserveur.Entities.Contexts;
using System;
using System.Collections.Generic;

namespace ORLserveur.Repositories
{
    public partial class RepositoryEnseigne : CrudRepository<orlContext, Enseigne>
    {
        private orlContext _context = new orlContext();
        public RepositoryEnseigne() : base()
        {

        }


    }
}

