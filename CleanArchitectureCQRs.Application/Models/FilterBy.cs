namespace CleanArchitectureCQRs.Application.Models;

public class FilterBy
{
    public string? Name { get; set; }
    public int? MaxPrice { get; set; }
    public int? MinPrice { get; set; }
    public string? Color { get; set; }
    public string? Category { get; set; }
}
