using System;

namespace Bridge.Implementors
{
	public class TieFighter : IInterceptor
	{
		public readonly string Name;

		public TieFighter(string name) => Name = name;

		public void Attack()
			=> Console.WriteLine($"{Name} осуществляет перехват");

		public void ReturnToBase()
			=> Console.WriteLine($"{Name} возвращается на базу");
	}
}