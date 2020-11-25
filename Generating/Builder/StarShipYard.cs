namespace Builder
{
	public class StarShipYard
	{
		public StarShip BuildStarShip(StarShipBuilder builder)
			=> builder.CreateStarShip();
	}
}