using System.ComponentModel.DataAnnotations.Schema;

namespace Gu.Process.Models;

public class Color
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? ArticleCode { get; set; } = null!;
    public string NormalizedCode { get; set; } = string.Empty;
    public int PaintingId { get; set; }
    [NotMapped]
    public Painting Painting { get; set; } = null!;
}