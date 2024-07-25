using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ConnecEmpleoAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProfilesController : ControllerBase
    {
        private static Dictionary<int, string> userProfiles = new Dictionary<int, string>();

        [HttpPost("create")]
        public IActionResult CreateProfile([FromBody] UserProfile profile)
        {
            if (!userProfiles.ContainsKey(profile.UserId))
            {
                userProfiles.Add(profile.UserId, profile.UserName);
                return Ok(new { message = "Profile created successfully." });
            }
            return BadRequest(new { message = "Profile already exists." });
        }

        [HttpGet("get/{userId}")]
        public IActionResult GetProfile(int userId)
        {
            if (userProfiles.TryGetValue(userId, out string userName))
            {
                return Ok(new { UserId = userId, UserName = userName });
            }
            return NotFound(new { message = "Profile not found." });
        }
    }

    public class UserProfile
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
    }
}
