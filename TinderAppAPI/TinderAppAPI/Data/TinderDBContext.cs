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

            builder.Entity<ProfilePhoto>()
                .HasOne(p => p.User)
                .WithMany(u => u.ProfilePhotos)
                .HasForeignKey(p => p.UserId);

            builder.Entity<Interest>().HasData(GenerateInterests());
        }

        private List<Interest> GenerateInterests()
        {
            var interests = new List<Interest>();
            var interestNames = new[]
            {
                "Reading", "Traveling", "Cooking", "Photography", "Music",
                "Movies", "Hiking", "Fitness", "Gaming", "Dancing",
                "Art", "Coding", "Blogging", "Yoga", "Gardening",
                "Cycling", "Fishing", "Sports", "Meditation", "Learning Languages"
            };

            int id = 1;
            foreach (var name in interestNames)
            {
                for (int i = 1; i <= 10; i++)
                {
                    interests.Add(new Interest
                    {
                        Id = id++,
                        Name = $"{name} {i}"
                    });
                }
            }

            return interests;
        }
    }



}

