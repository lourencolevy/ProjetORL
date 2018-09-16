using AutoMapper;
using ORL.Bll.DTO;
using ORL.Dal.Entities;
using ORL.Dal.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ORL.Bll.Services
{
    /// <summary>
    /// RepositoryMagasin contient les requetes vers la bdd pour le serviceMagasin
    /// </summary>
    public class ServiceMagasin
    {
        private readonly RepositoryMagasin RepoMagasin;
        public ServiceMagasin()
        {
            RepoMagasin = new RepositoryMagasin();
        }

        public void AjouterMagasin(DtoMagasin aDtoMagasin)
        {
            Magasin oMagasin = Mapper.Map<DtoMagasin, Magasin>(aDtoMagasin);
            RepoMagasin.Add(oMagasin);
            RepoMagasin.Save();
        }
        public void ModifierMagasin(DtoMagasin aDtoMagasin)
        {
            Magasin oMagasin = Mapper.Map<DtoMagasin, Magasin>(aDtoMagasin);
            RepoMagasin.Edit(oMagasin);
            RepoMagasin.Save();
        }
        public void SupprimerMagasin(DtoMagasin aDtoMagasin)
        {
            Magasin oMagasin = Mapper.Map<DtoMagasin, Magasin>(aDtoMagasin);
            RepoMagasin.Delete(oMagasin);
            RepoMagasin.Save();
        }
        public DtoMagasin TrouverMagasinAvecId(int aId)
        {
            return Mapper.Map<Magasin, DtoMagasin>
                (RepoMagasin.FindById(aId).FirstOrDefault());
        }
        public ICollection<DtoMagasin> ListerMagasins()
        {
            return Mapper.Map<ICollection<Magasin>, ICollection<DtoMagasin>>(RepoMagasin.FindAll().ToList());
        }
    }
}
