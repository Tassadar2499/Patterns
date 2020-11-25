using System;

namespace GeneratingPatterns
{
	public class Archery : Warrior
	{
		public int ArrowsCount { get; set; }

		public Archery(int arrowsCount)
		{
			ArrowsCount = arrowsCount;
		}

		public override void ShowInfo()
			=> Console.WriteLine("Лучник");
	}
}