using Data.Entities.User;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

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

            // Унікальний індекс для UserName
            builder.Entity<User>().HasIndex(u => u.UserName).IsUnique();

            // Налаштування зв'язку User <-> ProfilePhoto
            builder.Entity<ProfilePhoto>()
                .HasOne(p => p.User)
                .WithMany(u => u.ProfilePhotos)
                .HasForeignKey(p => p.UserId)
                .OnDelete(DeleteBehavior.Cascade); // Каскадне видалення

            // Налаштування унікальності для інтересів
            builder.Entity<Interest>()
                .HasIndex(i => i.Name)
                .IsUnique();

            // Ініціалізація даних для таблиці Interests
            builder.Entity<Interest>().HasData(GenerateInterests());
        }

        // Генерація початкових інтересів
        private List<Interest> GenerateInterests()
        {
            var interestNames = new[]
            {
                "Reading", "Traveling", "Cooking", "Photography", "Music",
                "Movies", "Hiking", "Fitness", "Gaming", "Dancing",
                "Art", "Coding", "Blogging", "Yoga", "Gardening",
                "Cycling", "Fishing", "Sports", "Meditation", "Learning Languages"
            };

            var interests = new List<Interest>();
            int id = 1;
            foreach (var name in interestNames)
            {
                interests.Add(new Interest
                {
                    Id = id++,
                    Name = name
                });
            }

            return interests;
        }
    }
}
