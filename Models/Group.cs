using System.ComponentModel.DataAnnotations.Schema;

namespace Gu.Process.Models;

public class Group
{
    public int Id { get; set; }
    public char Code_B { get; set; } = '0';
    public char? Code_C { get; set; }
    public string Name { get; set; } = string.Empty;
    public Guid? ConnectionId { get; set; }
    public int CategoryId { get; set; }
    [NotMapped]
    public Category Category { get; set; } = new();
}