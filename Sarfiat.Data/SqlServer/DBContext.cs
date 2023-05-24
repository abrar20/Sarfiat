using Microsoft.EntityFrameworkCore;
using Sarfiat.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sarfiat.Data.SqlServer
{
    public class DBContext:DbContext
    {
        public DBContext()
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //var sqlcon = @"Server=(localdb)\MSSQLLocalDB;Database=Sarfiat;Trusted_Connection=True";
            optionsBuilder.UseSqlServer(SqlCon.SqlConnection);
        }
        //Tables
        public DbSet<Categories> Categories { get; set; }
        public DbSet<SystemRecords> SystemRecords { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Suppliers> Suppliers { get; set; }
        public DbSet<Projects> Projects { get; set; }
        public DbSet<Outcome> Outcome { get; set; }
        public DbSet<Income> Income { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<UsersRoles> UsersRoles { get; set; }
    }
}
