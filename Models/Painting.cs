using System.ComponentModel.DataAnnotations.Schema;

namespace Gu.Process.Models;

public class Painting
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? ArticleCode { get; set; } = null!;
    public string ColorIds { get; set; } = string.Empty;
    [NotMapped]
    public List<Color> Colors { get; set; } = [];
}