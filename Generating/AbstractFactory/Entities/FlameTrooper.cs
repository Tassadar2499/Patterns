using System;

namespace AbstractFactory.Entities
{
	public class FlameTrooper : Infantry
	{
		public override int Damage { get; set; }

		public FlameTrooper(int damage) : base(damage)
		{
		}

		public override void Shoot()
		{
			Console.WriteLine("FlameTrooper shoot");
		}

		public void Burn()
		{
			Console.WriteLine("FlameTrooper burned");
		}
	}
}