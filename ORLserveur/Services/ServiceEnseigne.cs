using AutoMapper;
using ORLserveur.DTO;
using ORLserveur.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ORLserveur.Repositories
{
    public partial class ServiceEnseigne
    {
        private readonly RepositoryEnseigne RepoEnseigne;
        public ServiceEnseigne() 
        {
            RepoEnseigne = new RepositoryEnseigne();
        }

        public void AjouterEnseigne(DtoEnseigne aDtoEnseigne)
        {
            Enseigne oEnseigne = Mapper.Map<DtoEnseigne, Enseigne>(aDtoEnseigne);
            RepoEnseigne.Add(oEnseigne);
        }
        public void ModifierEnseigne(DtoEnseigne aDtoEnseigne)
        {
            Enseigne oEnseigne = Mapper.Map<DtoEnseigne, Enseigne>(aDtoEnseigne);
            RepoEnseigne.Edit(oEnseigne);
        }
        public void SupprimerEnseigne(DtoEnseigne aDtoEnseigne)
        {
            Enseigne oEnseigne = Mapper.Map<DtoEnseigne, Enseigne>(aDtoEnseigne);
            RepoEnseigne.Delete(oEnseigne);
        }
        public DtoEnseigne TrouverAvecId(int aId)
        {
            return Mapper.Map<Enseigne, DtoEnseigne>
                (RepoEnseigne.FindById(aId).FirstOrDefault());
        }
        public ICollection<DtoEnseigne> TrouverEnseignes()
        {
            return Mapper.Map<ICollection<Enseigne>, ICollection<DtoEnseigne>>(RepoEnseigne.FindAll().ToList());
        }
    }
}

