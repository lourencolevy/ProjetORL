using AutoMapper;
using ORLserveur.DTO;
using ORLserveur.Entities;
using ORLserveur.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ORLserveur
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
        }
        public void ModifierVisite(DtoVisite aDtoVisite)
        {
            Visite oVisite = Mapper.Map<DtoVisite, Visite>(aDtoVisite);
            RepoVisite.Edit(oVisite);
        }
        public void SupprimerVisite(DtoVisite aDtoVisite)
        {
            Visite oVisite = Mapper.Map<DtoVisite, Visite>(aDtoVisite);
            RepoVisite.Delete(oVisite);
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
