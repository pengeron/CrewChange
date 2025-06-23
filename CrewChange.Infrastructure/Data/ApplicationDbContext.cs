using CrewChange.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CrewChange.Infrastructure.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Employee> Employees { get; set; } = null!;
    public DbSet<EmployeeCertification> EmployeeCertifications { get; set; } = null!;
    public DbSet<State> States { get; set; } = null!;
    public DbSet<MaritalStatus> MaritalStatuses { get; set; } = null!;
    public DbSet<EmployeeStatus> EmployeeStatuses { get; set; } = null!;
    public DbSet<EmployeeGroup> EmployeeGroups { get; set; } = null!;
    public DbSet<EducationLevel> EducationLevels { get; set; } = null!;
    public DbSet<WorkStatus> WorkStatuses { get; set; } = null!;
    public DbSet<Location> Locations { get; set; } = null!;
    public DbSet<Job> Jobs { get; set; } = null!;
    public DbSet<EmployeeScheduleType> EmployeeScheduleTypes { get; set; } = null!;
    public DbSet<GenderType> GenderTypes { get; set; } = null!;
    public DbSet<NationalityType> NationalityTypes { get; set; } = null!;
    public DbSet<VeteranStatusType> VeteranStatusTypes { get; set; } = null!;
    public DbSet<TerminationReason> TerminationReasons { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Employee>()
            .HasMany(e => e.Certifications)
            .WithOne(c => c.Employee)
            .HasForeignKey(c => c.EmployeeId)
            .OnDelete(DeleteBehavior.Cascade);        modelBuilder.Entity<Employee>()
            .HasOne(e => e.State)
            .WithMany(s => s.Employees)
            .HasForeignKey(e => e.StateId)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<Employee>()
            .HasOne(e => e.MaritalStatus)
            .WithMany(m => m.Employees)
            .HasForeignKey(e => e.MaritalStatusId);

        modelBuilder.Entity<Employee>()
            .HasOne(e => e.EmployeeStatus)
            .WithMany(s => s.Employees)
            .HasForeignKey(e => e.EmployeeStatusId);

        modelBuilder.Entity<Employee>()
            .HasOne(e => e.EmployeeGroup)
            .WithMany(g => g.Employees)
            .HasForeignKey(e => e.EmployeeGroupId);

        modelBuilder.Entity<Employee>()
            .HasOne(e => e.EducationLevel)
            .WithMany(l => l.Employees)
            .HasForeignKey(e => e.EducationLevelId);

        modelBuilder.Entity<Employee>()
            .HasOne(e => e.EmployeeWorkStatus)
            .WithMany(s => s.EmployeeWorkStatuses)
            .HasForeignKey(e => e.EmployeeWorkStatusId);        modelBuilder.Entity<Employee>()
            .HasOne(e => e.WorkStatus)
            .WithMany(s => s.Employees)
            .HasForeignKey(e => e.WorkStatusId)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<Employee>()
            .HasOne(e => e.Location)
            .WithMany(l => l.Employees)
            .HasForeignKey(e => e.LocationId);

        modelBuilder.Entity<Employee>()
            .HasOne(e => e.Job)
            .WithMany(j => j.Employees)
            .HasForeignKey(e => e.JobId);

        modelBuilder.Entity<Employee>()
            .HasOne(e => e.EmployeeScheduleType)
            .WithMany(t => t.Employees)
            .HasForeignKey(e => e.EmployeeScheduleTypeId);

        modelBuilder.Entity<Employee>()
            .HasOne(e => e.GenderType)
            .WithMany(g => g.Employees)
            .HasForeignKey(e => e.GenderTypeId);

        modelBuilder.Entity<Employee>()
            .HasOne(e => e.NationalityType)
            .WithMany(n => n.Employees)
            .HasForeignKey(e => e.NationalityTypeId);

        modelBuilder.Entity<Employee>()
            .HasOne(e => e.VeteranStatusType)
            .WithMany(v => v.Employees)
            .HasForeignKey(e => e.VeteranStatusTypeId);

        modelBuilder.Entity<Employee>()
            .HasOne(e => e.TerminationReason)
            .WithMany(t => t.Employees)
            .HasForeignKey(e => e.TerminationReasonId);

        modelBuilder.Entity<Location>()
            .HasOne(l => l.State)
            .WithMany()
            .HasForeignKey(l => l.StateId);

        // Seed reference data
        DataSeeder.SeedData(modelBuilder);
    }
}
