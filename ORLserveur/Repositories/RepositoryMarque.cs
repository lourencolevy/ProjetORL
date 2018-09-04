using ORLserveur.Contexts.Entities;
using ORLserveur.Entities;
using ORLserveur.Repositories;
using System;
using System.Collections.Generic;

namespace ORLserveur.Repositories
{
    public class RepositoryMarque : CrudRepository<orlContext, Marque>
    {
        private orlContext _context = new orlContext();
        public RepositoryMarque() : base()
        {

        }
    }
}
