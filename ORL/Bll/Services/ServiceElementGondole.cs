using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using ORL.Dal.Repositories;
using ORL.Bll.DTO;
using ORL.Dal.Entities;

namespace ORL.Bll.Services
{
    public partial class ServiceElementGondole
    {
        private readonly RepositoryElementGondole RepoElementGondole;
        public ServiceElementGondole()
        {
            RepoElementGondole = new RepositoryElementGondole();
        }

        public void AjouterElementGondole(DtoElementGondole aDtoElementGondole)
        {
            ElementGondole oElementGondole = Mapper.Map<DtoElementGondole, ElementGondole>(aDtoElementGondole);
            RepoElementGondole.Add(oElementGondole);
            RepoElementGondole.Save();
        }
        public void ModifierElementGondole(DtoElementGondole aDtoElementGondole)
        {
            ElementGondole oElementGondole = Mapper.Map<DtoElementGondole, ElementGondole>(aDtoElementGondole);
            RepoElementGondole.Edit(oElementGondole);
            RepoElementGondole.Save();
        }
        public void SupprimerElementGondole(DtoElementGondole aDtoElementGondole)
        {
            ElementGondole oElementGondole = Mapper.Map<DtoElementGondole, ElementGondole>(aDtoElementGondole);
            RepoElementGondole.Delete(oElementGondole);
            RepoElementGondole.Save();
        }
        public DtoElementGondole TrouverAvecId(int aId)
        {
            return Mapper.Map<ElementGondole, DtoElementGondole>
                (RepoElementGondole.FindById(aId).FirstOrDefault());
        }
        public ICollection<DtoElementGondole> ListerElementGondoles()
        {
            return Mapper.Map<ICollection<ElementGondole>, ICollection<DtoElementGondole>>(RepoElementGondole.FindAll().ToList());
        }
    }
}
