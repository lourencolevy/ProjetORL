using AutoMapper;
using ORLserveur.DTO;
using ORLserveur.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ORLserveur.Repositories
{
    public partial class ServiceGamme
    {
        private readonly RepositoryGamme RepoGamme;
        public ServiceGamme()
        {
            RepoGamme = new RepositoryGamme();
        }

        public void AjouterGamme(DtoGamme aDtoGamme)
        {
            Gamme oGamme = Mapper.Map<DtoGamme, Gamme>(aDtoGamme);
            RepoGamme.Add(oGamme);
        }
        public void ModifierGamme(DtoGamme aDtoGamme)
        {
            Gamme oGamme = Mapper.Map<DtoGamme, Gamme>(aDtoGamme);
            RepoGamme.Edit(oGamme);
        }
        public void SupprimerGamme(DtoGamme aDtoGamme)
        {
            Gamme oGamme = Mapper.Map<DtoGamme, Gamme>(aDtoGamme);
            RepoGamme.Delete(oGamme);
        }
        public DtoGamme TrouverGammeAvecId(int aId)
        {
            return Mapper.Map<Gamme, DtoGamme>
                (RepoGamme.FindById(aId).FirstOrDefault());
        }
        public ICollection<DtoGamme> TrouverGammes()
        {
            return Mapper.Map<ICollection<Gamme>, ICollection<DtoGamme>>(RepoGamme.FindAll().ToList());
        }
    }
}
