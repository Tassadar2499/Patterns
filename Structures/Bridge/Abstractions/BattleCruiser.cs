using System;

namespace Bridge
{
	public class BattleCruiser : Carrier
	{
		public BattleCruiser(IInterceptor[] interceptors) : base(interceptors)
		{
		}

		public override void Shoot()
			=> Console.WriteLine("Выстрел крейсера из Ямато пушки");
	}
}