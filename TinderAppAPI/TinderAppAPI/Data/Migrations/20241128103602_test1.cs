using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TinderAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class test1 : Migration
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
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(22)", maxLength: 22, nullable: false),
                    BirthDay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    InterestedIn = table.Column<int>(type: "int", nullable: false),
                    LookingFor = table.Column<int>(type: "int", nullable: false),
                    SexualOrientation = table.Column<int>(type: "int", nullable: false),
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
                name: "Interests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Interests_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProfilePhotos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Path = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfilePhotos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProfilePhotos_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Interests",
                columns: new[] { "Id", "Name", "UserId" },
                values: new object[,]
                {
                    { 1, "Reading 1", null },
                    { 2, "Reading 2", null },
                    { 3, "Reading 3", null },
                    { 4, "Reading 4", null },
                    { 5, "Reading 5", null },
                    { 6, "Reading 6", null },
                    { 7, "Reading 7", null },
                    { 8, "Reading 8", null },
                    { 9, "Reading 9", null },
                    { 10, "Reading 10", null },
                    { 11, "Traveling 1", null },
                    { 12, "Traveling 2", null },
                    { 13, "Traveling 3", null },
                    { 14, "Traveling 4", null },
                    { 15, "Traveling 5", null },
                    { 16, "Traveling 6", null },
                    { 17, "Traveling 7", null },
                    { 18, "Traveling 8", null },
                    { 19, "Traveling 9", null },
                    { 20, "Traveling 10", null },
                    { 21, "Cooking 1", null },
                    { 22, "Cooking 2", null },
                    { 23, "Cooking 3", null },
                    { 24, "Cooking 4", null },
                    { 25, "Cooking 5", null },
                    { 26, "Cooking 6", null },
                    { 27, "Cooking 7", null },
                    { 28, "Cooking 8", null },
                    { 29, "Cooking 9", null },
                    { 30, "Cooking 10", null },
                    { 31, "Photography 1", null },
                    { 32, "Photography 2", null },
                    { 33, "Photography 3", null },
                    { 34, "Photography 4", null },
                    { 35, "Photography 5", null },
                    { 36, "Photography 6", null },
                    { 37, "Photography 7", null },
                    { 38, "Photography 8", null },
                    { 39, "Photography 9", null },
                    { 40, "Photography 10", null },
                    { 41, "Music 1", null },
                    { 42, "Music 2", null },
                    { 43, "Music 3", null },
                    { 44, "Music 4", null },
                    { 45, "Music 5", null },
                    { 46, "Music 6", null },
                    { 47, "Music 7", null },
                    { 48, "Music 8", null },
                    { 49, "Music 9", null },
                    { 50, "Music 10", null },
                    { 51, "Movies 1", null },
                    { 52, "Movies 2", null },
                    { 53, "Movies 3", null },
                    { 54, "Movies 4", null },
                    { 55, "Movies 5", null },
                    { 56, "Movies 6", null },
                    { 57, "Movies 7", null },
                    { 58, "Movies 8", null },
                    { 59, "Movies 9", null },
                    { 60, "Movies 10", null },
                    { 61, "Hiking 1", null },
                    { 62, "Hiking 2", null },
                    { 63, "Hiking 3", null },
                    { 64, "Hiking 4", null },
                    { 65, "Hiking 5", null },
                    { 66, "Hiking 6", null },
                    { 67, "Hiking 7", null },
                    { 68, "Hiking 8", null },
                    { 69, "Hiking 9", null },
                    { 70, "Hiking 10", null },
                    { 71, "Fitness 1", null },
                    { 72, "Fitness 2", null },
                    { 73, "Fitness 3", null },
                    { 74, "Fitness 4", null },
                    { 75, "Fitness 5", null },
                    { 76, "Fitness 6", null },
                    { 77, "Fitness 7", null },
                    { 78, "Fitness 8", null },
                    { 79, "Fitness 9", null },
                    { 80, "Fitness 10", null },
                    { 81, "Gaming 1", null },
                    { 82, "Gaming 2", null },
                    { 83, "Gaming 3", null },
                    { 84, "Gaming 4", null },
                    { 85, "Gaming 5", null },
                    { 86, "Gaming 6", null },
                    { 87, "Gaming 7", null },
                    { 88, "Gaming 8", null },
                    { 89, "Gaming 9", null },
                    { 90, "Gaming 10", null },
                    { 91, "Dancing 1", null },
                    { 92, "Dancing 2", null },
                    { 93, "Dancing 3", null },
                    { 94, "Dancing 4", null },
                    { 95, "Dancing 5", null },
                    { 96, "Dancing 6", null },
                    { 97, "Dancing 7", null },
                    { 98, "Dancing 8", null },
                    { 99, "Dancing 9", null },
                    { 100, "Dancing 10", null },
                    { 101, "Art 1", null },
                    { 102, "Art 2", null },
                    { 103, "Art 3", null },
                    { 104, "Art 4", null },
                    { 105, "Art 5", null },
                    { 106, "Art 6", null },
                    { 107, "Art 7", null },
                    { 108, "Art 8", null },
                    { 109, "Art 9", null },
                    { 110, "Art 10", null },
                    { 111, "Coding 1", null },
                    { 112, "Coding 2", null },
                    { 113, "Coding 3", null },
                    { 114, "Coding 4", null },
                    { 115, "Coding 5", null },
                    { 116, "Coding 6", null },
                    { 117, "Coding 7", null },
                    { 118, "Coding 8", null },
                    { 119, "Coding 9", null },
                    { 120, "Coding 10", null },
                    { 121, "Blogging 1", null },
                    { 122, "Blogging 2", null },
                    { 123, "Blogging 3", null },
                    { 124, "Blogging 4", null },
                    { 125, "Blogging 5", null },
                    { 126, "Blogging 6", null },
                    { 127, "Blogging 7", null },
                    { 128, "Blogging 8", null },
                    { 129, "Blogging 9", null },
                    { 130, "Blogging 10", null },
                    { 131, "Yoga 1", null },
                    { 132, "Yoga 2", null },
                    { 133, "Yoga 3", null },
                    { 134, "Yoga 4", null },
                    { 135, "Yoga 5", null },
                    { 136, "Yoga 6", null },
                    { 137, "Yoga 7", null },
                    { 138, "Yoga 8", null },
                    { 139, "Yoga 9", null },
                    { 140, "Yoga 10", null },
                    { 141, "Gardening 1", null },
                    { 142, "Gardening 2", null },
                    { 143, "Gardening 3", null },
                    { 144, "Gardening 4", null },
                    { 145, "Gardening 5", null },
                    { 146, "Gardening 6", null },
                    { 147, "Gardening 7", null },
                    { 148, "Gardening 8", null },
                    { 149, "Gardening 9", null },
                    { 150, "Gardening 10", null },
                    { 151, "Cycling 1", null },
                    { 152, "Cycling 2", null },
                    { 153, "Cycling 3", null },
                    { 154, "Cycling 4", null },
                    { 155, "Cycling 5", null },
                    { 156, "Cycling 6", null },
                    { 157, "Cycling 7", null },
                    { 158, "Cycling 8", null },
                    { 159, "Cycling 9", null },
                    { 160, "Cycling 10", null },
                    { 161, "Fishing 1", null },
                    { 162, "Fishing 2", null },
                    { 163, "Fishing 3", null },
                    { 164, "Fishing 4", null },
                    { 165, "Fishing 5", null },
                    { 166, "Fishing 6", null },
                    { 167, "Fishing 7", null },
                    { 168, "Fishing 8", null },
                    { 169, "Fishing 9", null },
                    { 170, "Fishing 10", null },
                    { 171, "Sports 1", null },
                    { 172, "Sports 2", null },
                    { 173, "Sports 3", null },
                    { 174, "Sports 4", null },
                    { 175, "Sports 5", null },
                    { 176, "Sports 6", null },
                    { 177, "Sports 7", null },
                    { 178, "Sports 8", null },
                    { 179, "Sports 9", null },
                    { 180, "Sports 10", null },
                    { 181, "Meditation 1", null },
                    { 182, "Meditation 2", null },
                    { 183, "Meditation 3", null },
                    { 184, "Meditation 4", null },
                    { 185, "Meditation 5", null },
                    { 186, "Meditation 6", null },
                    { 187, "Meditation 7", null },
                    { 188, "Meditation 8", null },
                    { 189, "Meditation 9", null },
                    { 190, "Meditation 10", null },
                    { 191, "Learning Languages 1", null },
                    { 192, "Learning Languages 2", null },
                    { 193, "Learning Languages 3", null },
                    { 194, "Learning Languages 4", null },
                    { 195, "Learning Languages 5", null },
                    { 196, "Learning Languages 6", null },
                    { 197, "Learning Languages 7", null },
                    { 198, "Learning Languages 8", null },
                    { 199, "Learning Languages 9", null },
                    { 200, "Learning Languages 10", null }
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
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Interests_UserId",
                table: "Interests",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfilePhotos_UserId",
                table: "ProfilePhotos",
                column: "UserId");
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
                name: "Interests");

            migrationBuilder.DropTable(
                name: "ProfilePhotos");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
