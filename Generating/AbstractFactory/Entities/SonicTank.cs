using System;

namespace AbstractFactory.Entities
{
	public class SonicTank : Tank
	{
		public override int Damage { get; set; }
		public override int Armor { get; set; }

		//Мы не можем обратиться к данному свойству из класса Army
		public int SoundVolume { get; }

		public SonicTank(int damage, int armor, int soundVolume) : this(damage, armor)
		{
			SoundVolume = soundVolume;
		}

		private SonicTank(int damage, int armor) : base(damage, armor)
		{
		}

		public override void Shoot()
		{
			Console.WriteLine("Sonic Tank Shoot");
		}
	}
}