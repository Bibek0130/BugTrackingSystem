using BugTracking.Application.Interfaces.Repositories;
using BugTracking.Domain.Entities;
using BugTracking.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracking.Infrastructure.Repositories
{
    public class AuthRepository : IAuthRepository
    {
        private readonly BugTrackingDbContext _context;

        public AuthRepository(BugTrackingDbContext context)
        {
            _context = context;
        }

        public Task<int> GetUserByAsync(Guid Id)
        {
            int _id = 1;
            return Task.FromResult(_id);
        }
    }
}
