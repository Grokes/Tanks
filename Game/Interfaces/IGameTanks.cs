﻿namespace Tanks.Game.Interfaces
{
	public interface IGameTanks
	{
        GameField GameField { get;}
        void StartGame();
		void EndGame();
	}
}
