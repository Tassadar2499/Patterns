using Adapter.Protoss;
using System;

namespace Adapter
{
	public class HybridAdapter : IZerg
	{
		private readonly IProtoss _protoss;

		public HybridAdapter(IProtoss protoss)
		{
			_protoss = protoss;
		}

		public void ExecuteOrder()
		{
			_protoss.IsFree = false;
			Console.WriteLine("Протосс подчиняется надмозгу");
		}
	}
}