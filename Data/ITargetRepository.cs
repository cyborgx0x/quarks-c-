using quarks.Models;
using System.Collections.Generic;

namespace quarks.Data
{
    public interface ITargetRepository
    {
        IEnumerable<Target> GetAll();
        Target GetById(int id);
        void Add(Target target);
        void Update(Target target);
        void Delete(int id);
    }
}