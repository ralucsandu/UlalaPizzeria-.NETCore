using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backendProiect.Entities
{
    public class backendProiectContext : IdentityDbContext<User, Role, int, IdentityUserClaim<int>, 
        UserRole, IdentityUserLogin<int>, IdentityRoleClaim<int>, IdentityUserToken<int>>
    {
        public backendProiectContext(DbContextOptions<backendProiectContext> options) : base(options) { }
        public DbSet<Ingredient>Ingredients { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Price> Prices { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<FoodIngredients> FoodIngredients { get; set; }

/*        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLoggerFactory(LoggerFactory.Create(builder => builder.AddConsole()))
                .UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Initial Catalog=backendProiect;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }*/

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Food>()
                .HasOne(food => food.Image)
                .WithOne(image => image.Food);

            builder.Entity<Price>()
                .HasMany(p => p.Foods)
                .WithOne(f => f.Price);

            builder.Entity<Food>()
                .HasMany(f => f.Reviews)
                .WithOne(r => r.Food);

            builder.Entity<FoodIngredients>().HasKey(fi => new { fi.FoodId, fi.IngredientId });

            builder.Entity<FoodIngredients>()
                .HasOne(fi => fi.Food)
                .WithMany(f => f.FoodsIngredients)
                .HasForeignKey(fi => fi.FoodId);

            builder.Entity<FoodIngredients>()
                .HasOne(fi => fi.Ingredient)
                .WithMany(i => i.FoodsIngredients)
                .HasForeignKey(fi => fi.IngredientId);

        }
    }
}
