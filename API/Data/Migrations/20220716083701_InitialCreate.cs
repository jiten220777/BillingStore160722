using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductCode = table.Column<string>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Type = table.Column<string>(type: "TEXT", nullable: true),
                    Brand = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    HSNCode = table.Column<string>(type: "TEXT", nullable: true),
                    QuantityInStock = table.Column<int>(type: "INTEGER", nullable: false),
                    Unit = table.Column<string>(type: "TEXT", nullable: true),
                    PurchaseRate = table.Column<long>(type: "INTEGER", nullable: false),
                    SaleRate = table.Column<long>(type: "INTEGER", nullable: false),
                    CGST = table.Column<long>(type: "INTEGER", nullable: false),
                    SGST = table.Column<long>(type: "INTEGER", nullable: false),
                    IGST = table.Column<long>(type: "INTEGER", nullable: false),
                    ReorderLevel = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductPictureUrl = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
