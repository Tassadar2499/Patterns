using System;

namespace AbstractFactory.Entities
{
	public class Sniper : Infantry
	{
		public override int Damage { get; set; }

		public Sniper(int damage) : base(damage)
		{
		}

		public override void Shoot()
		{
			Console.WriteLine("Sniper shoot");
		}

		public void Hide()
		{
			Console.WriteLine("Sniper hided");
		}
	}
}