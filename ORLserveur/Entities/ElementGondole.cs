﻿using ORLserveur.Entities;
using System;
using System.Collections.Generic;

namespace ORLserveur
{
    public partial class DtoElementGondole : EntityBase
    {
        public DtoElementGondole()
        {
            Planche = new HashSet<DtoPlanche>();
        }

        public int Id { get; set; }
        public int RayonId { get; set; }
        public string Numero { get; set; }

        public DtoRayon Rayon { get; set; }
        public ICollection<DtoPlanche> Planche { get; set; }
    }
}
