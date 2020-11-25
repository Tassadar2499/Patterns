using AbstractFactory.Entities;

namespace AbstractFactory.Factory
{
	public class AtreidesFactory : ArmyFactory
	{
		public override Infantry[] CreateInfantries()
			=> new Sniper[] { new Sniper(10), new Sniper(10) };

		public override Tank CreateTank()
			=> new SonicTank(20, 20, 20);
	}
}