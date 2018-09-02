using ORLserveur.Entities;
using System;
using System.Collections.Generic;

namespace ORLserveur.DTO
{
    public class DtoVisite
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Date { get; set; }

        public DtoUtilisateur User { get; set; }
    }
}
