using Visitor.Entities;
using Visitor.Serializers;

namespace Visitor
{
	public class Ricardo : IMan
	{
		public readonly string Name;

		public Ricardo() => Name = "Рикардо Милос";

		public void Flex(IFlexer flexer)
			=> flexer.FlexRicardo(this);
	}
}