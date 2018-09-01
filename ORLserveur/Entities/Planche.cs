using System;
using System.Collections.Generic;

namespace ORLserveur
{
    public partial class Planche
    {
        public int Id { get; set; }
        public string NumPlanche { get; set; }
        public int ElementGondoleId { get; set; }
        public sbyte? Rupture { get; set; }

        public ElementGondole ElementGondole { get; set; }
    }
}
