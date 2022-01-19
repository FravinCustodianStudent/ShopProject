using Microsoft.EntityFrameworkCore.Migrations;

namespace Fravin_DataAccess.Migrations
{
    public partial class PushOrderHeaderAndDetailToDbUpdt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Sqft",
                table: "OrderDetail",
                newName: "Amount");

            migrationBuilder.RenameColumn(
                name: "PricePerSqFt",
                table: "OrderDetail",
                newName: "PricePerOne");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PricePerOne",
                table: "OrderDetail",
                newName: "PricePerSqFt");

            migrationBuilder.RenameColumn(
                name: "Amount",
                table: "OrderDetail",
                newName: "Sqft");
        }
    }
}
