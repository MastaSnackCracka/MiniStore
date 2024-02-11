using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MiniStore.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class feb8_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StreetAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CatId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ListPrice = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Price50 = table.Column<double>(type: "float", nullable: false),
                    Price100 = table.Column<double>(type: "float", nullable: false),
                    Size = table.Column<int>(type: "int", nullable: false),
                    Image1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Char_Class = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Char_Race = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CatId",
                        column: x => x.CatId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(21)", maxLength: 21, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StreetAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderHeaders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ShippingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrderTotal = table.Column<double>(type: "float", nullable: false),
                    OrderStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrackingNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Carrier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaymentDueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SessionId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentIntentId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StreetAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderHeaders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderHeaders_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCarts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCarts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShoppingCarts_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShoppingCarts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderHeaderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderDetails_OrderHeaders_OrderHeaderId",
                        column: x => x.OrderHeaderId,
                        principalTable: "OrderHeaders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DisplayOrder", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Hero" },
                    { 2, 2, "Villain" },
                    { 3, 3, "Monster" }
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "City", "Name", "PhoneNumber", "PostalCode", "State", "StreetAddress" },
                values: new object[,]
                {
                    { 1, "Tech City", "Tech Solution", "6669990000", "12121", "IL", "123 Tech St" },
                    { 2, "Vid City", "Vivid Books", "7779990000", "66666", "IL", "999 Vid St" },
                    { 3, "Lala land", "Readers Club", "1113335555", "99999", "NY", "999 Main St" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CatId", "Char_Class", "Char_Race", "Description", "Image1", "Image2", "Image3", "ListPrice", "Name", "Price", "Price100", "Price50", "Size" },
                values: new object[,]
                {
                    { 1, 1, "Barbarian", "Human", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incIdIdunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupIdatat non proIdent, sunt in culpa qui officia deserunt mollit anim Id est laborum.", "PSX_20231209_101355.jpg", "PSX_20231209_101425.jpg", "PSX_20231209_101454.jpg", 0.0, "Faergus MacMurachadh (1)", 7.9900000000000002, 0.0, 0.0, 3 },
                    { 2, 1, "Monk", "Dragonborn", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incIdIdunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupIdatat non proIdent, sunt in culpa qui officia deserunt mollit anim Id est laborum.", "Tsunami.png", "", "", 0.0, "Black Tsunami", 7.9900000000000002, 0.0, 0.0, 3 },
                    { 3, 1, "Rogue", "Halfling", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incIdIdunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupIdatat non proIdent, sunt in culpa qui officia deserunt mollit anim Id est laborum.", "PSX_20231209_100500(1).jpg", "PSX_20231209_100531.jpg", "PSX_20231209_100559.jpg", 0.0, "Wendell PorrIdgepot", 6.9900000000000002, 0.0, 0.0, 2 },
                    { 4, 1, "Rogue", "Elf", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incIdIdunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupIdatat non proIdent, sunt in culpa qui officia deserunt mollit anim Id est laborum.", "", "", "", 0.0, "Alinar Merityn", 7.9900000000000002, 0.0, 0.0, 3 },
                    { 5, 1, "Barbarian", "Minotaur", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incIdIdunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupIdatat non proIdent, sunt in culpa qui officia deserunt mollit anim Id est laborum.", "PSX_20231209_101655.jpg", "PSX_20231209_101723.jpg", "PSX_20231209_101804.jpg", 0.0, "Norlak", 8.9900000000000002, 0.0, 0.0, 3 },
                    { 6, 2, "Thug", "Bugbear", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incIdIdunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupIdatat non proIdent, sunt in culpa qui officia deserunt mollit anim Id est laborum.", "PSX_20231209_084029.jpg", "PSX_20231209_102538.jpg", "PSX_20231209_102505.jpg", 0.0, "Big Bragg", 8.9900000000000002, 0.0, 0.0, 4 },
                    { 7, 2, "Thug", "Bugbear", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incIdIdunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupIdatat non proIdent, sunt in culpa qui officia deserunt mollit anim Id est laborum.", "PSX_20231209_102308.jpg", "PSX_20231209_102350.jpg", "PSX_20231209_102431.jpg", 0.0, "Big Brogg", 8.9900000000000002, 0.0, 0.0, 4 },
                    { 8, 1, "Cleric", "Dwarf", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incIdIdunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupIdatat non proIdent, sunt in culpa qui officia deserunt mollit anim Id est laborum.", "PSX_20231209_102136.jpg", "PSX_20231209_102215.jpg", "", 0.0, "Lomax Godhammer", 7.9900000000000002, 0.0, 0.0, 3 },
                    { 9, 1, "DruId", "Tortle", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incIdIdunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupIdatat non proIdent, sunt in culpa qui officia deserunt mollit anim Id est laborum.", "PSX_20231209_101912.jpg", "PSX_20231209_101945.jpg", "PSX_20231209_102020.jpg", 0.0, "Yehorta", 7.9900000000000002, 0.0, 0.0, 3 },
                    { 10, 1, "Cleric", "Dwarf", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incIdIdunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupIdatat non proIdent, sunt in culpa qui officia deserunt mollit anim Id est laborum.", "PSX_20231209_101522.jpg", "PSX_20231209_101556.jpg", "PSX_20231209_101628.jpg", 0.0, "Bulgrim Torvond", 7.9900000000000002, 0.0, 0.0, 3 },
                    { 11, 1, "Barbarian", "Human", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incIdIdunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupIdatat non proIdent, sunt in culpa qui officia deserunt mollit anim Id est laborum.", "PSX_20231209_101142.jpg", "PSX_20231209_101233.jpg", "PSX_20231209_101312.jpg", 0.0, "Faergus MacMurachadh (2)", 7.9900000000000002, 0.0, 0.0, 3 },
                    { 12, 1, "Fighter", "Human", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incIdIdunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupIdatat non proIdent, sunt in culpa qui officia deserunt mollit anim Id est laborum.", "PSX_20231209_100917.jpg", "PSX_20231209_101010.jpg", "PSX_20231209_101048.jpg", 0.0, "Bartel Radclif", 7.9900000000000002, 0.0, 0.0, 3 },
                    { 13, 2, "Warlock", "Tiefling", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incIdIdunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupIdatat non proIdent, sunt in culpa qui officia deserunt mollit anim Id est laborum.", "PSX_20231209_100708.jpg", "PSX_20231209_100804.jpg", "PSX_20231209_100845.jpg", 0.0, "Demeldor", 7.9900000000000002, 0.0, 0.0, 3 },
                    { 14, 1, "Cleric", "Human", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incIdIdunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupIdatat non proIdent, sunt in culpa qui officia deserunt mollit anim Id est laborum.", "PSX_20231209_100256.jpg", "PSX_20231209_100340.jpg", "PSX_20231209_100405.jpg", 0.0, "Cedric Greylock", 7.9900000000000002, 0.0, 0.0, 3 },
                    { 15, 1, "DruId", "Human", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incIdIdunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupIdatat non proIdent, sunt in culpa qui officia deserunt mollit anim Id est laborum.", "PSX_20231209_100047.jpg", "PSX_20231209_100130.jpg", "PSX_20231209_100207.jpg", 0.0, "Nulara Revenmar", 7.9900000000000002, 0.0, 0.0, 3 },
                    { 16, 1, "DruId", "Human", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incIdIdunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupIdatat non proIdent, sunt in culpa qui officia deserunt mollit anim Id est laborum.", "PSX_20231209_095914.jpg", "PSX_20231209_095937.jpg", "PSX_20231209_100009.jpg", 0.0, "Talmond Evonwood", 7.9900000000000002, 0.0, 0.0, 3 },
                    { 17, 1, "Paladin", "Human", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incIdIdunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupIdatat non proIdent, sunt in culpa qui officia deserunt mollit anim Id est laborum.", "PSX_20231209_095721.jpg", "PSX_20231209_095801.jpg", "PSX_20231209_095836.jpg", 0.0, "Dorian Ambrose", 7.9900000000000002, 0.0, 0.0, 3 },
                    { 18, 2, "Fighter", "Drow", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incIdIdunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupIdatat non proIdent, sunt in culpa qui officia deserunt mollit anim Id est laborum.", "PSX_20231209_095512.jpg", "PSX_20231209_095606.jpg", "PSX_20231209_095650.jpg", 0.0, "Calimar Tlin'orzza", 7.9900000000000002, 0.0, 0.0, 3 },
                    { 19, 1, "Wizard", "Gnome", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incIdIdunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupIdatat non proIdent, sunt in culpa qui officia deserunt mollit anim Id est laborum.", "PSX_20231209_095308.jpg", "PSX_20231209_095354.jpg", "PSX_20231209_095430.jpg", 0.0, "Elza Glitterbranch", 6.9900000000000002, 0.0, 0.0, 2 },
                    { 20, 1, "DruId", "Human", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incIdIdunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupIdatat non proIdent, sunt in culpa qui officia deserunt mollit anim Id est laborum.", "PSX_20231209_095048.jpg", "PSX_20231209_095128.jpg", "PSX_20231209_095226.jpg", 0.0, "Elias Leerstrom", 7.9900000000000002, 0.0, 0.0, 3 },
                    { 21, 1, "Wizard", "Gnome", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incIdIdunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupIdatat non proIdent, sunt in culpa qui officia deserunt mollit anim Id est laborum.", "PSX_20231209_094812.jpg", "PSX_20231209_094919.jpg", "PSX_20231209_095009.jpg", 0.0, "Fineela Nessik", 6.9900000000000002, 0.0, 0.0, 2 },
                    { 22, 1, "DruId", "Halfling", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incIdIdunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupIdatat non proIdent, sunt in culpa qui officia deserunt mollit anim Id est laborum.", "PSX_20231209_094556.jpg", "PSX_20231209_094633.jpg", "PSX_20231209_094718.jpg", 0.0, "Finnin Hierlihy", 6.9900000000000002, 0.0, 0.0, 2 },
                    { 23, 2, "Fighter", "Human", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incIdIdunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupIdatat non proIdent, sunt in culpa qui officia deserunt mollit anim Id est laborum.", "PSX_20231209_094305.jpg", "PSX_20231209_094352.jpg", "PSX_20231209_094505.jpg", 0.0, "Rutger Hightower", 8.9900000000000002, 0.0, 0.0, 3 },
                    { 24, 1, "Warlock", "Tiefling", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incIdIdunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupIdatat non proIdent, sunt in culpa qui officia deserunt mollit anim Id est laborum.", "PSX_20231209_094024.jpg", "PSX_20231209_094110.jpg", "PSX_20231209_094201.jpg", 0.0, "Valius Skamos", 7.9900000000000002, 0.0, 0.0, 3 },
                    { 25, 1, "Bard", "Tiefling", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incIdIdunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupIdatat non proIdent, sunt in culpa qui officia deserunt mollit anim Id est laborum.", "PSX_20231209_090842.jpg", "PSX_20231209_090927.jpg", "PSX_20231209_091011.jpg", 0.0, "ArchIdius Kazir", 7.9900000000000002, 0.0, 0.0, 3 },
                    { 26, 2, "Cleric", "Drow", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incIdIdunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupIdatat non proIdent, sunt in culpa qui officia deserunt mollit anim Id est laborum.", "PSX_20231209_090603.jpg", "PSX_20231209_090643.jpg", "PSX_20231209_090727.jpg", 0.0, "Chanzira Illyku'ur", 7.9900000000000002, 0.0, 0.0, 3 },
                    { 27, 1, "Bard", "Gnome", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incIdIdunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupIdatat non proIdent, sunt in culpa qui officia deserunt mollit anim Id est laborum.", "PSX_20231209_090354.jpg", "PSX_20231209_090430.jpg", "PSX_20231209_090516.jpg", 0.0, "Donella Tamble", 6.9900000000000002, 0.0, 0.0, 2 },
                    { 28, 1, "Fighter", "Human", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incIdIdunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupIdatat non proIdent, sunt in culpa qui officia deserunt mollit anim Id est laborum.", "PSX_20231209_090137.jpg", "PSX_20231209_090221.jpg", "PSX_20231209_090306.jpg", 0.0, "Allvar Mansc", 7.9900000000000002, 0.0, 0.0, 3 },
                    { 29, 2, "Sorcerer", "Human", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incIdIdunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupIdatat non proIdent, sunt in culpa qui officia deserunt mollit anim Id est laborum.", "PSX_20231209_085828.jpg", "PSX_20231209_085857.jpg", "PSX_20231209_090008.jpg", 0.0, "Carmen Hacari", 7.9900000000000002, 0.0, 0.0, 3 },
                    { 30, 1, "Bard", "Tiefling", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incIdIdunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupIdatat non proIdent, sunt in culpa qui officia deserunt mollit anim Id est laborum.", "PSX_20231209_085630.jpg", "PSX_20231209_085700.jpg", "PSX_20231209_085742.jpg", 0.0, "Kairon Daelius", 7.9900000000000002, 0.0, 0.0, 3 },
                    { 31, 3, "Aberration", "Beholder", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incIdIdunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupIdatat non proIdent, sunt in culpa qui officia deserunt mollit anim Id est laborum.", "PSX_20231209_085439.jpg", "PSX_20231209_085513.jpg", "PSX_20231209_085543.jpg", 0.0, "Bolla", 14.99, 0.0, 0.0, 4 },
                    { 32, 3, "Undead", "Ogre Zombie", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incIdIdunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupIdatat non proIdent, sunt in culpa qui officia deserunt mollit anim Id est laborum.", "PSX_20231209_085246.jpg", "PSX_20231209_085258.jpg", "PSX_20231209_085331.jpg", 0.0, "Grumbar", 14.99, 0.0, 0.0, 4 },
                    { 33, 3, "Monstrosity", "Griffon", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incIdIdunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupIdatat non proIdent, sunt in culpa qui officia deserunt mollit anim Id est laborum.", "PSX_20231209_085009.jpg", "PSX_20231209_085045.jpg", "PSX_20231209_085154.jpg", 0.0, "Torrenrak", 14.99, 0.0, 0.0, 4 },
                    { 34, 3, "Monstrosity", "Manticore", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incIdIdunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupIdatat non proIdent, sunt in culpa qui officia deserunt mollit anim Id est laborum.", "PSX_20231209_084720.jpg", "PSX_20231209_084809.jpg", "PSX_20231209_084901.jpg", 0.0, "Lauroumar", 14.99, 0.0, 0.0, 4 },
                    { 35, 3, "Giant", "Troll", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incIdIdunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupIdatat non proIdent, sunt in culpa qui officia deserunt mollit anim Id est laborum.", "PSX_20231209_084457.jpg", "PSX_20231209_084546.jpg", "PSX_20231209_084634.jpg", 0.0, "Oshryut", 12.99, 0.0, 0.0, 4 },
                    { 36, 3, "Fiend", "Night Hag", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incIdIdunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupIdatat non proIdent, sunt in culpa qui officia deserunt mollit anim Id est laborum.", "PSX_20231209_084200.jpg", "PSX_20231209_084259.jpg", "PSX_20231209_084408.jpg", 0.0, "Auntie Lucretia", 12.99, 0.0, 0.0, 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CompanyId",
                table: "AspNetUsers",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderHeaderId",
                table: "OrderDetails",
                column: "OrderHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductId",
                table: "OrderDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderHeaders_ApplicationUserId",
                table: "OrderHeaders",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CatId",
                table: "Products",
                column: "CatId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCarts_ApplicationUserId",
                table: "ShoppingCarts",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCarts_ProductId",
                table: "ShoppingCarts",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.DropTable(
                name: "ShoppingCarts");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "OrderHeaders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Companies");
        }
    }
}
