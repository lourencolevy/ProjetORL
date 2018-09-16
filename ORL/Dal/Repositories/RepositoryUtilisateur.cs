using ORL.Dal.Entities;
using ORL.Dal.Entities.Contexts;
using System;
using System.Collections.Generic;

namespace ORL.Dal.Repositories
{
    public class RepositoryUtilisateur : CrudRepository<orlContext, Utilisateur>
    {
        private orlContext _context = new orlContext();
        public RepositoryUtilisateur() : base()
        {

        }
    }
}
