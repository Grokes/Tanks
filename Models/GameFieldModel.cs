using Tanks.Game.Interfaces;

namespace Tanks.Models
{
	public class GameFieldModel
	{
		public int FieldWidth => 20;
		public int FieldHeight => 20;

		public GameFieldModel(IGameTanks game)
		{
			
		}
	}
}
