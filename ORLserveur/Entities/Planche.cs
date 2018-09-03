using ORLserveur.Entities;
using System;
using System.Collections.Generic;

namespace ORLserveur
{
    public partial class Planche : EntityBase
    {
        public int Id { get; set; }
        public string NumPlanche { get; set; }
        public int ElementGondoleId { get; set; }
        public sbyte? Rupture { get; set; }

        public ElementGondole ElementGondole { get; set; }
    }
}
