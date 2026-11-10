namespace JobApplicationTracker.Models;

public class JobApplication
{
    public int CandidateId { get; set; }
    public int JobId { get; set; }
    public DateTime AppliedAt { get; set; } = DateTime.Now;
}
