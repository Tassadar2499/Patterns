using System;

namespace Composite
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			var directory = new Location("Gym");
			directory.Add(new Rodnulkin("Billy"));

			var ricardo = new Rodnulkin("Ricardo");
			directory.Add(new Location("Раздевалка"));
			directory.Add(ricardo);

			directory.Add(new Location("Dungeon"));
			directory.Add(new Rodnulkin("Dungeon master"));

			directory.Display();

			directory.Remove(ricardo);
			Console.WriteLine("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");

			directory.Display();
		}
	}
}