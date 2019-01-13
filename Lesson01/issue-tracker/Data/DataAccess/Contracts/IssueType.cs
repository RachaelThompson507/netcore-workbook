using System;
using System.Collections.Generic;
using System.Text;

namespace IssueTracker.DataAccess.Contracts
{
    //IssueType Flags- hex to decimal 
    [Flags]
    internal enum IssueType
    {
        NotStarted = 0x00, //0
        InProgress = 0x01, //1
        InReview = 0x02, //2
        Done = 0x04 //4
    }
}
