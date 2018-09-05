using ORLserveur.Entities;
using ORLserveur.Entities.Contexts;
using ORLserveur.Repositories;
using System;
using System.Collections.Generic;

namespace ORLserveur
{
    public class RepositoryRayon : CrudRepository<orlContext, Rayon>
    {
        private orlContext _context = new orlContext();
        public RepositoryRayon() : base()
        {

        }
    }
}
