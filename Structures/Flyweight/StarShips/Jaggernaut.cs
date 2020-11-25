using System;

namespace Flyweight.StarShips
{
	//Не Разделяемый
	public class Jaggernaut : IStarShip
	{
		public string Engine { get; }
		public string Weapon { get; }

		public Jaggernaut()
		{
			Engine = "Worm hole";
			Weapon = "Kinetic";
		}

		public void Initiate(string name, int number)
			=> Initiate();

		public void Initiate()
			=> Console.WriteLine($"Created {this}");

		public override string ToString()
			=> $"Jaggernaut Engine - {Engine}; Weapon - {Weapon}";
	}
}