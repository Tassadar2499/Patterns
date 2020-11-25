using System.Threading.Tasks;
using Visitor.Entities;
using Visitor.Serializers;

namespace Visitor
{
	public class Gym
	{
		private readonly IMan[] _mens;

		public Gym(IMan[] mens) => _mens = mens;

		public void Flex(IFlexer flexer)
			=> Parallel.ForEach(_mens, (IMan m) => m.Flex(flexer));
	}
}