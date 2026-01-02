using BugTracking.Application.Interfaces.Repositories;
using BugTracking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracking.Infrastructure.Repositories
{
    public class BugRepository : IBugRepository
    {
        private readonly BugTrackingDbContext _context;

        public BugRepository(BugTrackingDbContext context)
        {
            _context = context;
        }

        public Task<Bug> GetIdByAsync(Guid Id)
        {
            return _context.IdByAsync(Id);
        }
    }
}
