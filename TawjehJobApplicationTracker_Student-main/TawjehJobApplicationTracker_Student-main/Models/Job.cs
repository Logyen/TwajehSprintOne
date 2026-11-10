namespace JobApplicationTracker.Models;

public class Job
{
    public int Id { get; set; }
    public string Title { get; set; } = "";
    public bool IsOpen { get; set; }
    public int CompanyId { get; set; }
}
