using System;

namespace Prototype
{
	[Serializable]
	public class Archery : Warrior
	{
		public int ArrowsCount { get; set; }

		public Archery(string name, int arrowsCount) : this(name)
		{
			ArrowsCount = arrowsCount;
		}

		protected Archery(string name) : base(name)
		{
		}

		public override void ShowInfo()
			=> Console.WriteLine("Лучник");
	}
}