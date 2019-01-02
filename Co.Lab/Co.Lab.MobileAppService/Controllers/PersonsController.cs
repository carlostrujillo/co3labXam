using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Co.Lab.MobileAppService.Interfaces;
using Co.Lab.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Co.Lab.MobileAppService.Controllers
{
    [Route("api/[controller]")]
    public class PersonsController : Controller
    {
        private readonly IPersonRepository personRepository;

        public PersonsController(IPersonRepository personRepository)
        {
            this.personRepository = personRepository;
        }
        // GET: api/values
        [HttpGet]
        public IEnumerable<Person> Get()
        {
            try
            {
                return personRepository.GetAll();
            }
            catch(Exception ex)
            {
                return null;
            }

        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Person Get(int id)
        {
            try
            {
                return personRepository.Get(id);
            }

            catch (Exception ex)
            {
                return null;
            }

        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Person person)
        {
            try
            {
                personRepository.Add(person);
            }

            catch (Exception ex)
            {

            }

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Person person)
        {
            try
            {
                personRepository.Update(person);
            }

            catch (Exception ex)
            {
                
            }

        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            try
            {
                personRepository.Remove(id);
            }

            catch (Exception ex)
            {

            }

        }
    }
}
