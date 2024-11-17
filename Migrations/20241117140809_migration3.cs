using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dofus_unity_rendering_back.Migrations
{
    /// <inheritdoc />
    public partial class migration3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AnimFunMonsterRecords_MonstersRecords_Monstersid",
                table: "AnimFunMonsterRecords");

            migrationBuilder.DropIndex(
                name: "IX_AnimFunMonsterRecords_Monstersid",
                table: "AnimFunMonsterRecords");

            migrationBuilder.AlterColumn<int>(
                name: "Monstersid",
                table: "AnimFunMonsterRecords",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Monstersid1",
                table: "AnimFunMonsterRecords",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AnimFunMonsterRecords_Monstersid1",
                table: "AnimFunMonsterRecords",
                column: "Monstersid1");

            migrationBuilder.AddForeignKey(
                name: "FK_AnimFunMonsterRecords_MonstersRecords_Monstersid1",
                table: "AnimFunMonsterRecords",
                column: "Monstersid1",
                principalTable: "MonstersRecords",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AnimFunMonsterRecords_MonstersRecords_Monstersid1",
                table: "AnimFunMonsterRecords");

            migrationBuilder.DropIndex(
                name: "IX_AnimFunMonsterRecords_Monstersid1",
                table: "AnimFunMonsterRecords");

            migrationBuilder.DropColumn(
                name: "Monstersid1",
                table: "AnimFunMonsterRecords");

            migrationBuilder.AlterColumn<int>(
                name: "Monstersid",
                table: "AnimFunMonsterRecords",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.CreateIndex(
                name: "IX_AnimFunMonsterRecords_Monstersid",
                table: "AnimFunMonsterRecords",
                column: "Monstersid");

            migrationBuilder.AddForeignKey(
                name: "FK_AnimFunMonsterRecords_MonstersRecords_Monstersid",
                table: "AnimFunMonsterRecords",
                column: "Monstersid",
                principalTable: "MonstersRecords",
                principalColumn: "id");
        }
    }
}
