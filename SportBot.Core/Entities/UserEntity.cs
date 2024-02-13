using System.ComponentModel.DataAnnotations;
using SportBot.Core.Interfaces;

namespace SportBot.Core.Entities;
public class UserEntity : IEntity
{
  public int Id { get; set; }
  [Required]
  public long UserId { get; set; } = 0;
  [Required]
  public string UserName { get; set; } = string.Empty;
  public ICollection<ReportEntity>? Reports { get; set; }
}
