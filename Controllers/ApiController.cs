using Microsoft.AspNetCore.Mvc;
using Tanks.Game;

namespace Tanks.Controllers
{
    public class ApiController
    {
        private readonly IProfile _profile;
        public ApiController(IProfile profile) 
        {
            this._profile = profile;
        }
        public IActionResult Login(string login, string pass)
        {
            if (login == null || pass == null) return new JsonResult("Failure"); ;
            if (_profile.ValidateProfile(login, pass)) 
            {
                return new RedirectToActionResult("Game", "Home", null); ;
            }
            return new JsonResult("Failure");
        }
    }
}
