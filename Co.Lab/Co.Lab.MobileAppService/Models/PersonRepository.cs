using System;
using System.Collections.Generic;
using Co.Lab.MobileAppService.Interfaces;
using Co.Lab.Models;

namespace Co.Lab.MobileAppService.Models
{
    public class PersonRepository : IPersonRepository
    {

        private LabDbContext dbContext;

        public PersonRepository(LabDbContext context)
        {
            dbContext = context;
        }



        public void Add(Person person)
        {
            dbContext.Persons.Add(person);
            dbContext.SaveChanges();

        }

        public Person Get(int id)
        {
            return dbContext.Persons.Find(id);
        }

        public IEnumerable<Person> GetAll()
        {
            return dbContext.Persons;
        }

        public void Remove(int id)
        {
            Person person = dbContext.Persons.Find(id);
 
            dbContext.Persons.Remove(person);
            dbContext.SaveChanges();
        }

        public void Update(Person person)
        {
            Person personDb = dbContext.Persons.Find(person.Id);
            person.Name = personDb.Name;
            person.Email = personDb.Email;

            dbContext.SaveChanges();
        }
    }
}
