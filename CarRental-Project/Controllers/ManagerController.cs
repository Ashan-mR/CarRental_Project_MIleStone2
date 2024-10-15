using CarRental_Project.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarRental_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManagerController : ControllerBase
    {
        private readonly IManagerServices _services;

        public ManagerController(IManagerServices services)
        {
            _services = services;
        }
    }
}
