using AbstractFactory.Entities;
using AbstractFactory.Factory;

namespace AbstractFactory
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			var atreidesArmy = new Army(new AtreidesFactory());
			atreidesArmy.Shoot();

			var harkonenArmy = new Army(new HarkonenFactory());
			harkonenArmy.Shoot();
		}
	}
}