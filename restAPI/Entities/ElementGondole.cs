using EntityFTest.repositories;
using System;
using System.Collections.Generic;

namespace EntityFTest
{
    public partial class ElementGondole : EntityBase
    {
        public ElementGondole()
        {
            Planche = new HashSet<Planche>();
        }

        
        public int RayonId { get; set; }
        public string Numero { get; set; }

        public Rayon Rayon { get; set; }
        public ICollection<Planche> Planche { get; set; }
    }
}
