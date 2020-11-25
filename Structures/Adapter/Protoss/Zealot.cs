using System;

namespace Adapter.Protoss
{
	public class Zealot : IProtoss
	{
		public bool IsFree { get; set; }

		public Zealot() => IsFree = true;

		public void BeFree()
		{
			if (IsFree)
				Console.WriteLine("Зилот свободен");
		}
	}
}