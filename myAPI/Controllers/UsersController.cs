﻿using DataAccess.Entidades;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace myAPI.Controllers
{
    public class UsersController : ControllerBase
    {
        private readonly ISvUser _svUser;
        public UsersController(ISvUser svUser)
        {
            _svUser = svUser;
        }
        // GET: api/<UsersController>
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _svUser.ListUsers();
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<UsersController>
        [HttpPost]
        public void Post([FromBody] User user)
        {
            _svUser.Add(user);
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _svUser.Delete(id);
        }
    }
}