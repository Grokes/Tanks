using Tanks.Game.Interfaces;

namespace Tanks.Game
{
	public class GameTanks : IGameTanks
	{
		public GameField GameField { get; private set; }
		public void EndGame()
		{
			
			throw new NotImplementedException();
		}

		public void StartGame()
		{
            GameField = new GameField();
        }
	}
}
