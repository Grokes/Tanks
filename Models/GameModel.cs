using Tanks.Game.Interfaces;

namespace Tanks.Models
{
	public class GameModel
	{
		public GameFieldModel GameFieldModel { get; private set; }
		public GameModel(IGameTanks game)
		{
			GameFieldModel = new GameFieldModel(game);
		}
	}
}
