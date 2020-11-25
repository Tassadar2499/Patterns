using System;

namespace Decorator.DecoratorClasses
{
	public class SportsmenGopnik : GopnikDecorator
	{
		public SportsmenGopnik(IBydlo mainObject) : base(mainObject)
		{
		}

		public void PropisatDvoechku()
			=> Console.WriteLine("Bam s levoj, bum s pravoj");
	}
}