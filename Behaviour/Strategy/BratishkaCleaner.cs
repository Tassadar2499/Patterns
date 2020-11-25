using System;

namespace Strategy
{
	internal class BratishkaCleaner : ICleaner
	{
		public void ClearToilet()
		{
			Console.WriteLine("Чищу вилкой быстро быстро");
		}
	}
}