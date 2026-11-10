using JobApplicationTracker.Models;

namespace JobApplicationTracker.Features;

public class IsCandidateEmailUnique
{
    
    public bool Execute(string email, List<Candidate> candidates)
    {

        if (string.IsNullOrWhiteSpace(email))
        {
            return false;
        }

        foreach (var candidate in candidates)
        {
            if (string.Equals(candidate.Email, email,
                StringComparison.OrdinalIgnoreCase))
            {
                return false;
            }
        }

        return true;
    }
}

