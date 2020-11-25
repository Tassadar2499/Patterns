using System;

namespace Decorator.DecoratorClasses
{
	public class PizhonGopnik : GopnikDecorator
	{
		public PizhonGopnik(IBydlo mainObject) : base(mainObject)
		{
		}

		public void Naehat()
			=> Console.WriteLine("Eeee s kakogo rajona eeee");
	}
}