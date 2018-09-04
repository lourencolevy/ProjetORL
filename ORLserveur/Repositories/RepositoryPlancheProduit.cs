﻿using ORLserveur.Contexts.Entities;
using ORLserveur.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ORLserveur.Repositories
{
    public class RepositoryPlancheProduit : CrudRepository<orlContext, PlancheProduit>
    {
        public IQueryable<PlancheProduit> GetProductsByPlanche(Planche ePlanche)
        {
            orlContext context = new orlContext();
            IQueryable<PlancheProduit> query = context.Set<PlancheProduit>()
                .Where(o => o.PlancheId == ePlanche.Id);
            return query;
        }
    }
}