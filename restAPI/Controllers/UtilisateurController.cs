﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.DTO;
using EntityFTest.services;
using Microsoft.AspNetCore.Mvc;



namespace restAPI.Controllers
{
    [Route("api/[controller]")]
    public class UtilisateurController : Controller
    {
        private UtilisateurService us;

        public UtilisateurController()
        {
            this.us = new UtilisateurService();
        }
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IEnumerable<CommercialDTO> Get(int id)
        {
            IEnumerable<CommercialDTO> ListCommercialDTO = us.F
            return ListCommercialDTO;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
