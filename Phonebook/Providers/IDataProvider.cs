using Phonebook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook.Providers
{
    public interface IDataProvider
    {
        IEnumerable<Entity> List();
        IEnumerable<Entity> Search(string searchText);
    }
}
