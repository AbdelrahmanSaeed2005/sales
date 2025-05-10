using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sales.Migrations
{
    /// <inheritdoc />
    public partial class saelsAddData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
        name: "data",
        table: "Seles",
        type: "datetime2",
        nullable: false,
        defaultValueSql: "GETDATE()", // ← استخدم دالة SQL
        oldClrType: typeof(DateTime),
        oldType: "datetime2");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
