using BugTracking.Application.Interfaces.Repositories;
using BugTracking.Domain.Entities;
using BugTracking.Infrastructure.Persistence;
using BugTracking.Infrastructure.Identity;
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

        public async Task<Bug?> GetIdByAsync(Guid Id)
        {
            return await _context.Bugs.FindAsync(Id);
        }
    }
}
