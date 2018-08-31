using EntityFTest.repositories;
using System;
using System.Collections.Generic;

namespace EntityFTest
{
    public partial class Planche : EntityBase
    {
        
        public string NumPlanche { get; set; }
        public int ElementGondoleId { get; set; }
        public sbyte? Rupture { get; set; }

        public ElementGondole ElementGondole { get; set; }
    }
}
