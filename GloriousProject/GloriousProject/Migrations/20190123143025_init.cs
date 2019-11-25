using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GloriousProject.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Lessons",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    auditorium = table.Column<string>(nullable: true),
                    auditoriumAmount = table.Column<int>(nullable: false),
                    auditoriumOid = table.Column<int>(nullable: false),
                    author = table.Column<string>(nullable: true),
                    beginLesson = table.Column<string>(nullable: true),
                    building = table.Column<string>(nullable: true),
                    createddate = table.Column<string>(nullable: true),
                    date = table.Column<string>(nullable: true),
                    dateOfNest = table.Column<string>(nullable: true),
                    dayOfWeek = table.Column<int>(nullable: false),
                    dayOfWeekString = table.Column<string>(nullable: true),
                    detailInfo = table.Column<string>(nullable: true),
                    discipline = table.Column<string>(nullable: true),
                    disciplineOid = table.Column<int>(nullable: false),
                    disciplineinplan = table.Column<string>(nullable: true),
                    disciplinetypeload = table.Column<int>(nullable: false),
                    endLesson = table.Column<string>(nullable: true),
                    group = table.Column<int>(nullable: false),
                    groupOid = table.Column<int>(nullable: false),
                    hideincapacity = table.Column<int>(nullable: false),
                    isBan = table.Column<bool>(nullable: false),
                    kindOfWork = table.Column<string>(nullable: true),
                    lecturer = table.Column<string>(nullable: true),
                    lecturerOid = table.Column<int>(nullable: false),
                    lessonNumberEnd = table.Column<int>(nullable: false),
                    lessonNumberStart = table.Column<int>(nullable: false),
                    modifieddate = table.Column<string>(nullable: true),
                    parentschedule = table.Column<string>(nullable: true),
                    stream = table.Column<string>(nullable: true),
                    streamOid = table.Column<int>(nullable: false),
                    subGroup = table.Column<int>(nullable: false),
                    subGroupOid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lessons", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lessons");
        }
    }
}
