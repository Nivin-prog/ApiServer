using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySampleProject.Core.Models;
using MySql.Data.MySqlClient;


namespace DataAccess.MySql
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    class DataContext: DbContext
    {
        public DataContext()
            : base("DefaultConnection")
        {        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Subjects> Subjects { get; set; }
      
    }
}
