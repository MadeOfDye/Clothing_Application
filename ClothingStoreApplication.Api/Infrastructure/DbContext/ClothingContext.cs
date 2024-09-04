using ClothingStoreApplication.Api.Core.Domain;
using Microsoft.EntityFrameworkCore;

namespace ClothingStoreApplication.Api.Infrastructure.DbContext
{
    public class ClothingContext : DbContext
    {
        public DbSet<ClothingItem> ClothingItems { get; set; }
        public DbSet<Accessory> Accessories { get; set; }
        public DbSet<Backpack> Backpacks { get; set; }
        public DbSet<Blazer> Blazers { get; set; }
        public DbSet<Blouse> Blouses { get; set; }
        public DbSet<Bodysuit> Bodysuits { get; set; }
        public DbSet<Boot> Boots { get; set; }
        public DbSet<BussinessShoes> BussinessShoes { get; set; }
        public DbSet<Coat> Coats { get; set; }
        public DbSet<Dress> Dresses { get; set; }
        public DbSet<Jacket> Jackets { get; set; }
        public DbSet<Jeans> Jeans { get; set; }
        public DbSet<Overshirt> Overshirts { get; set; }
        public DbSet<Perfume> Perfumes { get; set; }
        public DbSet<RunningShoes> RunningShoes { get; set; }
        public DbSet<Shirt> Shirts { get; set; }
        public DbSet<Shorts> Shorts { get; set; }
        public DbSet<Skirt> Skirts { get; set; }
        public DbSet<Skort> Skorts { get; set; }
        public DbSet<Sneakers> Sneakers { get; set; }
        public DbSet<Suit> Suits { get; set; }
        public DbSet<Top> Tops { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<TrenchCoat> TrenchCoats { get; set; }
        public DbSet<Trousers> Trousers { get; set; }
        public DbSet<TShirt> Tshirts { get; set; }

        public ClothingContext(DbContextOptions<ClothingContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure base class
            modelBuilder.Entity<ClothingItem>().ToTable("ClothingItems");

            // Configure each derived class with TPT (Table-per-Type) inheritance
            modelBuilder.Entity<Accessory>().ToTable("Accessories");
            modelBuilder.Entity<Backpack>().ToTable("Backpacks");
            modelBuilder.Entity<Blazer>().ToTable("Blazers");
            modelBuilder.Entity<Blouse>().ToTable("Blouses");
            modelBuilder.Entity<Bodysuit>().ToTable("Bodysuits");
            modelBuilder.Entity<Boot>().ToTable("Boots");
            modelBuilder.Entity<BussinessShoes>().ToTable("BussinessShoes");
            modelBuilder.Entity<Coat>().ToTable("Coats");
            modelBuilder.Entity<Dress>().ToTable("Dresses");
            modelBuilder.Entity<Jacket>().ToTable("Jackets");
            modelBuilder.Entity<Jeans>().ToTable("Jeans");
            modelBuilder.Entity<Overshirt>().ToTable("Overshirts");
            modelBuilder.Entity<Perfume>().ToTable("Perfumes");
            modelBuilder.Entity<RunningShoes>().ToTable("RunningShoes");
            modelBuilder.Entity<Shirt>().ToTable("Shirts");
            modelBuilder.Entity<Shorts>().ToTable("Shorts");
            modelBuilder.Entity<Skirt>().ToTable("Skirts");
            modelBuilder.Entity<Skort>().ToTable("Skorts");
            modelBuilder.Entity<Sneakers>().ToTable("Sneakers");
            modelBuilder.Entity<Suit>().ToTable("Suits");
            modelBuilder.Entity<Top>().ToTable("Tops");
            modelBuilder.Entity<Trainer>().ToTable("Trainers");
            modelBuilder.Entity<TrenchCoat>().ToTable("TrenchCoats");
            modelBuilder.Entity<Trousers>().ToTable("Trousers");
            modelBuilder.Entity<TShirt>().ToTable("TShirts");

            // Additional configurations (e.g., relationships, indexes, constraints) can go here
        }
    }
}
