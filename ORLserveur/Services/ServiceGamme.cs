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
            RepoGamme.Save();
        }
        public void ModifierGamme(DtoGamme aDtoGamme)
        {
            Gamme oGamme = Mapper.Map<DtoGamme, Gamme>(aDtoGamme);
            RepoGamme.Edit(oGamme);
            RepoGamme.Save();
        }
        public void SupprimerGamme(DtoGamme aDtoGamme)
        {
            Gamme oGamme = Mapper.Map<DtoGamme, Gamme>(aDtoGamme);
            RepoGamme.Delete(oGamme);
            RepoGamme.Save();
        }
        public DtoGamme TrouverGammeAvecId(int aId)
        {
            return Mapper.Map<Gamme, DtoGamme>
                (RepoGamme.FindById(aId).FirstOrDefault());
        }
        public ICollection<DtoGamme> ListerGammes()
        {
            return Mapper.Map<ICollection<Gamme>, ICollection<DtoGamme>>(RepoGamme.FindAll().ToList());
        }
    }
}
