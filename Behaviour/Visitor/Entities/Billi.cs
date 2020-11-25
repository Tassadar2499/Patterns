using Visitor.Entities;
using Visitor.Serializers;

namespace Visitor
{
	public class Billi : IMan
	{
		public readonly string Name;

		public Billi() => Name = "Билли Харрингтон";

		public void Flex(IFlexer flexer)
			=> flexer.FlexBilly(this);
	}
}