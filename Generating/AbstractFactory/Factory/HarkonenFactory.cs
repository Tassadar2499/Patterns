using AbstractFactory.Entities;

namespace AbstractFactory.Factory
{
	public class HarkonenFactory : ArmyFactory
	{
		public override Infantry[] CreateInfantries()
			=> new FlameTrooper[] { new FlameTrooper(9), new FlameTrooper(9) };

		public override Tank CreateTank()
			=> new Devastator(15, 30);
	}
}