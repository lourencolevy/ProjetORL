using AutoMapper;
using ORL.Bll.DTO;
using ORL.Dal.Entities;
using ORL.Dal.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ORL.Bll.Services
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
            RepoEnseigne.Save();
        }
        public void ModifierEnseigne(DtoEnseigne aDtoEnseigne)
        {
            Enseigne oEnseigne = Mapper.Map<DtoEnseigne, Enseigne>(aDtoEnseigne);
            RepoEnseigne.Edit(oEnseigne);
            RepoEnseigne.Save();
        }
        public void SupprimerEnseigne(DtoEnseigne aDtoEnseigne)
        {
            Enseigne oEnseigne = Mapper.Map<DtoEnseigne, Enseigne>(aDtoEnseigne);
            RepoEnseigne.Delete(oEnseigne);
            RepoEnseigne.Save();
        }
        public DtoEnseigne TrouverAvecId(int aId)
        {
            return Mapper.Map<Enseigne, DtoEnseigne>
                (RepoEnseigne.FindById(aId).FirstOrDefault());
        }
        public ICollection<DtoEnseigne> ListerEnseignes()
        {
            return Mapper.Map<ICollection<Enseigne>, ICollection<DtoEnseigne>>(RepoEnseigne.FindAll().ToList());
        }
    }
}

