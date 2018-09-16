using AutoMapper;
using ORL.Bll.DTO;
using ORL.Dal.Entities;
using ORL.Dal.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ORL.Bll.Services
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
            RepoMarque.Save();
        }
        public void ModifierMarque(DtoMarque aDtoMarque)
        {
            Marque oMarque = Mapper.Map<DtoMarque, Marque>(aDtoMarque);
            RepoMarque.Edit(oMarque);
            RepoMarque.Save();
        }
        public void SupprimerMarque(DtoMarque aDtoMarque)
        {
            Marque oMarque = Mapper.Map<DtoMarque, Marque>(aDtoMarque);
            RepoMarque.Delete(oMarque);
            RepoMarque.Save();
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
