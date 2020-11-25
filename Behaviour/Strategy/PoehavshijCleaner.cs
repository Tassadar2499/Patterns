using System;

namespace Strategy
{
	public class PoehavshijCleaner : ICleaner
	{
		public void ClearToilet()
		{
			Console.WriteLine("Чищу ложкой");
		}
	}
}