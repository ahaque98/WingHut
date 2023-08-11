using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Server.Models;

namespace Server.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<MenuItem>().HasData(
                new MenuItem
                {
                    Id = 1,
                    Name = "Package 1 (Friendly)",
                    Description = "4 Jumbo Burgers along with 3 Mini Burgers and 7 Wings with White Sauce!",
                    Image = "https://winghutimages.blob.core.windows.net/winghut/friendsPackage.jpg",
                    Price = 47.99,
                    Category = "Friendly Package",
                    SpecialTag = "Gathering"
                }, new MenuItem
                {
                    Id = 2,
                    Name = "Roasted Wings",
                    Description = "Roasted Wings with Garlic Sauce and sprinkled onion leaves",
                    Image = "https://winghutimages.blob.core.windows.net/winghut/normalWings.jpg",
                    Price = 8.99,
                    Category = "One Meal",
                    SpecialTag = "Top Rated"
                }, new MenuItem
                {
                    Id = 3,
                    Name = "Package 1 (Party)",
                    Description = "1 Large Pizza, 10 Cans of soft drinks, 40 Wings, Unlimited Suace, 1 Bowl of Chips, 1 Bowl of PopCorn",
                    Image = "https://winghutimages.blob.core.windows.net/winghut/partyPackage.jpg",
                    Price = 82.99,
                    Category = "Party Package",
                    SpecialTag = "Best Seller"
                }, new MenuItem
                {
                    Id = 4,
                    Name = "Whole Grilled Chicken",
                    Description = "1 Whole Grilled Chicken with our Special White Sauce",
                    Image = "https://winghutimages.blob.core.windows.net/winghut/wholeChicken.jpg",
                    Price = 10.69,
                    Category = "Whole Meal",
                    SpecialTag = ""
                }, new MenuItem
                {
                    Id = 5,
                    Name = "Package 1 (Bucket)",
                    Description = "A Bucket (50 pieces) of Chicken Wings with Hot Sauce and White Sauce",
                    Image = "https://winghutimages.blob.core.windows.net/winghut/wingOnBucket.jpg",
                    Price = 12.99,
                    Category = "Buckets",
                    SpecialTag = "Top Rated"
                }, new MenuItem
                {
                    Id = 6,
                    Name = "Package 1 (Tray)",
                    Description = "Tray of Wings specially marinated with lime and our secret sauce!",
                    Image = "https://winghutimages.blob.core.windows.net/winghut/wingTray.jpg",
                    Price = 101.99,
                    Category = "Trays",
                    SpecialTag = "Top Rated"
                }
                );
        }
    }
}
