using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorServerSide.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerSide.Server.DataAccess
{
    public class EmployeeContext : DbContext
    {
        public virtual DbSet<Employee> tblEmployee { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=StudentsDB;Trusted_Connection=True;");
            }
        }
    }
}
