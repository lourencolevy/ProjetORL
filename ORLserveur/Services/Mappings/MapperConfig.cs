using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ORLserveur.DTO;
using ORLserveur.Entities;

namespace ORLserveur.Services.Mappings
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<Utilisateur, DtoUtilisateur>().ReverseMap();
            CreateMap<Magasin, DtoMagasin>().ReverseMap();
            CreateMap<ElementGondole, DtoElementGondole>().ReverseMap();
            CreateMap<Enseigne, DtoEnseigne>().ReverseMap();
            CreateMap<Gamme, DtoGamme>().ReverseMap();
            CreateMap<Marque, DtoMarque>().ReverseMap();
            CreateMap<Planche, DtoPlanche>().ReverseMap();
            CreateMap<Produit, DtoProduit>().ReverseMap();
            CreateMap<Rayon, DtoRayon>().ReverseMap();
            CreateMap<Visite, DtoVisite>().ReverseMap();
        }
    }
}
