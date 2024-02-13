using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportBot.Core.Interfaces;

namespace SportBot.Core.Entities;
public class ExerciseEntity : IEntity
{
  public int Id { get; set; }
  [Required]
  [MaxLength(255)]
  public string Name { get; set; } = string.Empty;
  [Required]
  public string Description { get; set; } = string.Empty;
  public string? VideoUrl { get; set; }
  public int Quantity { get; set; }
  public int Sets { get; set; }
}
