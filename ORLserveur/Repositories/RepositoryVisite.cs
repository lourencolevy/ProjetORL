using ORLserveur.Entities;
using ORLserveur.Repositories;
using System;
using System.Collections.Generic;

namespace ORLserveur
{
    public class RepositoryVisite : CrudRepository<orlContext, Visite>
    {
        private orlContext _context = new orlContext();
        public RepositoryVisite() : base()
        {

        }
    }
}
