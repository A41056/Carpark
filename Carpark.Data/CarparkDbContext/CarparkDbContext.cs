using Carpark.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Carpark.Data.CarparkDbContext
{
    public class CarparkDbContext : DbContext
    {
        public CarparkDbContext(DbContextOptions<CarparkDbContext> options) : base(options) 
        {

        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<CarPark> Carparks { get; set; }    
        public virtual DbSet<UserFavorite> UserFavorites { get; set; }
        public virtual DbSet<CarParkType> CarParkTypes { get; set; }
        public virtual DbSet<FreeParkingType> FreeParkingTypes { get; set; }
        public virtual DbSet<NightParkingType> NightParkingTypes { get; set; }
        public virtual DbSet<ParkingTypeSystem> ParkingTypeSystems { get; set; }
        public virtual DbSet<ShortTermParkingType> ShortTermParkingTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("user");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.UserName).IsRequired().HasMaxLength(255);
                entity.Property(e => e.PasswordHash).IsRequired();
                entity.Property(e => e.PasswordSalt).IsRequired();
                entity.Property(e => e.FirstName).IsRequired().HasMaxLength(255);
                entity.Property(e => e.LastName).IsRequired().HasMaxLength(255);
                entity.Property(e => e.FullName).IsRequired().HasMaxLength(255);
                entity.Property(e => e.IsActive).IsRequired().HasDefaultValue(true);
                entity.Property(e => e.Created).IsRequired(false).HasDefaultValue(DateTime.UtcNow);
                entity.Property(e => e.Modified).IsRequired(false).HasDefaultValue(DateTime.UtcNow);

                entity.HasIndex(e => e.UserName).IsUnique();
            });

            modelBuilder.Entity<CarPark>(entity =>
            {
                entity.ToTable("car_park");

                entity.HasKey(e => e.CarParkNo);

                entity.Property(e => e.Address).IsRequired().HasMaxLength(500);
                entity.Property(e => e.CarParkDeck).IsRequired();
                entity.Property(e => e.GantryHeight).IsRequired().HasDefaultValue(0.0);
                entity.Property(e => e.CarParkBasement).IsRequired().HasDefaultValue(0);

                entity.HasOne(c => c.CarParkTypeNavigation)
                      .WithMany(t => t.CarParkNavigation)
                      .HasForeignKey(c => c.CarParkType);

                entity.HasOne(c => c.FreeParkingNavigation)
                      .WithMany(t => t.CarParkNavigation)
                      .HasForeignKey(c => c.FreeParkingType);

                entity.HasOne(c => c.NightParkingNavigation)
                      .WithMany(t => t.CarParkNavigation)
                      .HasForeignKey(c => c.NightParkingType);

                entity.HasOne(c => c.TypeOfParkingSystemNavigation)
                      .WithMany(t => t.CarParkNavigation)
                      .HasForeignKey(c => c.ParkingTypeSystem);

                entity.HasOne(c => c.ShortTermParkingNavigation)
                      .WithMany(t => t.CarParkNavigation)
                      .HasForeignKey(c => c.ShortTermParkingType);

                entity.HasIndex(e => e.CarParkNo).IsUnique();
            });

            modelBuilder.Entity<CarParkType>(entity =>
            {
                entity.ToTable("car_park_type");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.CarParkTypeName).IsRequired().HasMaxLength(255);
            });

            modelBuilder.Entity<FreeParkingType>(entity =>
            {
                entity.ToTable("free_parking_type");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.FreeParkingTypeName).IsRequired().HasMaxLength(255);
            });

            modelBuilder.Entity<ParkingTypeSystem>(entity =>
            {
                entity.ToTable("parking_system_type");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.ParkingTypeSystemName).IsRequired().HasMaxLength(255);
            });

            modelBuilder.Entity<NightParkingType>(entity =>
            {
                entity.ToTable("night_parking_type");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.NightParkingTypeName).IsRequired().HasMaxLength(255);
            });

            modelBuilder.Entity<ShortTermParkingType>(entity =>
            {
                entity.ToTable("short_term_parking_type");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.ShortTermParkingName).IsRequired().HasMaxLength(255);
            });

            modelBuilder.Entity<UserFavorite>(entity => 
            {
                entity.ToTable("user_favorite");

                entity.HasKey(e => new { e.UserId, e.CarParkNo });

                entity.HasOne(uf => uf.UserNavigation)
                      .WithOne(u => u.UserFavoriteNavigation)
                      .HasForeignKey<UserFavorite>(uf => uf.UserId);

                entity.HasOne(uf => uf.CarParkNavigation)
                      .WithOne(cp => cp.UserFavoriteNavigation)
                      .HasForeignKey<UserFavorite>(uf => uf.CarParkNo);

                entity.HasIndex(uf => uf.UserId).IsUnique();
                entity.HasIndex(uf => uf.CarParkNo).IsUnique();
            });

            base.OnModelCreating(modelBuilder);

            string password = "Admin@123";
            byte[] passwordSalt;
            byte[] passwordHash;

            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }

            var user1 = new User
            {
                Id = Guid.NewGuid(),
                UserName = "giappq",
                FirstName = "Pham",
                LastName = "Quang Giap",
                FullName = "Pham Quang Giap",
                Email = "giapp@vmogroup.com",
                IsActive = true,
                Created = DateTime.UtcNow,
                Modified = DateTime.UtcNow,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt
            };

            var user2 = new User
            {
                Id = Guid.NewGuid(),
                UserName = "giappq1",
                FirstName = "Pham",
                LastName = "Quang Giap 1",
                FullName = "Pham Quang Giap 1",
                Email = "giapp1@vmogroup.com",
                IsActive = true,
                Created = DateTime.UtcNow,
                Modified = DateTime.UtcNow,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt
            };

            //modelBuilder.Entity<User>().HasData(
            //    user1,
            //    user2
            //);
        }
    }
}
