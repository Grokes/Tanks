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
        [HttpPost]
        public string Login(string login, string pass)
        {
            if (login == null|| pass== null) return "Failure";
            if (_profile.ValidateProfile(login, pass)) 
            {
                return "Success";
            }
            return "Failure";
        }
    }
}
