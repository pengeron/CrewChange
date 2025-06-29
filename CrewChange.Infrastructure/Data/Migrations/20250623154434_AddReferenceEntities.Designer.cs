﻿// <auto-generated />
using System;
using CrewChange.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CrewChange.Infrastructure.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250623154434_AddReferenceEntities")]
    partial class AddReferenceEntities
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CrewChange.Domain.Entities.EducationLevel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EducationLevels");
                });

            modelBuilder.Entity("CrewChange.Domain.Entities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateTerminated")
                        .HasColumnType("datetime2");

                    b.Property<int>("EducationLevelId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmployeeGroupId")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeScheduleTypeId")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeStatusId")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeWorkStatusId")
                        .HasColumnType("int");

                    b.Property<string>("FaxNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GenderTypeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("HireDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("JobId")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<int>("MaritalStatusId")
                        .HasColumnType("int");

                    b.Property<int>("NationalityTypeId")
                        .HasColumnType("int");

                    b.Property<string>("PagerNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReasonTerminated")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("SseExpirationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Ssn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StateId")
                        .HasColumnType("int");

                    b.Property<bool>("Terminated")
                        .HasColumnType("bit");

                    b.Property<int?>("TerminationReasonId")
                        .HasColumnType("int");

                    b.Property<int>("VeteranStatusTypeId")
                        .HasColumnType("int");

                    b.Property<int>("WorkStatusId")
                        .HasColumnType("int");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EducationLevelId");

                    b.HasIndex("EmployeeGroupId");

                    b.HasIndex("EmployeeScheduleTypeId");

                    b.HasIndex("EmployeeStatusId");

                    b.HasIndex("EmployeeWorkStatusId");

                    b.HasIndex("GenderTypeId");

                    b.HasIndex("JobId");

                    b.HasIndex("LocationId");

                    b.HasIndex("MaritalStatusId");

                    b.HasIndex("NationalityTypeId");

                    b.HasIndex("StateId");

                    b.HasIndex("TerminationReasonId");

                    b.HasIndex("VeteranStatusTypeId");

                    b.HasIndex("WorkStatusId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("CrewChange.Domain.Entities.EmployeeCertification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CertificationName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CertificationNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("IssueDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("EmployeeCertifications");
                });

            modelBuilder.Entity("CrewChange.Domain.Entities.EmployeeGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EmployeeGroups");
                });

            modelBuilder.Entity("CrewChange.Domain.Entities.EmployeeScheduleType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EmployeeScheduleTypes");
                });

            modelBuilder.Entity("CrewChange.Domain.Entities.EmployeeStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EmployeeStatuses");
                });

            modelBuilder.Entity("CrewChange.Domain.Entities.GenderType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("GenderTypes");
                });

            modelBuilder.Entity("CrewChange.Domain.Entities.Job", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Jobs");
                });

            modelBuilder.Entity("CrewChange.Domain.Entities.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StateId")
                        .HasColumnType("int");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("StateId");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("CrewChange.Domain.Entities.MaritalStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MaritalStatuses");
                });

            modelBuilder.Entity("CrewChange.Domain.Entities.NationalityType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("NationalityTypes");
                });

            modelBuilder.Entity("CrewChange.Domain.Entities.State", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Abbreviation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("States");
                });

            modelBuilder.Entity("CrewChange.Domain.Entities.TerminationReason", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TerminationReasons");
                });

            modelBuilder.Entity("CrewChange.Domain.Entities.VeteranStatusType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("VeteranStatusTypes");
                });

            modelBuilder.Entity("CrewChange.Domain.Entities.WorkStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("WorkStatuses");
                });

            modelBuilder.Entity("CrewChange.Domain.Entities.Employee", b =>
                {
                    b.HasOne("CrewChange.Domain.Entities.EducationLevel", "EducationLevel")
                        .WithMany("Employees")
                        .HasForeignKey("EducationLevelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CrewChange.Domain.Entities.EmployeeGroup", "EmployeeGroup")
                        .WithMany("Employees")
                        .HasForeignKey("EmployeeGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CrewChange.Domain.Entities.EmployeeScheduleType", "EmployeeScheduleType")
                        .WithMany("Employees")
                        .HasForeignKey("EmployeeScheduleTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CrewChange.Domain.Entities.EmployeeStatus", "EmployeeStatus")
                        .WithMany("Employees")
                        .HasForeignKey("EmployeeStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CrewChange.Domain.Entities.WorkStatus", "EmployeeWorkStatus")
                        .WithMany("EmployeeWorkStatuses")
                        .HasForeignKey("EmployeeWorkStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CrewChange.Domain.Entities.GenderType", "GenderType")
                        .WithMany("Employees")
                        .HasForeignKey("GenderTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CrewChange.Domain.Entities.Job", "Job")
                        .WithMany("Employees")
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CrewChange.Domain.Entities.Location", "Location")
                        .WithMany("Employees")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CrewChange.Domain.Entities.MaritalStatus", "MaritalStatus")
                        .WithMany("Employees")
                        .HasForeignKey("MaritalStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CrewChange.Domain.Entities.NationalityType", "NationalityType")
                        .WithMany("Employees")
                        .HasForeignKey("NationalityTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CrewChange.Domain.Entities.State", "State")
                        .WithMany("Employees")
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("CrewChange.Domain.Entities.TerminationReason", "TerminationReason")
                        .WithMany("Employees")
                        .HasForeignKey("TerminationReasonId");

                    b.HasOne("CrewChange.Domain.Entities.VeteranStatusType", "VeteranStatusType")
                        .WithMany("Employees")
                        .HasForeignKey("VeteranStatusTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CrewChange.Domain.Entities.WorkStatus", "WorkStatus")
                        .WithMany("Employees")
                        .HasForeignKey("WorkStatusId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("EducationLevel");

                    b.Navigation("EmployeeGroup");

                    b.Navigation("EmployeeScheduleType");

                    b.Navigation("EmployeeStatus");

                    b.Navigation("EmployeeWorkStatus");

                    b.Navigation("GenderType");

                    b.Navigation("Job");

                    b.Navigation("Location");

                    b.Navigation("MaritalStatus");

                    b.Navigation("NationalityType");

                    b.Navigation("State");

                    b.Navigation("TerminationReason");

                    b.Navigation("VeteranStatusType");

                    b.Navigation("WorkStatus");
                });

            modelBuilder.Entity("CrewChange.Domain.Entities.EmployeeCertification", b =>
                {
                    b.HasOne("CrewChange.Domain.Entities.Employee", "Employee")
                        .WithMany("Certifications")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("CrewChange.Domain.Entities.Location", b =>
                {
                    b.HasOne("CrewChange.Domain.Entities.State", "State")
                        .WithMany()
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("State");
                });

            modelBuilder.Entity("CrewChange.Domain.Entities.EducationLevel", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("CrewChange.Domain.Entities.Employee", b =>
                {
                    b.Navigation("Certifications");
                });

            modelBuilder.Entity("CrewChange.Domain.Entities.EmployeeGroup", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("CrewChange.Domain.Entities.EmployeeScheduleType", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("CrewChange.Domain.Entities.EmployeeStatus", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("CrewChange.Domain.Entities.GenderType", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("CrewChange.Domain.Entities.Job", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("CrewChange.Domain.Entities.Location", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("CrewChange.Domain.Entities.MaritalStatus", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("CrewChange.Domain.Entities.NationalityType", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("CrewChange.Domain.Entities.State", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("CrewChange.Domain.Entities.TerminationReason", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("CrewChange.Domain.Entities.VeteranStatusType", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("CrewChange.Domain.Entities.WorkStatus", b =>
                {
                    b.Navigation("EmployeeWorkStatuses");

                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
