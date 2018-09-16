using System;
using System.Collections.Generic;

namespace ORL.Bll.DTO
{
    public class DtoRayon
    {
        public int Id { get; set; }
        public int MagasinId { get; set; }
        public string NumRayon { get; set; }

        public DtoMagasin Magasin { get; set; }
        public ICollection<DtoElementGondole> ElementGondole { get; set; }
    }
}
