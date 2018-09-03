using ORLserveur.Entities;
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
