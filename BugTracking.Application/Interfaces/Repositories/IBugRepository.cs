using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BugTracking.Domain.Entities;
namespace BugTracking.Application.Interfaces.Repositories
{
    public interface IBugRepository
    {
        Task<Bug?> GetIdByAsync(Guid Id);
    }
}
