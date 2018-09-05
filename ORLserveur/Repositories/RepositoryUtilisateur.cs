using ORLserveur.Entities;
using ORLserveur.Entities.Contexts;
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
