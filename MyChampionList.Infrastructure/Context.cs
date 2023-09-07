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
        public DbSet<User> Users { get; set; }
        public DbSet<LikedChamp> LikedChamp { get; set; }
        public DbSet<TrashedChamp> TrashedChamp { get; set; }
        public Context(DbContextOptions options) : base(options) 
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<LikedChamp>()
                .HasKey(e => new { e.UserId, e.ChampionId });

            builder.Entity<LikedChamp>()
                .HasOne<User>(p => p.User)
                .WithMany(p => p.LikedChamps)
                .HasForeignKey(p => p.UserId);

            builder.Entity<LikedChamp>()
                .HasOne<Champion>(p => p.Champion)
                .WithMany(p => p.LikedChamps)
                .HasForeignKey(p => p.ChampionId);

            builder.Entity<TrashedChamp>()
                .HasKey(e => new { e.UserId, e.ChampionId });

            builder.Entity<TrashedChamp>()
                .HasOne<User>(p => p.User)
                .WithMany(p => p.TrashedChamps)
                .HasForeignKey(p => p.UserId);

            builder.Entity<TrashedChamp>()
                .HasOne<Champion>(p => p.Champion)
                .WithMany(p => p.TrashedChamps)
                .HasForeignKey(p => p.ChampionId);
        }
    }
}
