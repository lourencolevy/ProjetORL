using System;
using System.Collections.Generic;

namespace ORL.Dal.Entities
{
    public partial class Rayon : EntityBase
    {
        public Rayon()
        {
            ElementGondole = new HashSet<ElementGondole>();
        }

        public int Id { get; set; }
        public int MagasinId { get; set; }
        public string NumRayon { get; set; }

        public Magasin Magasin { get; set; }
        public ICollection<ElementGondole> ElementGondole { get; set; }
    }
}
