using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeChatAPI.Models;

namespace WeChatAPI.DataAccess
{
    public class SunInfoContext:DbContext
    {

        public SunInfoContext()
        {

        }

        public SunInfoContext(DbContextOptions<SunInfoContext> options):base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=suninfo.db");
            }
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        public DbSet<App> Apps { get; set; }
    }
}
