using MySampleProject.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlDataAccess;

namespace MySql.DataAccess.Buisness
{
    public static class BuisnessModel
    {
        public static int CreateEmployee(string Usernameq, string password)
        {
            Student data = new Student
            {
                Name = Usernameq,
                Description = password

            };
         
            string sql = @"insert into users (USERNAME,PASSWORD) VALUES (@userName,@Password);";
            int v = MySqlDataAccess.DataAccess.SaveData(sql, data);
            return DataAccess.SaveData(sql, data);


        }
    }
}
