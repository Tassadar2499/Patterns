namespace Builder
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			var yard = new StarShipYard();

			var corvet = yard.BuildStarShip(new CorvetBuilder());
			var battleCruiser = yard.BuildStarShip(new BattleCruiserBuilder());
			var jaggernaut = yard.BuildStarShip(new JaggernautBuilder());
		}
	}
}