using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CrewChange.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddEmployeeFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateTerminated",
                table: "Employees",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EducationLevelId",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeGroupId",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeScheduleTypeId",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeStatusId",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeWorkStatusId",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "FaxNumber",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "GenderTypeId",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "JobId",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LocationId",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MaritialStatus",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NationalityTypeId",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "PagerNumber",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ReasonTerminated",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "SseExpirationDate",
                table: "Employees",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ssn",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "StateId",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Terminated",
                table: "Employees",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "TerminationReasonId",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VeteranStatusTypeId",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WorkStatusId",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ZipCode",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "DateTerminated",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "EducationLevelId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "EmployeeGroupId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "EmployeeScheduleTypeId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "EmployeeStatusId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "EmployeeWorkStatusId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "FaxNumber",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "FullName",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "GenderTypeId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "JobId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "MaritialStatus",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "NationalityTypeId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "PagerNumber",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "ReasonTerminated",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "SseExpirationDate",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Ssn",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "StateId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Terminated",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "TerminationReasonId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "VeteranStatusTypeId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "WorkStatusId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "ZipCode",
                table: "Employees");
        }
    }
}
