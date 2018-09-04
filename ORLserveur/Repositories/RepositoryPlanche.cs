using ORLserveur.Contexts.Entities;
using ORLserveur.Entities;
using System;
using System.Collections.Generic;

namespace ORLserveur.Repositories
{
    public partial class RepositoryPlanche : CrudRepository<orlContext, Planche>
    {
        private orlContext _context = new orlContext();
        public RepositoryPlanche() : base()
        {

        }
    }
}
