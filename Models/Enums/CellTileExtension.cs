using Tanks.Game.Enums;

namespace Tanks.Models.Enums
{
    public static class CellTileExtension
    {
        private static Dictionary<GameCellTile, CellTile> _convertDictionary =
            new Dictionary<GameCellTile, CellTile>()
            {
                { GameCellTile.Bedrock, CellTile.Bedrock},
                { GameCellTile.FriendlyBase, CellTile.FriendlyBase},
                { GameCellTile.Brick, CellTile.Brick},
                { GameCellTile.EnemyBase, CellTile.EnemyBase},
                { GameCellTile.Empty, CellTile.Empty}
            };

        public static CellTile ToCellTile(this GameCellTile source)
        {
            return _convertDictionary[source];
        }
    }
}
