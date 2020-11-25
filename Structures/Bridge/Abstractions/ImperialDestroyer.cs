using System;

namespace Bridge
{
	public class ImperialDestroyer : Carrier
	{
		public ImperialDestroyer(IInterceptor[] interceptors) : base(interceptors)
		{
		}

		public override void Shoot()
			=> Console.WriteLine("Имперский крейсер стреляет из лазеров");
	}
}