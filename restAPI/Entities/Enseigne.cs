using EntityFTest.repositories;
using System;
using System.Collections.Generic;

namespace EntityFTest
{
    public partial class Enseigne : EntityBase
    {
        public Enseigne()
        {
            Magasin = new HashSet<Magasin>();
        }

       
        public string Nom { get; set; }

        public ICollection<Magasin> Magasin { get; set; }
    }
}
