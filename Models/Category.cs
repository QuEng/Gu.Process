namespace Gu.Process.Models;

public class Category
{
    public int Id { get; set; }
    public char Code_A { get; set; } = '0';
    public char Code_B { get; set; } = '0';
    public char Code_C { get; set; } = '0';
    public Guid? ConnectionId { get; set; }
    public string Name { get; set; } = null!;
}