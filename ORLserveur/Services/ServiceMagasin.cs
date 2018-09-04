using AutoMapper;
using ORLserveur.DTO;
using ORLserveur.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ORLserveur.Repositories
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
        }
        public void ModifierMagasin(DtoMagasin aDtoMagasin)
        {
            Magasin oMagasin = Mapper.Map<DtoMagasin, Magasin>(aDtoMagasin);
            RepoMagasin.Edit(oMagasin);
        }
        public void SupprimerMagasin(DtoMagasin aDtoMagasin)
        {
            Magasin oMagasin = Mapper.Map<DtoMagasin, Magasin>(aDtoMagasin);
            RepoMagasin.Delete(oMagasin);
        }
        public DtoMagasin TrouverMagasinAvecId(int aId)
        {
            return Mapper.Map<Magasin, DtoMagasin>
                (RepoMagasin.FindById(aId).FirstOrDefault());
        }
        public ICollection<DtoMagasin> TrouverMagasins()
        {
            return Mapper.Map<ICollection<Magasin>, ICollection<DtoMagasin>>(RepoMagasin.FindAll().ToList());
        }
    }
}
