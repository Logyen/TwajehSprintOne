using JobApplicationTracker.Models;
using JobApplicationTracker.Data;
using JobApplicationTracker.Features;

var data = SampleData.Create();
var findJob = new FindJobById();
var listCompanies = new ListCompaniesByStatus();
var applyToJob = new ApplyToJob();
var checkEmail = new IsCandidateEmailUnique();

while (true)
{
    Console.WriteLine("\n=== Job Application Tracker ===");
    Console.WriteLine("1. Show jobs");
    Console.WriteLine("2. Find job by ID");
    Console.WriteLine("3. List companies by status");
    Console.WriteLine("4. Apply to a job");
    Console.WriteLine("5. Check whether an email is available");
    Console.WriteLine("0. Exit");
    Console.Write("Choose: ");

    var choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            foreach (var job in data.Jobs)
                Console.WriteLine($"{job.Id}: {job.Title} | Open: {job.IsOpen} | Company ID: {job.CompanyId}");
            break;

        case "2":
            Console.Write("Job ID: ");
            if (int.TryParse(Console.ReadLine(), out var jobId))
            {
                var job = findJob.Execute(jobId, data.Jobs);
                Console.WriteLine(job is null ? "Job not found." : $"Found: {job.Title}");
            }
            else Console.WriteLine("Please enter a valid number.");
            break;

        case "3":
            Console.Write("Status (Pending, Approved, Rejected): ");
            if (Enum.TryParse<CompanyStatus>(Console.ReadLine(), true, out var status))
            {
                var companies = listCompanies.Execute(status, data.Companies);
                foreach (var company in companies)
                    Console.WriteLine($"{company.Id}: {company.Name} ({company.Status})");
                if (companies.Count == 0) Console.WriteLine("No companies found.");
            }
            else Console.WriteLine("Unknown status.");
            break;

        case "4":
            Console.Write("Candidate ID: ");
            var candidateOk = int.TryParse(Console.ReadLine(), out var candidateId);
            Console.Write("Job ID: ");
            var jobOk = int.TryParse(Console.ReadLine(), out var applyJobId);

            if (!candidateOk || !jobOk)
            {
                Console.WriteLine("Please enter valid numeric IDs.");
                break;
            }

            var result = applyToJob.Execute(candidateId, applyJobId, data);
            Console.WriteLine(result.Message);
            break;

        case "5":
            Console.Write("Email: ");
            var email = Console.ReadLine() ?? "";
            Console.WriteLine(checkEmail.Execute(email, data.Candidates)
                ? "Email is available."
                : "Email is already used.");
            break;

        case "0":
            return;

        default:
            Console.WriteLine("Invalid choice. Try again.");
            break;
    }
}
