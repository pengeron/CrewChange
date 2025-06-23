using CrewChange.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CrewChange.Infrastructure.Data;

public static class DataSeeder
{
    public static void SeedData(ModelBuilder modelBuilder)
    {
        // Seed States
        modelBuilder.Entity<State>().HasData(
            new State { Id = 1, Name = "Alabama", Abbreviation = "AL" },
            new State { Id = 2, Name = "Alaska", Abbreviation = "AK" },
            // Add more states as needed
            new State { Id = 50, Name = "Wyoming", Abbreviation = "WY" }
        );

        // Seed MaritalStatus
        modelBuilder.Entity<MaritalStatus>().HasData(
            new MaritalStatus { Id = 1, Name = "Single" },
            new MaritalStatus { Id = 2, Name = "Married" },
            new MaritalStatus { Id = 3, Name = "Divorced" },
            new MaritalStatus { Id = 4, Name = "Widowed" }
        );

        // Seed EmployeeStatus
        modelBuilder.Entity<EmployeeStatus>().HasData(
            new EmployeeStatus { Id = 1, Name = "Active", Description = "Currently employed" },
            new EmployeeStatus { Id = 2, Name = "On Leave", Description = "Temporarily away" },
            new EmployeeStatus { Id = 3, Name = "Terminated", Description = "No longer employed" }
        );

        // Seed EducationLevel
        modelBuilder.Entity<EducationLevel>().HasData(
            new EducationLevel { Id = 1, Name = "High School", Description = "High School Diploma" },
            new EducationLevel { Id = 2, Name = "Associate's", Description = "Associate's Degree" },
            new EducationLevel { Id = 3, Name = "Bachelor's", Description = "Bachelor's Degree" },
            new EducationLevel { Id = 4, Name = "Master's", Description = "Master's Degree" },
            new EducationLevel { Id = 5, Name = "Doctorate", Description = "Doctorate Degree" }
        );

        // Seed WorkStatus
        modelBuilder.Entity<WorkStatus>().HasData(
            new WorkStatus { Id = 1, Name = "Full-Time", Description = "40 hours per week" },
            new WorkStatus { Id = 2, Name = "Part-Time", Description = "Less than 40 hours per week" },
            new WorkStatus { Id = 3, Name = "Contract", Description = "Temporary contract worker" },
            new WorkStatus { Id = 4, Name = "Seasonal", Description = "Seasonal employee" }
        );

        // Seed GenderType
        modelBuilder.Entity<GenderType>().HasData(
            new GenderType { Id = 1, Name = "Male" },
            new GenderType { Id = 2, Name = "Female" },
            new GenderType { Id = 3, Name = "Non-Binary" },
            new GenderType { Id = 4, Name = "Prefer Not to Say" }
        );

        // Seed VeteranStatusType
        modelBuilder.Entity<VeteranStatusType>().HasData(
            new VeteranStatusType { Id = 1, Name = "Not a Veteran", Description = "No military service" },
            new VeteranStatusType { Id = 2, Name = "Veteran", Description = "Military service veteran" },
            new VeteranStatusType { Id = 3, Name = "Disabled Veteran", Description = "Disabled military service veteran" },
            new VeteranStatusType { Id = 4, Name = "Active Reserve", Description = "Currently in military reserves" }
        );

        // Seed TerminationReason
        modelBuilder.Entity<TerminationReason>().HasData(
            new TerminationReason { Id = 1, Name = "Voluntary", Description = "Employee resigned" },
            new TerminationReason { Id = 2, Name = "Layoff", Description = "Position eliminated" },
            new TerminationReason { Id = 3, Name = "Performance", Description = "Performance issues" },
            new TerminationReason { Id = 4, Name = "Retirement", Description = "Employee retired" }
        );
    }
}
