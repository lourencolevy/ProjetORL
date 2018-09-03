using ORLserveur.Entities;
using ORLserveur.Repositories;
using System;
using System.Collections.Generic;

namespace ORLserveur
{
    public partial class RepositoryPlanche : CrudRepository<orlContext, Planche>
    {
        private orlContext _context = new orlContext();
        public RepositoryPlanche() : base()
        {

        }
    }
}
