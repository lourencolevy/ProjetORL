using System;
using System.Collections.Generic;

namespace ORL.Bll.DTO
{
    public class DtoVisite
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Date { get; set; }

        public DtoUtilisateur User { get; set; }
    }
}
