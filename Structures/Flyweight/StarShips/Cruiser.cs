using System;

namespace Flyweight.StarShips
{
	//Разделяемый
	public class Cruiser : IStarShip
	{
		public string Engine { get; }
		public string Weapon { get; }

		public Cruiser()
		{
			Engine = "Hyperdrive";
			Weapon = "Nuclear";
		}

		public void Initiate(string name, int number)
			=> Console.WriteLine($"Created {this}: number - {number} name - {name}");

		public override string ToString()
			=> $"Cruiser Engine - {Engine}; Weapon - {Weapon}";
	}
}