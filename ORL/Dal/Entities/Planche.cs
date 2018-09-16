using System;
using System.Collections.Generic;

namespace ORL.Dal.Entities
{
    public partial class Planche : EntityBase
    {
        public Planche()
        {
            PlancheProduit = new HashSet<PlancheProduit>();
        }

        public int Id { get; set; }
        public string NumPlanche { get; set; }
        public int ElementGondoleId { get; set; }
        public sbyte? Rupture { get; set; }

        public ElementGondole ElementGondole { get; set; }
        public ICollection<PlancheProduit> PlancheProduit { get; set; }
    }
}
