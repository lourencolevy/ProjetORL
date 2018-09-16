using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ORL.Dal.Entities;
using ORL.Dal.Entities.Contexts;

namespace ORL.Dal.Repositories
{
    public partial class RepositoryElementGondole : CrudRepository<orlContext, ElementGondole>
    {
        private orlContext _context = new orlContext();
        public RepositoryElementGondole() : base()
        {

        }
    }
}
