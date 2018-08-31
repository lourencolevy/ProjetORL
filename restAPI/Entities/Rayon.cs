using EntityFTest.repositories;
using System;
using System.Collections.Generic;

namespace EntityFTest
{
    public partial class Rayon : EntityBase
    {
        public Rayon()
        {
            ElementGondole = new HashSet<ElementGondole>();
        }

        
        public int MagasinId { get; set; }
        public string NumRayon { get; set; }

        public Magasin Magasin { get; set; }
        public ICollection<ElementGondole> ElementGondole { get; set; }
    }
}
