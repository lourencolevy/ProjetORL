using AutoMapper;
using ORL.Bll.DTO;
using ORL.Dal.Entities;
using ORL.Dal.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ORL.Bll.Services
{
    public partial class ServicePlanche
    {
        private readonly RepositoryPlanche RepoPlanche;
        public ServicePlanche()
        {
            RepoPlanche = new RepositoryPlanche();
        }

        public void AjouterPlanche(DtoPlanche aDtoPlanche)
        {
            Planche oPlanche = Mapper.Map<DtoPlanche, Planche>(aDtoPlanche);
            RepoPlanche.Add(oPlanche);
            RepoPlanche.Save();
        }
        public void ModifierPlanche(DtoPlanche aDtoPlanche)
        {
            Planche oPlanche = Mapper.Map<DtoPlanche, Planche>(aDtoPlanche);
            RepoPlanche.Edit(oPlanche);
            RepoPlanche.Save();
        }
        public void SupprimerPlanche(DtoPlanche aDtoPlanche)
        {
            Planche oPlanche = Mapper.Map<DtoPlanche, Planche>(aDtoPlanche);
            RepoPlanche.Delete(oPlanche);
            RepoPlanche.Save();
        }
        public DtoPlanche TrouverPlancheAvecId(int aId)
        {
            return Mapper.Map<Planche, DtoPlanche>
                (RepoPlanche.FindById(aId).FirstOrDefault());
        }
        public ICollection<DtoPlanche> ListerPlanches()
        {
            return Mapper.Map<ICollection<Planche>, ICollection<DtoPlanche>>(RepoPlanche.FindAll().ToList());
        }
    }
}
