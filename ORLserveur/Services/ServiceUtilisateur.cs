using ORLserveur.DTO;
using ORLserveur.Entities;
using ORLserveur.Repositories;
using System;
using System.Collections.Generic;
using AutoMapper;

namespace ORLserveur
{
    public class ServiceUtilisateur
    {
        private readonly RepositoryUtilisateur RepoUtilisateur;
        public ServiceUtilisateur() 
        {
            RepoUtilisateur = new RepositoryUtilisateur();
        }
        public void AjouterUtilisateur(DtoUtilisateur eDtoUtilisateur)
        {
            Utilisateur util = Mapper.Map<DtoUtilisateur, Utilisateur>(eDtoUtilisateur);
            RepoUtilisateur.Add(util);
        }
    }
}
