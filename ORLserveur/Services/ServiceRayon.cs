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
            RepoRayon.Save();
        }
        public void ModifierRayon(DtoRayon aDtoRayon)
        {
            Rayon oRayon = Mapper.Map<DtoRayon, Rayon>(aDtoRayon);
            RepoRayon.Edit(oRayon);
            RepoRayon.Save();
        }
        public void SupprimerRayon(DtoRayon aDtoRayon)
        {
            Rayon oRayon = Mapper.Map<DtoRayon, Rayon>(aDtoRayon);
            RepoRayon.Delete(oRayon);
            RepoRayon.Save();
        }
        public DtoRayon TrouverRayonAvecId(int aId)
        {
            return Mapper.Map<Rayon, DtoRayon>
                (RepoRayon.FindById(aId).FirstOrDefault());
        }
        public ICollection<DtoRayon> ListerRayons()
        {
            return Mapper.Map<ICollection<Rayon>, ICollection<DtoRayon>>(RepoRayon.FindAll().ToList());
        }
    }
}
