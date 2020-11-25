using System;

namespace Bridge.Implementors
{
	public class Viking : IInterceptor
	{
		public readonly string Name;

		public Viking(string name) => Name = name;

		public void Attack()
			=> Console.WriteLine($"{Name} стреляет ракетами");

		public void ReturnToBase()
			=> Console.WriteLine($"{Name} возвращается на корабль");
	}
}