using Microsoft.EntityFrameworkCore;
using SportBot.Core.Entities;

namespace SportBot.Infrastructure.Data;
public class WorkoutContext : DbContext
{
  public WorkoutContext()
  { }
  public WorkoutContext(DbContextOptions<WorkoutContext> options) : base(options)
  { }
  public DbSet<WorkoutEntity> Workouts { get; set; }
  public DbSet<UserEntity> Users { get; set; }
  public DbSet<ReportEntity> Reports { get; set; }
  public DbSet<ExerciseEntity> Exercises { get; set; }

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    modelBuilder.Entity<WorkoutEntity>()
      .HasMany(w => w.Exercises);

    modelBuilder.Entity<ExerciseEntity>();

    modelBuilder.Entity<UserEntity>()
      .HasMany(u => u.Reports)
      .WithOne(r => r.User)
      .HasForeignKey(r => r.UserId);

    modelBuilder.Entity<ReportEntity>()
      .HasOne(r => r.Exercice);
  }
}
