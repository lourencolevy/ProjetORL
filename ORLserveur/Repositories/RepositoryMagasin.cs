using ORLserveur.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ORLserveur.Repositories
{
    /// <summary>
    /// RepositoryMagasin contient les requetes vers la bdbd pour le serviceMagasin
    /// </summary>
    public class RepositoryMagasin : CrudRepository<orlContext, Magasin>
    {
        private orlContext _context = new orlContext();
        public RepositoryMagasin() : base()
        {

        }
    }
}
