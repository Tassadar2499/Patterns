using Adapter.Protoss;

namespace Adapter
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			var overmind = new Overmind();
			var hydralisk = new Hydralisk();

			overmind.SendOrder(hydralisk);

			var zealot = new Zealot();
			var hybrid = InfectProtoss(zealot);

			overmind.SendOrder(hybrid);
		}

		private static HybridAdapter InfectProtoss(IProtoss protoss)
			=> new HybridAdapter(protoss);
	}
}