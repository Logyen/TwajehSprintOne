using JobApplicationTracker.Models;

namespace JobApplicationTracker.Data;

public class WorkshopData
{
    public List<Company> Companies { get; set; } = new();
    public List<Job> Jobs { get; set; } = new();
    public List<Candidate> Candidates { get; set; } = new();
    public List<JobApplication> Applications { get; set; } = new();
}
