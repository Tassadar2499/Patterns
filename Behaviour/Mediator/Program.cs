using Mediator.Gestalts;
using Mediator.Slaves;
using System.Collections.Generic;

namespace Mediator
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			var khala = new Khala();

			var highTemplar = new HighTemplar(khala);

			var dragoon1 = new Dragun(khala, "Dragoon1");
			var dragoon2 = new Dragun(khala, "Dragoon2");
			var dragunes = new List<Dragun>() { dragoon1, dragoon2 };

			var zealot1 = new Zealot(khala, "zealot1");
			var zealot2 = new Zealot(khala, "zealot2");
			var zealot3 = new Zealot(khala, "zealot3");
			var zealots = new List<Zealot>() { zealot1, zealot2, zealot3, };

			khala.HighTemplar = highTemplar;
			khala.Dragunes = dragunes;
			khala.Zealots = zealots;

			zealot2.Send("Zealot2 died");
			khala.Zealots.Remove(zealot2);

			dragoon1.Send("Dragoon1 died");
			khala.Dragunes.Remove(dragoon1);

			highTemplar.Send("HighTemplar died");
			khala.HighTemplar = null;
		}
	}
}