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
    public class ServicePlancheProduit
    {
        private readonly RepositoryPlancheProduit RepoPlancheProduit;
        public ServicePlancheProduit()
        {
            RepoPlancheProduit = new RepositoryPlancheProduit();
        }

        public void AjouterPlancheProduit(DtoPlancheProduit aDtoPlancheProduit)
        {
            PlancheProduit oPlancheProduit = Mapper.Map<DtoPlancheProduit, PlancheProduit>(aDtoPlancheProduit);
            RepoPlancheProduit.Add(oPlancheProduit);
            RepoPlancheProduit.Save();
        }
        public void ModifierPlancheProduit(DtoPlancheProduit aDtoPlancheProduit)
        {
            PlancheProduit oPlancheProduit = Mapper.Map<DtoPlancheProduit, PlancheProduit>(aDtoPlancheProduit);
            RepoPlancheProduit.Edit(oPlancheProduit);
            RepoPlancheProduit.Save();
        }
        public void SupprimerPlancheProduit(DtoPlancheProduit aDtoPlancheProduit)
        {
            PlancheProduit oPlancheProduit = Mapper.Map<DtoPlancheProduit, PlancheProduit>(aDtoPlancheProduit);
            RepoPlancheProduit.Delete(oPlancheProduit);
            RepoPlancheProduit.Save();
        }
        public DtoPlancheProduit TrouverPlancheProduitAvecId(int aId)
        {
            return Mapper.Map<PlancheProduit, DtoPlancheProduit>
                (RepoPlancheProduit.FindById(aId).FirstOrDefault());
        }
        public ICollection<DtoPlancheProduit> ListerPlancheProduits()
        {
            return Mapper.Map<ICollection<PlancheProduit>, ICollection<DtoPlancheProduit>>(RepoPlancheProduit.FindAll().ToList());
        }
    }
}

