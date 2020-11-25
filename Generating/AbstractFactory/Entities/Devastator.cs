using System;

namespace AbstractFactory.Entities
{
	public class Devastator : Tank
	{
		public override int Damage { get; set; }
		public override int Armor { get; set; }

		public Devastator(int damage, int armor) : base(damage, armor)
		{
		}

		public override void Shoot()
		{
			Console.WriteLine("Devastator Shoot");
		}

		//Мы не можем обратиться к данному методу через класс - Army
		public void Explode()
		{
			Console.WriteLine("Devastator explode");
		}
	}
}