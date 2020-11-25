using Flyweight.StarShips;
using System.Collections.Generic;

namespace Flyweight
{
	public enum ShipType
	{
		Corvet = 1,
		Cruiser = 2,
		Jaggernaut = 3
	}

	public class StarShipsFactory
	{
		private readonly Dictionary<ShipType, IStarShip> _starShips;

		public StarShipsFactory()
		{
			_starShips = new Dictionary<ShipType, IStarShip>()
			{
				[ShipType.Corvet] = new Corvet(),
				[ShipType.Cruiser] = new Cruiser(),
				[ShipType.Jaggernaut] = new Jaggernaut()
			};
		}

		public IStarShip GetShip(ShipType shipType)
		{
			var isSucces = _starShips.TryGetValue(shipType, out IStarShip starShip);

			return isSucces ? starShip : null;
		}
	}
}