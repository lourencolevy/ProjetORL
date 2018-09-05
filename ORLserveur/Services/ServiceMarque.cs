using AutoMapper;
using ORLserveur.DTO;
using ORLserveur.Entities;
using ORLserveur.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ORLserveur.Repositories
{
    public class ServiceMarque
    {
        private readonly RepositoryMarque RepoMarque;
        public ServiceMarque()
        {
            RepoMarque = new RepositoryMarque();
        }

        public void AjouterMarque(DtoMarque aDtoMarque)
        {
            Marque oMarque = Mapper.Map<DtoMarque, Marque>(aDtoMarque);
            RepoMarque.Add(oMarque);
        }
        public void ModifierMarque(DtoMarque aDtoMarque)
        {
            Marque oMarque = Mapper.Map<DtoMarque, Marque>(aDtoMarque);
            RepoMarque.Edit(oMarque);
        }
        public void SupprimerMarque(DtoMarque aDtoMarque)
        {
            Marque oMarque = Mapper.Map<DtoMarque, Marque>(aDtoMarque);
            RepoMarque.Delete(oMarque);
        }
        public DtoMarque TrouverMarqueAvecId(int aId)
        {
            return Mapper.Map<Marque, DtoMarque>
                (RepoMarque.FindById(aId).FirstOrDefault());
        }
        public ICollection<DtoMarque> ListerMarques()
        {
            return Mapper.Map<ICollection<Marque>, ICollection<DtoMarque>>(RepoMarque.FindAll().ToList());
        }
    }
}
