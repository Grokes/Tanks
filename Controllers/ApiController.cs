using Microsoft.AspNetCore.Mvc;
using Tanks.Game.Interfaces;
using Tanks.Models;

namespace Tanks.Controllers
{
    public class ApiController: Controller
    {
        private readonly IProfile _profile;
        private readonly IGameManager _gameManager;
        public ApiController(IProfile profile, IGameManager gameManager) 
        {
            this._profile = profile;
            this._gameManager = gameManager;
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

        [HttpPost]
        [Route(nameof(StartGame))]
        public IActionResult StartGame()
        {
            var gameTanks = _gameManager.GetGameTanks(null);
            gameTanks.StartGame();
            var gameModel = new GameModel(gameTanks);

            return PartialView("GameField", gameModel.GameFieldModel);
        }
    }
}
