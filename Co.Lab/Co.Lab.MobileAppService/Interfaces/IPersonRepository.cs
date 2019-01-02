using System;
using System.Collections.Generic;
using Co.Lab.Models;

namespace Co.Lab.MobileAppService.Interfaces
{
    public interface IPersonRepository
    {
        void Add(Person item);
        void Update(Person item);
        void Remove(int id);
        Person Get(int id);
        IEnumerable<Person> GetAll();
    }
}
