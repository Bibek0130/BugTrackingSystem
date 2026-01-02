using BugTracking.Application.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BugTracking.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BugsController : ControllerBase
    {
        private readonly IBugService? _bugService;

        public BugsController(IBugService bugService)
        {
            _bugService = bugService;
        }

    }
}
