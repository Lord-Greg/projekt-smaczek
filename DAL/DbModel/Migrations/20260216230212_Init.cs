using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DbModel.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FoodBrands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodBrands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FoodMixtures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodMixtures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Storages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Storages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FoodProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FoodType = table.Column<int>(type: "int", nullable: false),
                    FoodBrandId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FoodProducts_FoodBrands_FoodBrandId",
                        column: x => x.FoodBrandId,
                        principalTable: "FoodBrands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FoodProductItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodProductId = table.Column<int>(type: "int", nullable: false),
                    ContainerType = table.Column<int>(type: "int", nullable: false),
                    WeightInGram = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodProductItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FoodProductItems_FoodProducts_FoodProductId",
                        column: x => x.FoodProductId,
                        principalTable: "FoodProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FoodMixtureItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodMixtureId = table.Column<int>(type: "int", nullable: false),
                    FoodProductItemId = table.Column<int>(type: "int", nullable: false),
                    ItemWeightInGram = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodMixtureItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FoodMixtureItems_FoodMixtures_FoodMixtureId",
                        column: x => x.FoodMixtureId,
                        principalTable: "FoodMixtures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FoodMixtureItems_FoodProductItems_FoodProductItemId",
                        column: x => x.FoodProductItemId,
                        principalTable: "FoodProductItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StorageItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StorageId = table.Column<int>(type: "int", nullable: false),
                    FoodProductItemId = table.Column<int>(type: "int", nullable: true),
                    FoodMixtureId = table.Column<int>(type: "int", nullable: true),
                    Quantity = table.Column<decimal>(type: "decimal(4,4)", precision: 4, scale: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StorageItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StorageItems_FoodMixtures_FoodMixtureId",
                        column: x => x.FoodMixtureId,
                        principalTable: "FoodMixtures",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StorageItems_FoodProductItems_FoodProductItemId",
                        column: x => x.FoodProductItemId,
                        principalTable: "FoodProductItems",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StorageItems_Storages_StorageId",
                        column: x => x.StorageId,
                        principalTable: "Storages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FoodMixtureItems_FoodMixtureId",
                table: "FoodMixtureItems",
                column: "FoodMixtureId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodMixtureItems_FoodProductItemId",
                table: "FoodMixtureItems",
                column: "FoodProductItemId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodProductItems_FoodProductId",
                table: "FoodProductItems",
                column: "FoodProductId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodProducts_FoodBrandId",
                table: "FoodProducts",
                column: "FoodBrandId");

            migrationBuilder.CreateIndex(
                name: "IX_StorageItems_FoodMixtureId",
                table: "StorageItems",
                column: "FoodMixtureId");

            migrationBuilder.CreateIndex(
                name: "IX_StorageItems_FoodProductItemId",
                table: "StorageItems",
                column: "FoodProductItemId");

            migrationBuilder.CreateIndex(
                name: "IX_StorageItems_StorageId",
                table: "StorageItems",
                column: "StorageId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FoodMixtureItems");

            migrationBuilder.DropTable(
                name: "StorageItems");

            migrationBuilder.DropTable(
                name: "FoodMixtures");

            migrationBuilder.DropTable(
                name: "FoodProductItems");

            migrationBuilder.DropTable(
                name: "Storages");

            migrationBuilder.DropTable(
                name: "FoodProducts");

            migrationBuilder.DropTable(
                name: "FoodBrands");
        }
    }
}
