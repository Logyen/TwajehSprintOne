using JobApplicationTracker.Models;

namespace JobApplicationTracker.Data;

public static class SampleData
{
    public static WorkshopData Create()
    {
        var data = new WorkshopData();

        data.Companies.AddRange(new[]
        {
            new Company { Id = 1, Name = "Tech House", Status = CompanyStatus.Approved },
            new Company { Id = 2, Name = "Future Apps", Status = CompanyStatus.Pending },
            new Company { Id = 3, Name = "Code Factory", Status = CompanyStatus.Rejected }
        });

        data.Jobs.AddRange(new[]
        {
            new Job { Id = 1, Title = "Junior .NET Developer", IsOpen = true, CompanyId = 1 },
            new Job { Id = 2, Title = "Backend Intern", IsOpen = true, CompanyId = 2 },
            new Job { Id = 3, Title = "QA Intern", IsOpen = false, CompanyId = 1 },
            new Job { Id = 4, Title = "Software Engineer", IsOpen = true, CompanyId = 3 }
        });

        data.Candidates.AddRange(new[]
        {
            new Candidate { Id = 1, Name = "Mona Ali", Email = "mona@example.com" },
            new Candidate { Id = 2, Name = "Omar Samy", Email = "omar@example.com" },
            new Candidate { Id = 3, Name = "Sara Adel", Email = "sara@example.com" }
        });

        data.Applications.Add(new JobApplication
        {
            CandidateId = 1,
            JobId = 1,
            AppliedAt = DateTime.Now.AddDays(-1)
        });

        return data;
    }
}
