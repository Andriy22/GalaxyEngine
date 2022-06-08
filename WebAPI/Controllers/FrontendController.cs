using Application.Interfaces;
using Application.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FrontendController : BaseController
    {
        private readonly IFrontendService _frontendService;
        public FrontendController(IFrontendService frontendService)
        {
            _frontendService = frontendService;
        }

        [HttpPost("create-page")]
        public async Task<IActionResult> CreatePage(CreateFrontPageDto model)
        {
            return Ok(await _frontendService.CreatePage(model));
        }
    }
}
