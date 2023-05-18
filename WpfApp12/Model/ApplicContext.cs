using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp12.Model
{
    class ApplicContext : DbContext
    {
        public DbSet<Appli> Applics { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = DataBase.db");
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}
