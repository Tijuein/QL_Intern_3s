using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _3s_QLThucTapSinhIntern.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext()
        {
        }

        public MyDbContext(DbContextOptions options) : base()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=LAPCN-I-TUANVV\\SQLEXPRESS;Initial Catalog=3s_QLthuctapsinhIntern;Integrated Security=True");
        }
    }

    public class DbContextOptions
    {
    }
}
