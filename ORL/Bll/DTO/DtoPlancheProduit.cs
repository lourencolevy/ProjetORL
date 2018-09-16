﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ORL.Bll.DTO
{
    public class DtoPlancheProduit
    {
        public int Id { get; set; }
        public int PlancheId { get; set; }
        public int ProduitId { get; set; }
        public int VisiteId { get; set; }
        public int? NombreProduit { get; set; }

        public DtoPlanche Planche { get; set; }
        public DtoProduit Produit { get; set; }
        public DtoVisite Visite { get; set; }
    }
}