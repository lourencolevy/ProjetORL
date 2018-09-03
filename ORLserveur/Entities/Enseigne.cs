using ORLserveur.Entities;
using System;
using System.Collections.Generic;

namespace ORLserveur
{
    public partial class Enseigne : EntityBase
    {
       
        public int Id { get; set; }
        public string Nom { get; set; }
    }
}
