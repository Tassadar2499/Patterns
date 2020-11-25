using System;

namespace Adapter
{
	public class Hydralisk : IZerg
	{
		public void ExecuteOrder()
			=> Console.WriteLine("Гидралиск подчиняется надмозгу");
	}
}