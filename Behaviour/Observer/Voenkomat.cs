using System;

namespace Observer
{
	public class Voenkomat : IObserver
	{
		public void Handle()
			=> Console.WriteLine("Haha loshara derzi povestku");
	}
}