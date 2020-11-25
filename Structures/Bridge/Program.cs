using Bridge.Implementors;

namespace Bridge
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			var vikings = new Viking[]
			{
				new Viking("Викинг 1"),
				new Viking("Викинг 2"),
				new Viking("Викинг 3")
			};

			Carrier carrier = new BattleCruiser(vikings);
			carrier.Intercept();
			carrier.Shoot();

			var tieFighters = new TieFighter[]
			{
				new TieFighter("TIE fighter 1"),
				new TieFighter("TIE fighter 2"),
				new TieFighter("TIE fighter 3")
			};

			carrier = new ImperialDestroyer(tieFighters);
			carrier.Intercept();
			carrier.Shoot();
		}
	}
}