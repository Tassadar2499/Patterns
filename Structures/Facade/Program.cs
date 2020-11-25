using Facade.Components;
using Facade.Components.Interfaces;
using Ninject;

namespace Facade
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			var kernel = new StandardKernel();

			kernel.Bind<IGun>().To<YamatoGun>();
			kernel.Bind<IDrive>().To<HyperDrive>();
			kernel.Bind<IShield>().To<PlazmaShield>();
			kernel.Bind<IShip>().To<BattleCruiser>();

			var battleCruiser = kernel.Get<BattleCruiser>();

			var pilot = new Pilot();
			pilot.StartHarrasment(battleCruiser);
		}
	}
}