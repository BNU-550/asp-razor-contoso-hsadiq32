using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP_RazorContoso.Migrations
{
    public partial class ModuleTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseModule_Module_ModulesModuleID",
                table: "CourseModule");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Module",
                table: "Module");

            migrationBuilder.RenameTable(
                name: "Module",
                newName: "Modules");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Modules",
                table: "Modules",
                column: "ModuleID");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseModule_Modules_ModulesModuleID",
                table: "CourseModule",
                column: "ModulesModuleID",
                principalTable: "Modules",
                principalColumn: "ModuleID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseModule_Modules_ModulesModuleID",
                table: "CourseModule");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Modules",
                table: "Modules");

            migrationBuilder.RenameTable(
                name: "Modules",
                newName: "Module");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Module",
                table: "Module",
                column: "ModuleID");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseModule_Module_ModulesModuleID",
                table: "CourseModule",
                column: "ModulesModuleID",
                principalTable: "Module",
                principalColumn: "ModuleID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
