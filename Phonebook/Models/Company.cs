using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook.Models
{
    public class Company : Entity
    {
        public string Name { get; set; }

        public Company(int id, string name) : base(id)
        {
            Name = name;
        }
        public override string ToString()
        {
            return base.ToString() + Name.ToString();
        }

    }

}
