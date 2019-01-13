﻿using IssueTracker.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Issue : IIssue
    {
        [Key]
        public int? Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Estimate { get; set; }

        public string Description { get; set; }
        //get Status 
        public string Status { get; set; }
        //get Past States (PastStatuses)
        public List<string> PastStates { get; set; }
    }
}
