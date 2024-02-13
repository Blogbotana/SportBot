using System.ComponentModel.DataAnnotations;
using SportBot.Core.Interfaces;

namespace SportBot.Core.Entities;
public class WorkoutEntity : IEntity
{
  public int Id { get; set; }
  [Required]
  [MaxLength(255)]
  public string Name { get; set; } = string.Empty;
  [Required]
  public string Description { get; set; } = string.Empty;
  public string? ImageUrl { get; set; }
  public ICollection<ExerciseEntity>? Exercises { get; set; }

}
