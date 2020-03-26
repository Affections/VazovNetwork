using MySql.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VazovNetwork.Db
{
    public class SchoolDbContext : DbContext
    {

        public DbSet<Student> Students { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Competition> Competitions { get; set; }

        public DbSet<Achievment> Achievments { get; set; }

    }
}
