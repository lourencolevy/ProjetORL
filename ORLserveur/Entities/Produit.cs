using System;
using System.Collections.Generic;

namespace ORLserveur
{
    public partial class Produit
    {
        public int Id { get; set; }
        public int GammeId { get; set; }
        public string CodeBarre { get; set; }
        public int MarqueId { get; set; }
        public string Debut { get; set; }
        public string Fin { get; set; }

        public Gamme Gamme { get; set; }
        public Marque Marque { get; set; }
    }
}
