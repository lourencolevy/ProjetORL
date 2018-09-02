﻿using ORLserveur.Entities;
using System;
using System.Collections.Generic;

namespace ORLserveur
{
    public partial class DtoMagasin : EntityBase
    {
        public DtoMagasin()
        {
            Rayon = new HashSet<DtoRayon>();
        }

        public int Id { get; set; }
        public string Adresse1 { get; set; }
        public string Adresse2 { get; set; }
        public string Adresse3 { get; set; }
        public string CodePostal { get; set; }
        public string Ville { get; set; }
        public string Typo { get; set; }
        public int EnseigneId { get; set; }

        public ICollection<DtoRayon> Rayon { get; set; }
    }
}