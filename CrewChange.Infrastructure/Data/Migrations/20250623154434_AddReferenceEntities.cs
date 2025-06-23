using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CrewChange.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddReferenceEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MaritialStatus",
                table: "Employees",
                newName: "MaritalStatusId");

            migrationBuilder.CreateTable(
                name: "EducationLevels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationLevels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeScheduleTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeScheduleTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GenderTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenderTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Jobs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jobs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MaritalStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaritalStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NationalityTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NationalityTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "States",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Abbreviation = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_States", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TerminationReasons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TerminationReasons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VeteranStatusTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VeteranStatusTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WorkStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StateId = table.Column<int>(type: "int", nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Locations_States_StateId",
                        column: x => x.StateId,
                        principalTable: "States",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_EducationLevelId",
                table: "Employees",
                column: "EducationLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_EmployeeGroupId",
                table: "Employees",
                column: "EmployeeGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_EmployeeScheduleTypeId",
                table: "Employees",
                column: "EmployeeScheduleTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_EmployeeStatusId",
                table: "Employees",
                column: "EmployeeStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_EmployeeWorkStatusId",
                table: "Employees",
                column: "EmployeeWorkStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_GenderTypeId",
                table: "Employees",
                column: "GenderTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_JobId",
                table: "Employees",
                column: "JobId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_LocationId",
                table: "Employees",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_MaritalStatusId",
                table: "Employees",
                column: "MaritalStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_NationalityTypeId",
                table: "Employees",
                column: "NationalityTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_StateId",
                table: "Employees",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_TerminationReasonId",
                table: "Employees",
                column: "TerminationReasonId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_VeteranStatusTypeId",
                table: "Employees",
                column: "VeteranStatusTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_WorkStatusId",
                table: "Employees",
                column: "WorkStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_StateId",
                table: "Locations",
                column: "StateId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_EducationLevels_EducationLevelId",
                table: "Employees",
                column: "EducationLevelId",
                principalTable: "EducationLevels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_EmployeeGroups_EmployeeGroupId",
                table: "Employees",
                column: "EmployeeGroupId",
                principalTable: "EmployeeGroups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_EmployeeScheduleTypes_EmployeeScheduleTypeId",
                table: "Employees",
                column: "EmployeeScheduleTypeId",
                principalTable: "EmployeeScheduleTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_EmployeeStatuses_EmployeeStatusId",
                table: "Employees",
                column: "EmployeeStatusId",
                principalTable: "EmployeeStatuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_GenderTypes_GenderTypeId",
                table: "Employees",
                column: "GenderTypeId",
                principalTable: "GenderTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Jobs_JobId",
                table: "Employees",
                column: "JobId",
                principalTable: "Jobs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Locations_LocationId",
                table: "Employees",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_MaritalStatuses_MaritalStatusId",
                table: "Employees",
                column: "MaritalStatusId",
                principalTable: "MaritalStatuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_NationalityTypes_NationalityTypeId",
                table: "Employees",
                column: "NationalityTypeId",
                principalTable: "NationalityTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_States_StateId",
                table: "Employees",
                column: "StateId",
                principalTable: "States",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_TerminationReasons_TerminationReasonId",
                table: "Employees",
                column: "TerminationReasonId",
                principalTable: "TerminationReasons",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_VeteranStatusTypes_VeteranStatusTypeId",
                table: "Employees",
                column: "VeteranStatusTypeId",
                principalTable: "VeteranStatusTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_WorkStatuses_EmployeeWorkStatusId",
                table: "Employees",
                column: "EmployeeWorkStatusId",
                principalTable: "WorkStatuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_WorkStatuses_WorkStatusId",
                table: "Employees",
                column: "WorkStatusId",
                principalTable: "WorkStatuses",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_EducationLevels_EducationLevelId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_EmployeeGroups_EmployeeGroupId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_EmployeeScheduleTypes_EmployeeScheduleTypeId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_EmployeeStatuses_EmployeeStatusId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_GenderTypes_GenderTypeId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Jobs_JobId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Locations_LocationId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_MaritalStatuses_MaritalStatusId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_NationalityTypes_NationalityTypeId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_States_StateId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_TerminationReasons_TerminationReasonId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_VeteranStatusTypes_VeteranStatusTypeId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_WorkStatuses_EmployeeWorkStatusId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_WorkStatuses_WorkStatusId",
                table: "Employees");

            migrationBuilder.DropTable(
                name: "EducationLevels");

            migrationBuilder.DropTable(
                name: "EmployeeGroups");

            migrationBuilder.DropTable(
                name: "EmployeeScheduleTypes");

            migrationBuilder.DropTable(
                name: "EmployeeStatuses");

            migrationBuilder.DropTable(
                name: "GenderTypes");

            migrationBuilder.DropTable(
                name: "Jobs");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "MaritalStatuses");

            migrationBuilder.DropTable(
                name: "NationalityTypes");

            migrationBuilder.DropTable(
                name: "TerminationReasons");

            migrationBuilder.DropTable(
                name: "VeteranStatusTypes");

            migrationBuilder.DropTable(
                name: "WorkStatuses");

            migrationBuilder.DropTable(
                name: "States");

            migrationBuilder.DropIndex(
                name: "IX_Employees_EducationLevelId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_EmployeeGroupId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_EmployeeScheduleTypeId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_EmployeeStatusId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_EmployeeWorkStatusId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_GenderTypeId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_JobId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_LocationId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_MaritalStatusId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_NationalityTypeId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_StateId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_TerminationReasonId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_VeteranStatusTypeId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_WorkStatusId",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "MaritalStatusId",
                table: "Employees",
                newName: "MaritialStatus");
        }
    }
}
