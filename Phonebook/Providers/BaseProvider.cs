using MySql.Data.MySqlClient;
using Phonebook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook.Providers
{
    public abstract class BaseProvider : IDataProvider
    {
        protected abstract string GetTable();

        protected abstract Entity CreateItem(MySqlDataReader reader);

        private IEnumerable<Entity> GetData()
        {
            List<Entity> entities = new List<Entity>();

            MySqlConnection conn = GetConnection();
            conn.Open();

            MySqlCommand cmd = new MySqlCommand("select * from " + GetTable(), conn);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                entities.Add(CreateItem(reader));
            }
            conn.Close();

            return entities;
        }

        public IEnumerable<Entity> List()
        {
            return GetData();
        }

        public IEnumerable<Entity> Search(string searchText)
        {
            searchText = searchText.ToLower();
            List<Entity> results = new List<Entity>();

            foreach (Entity entity in GetData())
            {
                if(entity.ToString().ToLower().Contains(searchText))
                {
                    results.Add(entity);
                }
            }

            return results;
        }

        protected MySqlConnection GetConnection()
        {
            return new MySqlConnection("server=localhost;port=3306;user=root;password=;database=adodotnet");
        }

    }
}
