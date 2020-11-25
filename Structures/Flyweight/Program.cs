using Flyweight.StarShips;
using System;

namespace Flyweight
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			var starShipFactory = new StarShipsFactory();

			var corvet = starShipFactory.GetShip(ShipType.Corvet);
			corvet.Initiate("Kek", 1);
			corvet.Initiate("Lol", 2);

			var cruiser = starShipFactory.GetShip(ShipType.Cruiser);
			cruiser.Initiate("Peppa", 1);
			cruiser.Initiate("Hruknul", 2);

			var jaggernaut = starShipFactory.GetShip(ShipType.Jaggernaut);
			(jaggernaut as Jaggernaut)?.Initiate();

			Console.ReadKey();
		}
	}
}