using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyChampionList.Domain.Model;

namespace MyChampionList.Infrastructure
{
    public class Context : IdentityDbContext
    {
        public DbSet<Champion> Champions { get; set; }
        public DbSet<Role> Roles { get; set; }
        public Context(DbContextOptions options) : base(options) 
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
