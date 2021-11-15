using MySql.Data.MySqlClient;
using Phonebook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook.Providers
{
    public class PersonProvider : BaseProvider
    {

        protected override string GetTable()
        {
            return "person";
        }

        protected override Entity CreateItem(MySqlDataReader reader)
        {
            return new Person(Convert.ToInt32(reader["id"]), reader["firstname"].ToString(), reader["lastname"].ToString());
        }

    }
}
