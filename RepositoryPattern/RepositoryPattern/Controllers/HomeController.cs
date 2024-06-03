using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositoryPattern.Service;

namespace RepositoryPattern.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class HomeController : ControllerBase
	{
        private readonly IHomeInterface _homeInterface;
        public HomeController(IHomeInterface homeInterface)
        {
            _homeInterface = homeInterface;
        }

        [HttpGet]
        public ActionResult<string> retornaString()
        {
            var valString = _homeInterface.retornaString();
            return Ok(valString);
        }
    }
}
