using SportBot.Core.Interfaces;

namespace SportBot.Core.Entities;
public class ReportEntity : IEntity
{
  public int Id { get; set; }
  public DateTime Date { get; set; }
  public ExerciseEntity? Exercice { get; set; }
  public int UserId { get; set; }
  public UserEntity? User { get; set; }
  public int Quantity { get; set; }
  public double Rate { get; set; }
  public double Weight { get; set; }
}
