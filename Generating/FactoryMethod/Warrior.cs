using System;

namespace GeneratingPatterns
{
	public abstract class Warrior
	{
		public virtual void ShowInfo()
			=> Console.WriteLine(GetType().Name);
	}
}