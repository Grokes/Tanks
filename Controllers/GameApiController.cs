using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Tanks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameApiController : ControllerBase
    {
        [HttpPost]
        [Route("move")]
        public void Move()
        {
            
        }
        [HttpPost]
        [Route("attack")]
        public void Attack()
        {

        }
        [HttpPost]
        [Route("die")]
        public void Die()
        {

        }
        [HttpPost]
        [Route("pay")]
        public void Pay()
        {

        }
        [HttpPost]
        [Route("restore")]
        public void Restore ()
        {

        }
        [HttpGet]
        [Route("getCurrentPosition")]
        public string GetCurrentPosition()
        {
            return string.Empty;
        }
    }
}
