using Phonebook.Models;
using Phonebook.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook.Services
{
    public  class RepositoryService
    {
        private IEnumerable<IDataProvider> _providers;
        public RepositoryService(IEnumerable<IDataProvider> providers)
        {
            _providers = providers;
        }

        public IEnumerable<Entity> List()
        {
            IEnumerable<Entity> allEntities= new List<Entity>();
            foreach (IDataProvider provider in _providers)
            {
                allEntities = allEntities.Concat(provider.List());
            }
            return allEntities;
        }

        public IEnumerable<Entity> Search(string searchText)
        {
            IEnumerable<Entity> foundEntities = new List<Entity>();
            foreach (IDataProvider provider in _providers)
            {
                foundEntities = foundEntities.Concat(provider.Search(searchText));
            }
            return foundEntities;
        }

    }
}
