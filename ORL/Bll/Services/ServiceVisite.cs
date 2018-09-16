using AutoMapper;
using ORL.Bll.DTO;
using ORL.Dal.Entities;
using ORL.Dal.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ORL.Bll.Services
{
    public class servicesVisite
    {
        private readonly RepositoryVisite RepoVisite;
        public servicesVisite()
        {
            RepoVisite = new RepositoryVisite();
        }

        public void AjouterVisite(DtoVisite aVisite)
        {
            Visite oVisite = Mapper.Map<DtoVisite, Visite>(aVisite);
            RepoVisite.Add(oVisite);
            RepoVisite.Save();
        }
        public void ModifierVisite(DtoVisite aDtoVisite)
        {
            Visite oVisite = Mapper.Map<DtoVisite, Visite>(aDtoVisite);
            RepoVisite.Edit(oVisite);
            RepoVisite.Save();
        }
        public void SupprimerVisite(DtoVisite aDtoVisite)
        {
            Visite oVisite = Mapper.Map<DtoVisite, Visite>(aDtoVisite);
            RepoVisite.Delete(oVisite);
            RepoVisite.Save();
        }
        public DtoVisite TrouverVisiteAvecId(int aId)
        {
            return Mapper.Map<Visite, DtoVisite>
                (RepoVisite.FindById(aId).FirstOrDefault());
        }
        public ICollection<DtoVisite> ListerVisites()
        {
            return Mapper.Map<ICollection<Visite>, ICollection<DtoVisite>>(RepoVisite.FindAll().ToList());
        }
    }
}
