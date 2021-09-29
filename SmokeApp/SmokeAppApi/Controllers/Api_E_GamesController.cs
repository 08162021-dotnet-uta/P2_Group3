﻿using Microsoft.AspNetCore.Mvc;
using SmokeApp_Storage.ExternalApiModels;
using SmokeApp_Storage.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SmokeAppApi.Controllers
{

    [Route("[controller]")]
    [ApiController]
    public class Api_E_GamesController : ControllerBase
    {
    private static readonly RawgRepository rawgRepo = RawgRepository.Instance;


        // GET: api/<Api_E_GamesController>
        [HttpGet]
        public async Task<Api_E_Game[]> GetGamesAsync()
        {
            var games = await rawgRepo.GetGamesAsync();
            return games;


        }

        // GET api/<Api_E_GamesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<Api_E_GamesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<Api_E_GamesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Api_E_GamesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
