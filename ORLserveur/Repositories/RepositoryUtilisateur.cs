using ORLserveur.Contexts.Entities;
using ORLserveur.Entities;
using ORLserveur.Repositories;
using System;
using System.Collections.Generic;

namespace ORLserveur
{
    public class RepositoryUtilisateur : CrudRepository<orlContext, Utilisateur>
    {
        private orlContext _context = new orlContext();
        public RepositoryUtilisateur() : base()
        {

        }
    }
}
