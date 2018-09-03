
using ORLserveur.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ORLserveur.Repositories;

namespace ORLserveur.DTO.Repositories
{
    public partial class RepositoryElementGondole : CrudRepository<orlContext, ElementGondole>
    {
        private orlContext _context = new orlContext();
        public RepositoryElementGondole() : base()
        {

        }
    }
}
