using System.ComponentModel.DataAnnotations.Schema;

namespace Gu.Process.Models;

public class Product
{
    public int Id { get; set; }
    public string GroupCode { get; set; } = string.Empty;
    public string Article { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public UnitOfMeasurement UnitOfMeasurement { get; set; }
    public Guid? CategoryConnectionId { get; set; }
    public int CategoryId { get; set; }
    [NotMapped]
    public Category Category { get; set; } = null!;
    public Guid? GroupConnectionId { get; set; }
    public int? GroupId { get; set; } = null!;
    [NotMapped]
    public Group Group { get; set; } = null!;
    public int? SubGroupId { get; set; } = null!;
    [NotMapped]
    public SubGroup SubGroup { get; set; } = null!;
    public string PaintingIds { get; set; } = string.Empty;
    [NotMapped]
    public List<Painting> Paintings { get; set; } = [];
    public string ColorIds { get; set; } = string.Empty;
    [NotMapped]
    public List<Color> Colors { get; set; } = [];
    [NotMapped]
    public EditMode EditMode { get; set; } = EditMode.Default;
}
