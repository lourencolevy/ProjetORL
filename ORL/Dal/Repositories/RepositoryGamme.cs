﻿using ORL.Dal.Entities;
using ORL.Dal.Entities.Contexts;
using System;
using System.Collections.Generic;

namespace ORL.Dal.Repositories
{
    public partial class RepositoryGamme : CrudRepository<orlContext, Gamme>
    {
        private orlContext _context = new orlContext();
        public RepositoryGamme() : base()
        {

        }


    }
}