using ORLserveur.DTO;
using ORLserveur.Entities;
using ORLserveur.Repositories;
using System;
using System.Collections.Generic;
using AutoMapper;
using System.Linq;

namespace ORLserveur
{
    public class ServiceUtilisateur
    {
        private readonly RepositoryUtilisateur RepoUtilisateur;
        public ServiceUtilisateur() 
        {
            RepoUtilisateur = new RepositoryUtilisateur();
        }
        public void AjouterUtilisateur(DtoUtilisateur aDtoUtilisateur)
        {
            Utilisateur util = Mapper.Map<DtoUtilisateur, Utilisateur>(aDtoUtilisateur);
            RepoUtilisateur.Add(util);
        }
        public void ModifierUtilisateur(DtoUtilisateur aDtoUtilisateur)
        {
            Utilisateur util = Mapper.Map<DtoUtilisateur, Utilisateur>(aDtoUtilisateur);
            RepoUtilisateur.Edit(util);
        }
        public void SupprimerUtilisateur(DtoUtilisateur aDtoUtilisateur)
        {
            Utilisateur util = Mapper.Map<DtoUtilisateur, Utilisateur>(aDtoUtilisateur);
            RepoUtilisateur.Delete(util);
        }
        public DtoUtilisateur TrouverAvecId(int aId)
        {
            return Mapper.Map<Utilisateur, DtoUtilisateur>
                (RepoUtilisateur.FindById(aId).FirstOrDefault());
        }
        public ICollection<DtoUtilisateur> ListerUtilisateurs()
        {
            return Mapper.Map<ICollection< Utilisateur >, ICollection<DtoUtilisateur>>(RepoUtilisateur.FindAll().ToList());
        }
    }
}
