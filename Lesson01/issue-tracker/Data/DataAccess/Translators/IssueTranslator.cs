using IssueTracker.DataAccess.Contracts;
using IssueTracker.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace IssueTracker.DataAccess.Translators
{
    internal class IssueTranslator
    {
        public IIssue ToDomain(Contracts.Issue issue)
        {
            //if issue is null return null (ie- issue not instantiated yet?)
            if (issue == null)
                return null;
            // issue domain contracts 
            var result = new Domain.Contracts.Issue
            {
                Id = issue.Id,
                Title = issue.Title,
                Description = issue.Description,
                Estimate = issue.Estimate.ToString(),
                PastStates = issue.PastStates()
            };
            /* 
                Program does not have the ability to go backwards- Status only has forward capability
            */
            if ((decimal)issue.Type<1) result.Status = "Not Started";
            else if ((decimal)issue.Type <2) result.Status = "In Progress"; 
            else if ((decimal)issue.Type <3) result.Status = "In Review";
            else if ((decimal)issue.Type <5) result.Status =  "Done";

            return result;
        }

        public Contracts.Issue ToModel(IIssue issue)
        {
            if (issue == null)
                return null;

            var result = new Contracts.Issue
            {
                Id = issue.Id,
                Title = issue.Title,
                Description = issue.Description,
                Estimate = decimal.Parse(issue.Estimate)
            };

            if (string.IsNullOrEmpty(issue.Status)) result.Type = IssueType.NotStarted;
            else if (issue.Status.Equals("In Progress", StringComparison.CurrentCultureIgnoreCase)) result.Type = IssueType.InProgress;
            else if (issue.Status.Equals("In Review", StringComparison.CurrentCultureIgnoreCase)) result.Type = IssueType.InReview;
            else if (issue.Status.Equals("Done", StringComparison.CurrentCultureIgnoreCase)) result.Type = IssueType.Done;
            else if (issue.Status.Equals("Not Started", StringComparison.CurrentCultureIgnoreCase)) result.Type = IssueType.NotStarted;

            return result;
        }
    }
}
