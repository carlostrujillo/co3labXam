using System;
using System.Collections.Generic;
using Co.Lab.Models;

namespace Co.Lab.Interfaces
{
    public interface IItemRepository
    {
        void Add(Item item);
        void Update(Item item);
        Item Remove(string key);
        Item Get(string id);
        IEnumerable<Item> GetAll();
    }
}
