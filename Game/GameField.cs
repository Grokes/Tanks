using Tanks.Game.Interfaces;
using Tanks.Game.Enums;

namespace Tanks.Game
{
    public class GameField
    {
        public int FieldWidth => 15;
        public int FieldHeight => 15;

        public GameCellTile[][] Map { get; private set; }
        public GameField()
        {
            Map = InitializeMap();
            GenerateMap();
        }

        private void GenerateMap()
        {
            GenerateBrickCells(60);
            GenerateBedrockCells();
            Map[^1][FieldWidth / 2] = GameCellTile.FriendlyBase;
            Map[0][FieldWidth / 2] = GameCellTile.EnemyBase;
        }

        private void GenerateBedrockCells()
        {
            for (int row = 2; row < FieldHeight - 2; row += 2)
            {
                for (int column = 2; column < FieldWidth - 2; column += 2)
                {
                    Map[row][column] = GameCellTile.Bedrock;
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
                        Map[row][column] = GameCellTile.Brick;
                    }
                }
            }
        }

        private GameCellTile[][] InitializeMap()
        {
            GameCellTile[][] map = new GameCellTile[FieldHeight][];

            for (int i = 0; i < FieldHeight; ++i)
            {
                map[i] = new GameCellTile[FieldWidth];
                Array.Fill(map[i], GameCellTile.Empty);
            }

            return map;
        }
    }
}
