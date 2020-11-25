using AbstractFactory.Entities;

namespace AbstractFactory.Factory
{
	public abstract class ArmyFactory
	{
		public abstract Infantry[] CreateInfantries();

		public abstract Tank CreateTank();
	}
}