namespace Facade
{
	public class Pilot
	{
		public void StartHarrasment(IShip ship)
		{
			ship.PrepareToBattle();
			ship.InitiateFighting();
			ship.Retreat();
		}
	}
}