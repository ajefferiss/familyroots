using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Family_Roots.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Street = table.Column<string>(type: "TEXT", nullable: false),
                    City = table.Column<string>(type: "TEXT", nullable: false),
                    State = table.Column<string>(type: "TEXT", nullable: false),
                    ZipCode = table.Column<string>(type: "TEXT", nullable: false),
                    Country = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Type = table.Column<int>(type: "INTEGER", nullable: false),
                    AddressId = table.Column<int>(type: "INTEGER", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DatePlaceEntities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DatePlace = table.Column<int>(type: "INTEGER", nullable: false),
                    Person = table.Column<int>(type: "INTEGER", nullable: false),
                    Type = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatePlaceEntities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DatePlaces",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Date = table.Column<string>(type: "TEXT", nullable: false),
                    Place = table.Column<string>(type: "TEXT", nullable: false),
                    Latitude = table.Column<string>(type: "TEXT", nullable: false),
                    Longitude = table.Column<string>(type: "TEXT", nullable: false),
                    Note = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatePlaces", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EventName = table.Column<string>(type: "TEXT", nullable: false),
                    DatePlace = table.Column<int>(type: "INTEGER", nullable: false),
                    Person = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Adoptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DatePlaceId = table.Column<int>(type: "INTEGER", nullable: true),
                    Type = table.Column<string>(type: "TEXT", nullable: false),
                    AdoptingParents = table.Column<string>(type: "TEXT", nullable: false),
                    Note = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adoptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Adoptions_DatePlaces_DatePlaceId",
                        column: x => x.DatePlaceId,
                        principalTable: "DatePlaces",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GEDId = table.Column<string>(type: "TEXT", nullable: false),
                    Uid = table.Column<string>(type: "TEXT", nullable: false),
                    IdNumber = table.Column<string>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    Gender = table.Column<string>(type: "TEXT", nullable: false),
                    BirthId = table.Column<int>(type: "INTEGER", nullable: true),
                    DeathId = table.Column<int>(type: "INTEGER", nullable: true),
                    BuriedId = table.Column<int>(type: "INTEGER", nullable: true),
                    BaptizedId = table.Column<int>(type: "INTEGER", nullable: true),
                    Education = table.Column<string>(type: "TEXT", nullable: false),
                    Religion = table.Column<string>(type: "TEXT", nullable: false),
                    Nationality = table.Column<string>(type: "TEXT", nullable: false),
                    Note = table.Column<string>(type: "TEXT", nullable: false),
                    Changed = table.Column<string>(type: "TEXT", nullable: false),
                    Occupation = table.Column<string>(type: "TEXT", nullable: false),
                    Health = table.Column<string>(type: "TEXT", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    LastAddressId = table.Column<int>(type: "INTEGER", nullable: true),
                    AdoptedId = table.Column<int>(type: "INTEGER", nullable: true),
                    GraduationId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Persons_Addresses_LastAddressId",
                        column: x => x.LastAddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Persons_Adoptions_AdoptedId",
                        column: x => x.AdoptedId,
                        principalTable: "Adoptions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Persons_DatePlaces_BaptizedId",
                        column: x => x.BaptizedId,
                        principalTable: "DatePlaces",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Persons_DatePlaces_BirthId",
                        column: x => x.BirthId,
                        principalTable: "DatePlaces",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Persons_DatePlaces_BuriedId",
                        column: x => x.BuriedId,
                        principalTable: "DatePlaces",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Persons_DatePlaces_DeathId",
                        column: x => x.DeathId,
                        principalTable: "DatePlaces",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Persons_DatePlaces_GraduationId",
                        column: x => x.GraduationId,
                        principalTable: "DatePlaces",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Adoptions_DatePlaceId",
                table: "Adoptions",
                column: "DatePlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_AdoptedId",
                table: "Persons",
                column: "AdoptedId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_BaptizedId",
                table: "Persons",
                column: "BaptizedId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_BirthId",
                table: "Persons",
                column: "BirthId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_BuriedId",
                table: "Persons",
                column: "BuriedId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_DeathId",
                table: "Persons",
                column: "DeathId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_GraduationId",
                table: "Persons",
                column: "GraduationId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_LastAddressId",
                table: "Persons",
                column: "LastAddressId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "DatePlaceEntities");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Adoptions");

            migrationBuilder.DropTable(
                name: "DatePlaces");
        }
    }
}
