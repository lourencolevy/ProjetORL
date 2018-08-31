using Business.DTO;
using EntityFTest.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFTest.services
{
    public class UtilisateurService
    {
        //FindAll
        //FindById

        //Create
        //PutById
        //DeleteById
        private UtilisateurRepo ur;

        public UtilisateurService()
        {
            ur = new UtilisateurRepo();
        }

        public IEnumerable<CommercialDTO> findAll()
        {
            // récupération des Utilisateurs depuis la BDD
            ICollection<Utilisateur> utilisateurs = ur.FindAll().ToList();
            // transformation en DTO
            ICollection<CommercialDTO> UtilisateursDto = UtilisateurUtilisateurDTO.Map(cities);
            return citiesDto;
        }

        public CityDto findByID(int id)
        {
            // récupération depuis la BDD
            City city = cr.FindById(id).First();
            // transformation en DTO
            CityDto cityDto = CityCityDto.Map(city);
            return cityDto;
        }

        public void Create(CityDto cityDto)
        {
            City city = CityCityDto.Map(cityDto);
            cr.Add(city);
            cr.Save();
        }
    }
}
