using JobApplicationTracker.Models;

namespace JobApplicationTracker.Features;

public class FindJobById
{
    public Job? Execute(int jobId, List<Job> jobs)
    {

        foreach (var job in jobs)
        {
            if (job.Id == jobId)
            {
                return job;
            }
        }
        return null;
    }
}
