using System;

namespace Observer
{
	public class Parent : IObserver
	{
		public void Handle()
			=> Console.WriteLine("You sjezjaesh s hati");
	}
}