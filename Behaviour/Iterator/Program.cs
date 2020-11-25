using System;

namespace Iterator
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			foreach (var meme in new Memes())
				Console.WriteLine(meme);
		}
	}
}