using Business.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFTest.services.Mappings
{
    static class UtilisateurUtilisateurDTO
    {
        public static CommercialDTO Map(Utilisateur user)
        {
            CommercialDTO userDto = new CommercialDTO();
            userDto.Id = user.Id;
            userDto. = user.Name;
            userDto.Population = user.Population;
            userDto.CountryCode = user.CountryCode;
            return userDto;
        }

        public static City Map(CityDto cdto)
        {
            City city = new City();
            city.Id = cdto.Id;
            city.Name = cdto.Name;
            city.Population = cdto.Population;
            city.CountryCode = cdto.CountryCode;
            return city;
        }

        public static ICollection<CityDto> Map(IEnumerable<City> cities)
        {
            ICollection<CityDto> citiesDto = new List<CityDto>();

            foreach (var city in cities)
            {
                citiesDto.Add(Map(city));
            }

            return citiesDto;
        }


        public static ICollection<City> Map(IEnumerable<CityDto> citiesDto)
        {
            ICollection<City> cities = new List<City>();
            foreach (var cityDto in citiesDto)
            {
                cities.Add(Map(cityDto));
            }
            return cities;
        }

    }
}
