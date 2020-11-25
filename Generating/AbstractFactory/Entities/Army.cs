using AbstractFactory.Factory;

namespace AbstractFactory.Entities
{
	public class Army
	{
		private readonly Tank _tank;
		private readonly Infantry[] _infantries;

		public Army(ArmyFactory factory)
		{
			_tank = factory.CreateTank();
			_infantries = factory.CreateInfantries();
		}

		public void Shoot()
		{
			_tank.Shoot();
			foreach (var infantry in _infantries)
				infantry.Shoot();
		}
	}
}