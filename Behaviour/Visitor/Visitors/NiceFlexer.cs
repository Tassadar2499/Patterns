using System;
using Visitor.Serializers;

namespace Visitor.Visitors
{
	public class NiceFlexer : IFlexer
	{
		public void FlexBilly(Billi billy)
			=> Console.WriteLine($"{billy.Name} красиво флексит");

		public void FlexRicardo(Ricardo ricardo)
			=> Console.WriteLine($"Красивый флекс от {ricardo.Name}");
	}
}