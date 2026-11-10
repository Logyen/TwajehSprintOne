using JobApplicationTracker.Data;
using JobApplicationTracker.Models;

namespace JobApplicationTracker.Features;
public class ApplyToJob
{
    public ApplyResult Execute(int candidateId, int jobId, WorkshopData data)
    {

        Candidate? candidate = null;

        foreach (var item in data.Candidates)
        {
            if (item.Id == candidateId)
            {
                candidate = item;
                break;
            }
        }

        if (candidate == null)
        {
            return new ApplyResult(false, "Candidate not found.");
        }

        Job? job = null;

        foreach (var item in data.Jobs)
        {
            if (item.Id == jobId)
            {
                job = item;
                break;
            }
        }

        if (job == null)
        {
            return new ApplyResult(false, "Job not found.");
        }

        
        if (job.IsOpen == false)
        {
            return new ApplyResult(false, "This job is closed.");
        }

        
        Company? company = null;

        foreach (var item in data.Companies)
        {
            if (item.Id == job.CompanyId)
            {
                company = item;
                break;
            }
        }

        if (company == null)
        {
            return new ApplyResult(false, "Company not found.");
        }

        
        if (company.Status != CompanyStatus.Approved)
        {
            return new ApplyResult(false, "Company is not approved.");
        }

        
        foreach (var application in data.Applications)
        {
            if (application.CandidateId == candidateId &&
                application.JobId == jobId)
            {
                return new ApplyResult(false, "You already applied to this job.");
            }
        }

        
        JobApplication newApplication = new JobApplication();

        newApplication.CandidateId = candidateId;
        newApplication.JobId = jobId;
        newApplication.AppliedAt = DateTime.Now;

       
        data.Applications.Add(newApplication);

        return new ApplyResult(true, "Application submitted successfully.");
    }
}

public record ApplyResult(bool Success, string Message);
