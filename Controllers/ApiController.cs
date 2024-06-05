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
        string Login(string login, string pass)
        {
            if (_profile.ValidateProfile(login, pass)) 
            {
                return "Success";
            }
            return "Failure";
        }
    }
}
