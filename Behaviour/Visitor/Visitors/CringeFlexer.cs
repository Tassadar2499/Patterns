using System;
using Visitor.Serializers;

namespace Visitor.Visitors
{
	public class CringeFlexer : IFlexer
	{
		public void FlexBilly(Billi billy)
			=> Console.WriteLine($"{billy.Name} кринжово флексит");

		public void FlexRicardo(Ricardo ricardo)
			=> Console.WriteLine($"Кринжовый флекс от {ricardo.Name}");
	}
}