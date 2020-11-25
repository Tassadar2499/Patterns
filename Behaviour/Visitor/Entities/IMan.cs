using Visitor.Serializers;

namespace Visitor.Entities
{
	public interface IMan
	{
		void Flex(IFlexer serializer);
	}
}