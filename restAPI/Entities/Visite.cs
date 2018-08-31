using EntityFTest.repositories;
using System;
using System.Collections.Generic;

namespace EntityFTest
{
    public partial class Visite : EntityBase
    {
        
        public int UserId { get; set; }
        public string Date { get; set; }

        public Utilisateur User { get; set; }
    }
}
