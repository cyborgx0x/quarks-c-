using quarks.Models;
using System.Collections.Generic;
using System.Linq;

namespace quarks.Data
{
    public class TargetRepository : ITargetRepository
    {
        // This could be an in-memory list for simplicity or a database context for a real application
        private readonly List<Target> _targets = new List<Target>();

        public IEnumerable<Target> GetAll()
        {
            return _targets;
        }

        public Target? GetById(int id)
        {
            return _targets.FirstOrDefault(t => t.Id == id);
        }


        public void Add(Target target)
        {
            // Add the target to the database or collection
            _targets.Add(target);
        }

        public void Update(Target target)
        {
            // Update the target in the database or collection
            var existing = GetById(target.Id);
            if (existing != null)
            {
                // Update properties
                existing.Name = target.Name;
                // Update other properties
            }
        }

        public void Delete(int id)
        {
            var target = GetById(id);
            if (target != null)
            {
                _targets.Remove(target);
            }
        }
    }
}
