using JobApplicationTracker.Models;

namespace JobApplicationTracker.Features;

public class ListCompaniesByStatus
{
    public List<Company> Execute(CompanyStatus status, List<Company> companies)
    {

        List<Company> result = new List<Company>();

       
        foreach (var company in companies)
        {
            if (company.Status == status)
            {
                result.Add(company);
            }
        }

        return result;
    }
}
