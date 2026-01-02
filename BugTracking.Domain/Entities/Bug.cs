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
        public string? Name { get; set; }
        public string? Description { get; set; }

    }
}
