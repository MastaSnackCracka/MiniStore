using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MiniStore.Models;
using Microsoft.AspNetCore.Identity;

namespace MiniStore.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<OrderHeader> OrderHeaders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Hero", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Villain", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Monster", DisplayOrder = 3 }
            );

            modelBuilder.Entity<Company>().HasData(
                new Company
                {
                    Id = 1,
                    Name = "Tech Solution",
                    StreetAddress = "123 Tech St",
                    City = "Tech City",
                    PostalCode = "12121",
                    Province = "ON",
                    PhoneNumber = "6669990000"
                },
                new Company
                {
                    Id = 2,
                    Name = "Vivid Books",
                    StreetAddress = "999 Vid St",
                    City = "Vid City",
                    PostalCode = "66666",
                    Province = "AL",
                    PhoneNumber = "7779990000"
                },
                new Company
                {
                    Id = 3,
                    Name = "Readers Club",
                    StreetAddress = "999 Main St",
                    City = "Lala land",
                    PostalCode = "99999",
                    Province = "QU",
                    PhoneNumber = "1113335555"
                }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Faergus MacMurachadh (1)",
                    Size = 3,
                    CatId = 1,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incIdIdunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupIdatat non proIdent, sunt in culpa qui officia deserunt mollit anim Id est laborum.",
                    Price = 7.99,
                    Image1 = "PSX_20231209_101355.jpg",
                    Image2 = "PSX_20231209_101425.jpg",
                    Image3 = "PSX_20231209_101454.jpg",
                    Char_Race = "Human",
                    Char_Class = "Barbarian"
                },
                new Product
                {
                    Id = 2,
                    Name = "Black Tsunami",
                    Size = 3,
                    CatId = 1,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incIdIdunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupIdatat non proIdent, sunt in culpa qui officia deserunt mollit anim Id est laborum.",
                    Price = 7.99,
                    Image1 = "Tsunami.png",
                    Image2 = "",
                    Image3 = "",
                    Char_Race = "Dragonborn",
                    Char_Class = "Monk"
                },
                new Product
                {
                    Id = 3,
                    Name = "Wendell PorrIdgepot",
                    Size = 2,
                    CatId = 1,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incIdIdunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupIdatat non proIdent, sunt in culpa qui officia deserunt mollit anim Id est laborum.",
                    Price = 6.99,
                    Image1 = "PSX_20231209_100500(1).jpg",
                    Image2 = "PSX_20231209_100531.jpg",
                    Image3 = "PSX_20231209_100559.jpg",
                    Char_Race = "Halfling",
                    Char_Class = "Rogue"
                },
                new Product
                {
                    Id = 4,
                    Name = "Alinar Merityn",
                    Size = 3,
                    CatId = 1,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incIdIdunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupIdatat non proIdent, sunt in culpa qui officia deserunt mollit anim Id est laborum.",
                    Price = 7.99,
                    Image1 = "",
                    Image2 = "",
                    Image3 = "",
                    Char_Race = "Elf",
                    Char_Class = "Rogue"
                },
                new Product
                {
                    Id = 5,
                    Name = "Norlak",
                    Size = 3,
                    CatId = 1,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incIdIdunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupIdatat non proIdent, sunt in culpa qui officia deserunt mollit anim Id est laborum.",
                    Price = 8.99,
                    Image1 = "PSX_20231209_101655.jpg",
                    Image2 = "PSX_20231209_101723.jpg",
                    Image3 = "PSX_20231209_101804.jpg",
                    Char_Race = "Minotaur",
                    Char_Class = "Barbarian"
                },
                new Product
                {
                    Id = 6,
                    Name = "Big Bragg",
                    Size = 4,
                    CatId = 2,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incIdIdunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupIdatat non proIdent, sunt in culpa qui officia deserunt mollit anim Id est laborum.",
                    Price = 8.99,
                    Image1 = "PSX_20231209_084029.jpg",
                    Image2 = "PSX_20231209_102538.jpg",
                    Image3 = "PSX_20231209_102505.jpg",
                    Char_Race = "Bugbear",
                    Char_Class = "Thug"
                },
                new Product
                {
                    Id = 7,
                    Name = "Big Brogg",
                    Size = 4,
                    CatId = 2,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incIdIdunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupIdatat non proIdent, sunt in culpa qui officia deserunt mollit anim Id est laborum.",
                    Price = 8.99,
                    Image1 = "PSX_20231209_102308.jpg",
                    Image2 = "PSX_20231209_102350.jpg",
                    Image3 = "PSX_20231209_102431.jpg",
                    Char_Race = "Bugbear",
                    Char_Class = "Thug"
                },
                new Product
                {
                    Id = 8,
                    Name = "Lomax Godhammer",
                    Size = 3,
                    CatId = 1,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incIdIdunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupIdatat non proIdent, sunt in culpa qui officia deserunt mollit anim Id est laborum.",
                    Price = 7.99,
                    Image1 = "PSX_20231209_102136.jpg",
                    Image2 = "PSX_20231209_102215.jpg",
                    Image3 = "",
                    Char_Race = "Dwarf",
                    Char_Class = "Cleric"
                },
                new Product
                {
                    Id = 9,
                    Name = "Yehorta",
                    Size = 3,
                    CatId = 1,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incIdIdunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupIdatat non proIdent, sunt in culpa qui officia deserunt mollit anim Id est laborum.",
                    Price = 7.99,
                    Image1 = "PSX_20231209_101912.jpg",
                    Image2 = "PSX_20231209_101945.jpg",
                    Image3 = "PSX_20231209_102020.jpg",
                    Char_Race = "Tortle",
                    Char_Class = "DruId"
                },
                new Product
                {
                    Id = 10,
                    Name = "Bulgrim Torvond",
                    Size = 3,
                    CatId = 1,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incIdIdunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupIdatat non proIdent, sunt in culpa qui officia deserunt mollit anim Id est laborum.",
                    Price = 7.99,
                    Image1 = "PSX_20231209_101522.jpg",
                    Image2 = "PSX_20231209_101556.jpg",
                    Image3 = "PSX_20231209_101628.jpg",
                    Char_Race = "Dwarf",
                    Char_Class = "Cleric"
                },
                new Product
                {
                    Id = 11,
                    Name = "Faergus MacMurachadh (2)",
                    CatId = 1,
                    Size = 3,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incIdIdunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupIdatat non proIdent, sunt in culpa qui officia deserunt mollit anim Id est laborum.",
                    Price = 7.99,
                    Image1 = "PSX_20231209_101142.jpg",
                    Image2 = "PSX_20231209_101233.jpg",
                    Image3 = "PSX_20231209_101312.jpg",
                    Char_Race = "Human",
                    Char_Class = "Barbarian"
                },
                new Product
                {
                    Id = 12,
                    Name = "Bartel Radclif",
                    Size = 3,
                    CatId = 1,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incIdIdunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupIdatat non proIdent, sunt in culpa qui officia deserunt mollit anim Id est laborum.",
                    Price = 7.99,
                    Image1 = "PSX_20231209_100917.jpg",
                    Image2 = "PSX_20231209_101010.jpg",
                    Image3 = "PSX_20231209_101048.jpg",
                    Char_Race = "Human",
                    Char_Class = "Fighter"
                },
                new Product
                {
                    Id = 13,
                    Name = "Demeldor",
                    Size = 3,
                    CatId = 2,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incIdIdunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupIdatat non proIdent, sunt in culpa qui officia deserunt mollit anim Id est laborum.",
                    Price = 7.99,
                    Image1 = "PSX_20231209_100708.jpg",
                    Image2 = "PSX_20231209_100804.jpg",
                    Image3 = "PSX_20231209_100845.jpg",
                    Char_Race = "Tiefling",
                    Char_Class = "Warlock"
                },
                new Product
                {
                    Id = 14,
                    Name = "Cedric Greylock",
                    Size = 3,
                    CatId = 1,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incIdIdunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupIdatat non proIdent, sunt in culpa qui officia deserunt mollit anim Id est laborum.",
                    Price = 7.99,
                    Image1 = "PSX_20231209_100256.jpg",
                    Image2 = "PSX_20231209_100340.jpg",
                    Image3 = "PSX_20231209_100405.jpg",
                    Char_Race = "Human",
                    Char_Class = "Cleric"
                },
                new Product
                {
                    Id = 15,
                    Name = "Nulara Revenmar",
                    Size = 3,
                    CatId = 1,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incIdIdunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupIdatat non proIdent, sunt in culpa qui officia deserunt mollit anim Id est laborum.",
                    Price = 7.99,
                    Image1 = "PSX_20231209_100047.jpg",
                    Image2 = "PSX_20231209_100130.jpg",
                    Image3 = "PSX_20231209_100207.jpg",
                    Char_Race = "Human",
                    Char_Class = "DruId"
                },
                new Product
                {
                    Id = 16,
                    Name = "Talmond Evonwood",
                    Size = 3,
                    CatId = 1,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incIdIdunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupIdatat non proIdent, sunt in culpa qui officia deserunt mollit anim Id est laborum.",
                    Price = 7.99,
                    Image1 = "PSX_20231209_095914.jpg",
                    Image2 = "PSX_20231209_095937.jpg",
                    Image3 = "PSX_20231209_100009.jpg",
                    Char_Race = "Human",
                    Char_Class = "DruId"
                },
                new Product
                {
                    Id = 17,
                    Name = "Dorian Ambrose",
                    Size = 3,
                    CatId = 1,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incIdIdunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupIdatat non proIdent, sunt in culpa qui officia deserunt mollit anim Id est laborum.",
                    Price = 7.99,
                    Image1 = "PSX_20231209_095721.jpg",
                    Image2 = "PSX_20231209_095801.jpg",
                    Image3 = "PSX_20231209_095836.jpg",
                    Char_Race = "Human",
                    Char_Class = "Paladin"
                },
                new Product
                {
                    Id = 18,
                    Name = "Calimar Tlin'orzza",
                    Size = 3,
                    CatId = 2,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incIdIdunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupIdatat non proIdent, sunt in culpa qui officia deserunt mollit anim Id est laborum.",
                    Price = 7.99,
                    Image1 = "PSX_20231209_095512.jpg",
                    Image2 = "PSX_20231209_095606.jpg",
                    Image3 = "PSX_20231209_095650.jpg",
                    Char_Race = "Drow",
                    Char_Class = "Fighter"
                },
                new Product
                {
                    Id = 19,
                    Name = "Elza Glitterbranch",
                    Size = 2,
                    CatId = 1,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incIdIdunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupIdatat non proIdent, sunt in culpa qui officia deserunt mollit anim Id est laborum.",
                    Price = 6.99,
                    Image1 = "PSX_20231209_095308.jpg",
                    Image2 = "PSX_20231209_095354.jpg",
                    Image3 = "PSX_20231209_095430.jpg",
                    Char_Race = "Gnome",
                    Char_Class = "Wizard"
                },
                new Product
                {
                    Id = 20,
                    Name = "Elias Leerstrom",
                    Size = 3,
                    CatId = 1,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incIdIdunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupIdatat non proIdent, sunt in culpa qui officia deserunt mollit anim Id est laborum.",
                    Price = 7.99,
                    Image1 = "PSX_20231209_095048.jpg",
                    Image2 = "PSX_20231209_095128.jpg",
                    Image3 = "PSX_20231209_095226.jpg",
                    Char_Race = "Human",
                    Char_Class = "DruId"
                },
                new Product
                {
                    Id = 21,
                    Name = "Fineela Nessik",
                    Size = 2,
                    CatId = 1,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incIdIdunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupIdatat non proIdent, sunt in culpa qui officia deserunt mollit anim Id est laborum.",
                    Price = 6.99,
                    Image1 = "PSX_20231209_094812.jpg",
                    Image2 = "PSX_20231209_094919.jpg",
                    Image3 = "PSX_20231209_095009.jpg",
                    Char_Race = "Gnome",
                    Char_Class = "Wizard"
                },
                new Product
                {
                    Id = 22,
                    Name = "Finnin Hierlihy",
                    Size = 2,
                    CatId = 1,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incIdIdunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupIdatat non proIdent, sunt in culpa qui officia deserunt mollit anim Id est laborum.",
                    Price = 6.99,
                    Image1 = "PSX_20231209_094556.jpg",
                    Image2 = "PSX_20231209_094633.jpg",
                    Image3 = "PSX_20231209_094718.jpg",
                    Char_Race = "Halfling",
                    Char_Class = "DruId"
                },
                new Product
                {
                    Id = 23,
                    Name = "Rutger Hightower",
                    Size = 3,
                    CatId = 2,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incIdIdunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupIdatat non proIdent, sunt in culpa qui officia deserunt mollit anim Id est laborum.",
                    Price = 8.99,
                    Image1 = "PSX_20231209_094305.jpg",
                    Image2 = "PSX_20231209_094352.jpg",
                    Image3 = "PSX_20231209_094505.jpg",
                    Char_Race = "Human",
                    Char_Class = "Fighter"
                },
                new Product
                {
                    Id = 24,
                    Name = "Valius Skamos",
                    Size = 3,
                    CatId = 1,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incIdIdunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupIdatat non proIdent, sunt in culpa qui officia deserunt mollit anim Id est laborum.",
                    Price = 7.99,
                    Image1 = "PSX_20231209_094024.jpg",
                    Image2 = "PSX_20231209_094110.jpg",
                    Image3 = "PSX_20231209_094201.jpg",
                    Char_Race = "Tiefling",
                    Char_Class = "Warlock"
                },
                new Product
                {
                    Id = 25,
                    Name = "ArchIdius Kazir",
                    Size = 3,
                    CatId = 1,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incIdIdunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupIdatat non proIdent, sunt in culpa qui officia deserunt mollit anim Id est laborum.",
                    Price = 7.99,
                    Image1 = "PSX_20231209_090842.jpg",
                    Image2 = "PSX_20231209_090927.jpg",
                    Image3 = "PSX_20231209_091011.jpg",
                    Char_Race = "Tiefling",
                    Char_Class = "Bard"
                },
                new Product
                {
                    Id = 26,
                    Name = "Chanzira Illyku'ur",
                    Size = 3,
                    CatId = 2,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incIdIdunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupIdatat non proIdent, sunt in culpa qui officia deserunt mollit anim Id est laborum.",
                    Price = 7.99,
                    Image1 = "PSX_20231209_090603.jpg",
                    Image2 = "PSX_20231209_090643.jpg",
                    Image3 = "PSX_20231209_090727.jpg",
                    Char_Race = "Drow",
                    Char_Class = "Cleric"
                },
                new Product
                {
                    Id = 27,
                    Name = "Donella Tamble",
                    Size = 2,
                    CatId = 1,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incIdIdunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupIdatat non proIdent, sunt in culpa qui officia deserunt mollit anim Id est laborum.",
                    Price = 6.99,
                    Image1 = "PSX_20231209_090354.jpg",
                    Image2 = "PSX_20231209_090430.jpg",
                    Image3 = "PSX_20231209_090516.jpg",
                    Char_Race = "Gnome",
                    Char_Class = "Bard"
                },
                new Product
                {
                    Id = 28,
                    Name = "Allvar Mansc",
                    Size = 3,
                    CatId = 1,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incIdIdunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupIdatat non proIdent, sunt in culpa qui officia deserunt mollit anim Id est laborum.",
                    Price = 7.99,
                    Image1 = "PSX_20231209_090137.jpg",
                    Image2 = "PSX_20231209_090221.jpg",
                    Image3 = "PSX_20231209_090306.jpg",
                    Char_Race = "Human",
                    Char_Class = "Fighter"
                },
                new Product
                {
                    Id = 29,
                    Name = "Carmen Hacari",
                    Size = 3,
                    CatId = 2,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incIdIdunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupIdatat non proIdent, sunt in culpa qui officia deserunt mollit anim Id est laborum.",
                    Price = 7.99,
                    Image1 = "PSX_20231209_085828.jpg",
                    Image2 = "PSX_20231209_085857.jpg",
                    Image3 = "PSX_20231209_090008.jpg",
                    Char_Race = "Human",
                    Char_Class = "Sorcerer"
                },
                new Product
                {
                    Id = 30,
                    Name = "Kairon Daelius",
                    Size = 3,
                    CatId = 1,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incIdIdunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupIdatat non proIdent, sunt in culpa qui officia deserunt mollit anim Id est laborum.",
                    Price = 7.99,
                    Image1 = "PSX_20231209_085630.jpg",
                    Image2 = "PSX_20231209_085700.jpg",
                    Image3 = "PSX_20231209_085742.jpg",
                    Char_Race = "Tiefling",
                    Char_Class = "Bard"
                },
                new Product
                {
                    Id = 31,
                    Name = "Bolla",
                    CatId = 3,
                    Size = 4,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incIdIdunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupIdatat non proIdent, sunt in culpa qui officia deserunt mollit anim Id est laborum.",
                    Price = 14.99,
                    Image1 = "PSX_20231209_085439.jpg",
                    Image2 = "PSX_20231209_085513.jpg",
                    Image3 = "PSX_20231209_085543.jpg",
                    Char_Race = "Beholder",
                    Char_Class = "Aberration"
                },
                new Product
                {
                    Id = 32,
                    Name = "Grumbar",
                    Size = 4,
                    CatId = 3,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incIdIdunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupIdatat non proIdent, sunt in culpa qui officia deserunt mollit anim Id est laborum.",
                    Price = 14.99,
                    Image1 = "PSX_20231209_085246.jpg",
                    Image2 = "PSX_20231209_085258.jpg",
                    Image3 = "PSX_20231209_085331.jpg",
                    Char_Race = "Ogre Zombie",
                    Char_Class = "Undead"
                },
                new Product
                {
                    Id = 33,
                    Name = "Torrenrak",
                    Size = 4,
                    CatId = 3,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incIdIdunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupIdatat non proIdent, sunt in culpa qui officia deserunt mollit anim Id est laborum.",
                    Price = 14.99,
                    Image1 = "PSX_20231209_085009.jpg",
                    Image2 = "PSX_20231209_085045.jpg",
                    Image3 = "PSX_20231209_085154.jpg",
                    Char_Race = "Griffon",
                    Char_Class = "Monstrosity"
                },
                new Product
                {
                    Id = 34,
                    Name = "Lauroumar",
                    Size = 4,
                    CatId = 3,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incIdIdunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupIdatat non proIdent, sunt in culpa qui officia deserunt mollit anim Id est laborum.",
                    Price = 14.99,
                    Image1 = "PSX_20231209_084720.jpg",
                    Image2 = "PSX_20231209_084809.jpg",
                    Image3 = "PSX_20231209_084901.jpg",
                    Char_Race = "Manticore",
                    Char_Class = "Monstrosity"
                },
                new Product
                {
                    Id = 35,
                    Name = "Oshryut",
                    Size = 4,
                    CatId = 3,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incIdIdunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupIdatat non proIdent, sunt in culpa qui officia deserunt mollit anim Id est laborum.",
                    Price = 12.99,
                    Image1 = "PSX_20231209_084457.jpg",
                    Image2 = "PSX_20231209_084546.jpg",
                    Image3 = "PSX_20231209_084634.jpg",
                    Char_Race = "Troll",
                    Char_Class = "Giant"
                },
                new Product
                {
                    Id = 36,
                    Name = "Auntie Lucretia",
                    Size = 4,
                    CatId = 3,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incIdIdunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupIdatat non proIdent, sunt in culpa qui officia deserunt mollit anim Id est laborum.",
                    Price = 12.99,
                    Image1 = "PSX_20231209_084200.jpg",
                    Image2 = "PSX_20231209_084259.jpg",
                    Image3 = "PSX_20231209_084408.jpg",
                    Char_Race = "Night Hag",
                    Char_Class = "Fiend"
                }
                );
        }
    }
}
