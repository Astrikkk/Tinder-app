using Data.Entities.User;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Data
{
    public class TinderDBContext : IdentityDbContext<User>
    {
        public DbSet<Interest> Interests { get; set; }
        public DbSet<ProfilePhoto> ProfilePhotos { get; set; }

        public TinderDBContext(DbContextOptions<TinderDBContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Interest>()
                .HasOne(i => i.User)
                .WithMany(u => u.Interests)
                .HasForeignKey(i => i.UserId);

            builder.Entity<ProfilePhoto>()
                .HasOne(p => p.User)
                .WithMany(u => u.ProfilePhotos)
                .HasForeignKey(p => p.UserId);
        }
    }



}

