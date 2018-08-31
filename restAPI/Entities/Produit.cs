using EntityFTest.repositories;
using System;
using System.Collections.Generic;

namespace EntityFTest
{
    public partial class Produit : EntityBase
    {
        
        public int GammeId { get; set; }
        public string CodeBarre { get; set; }
        public int MarqueId { get; set; }
        public string Debut { get; set; }
        public string Fin { get; set; }

        public Gamme Gamme { get; set; }
        public Marque Marque { get; set; }
    }
}
