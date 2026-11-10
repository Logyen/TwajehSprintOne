namespace JobApplicationTracker.Models;

public class Company
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public CompanyStatus Status { get; set; }
}
