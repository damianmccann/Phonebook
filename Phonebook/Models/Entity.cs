using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook.Models
{
    public abstract class Entity
    {
        public int Id { get; set; }
        public Entity(int id)
        {
            Id = id;
        }

        public override string ToString()
        {
            return Id + ": ";
        }

    }
}
