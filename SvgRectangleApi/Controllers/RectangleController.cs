using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SvgRectangleApi.Models;
using System.IO;
using System.Threading.Tasks;

namespace SvgRectangleApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RectangleController : ControllerBase
    {
        private const string FilePath = "Data/dimensions.json";

        [HttpGet]
        public async Task<ActionResult<RectangleDimensions>> GetDimensions()
        {
            var json = await System.IO.File.ReadAllTextAsync(FilePath);
            var dimensions = JsonConvert.DeserializeObject<RectangleDimensions>(json);
            return Ok(dimensions);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateDimensions([FromBody] RectangleDimensions dimensions)
        {
            if (dimensions.Width > dimensions.Height)
            {
                await Task.Delay(10000); // Simulate long calculation delay
                return BadRequest("Width cannot exceed height.");
            }

            var json = JsonConvert.SerializeObject(dimensions, Formatting.Indented);
            await System.IO.File.WriteAllTextAsync(FilePath, json);
            return Ok();
        }
    }
}