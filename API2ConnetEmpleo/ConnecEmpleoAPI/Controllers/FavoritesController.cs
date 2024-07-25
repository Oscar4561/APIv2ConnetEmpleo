using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace ConnecEmpleoAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FavoritesController : ControllerBase
    {
        private static List<int> favoriteJobs = new List<int>();

        [HttpPost("add")]
        public IActionResult AddFavoriteJob([FromBody] int jobId)
        {
            if (!favoriteJobs.Contains(jobId))
            {
                favoriteJobs.Add(jobId);
                return Ok(new { message = "Job added to favorites." });
            }
            return BadRequest(new { message = "Job is already in favorites." });
        }

        [HttpGet("list")]
        public IActionResult GetFavoriteJobs()
        {
            return Ok(favoriteJobs);
        }
    }
}
