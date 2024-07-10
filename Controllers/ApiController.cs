using Microsoft.AspNetCore.Mvc;
using Tanks.Game.Interfaces;

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
                return new RedirectToActionResult("Game", "Game", null); ;
            }
            return new JsonResult("Failure");
        }
    }
}
