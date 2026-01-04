using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracking.Domain.Entities
{
    public  class Bug
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = default!;
        public string? Description { get; set; } = default!;
        //public BugSeverity Severity { get; set; }  //enums

        //public BugStatus status { get; set; }   //enums
        public string ReporterId { get; set; } = default!;
        public string? AssignedDeveloperId { get; set; }

        public DateTime CreatedAt { get; set; }


    }
}
