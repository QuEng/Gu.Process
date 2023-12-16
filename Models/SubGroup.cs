namespace Gu.Process.Models;

public class SubGroup
{
    public int Id { get; set; }
    public char Code_C { get; set; } = '0';
    public string Name { get; set; } = string.Empty;
    public int GroupId { get; set; }
}
