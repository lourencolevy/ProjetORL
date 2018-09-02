﻿using ORLserveur.Entities;
using System;
using System.Collections.Generic;

namespace ORLserveur
{
    public partial class DtoVisite  : EntityBase
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Date { get; set; }

        public DtoUtilisateur User { get; set; }
    }
}
