using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CrewChange.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedReferenceData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "EducationLevels",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "High School Diploma", "High School" },
                    { 2, "Associate's Degree", "Associate's" },
                    { 3, "Bachelor's Degree", "Bachelor's" },
                    { 4, "Master's Degree", "Master's" },
                    { 5, "Doctorate Degree", "Doctorate" }
                });

            migrationBuilder.InsertData(
                table: "EmployeeStatuses",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Currently employed", "Active" },
                    { 2, "Temporarily away", "On Leave" },
                    { 3, "No longer employed", "Terminated" }
                });

            migrationBuilder.InsertData(
                table: "GenderTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Male" },
                    { 2, "Female" },
                    { 3, "Non-Binary" },
                    { 4, "Prefer Not to Say" }
                });

            migrationBuilder.InsertData(
                table: "MaritalStatuses",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Single" },
                    { 2, "Married" },
                    { 3, "Divorced" },
                    { 4, "Widowed" }
                });

            migrationBuilder.InsertData(
                table: "States",
                columns: new[] { "Id", "Abbreviation", "Name" },
                values: new object[,]
                {
                    { 1, "AL", "Alabama" },
                    { 2, "AK", "Alaska" },
                    { 50, "WY", "Wyoming" }
                });

            migrationBuilder.InsertData(
                table: "TerminationReasons",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Employee resigned", "Voluntary" },
                    { 2, "Position eliminated", "Layoff" },
                    { 3, "Performance issues", "Performance" },
                    { 4, "Employee retired", "Retirement" }
                });

            migrationBuilder.InsertData(
                table: "VeteranStatusTypes",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "No military service", "Not a Veteran" },
                    { 2, "Military service veteran", "Veteran" },
                    { 3, "Disabled military service veteran", "Disabled Veteran" },
                    { 4, "Currently in military reserves", "Active Reserve" }
                });

            migrationBuilder.InsertData(
                table: "WorkStatuses",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "40 hours per week", "Full-Time" },
                    { 2, "Less than 40 hours per week", "Part-Time" },
                    { 3, "Temporary contract worker", "Contract" },
                    { 4, "Seasonal employee", "Seasonal" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EducationLevels",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EducationLevels",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EducationLevels",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EducationLevels",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "EducationLevels",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "EmployeeStatuses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EmployeeStatuses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EmployeeStatuses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "GenderTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "GenderTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "GenderTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "GenderTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MaritalStatuses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MaritalStatuses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MaritalStatuses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MaritalStatuses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "TerminationReasons",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TerminationReasons",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TerminationReasons",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TerminationReasons",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "VeteranStatusTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "VeteranStatusTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "VeteranStatusTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "VeteranStatusTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "WorkStatuses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "WorkStatuses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "WorkStatuses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "WorkStatuses",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
