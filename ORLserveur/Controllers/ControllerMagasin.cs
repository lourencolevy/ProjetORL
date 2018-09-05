using Microsoft.AspNetCore.Mvc;
using ORLserveur.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ORLserveur.Controllers
{
    /// <summary>
    ///Une class ControlleurMagasin qui appelle l'objet type DtoProduit pour 
    ///stocker le résultat du calcul de l'objet type DtoProduit.
    ///Le but de cette classe est que pendant ce passage de donnée il y a 
    ///un contrôle sur le typage et un filtre avec les regex . 
    ///Mais c'est pas la priorité donc on fait pas de controle. 
    /// 
    /// Objet composé d'un seul attribut de type :
    ///     *ProduitService
    ///     
    /// Objet composé de plusieurs membres:
    ///     *une methode Get avec plusieur surcharge qu'on listera listé ici
    ///         _ Get()
    ///         _ Get(ID)
    ///     *ListIdProduit
    ///     
    ///     *une methode Post avec plusieur surcharge qu'on listera listé ici
    ///         _ Post()
    ///        
    ///      *une methode Put avec plusieur surcharge qu'on listera listé ici
    ///         _ Put(Id,String Value)
    ///         
    ///     *une methode Delete avec plusieur surcharge qu'on listera listé ici
    ///         _ Delete(Id)
    /// 
    /// </summary>

    [Route("api/produit")]
    [ApiController]
    public class ControllerMagasin : Controller
    {
        //TODO créer l'objet ps de type ProduitService et l'utiliser pour implémenter les méthodes
        //private ServiceMagasin sm;

        public ControllerMagasin()
        {
            //  this.sm = new ServiceMagasin();
        }

        //TODO Implémenter
        // GET api/values
        [HttpGet]
        public IEnumerable<DtoProduit> Get()
        {
            IEnumerable<DtoProduit> ListDtoProduit = null;
            return ListDtoProduit;
        }

        //TODO Implémenter
        // GET api/values/5
        [HttpGet("{id}")]
        public IEnumerable<DtoProduit> Get(int id)
        {
            IEnumerable<DtoProduit> ListDtoProduit = null;
            return ListDtoProduit;
        }

        //TODO Implémenter
        // POST api/value
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        //TODO Implémenter
        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        //TODO Implémenter
        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }

}
