using System;
using System.Collections.Generic;

namespace ORLserveur
{
    public partial class Visite
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Date { get; set; }

        public Utilisateur User { get; set; }
    }
}
