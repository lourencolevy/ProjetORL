using ORLserveur.Entities;
using ORLserveur.Entities.Contexts;
using System;
using System.Collections.Generic;

namespace ORLserveur.Repositories
{
    public partial class RepositoryGamme : CrudRepository<orlContext, Gamme>
    {
        private orlContext _context = new orlContext();
        public RepositoryGamme() : base()
        {

        }


    }
}
