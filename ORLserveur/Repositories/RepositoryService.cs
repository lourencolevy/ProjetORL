using ORLserveur.Entities;
using ORLserveur.Entities.Contexts;
using ORLserveur.Repositories;
using System;
using System.Collections.Generic;

namespace ORLserveur
{
    public class Repositoryservices : CrudRepository<orlContext, Visite>
    {
        private orlContext _context = new orlContext();
        public Repositoryservices() : base()
        {

        }
    }
}
