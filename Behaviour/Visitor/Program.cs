using Visitor.Entities;
using Visitor.Visitors;

namespace Visitor
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			var gym = new Gym(new IMan[] { new Ricardo(), new Billi() });
			var cringeFlexer = new CringeFlexer();
			var niceFlexer = new NiceFlexer();

			gym.Flex(cringeFlexer);
			gym.Flex(niceFlexer);
		}
	}
}