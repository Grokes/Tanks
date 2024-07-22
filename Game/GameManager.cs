using Tanks.Game.Interfaces;

namespace Tanks.Game
{
	public class GameManager : IGameManager
	{
		private Dictionary<string, IGameTanks> _games = [];
		public IGameTanks GetGameTanks(IGameCredentials? credentials)
		{
			if (credentials != null) throw new NotImplementedException();

			if (!_games.TryGetValue("null", out var game)) InitGameTanks(credentials);

			return _games["null"];
		}

		public void InitGameTanks(IGameCredentials? credentials)
		{
			if (credentials != null) throw new NotImplementedException();
			if (_games.ContainsKey("null"))
			{
				_games["null"].EndGame();
			}
			_games["null"] = new GameTanks();
            _games["null"].StartGame();

        }
	}
}
