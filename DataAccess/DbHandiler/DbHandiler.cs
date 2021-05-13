using Dapper;
using DataAccess.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccess.DbHandiler
{
    public class DbHandiler
    {
        public string GetConnection(string name = "DefaultConnection")
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

        internal int SaveData<t>(string sql, t data)
        {
            using(IDbConnection con = new MySqlConnection(GetConnection()))
            {
                return con.Execute(sql, data);
            }
        }

        internal List<T> LoadData<T>(string sql)
        {
            using (IDbConnection con = new MySqlConnection(GetConnection()))
            {
                return con.Query<T>(sql).ToList();
            }
        }
    }
}
