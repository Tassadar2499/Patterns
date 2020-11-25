using System;

namespace Facade.Components
{
	public class HyperDrive : IDrive
	{
		public void Jump()
			=> Console.WriteLine("Гиперпрыжок");
	}
}