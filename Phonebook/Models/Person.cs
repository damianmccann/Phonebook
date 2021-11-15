using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook.Models
{
    public class Person : Entity
    {
        public string Firstname{ get; set; }
        public string Lastname { get; set; }

        public Person(int id, string firstname, string lastname) : base(id)
        {
            Firstname = firstname;
            Lastname = lastname;
        }

        public override string ToString()
        {
            return base.ToString() + Firstname.ToString() + " " + Lastname.ToString();
        }

    }
}
