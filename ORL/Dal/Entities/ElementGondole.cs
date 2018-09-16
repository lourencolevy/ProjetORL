using System;
using System.Collections.Generic;

namespace ORL.Dal.Entities
{
    public partial class ElementGondole : EntityBase
    {
        public ElementGondole()
        {
            Planche = new HashSet<Planche>();
        }

        public int Id { get; set; }
        public int RayonId { get; set; }
        public string Numero { get; set; }

        public Rayon Rayon { get; set; }
        public ICollection<Planche> Planche { get; set; }
    }
}
