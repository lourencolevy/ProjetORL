﻿using ORLserveur.Entities;
using System;
using System.Collections.Generic;

namespace ORLserveur
{
    public partial class DtoEnseigne : EntityBase
    {
        public int Id { get; set; }
        public string Nom { get; set; }
    }
}