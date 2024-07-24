using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HotelFinder.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MyController : ControllerBase
    {
        private readonly MyService _myService;

        public MyController(MyService myService)
        {
            _myService = myService;
        }

        [HttpGet("data")]
        public async Task<IActionResult> GetData()
        {
            var data = await _myService.GetDataFromWebServiceAsync("https://api.example.com/data");
            return Ok(data);
        }
    }

}
