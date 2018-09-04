using AutoMapper;
using ORLserveur.DTO;
using ORLserveur.Entities;
using ORLserveur.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ORLserveur
{
    public class ServiceRayon
    {
        private readonly RepositoryRayon RepoRayon;
        public ServiceRayon()
        {
            RepoRayon = new RepositoryRayon();
        }

        public void AjouterRayon(DtoRayon aDtoRayon)
        {
            Rayon oRayon = Mapper.Map<DtoRayon, Rayon>(aDtoRayon);
            RepoRayon.Add(oRayon);
        }
        public void ModifierRayon(DtoRayon aDtoRayon)
        {
            Rayon oRayon = Mapper.Map<DtoRayon, Rayon>(aDtoRayon);
            RepoRayon.Edit(oRayon);
        }
        public void SupprimerRayon(DtoRayon aDtoRayon)
        {
            Rayon oRayon = Mapper.Map<DtoRayon, Rayon>(aDtoRayon);
            RepoRayon.Delete(oRayon);
        }
        public DtoRayon TrouverRayonAvecId(int aId)
        {
            return Mapper.Map<Rayon, DtoRayon>
                (RepoRayon.FindById(aId).FirstOrDefault());
        }
        public ICollection<DtoRayon> TrouverRayons()
        {
            return Mapper.Map<ICollection<Rayon>, ICollection<DtoRayon>>(RepoRayon.FindAll().ToList());
        }
    }
}
