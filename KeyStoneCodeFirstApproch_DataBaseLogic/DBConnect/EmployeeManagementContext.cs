using KeyStoneCodeFirst_BusinessEntities.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyStoneCodeFirstApproch_DataBaseLogic.DBConnect
{
    public class EmployeeManagementContext:DbContext
    {
        public DbSet<Employee> employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-NORDVAN\MSSQLSERVER01;initial Catalog=KeyStoneCodeFirstApproch;Integrated Security=True;");
        }
    }
}
