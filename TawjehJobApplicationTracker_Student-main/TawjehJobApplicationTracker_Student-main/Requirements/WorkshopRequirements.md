# Workshop Requirements

Read each requirement before writing code. For every feature, discuss:

- Actor
- Inputs
- Output
- Validations
- Business rules
- At least 3 Given / When / Then acceptance criteria
- Which collection would you choose, and why?
- What is the expected time complexity?

## Requirement 1 — Find a Job

A user can search for a job using its ID. If a job with that ID exists, the system returns its details. Otherwise, the system reports that the job was not found.

## Requirement 2 — List Companies by Status

A user can request companies with a particular status. The system returns all companies whose status matches the requested status. If none match, the result is empty.

## Requirement 3 — Apply to a Job

A candidate can apply to a job by providing their candidate ID and the job ID.

The candidate and job must exist. The job must be open, and its company must have Approved status. A candidate cannot apply to the same job more than once.

If any rule fails, the system must explain why the application was rejected. A rejected attempt must not be saved. If all rules pass, the application is saved and the system reports success.

## Requirement 4 — Check Email Availability

A user can check whether an email address is available for a new candidate. Email comparison is case-insensitive. The result is available only if no existing candidate uses that email.

## Sample Data Notes

The sample data intentionally includes open and closed jobs, companies with different statuses, and an existing application. Use these cases to explore successful and unsuccessful scenarios.
