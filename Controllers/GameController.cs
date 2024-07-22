using Microsoft.AspNetCore.Mvc;
using Tanks.Game.Interfaces;
using Tanks.Models;


namespace Tanks.Controllers
{
    public class GameController(IGameManager _gameManager) : Controller
    {
        public IActionResult Game()
        {
            var game = _gameManager.GetGameTanks(null);
            var dataModel = new GameModel(game);
            return View(dataModel);
        }
    }
}