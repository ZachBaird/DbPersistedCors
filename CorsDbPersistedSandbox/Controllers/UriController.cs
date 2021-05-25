using CorsDbPersistedSandbox.Models;
using CorsDbPersistedSandbox.Services;
using Microsoft.AspNetCore.Mvc;

namespace CorsDbPersistedSandbox.Controllers
{
    [ApiController]
    public class UriController : Controller
    {
        private readonly UriService _uriService;

        public UriController(UriService uriService)
        {
            _uriService = uriService;
        }

        [HttpGet("/uris")]
        public IActionResult GetUris() =>
            Ok(_uriService.GetWhitelistedUris());

        [HttpPost("/uris/create")]
        public IActionResult CreateUri([FromBody] CorsUri newUri)
        {
            _uriService.AddWhitelistedUri(newUri);
            return Ok("Uri successfully added!");
        }
    }
}
