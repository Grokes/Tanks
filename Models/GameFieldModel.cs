using Tanks.Game.Interfaces;
using Tanks.Models.Enums;

namespace Tanks.Models
{
	public class GameFieldModel
	{
		public int FieldWidth => 15;
		public int FieldHeight => 15;

		public CellTile[][] Map { get; private set; }
		public GameFieldModel(IGameTanks game)
		{
			Map = InitializeMap();
			GenerateMap();
		}

		private void GenerateMap()
		{
			GenerateBrickCells(60);
			GenerateBedrockCells();
			Map[^1][FieldWidth / 2] = CellTile.FriendlyBase;
			Map[0][FieldWidth / 2] = CellTile.EnemyBase;
		}

		private void GenerateBedrockCells()
		{
			for (int row = 2; row < FieldHeight - 2; row += 2)
			{
				for (int column = 2; column < FieldWidth - 2; column += 2)
				{
						Map[row][column] = CellTile.Bedrock;
				}
			}
		}

		private void GenerateBrickCells(int fillPercent)
		{
			Random rand = new Random();
			for (int row = 0; row < FieldHeight; ++row)
			{
				for (int column = 0; column < FieldWidth; ++column)
				{
					if (rand.Next(0, 100) < fillPercent)
					{
						Map[row][column] = CellTile.Brick;
					}
				}
			}
		}

		private CellTile[][] InitializeMap()
		{
			CellTile[][] map = new CellTile[FieldHeight][];

			for (int i = 0; i < FieldHeight; ++i)
			{
				map[i] = new CellTile[FieldWidth];
				Array.Fill(map[i], CellTile.Empty);
			}

			return map;
		}
	}
}
