using Ninject;

namespace Strategy
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			var bratishkaContainer = new StandardKernel();
			bratishkaContainer.Bind<ICleaner>().To<BratishkaCleaner>();

			var army = bratishkaContainer.Get<Army>();
			army.CleanToilet();

			var poehavshijContainer = new StandardKernel();
			poehavshijContainer.Bind<ICleaner>().To<PoehavshijCleaner>();

			army = poehavshijContainer.Get<Army>();
			army.CleanToilet();
		}
	}
}